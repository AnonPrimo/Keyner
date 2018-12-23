using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Keyner_v1.View
{
    /// <summary>
    /// Логика взаимодействия для ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {
        public Controller.ShopWindowController shopcon;
        int index;                                  //index of first image of monster on window
        List<Controller.MonsterItem> monList;       //list of monsters (image, name, price etc)

        public ShopWindow()
        {
            InitializeComponent();
            shopcon = new Controller.ShopWindowController();
            index = 0;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            monList = shopcon.getMonsterItems();
            fillUserInfo(shopcon.CurrentUser.Name, shopcon.CurrentUser.Money);
            fillMosterFields();
        }

        //filling monster data
        private void fillMosterFields()
        {
            if(index == 0)
            {
                ClearStackpnl(stackpanel1);
                fillMonsterStackpnl(monList[index], stackpanel2);
                fillMonsterStackpnl(monList[index + 1], stackpanel3);
                return;
            }

            if(index == monList.Count - 1)
            {
                ClearStackpnl(stackpanel3);

                fillMonsterStackpnl(monList[index-1], stackpanel1);
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
            bitIm = Controller.UserFormController.ImageConvert.Convert(monster.Image);
            SetMainMonsterButton();
            foreach (var uielement in s.Children)
            {
                if(uielement is TextBlock)
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
            txt2.Text = money.ToString();
            moneyImage.Source = new BitmapImage(new Uri("/Pictures/money_im.png", UriKind.Relative));
        }

        private void SetMainMonsterButton()
        {
            if (monList[index].IsBought)
                mainMonsterButton.IsEnabled = true;
            else
                mainMonsterButton.IsEnabled = false;

        }

        //buy monster
        private void buybutton_Click(object sender, RoutedEventArgs e)
        {
            //int price = Int32.Parse((e.Source as Button).Content.ToString());
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
                index--;
            fillMosterFields();
        }

        //next monster
        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (index < monList.Count)
                index++;
            fillMosterFields();
        }

        private void MainMonsterButton_Click(object sender, RoutedEventArgs e)
        {
            shopcon.SetMainMonster(monList[index].Id_Monster);
        }
    }
}
