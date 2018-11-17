using System;
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

        public ShopWindow()
        {
            InitializeComponent();
            shopcon = new Controller.ShopWindowController();
            buybutton.IsEnabled = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            refresh();
        }

        private void fillGrid()
        {
            datagrid.ItemsSource = shopcon.getMonsterItems();
        }

        private void refresh()
        {
            fillUserInfo(shopcon.CurrentUser.Name, shopcon.CurrentUser.Money);
            fillGrid();
        }

        private byte[] datagrid_imageFill()
        {
            return shopcon.getListOfMonsterImages()[shopcon.Index];
        }

        private void fillUserInfo(string name, int money)
        {
            txt1.Text = name;
            txt2.Text = money.ToString();
            moneyImage.Source = new BitmapImage(new Uri("/Pictures/money_im.png", UriKind.Relative));
        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((Controller.MonsterItem)datagrid.SelectedItem).IsBought)
                buybutton.IsEnabled = false;
            else
                buybutton.IsEnabled = true;
        }

        private void buybutton_Click(object sender, RoutedEventArgs e)
        {
            Controller.MonsterItem m = (Controller.MonsterItem)datagrid.SelectedItem;
            if (m.Price > shopcon.CurrentUser.Money)
            {
                MessageBox.Show("На жаль, у вас не вистачає коштів, щоб купити цього монстра!", "Увага!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            shopcon.BuyMonster(m.Id_Monster);
            shopcon.payForMonster(shopcon.CurrentUser.Money-m.Price);
            MessageBox.Show("Дякуємо за покупку!", "Увага!", MessageBoxButton.OK, MessageBoxImage.Information);
            refresh();
        }
    }
}
