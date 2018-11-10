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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        Controller.AutorizAndRegistr aar;
        Autorization autor;

        public Registration()
        {
            InitializeComponent();
            aar = new Controller.AutorizAndRegistr();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            aar.AddUser(fio.Text, passBox.Password, passBox_Copy.Password, (int)comboBoxGroup.SelectedValue);
            //MainUserWindow mw = new MainUserWindow();
            //mw.Show();
            this.Close();
        }

      
    }
}
