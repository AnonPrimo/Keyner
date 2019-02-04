using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Keyner_v1.View
{
    /// <summary>
    /// Логика взаимодействия для ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {
        public Controller.ShopWindowController shopcon; //controller for work with database
        int index;                                  //index of current monster item on window
        List<Controller.MonsterItem> monList;       //list of monsters (monster items:image, name, price etc)

        public ShopWindow()
        {
            InitializeComponent();
        }

        public ShopWindow(int id_user) : this()
        {
            shopcon = new Controller.ShopWindowController(id_user);
            index = 0;
        }

        //async filling the window
        private async void FillMonsterList()
        {
            Task t = Task.Run(() =>
            monList = shopcon.getMonsterItems());
            t.Wait();
            await Task.Run(() => fillMosterFields());

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fillUserInfo(shopcon.CurrentUser.Name, shopcon.CurrentUser.Money);

            monList = shopcon.getMonsterItems();
            fillMosterFields();
        }

        //filling monster data
        private void fillMosterFields()
        {
            mainMonsterButton.Background = Brushes.PeachPuff;
            CheckMainMonster();
            if (index == 0)
            {
                ClearStackpnl(stackpanel1);
                fillMonsterStackpnl(monList[index], stackpanel2);
                if(monList.Count > 1)
                    fillMonsterStackpnl(monList[index + 1], stackpanel3);
                return;
            }

            if (index == monList.Count - 1)
            {
                ClearStackpnl(stackpanel3);

                fillMonsterStackpnl(monList[index - 1], stackpanel1);
                fillMonsterStackpnl(monList[index], stackpanel2);
                return;
            }
            if (index > 0 && index < monList.Count - 1)
            {
                fillMonsterStackpnl(monList[index - 1], stackpanel1);
                fillMonsterStackpnl(monList[index], stackpanel2);
                fillMonsterStackpnl(monList[index + 1], stackpanel3);
            }
        }

        private void ClearStackpnl(StackPanel stk)
        {
            foreach (var uielement in stk.Children)
            {
                if (uielement is TextBlock)
                    (uielement as TextBlock).Text = string.Empty;
                if (uielement is Image)
                    (uielement as Image).Source = null;
                if (uielement is Button)
                {
                    (uielement as Button).Content = null;
                }
            }

        }

        //filling monster shop
        private void fillMonsterStackpnl(Controller.MonsterItem monster, StackPanel s)
        {
            BitmapImage bitIm = new BitmapImage();
            bitIm = Controller.ImageConvert.Convert(monster.Image);
            SetMainMonsterButton();
            foreach (var uielement in s.Children)
            {
                if (uielement is TextBlock)
                    (uielement as TextBlock).Text = monster.Name;
                if (uielement is Image)
                    (uielement as Image).Source = bitIm;
                if (uielement is Button)
                {
                    if (monster.IsBought)
                    {
                        (uielement as Button).Content = "Куплено!";
                        (uielement as Button).IsEnabled = false;
                        return;
                    }
                    else
                    {
                        (uielement as Button).Content = monster.Price;
                        (uielement as Button).IsEnabled = true;
                        return;
                    }
                }
            }
        }

        //filling user data
        private void fillUserInfo(string name, int money)
        {
            txt1.Text = name;
            FillUserMoney(money);
            moneyImage.Source = new BitmapImage(new Uri("/Pictures/money_im.png", UriKind.Relative));
        }
        private void FillUserMoney(int money)
        {
            txt2.Text = money.ToString();
        }

        //setting main monster (if user has few monsters available)
        private void SetMainMonsterButton()
        {
            if (monList[index].IsBought)
                mainMonsterButton.IsEnabled = true;
            else
                mainMonsterButton.IsEnabled = false;

        }
        private void MainMonsterButton_Click(object sender, RoutedEventArgs e)
        {
            shopcon.SetMainMonster(monList[index].Id_Monster);
            mainMonsterButton.Background = Brushes.Cyan;

        }

        //if selected monster is set as main
        private void CheckMainMonster()
        {
            if (monList[index].Id_Monster == shopcon.CurrentUser.Id_Monster)
                mainMonsterButton.Background = Brushes.Cyan;
        }

        //buy monster
        private void buybutton_Click(object sender, RoutedEventArgs e)
        {
            if (!MonsterButton2.IsEnabled)
                return;

            int price = monList[index].Price;
            if (price > shopcon.CurrentUser.Money)
            {
                MessageBox.Show("На жаль, у вас не вистачає коштів, щоб купити цього монстра!", "Увага!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            shopcon.BuyMonster(monList[index].Id_Monster);
            shopcon.payForMonster(price);
            MessageBox.Show("Дякуємо за покупку!", "Thank you!", MessageBoxButton.OK, MessageBoxImage.Information);
            mainMonsterButton.IsEnabled = true;
            MonsterButton2.Content = "Куплено!";
            MonsterButton2.IsEnabled = false;
            FillUserMoney(shopcon.CurrentUser.Money);
        }

        //return to previous form
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //previous monster
        private void prevImage_Click(object sender, RoutedEventArgs e)
        {
            if (index > 0)
            {
                index--;
                fillMosterFields();
            }
        }

        //next monster
        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (index < monList.Count-1)
            {
                index++;
                fillMosterFields();
            }
        }

        private void stackpanel3_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (index < monList.Count - 1)
            {
                index++;
                fillMosterFields();
            }
        }

        private void stackpanel1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (index > 0)
            {
                index--;
                fillMosterFields();
            }
        }
    }
}
