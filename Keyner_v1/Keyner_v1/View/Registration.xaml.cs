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
      
        public Registration()
        {
            InitializeComponent();
            aar = new Controller.AutorizAndRegistr();

            comboBoxGroup.DisplayMemberPath = "Name";
            comboBoxGroup.SelectedValue = "Id";
            comboBoxGroup.ItemsSource = aar.GetGroupList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxGroup.SelectionBoxItem == "")
            {
                MessageBox.Show("Введіть усі дані");
                return;
            }

            if(fio.Text == "")
            {
                MessageBox.Show("Введіть ім'я користувача");
                return;
            }

            if (passBox.Password.Length == 0)
            {
                MessageBox.Show("Пароль не введено!");
                return;
            }

            if (passBox.Password == passBox_Copy.Password)
            {
                if(aar.CheckName(fio.Text))
                {
                    MessageBox.Show("Таке ім'я користувача вже існує");
                    return;
                }

                aar.AddUser(fio.Text, passBox.Password, (comboBoxGroup.SelectedValue as Model.Group).Id);

                int id_user = aar.GetIdUser(fio.Text, passBox.Password);
                MainUserWindow mw = new MainUserWindow(id_user);
                this.Hide();
                mw.ShowDialog();
                this.Close();
            }
            else
                if(passBox_Copy.Password == "")
                MessageBox.Show("Не введено підтвердження пароля");
            else
                MessageBox.Show("Паролі не співпадають!");

        }
    }
}
