using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fillUserInfo(shopcon.CurrentUser.Name, shopcon.CurrentUser.Money);
        }

        private void fillUserInfo(string name, int money)
        {
            txt1.Text = name;
            txt2.Text = money.ToString();
            moneyImage.Source = new BitmapImage(new Uri("/Pictures/money_im.png", UriKind.Relative));
        }

    }
}
