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
    /// Логика взаимодействия для MainUserWindow.xaml
    /// </summary>
    public partial class MainUserWindow : Window
    {
        Model.User user;
        Keyner_v1.Model.KeynerContext kcon;

        public MainUserWindow()
        {
            InitializeComponent();
            
            kcon = new Model.KeynerContext();

        }

        private void fillGrid()
        {

            datagrid1.DataContext = kcon.TestSet;
        }

        private void fillInfo(string name, string money, string level)
        {
            txt1.Text = name;
            txt1.FontSize = 20;

            txt2.Text = money;
            txt2.FontSize = 20;

            txt3.Text = "Рівень: " + level;
        }

        private void fillImage(Image im)
        {
            monster = im;
        }

        private void shopbutton_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow sw = new ShopWindow();
            sw.Show();
        }
    }
}
