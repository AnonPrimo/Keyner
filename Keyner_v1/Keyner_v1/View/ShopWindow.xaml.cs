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
        int index;
        List<Controller.MonsterItem> monList;

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
            fillThreeMosterFields();
        }

        //filling monster data
        private void fillThreeMosterFields()
        {
            fillMonsterStackpnl(monList[index], stackpanel1);
            fillMonsterStackpnl(monList[index+1], stackpanel2);
            fillMonsterStackpnl(monList[index+2], stackpanel3);
        }

        private void fillMonsterStackpnl(Controller.MonsterItem monster, StackPanel s)
        {
            BitmapImage bitIm = new BitmapImage();
            bitIm = Controller.UserFormController.ImageConvert.Convert(monster.Image);

            foreach(var uielement in s.Children)
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

        private void buybutton_Click(object sender, RoutedEventArgs e)
        {

            int price = Int32.Parse((e.Source as Button).Content.ToString());
            if (price > shopcon.CurrentUser.Money)
            {
                MessageBox.Show("На жаль, у вас не вистачає коштів, щоб купити цього монстра!", "Увага!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            //shopcon.BuyMonster(m.Id_Monster);
            //shopcon.payForMonster(price);
            MessageBox.Show("Дякуємо за покупку!", "Thank you!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //return to previous form
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void prevImage_Click(object sender, RoutedEventArgs e)
        {
            if (index > 0)
                index--;
            fillThreeMosterFields();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (index < monList.Count - 3)
                index++;
            fillThreeMosterFields();
        }
    }
}
