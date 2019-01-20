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
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public int IdUser;
        Controller.SettingWinController setcon;

        public SettingsWindow()
        {
            InitializeComponent();
            setcon = new Controller.SettingWinController();
        }

        //confirm password change
        private void passwordButton_Click(object sender, RoutedEventArgs e)
        {
            if (pass1.Password.Length == 0)
                return;

            if (!setcon.CurrentPassCheck(IdUser, pass1.Password))
            {
                MessageBox.Show("Старий пароль введено неправильно!");
                Clear();
                return;
            }

            if (pass2.Password.Length == 0 || pass3.Password.Length == 0)
            {
                MessageBox.Show("Новий пароль не введено!");
                Clear();
                return;
            }

            if(pass2.Password != pass3.Password)
            {
                MessageBox.Show("Паролі не співпадають!");
                Clear();
                return;
            }
            else
            {
                setcon.PasswordChange(IdUser, pass3.Password);
                MessageBox.Show("Пароль був змінений.");
                Clear();
            }
        }

        private void Clear()
        {
            pass1.Password = string.Empty;
            pass2.Password = string.Empty;
            pass3.Password = string.Empty;
        }

        //return to main user window
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
