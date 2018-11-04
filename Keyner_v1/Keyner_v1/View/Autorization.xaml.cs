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
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        Model.KeynerContext keynerContext;

        Controller.AutorizAndRegistr aar;
        public Autorization()
        {
            InitializeComponent();
            keynerContext = new Model.KeynerContext();
            aar = new Controller.AutorizAndRegistr();
            //comboBoxGroup.DataContext = keynerContext.

            comboBoxUser.DataContext = keynerContext.UserSet.ToList();
            comboBoxUser.DisplayMemberPath = "Name";
            comboBoxUser.SelectedValue = "Id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (aar.GetPass((int)comboBoxUser.SelectedValue, passBox.SecurePassword.ToString()))
            {
                MainUserWindow mw = new MainUserWindow(/*(int)comboBoxUser.SelectedValue*/);
                mw.Show();
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Close();
        }
    }
}
