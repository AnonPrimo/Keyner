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

        public Registration(Autorization a)
        {
            InitializeComponent();
            aar = new Controller.AutorizAndRegistr();

            autor = new Autorization();
            autor = a;

            comboBoxGroup.DisplayMemberPath = "Name";
            comboBoxGroup.SelectedValue = "Id";
            comboBoxGroup.ItemsSource = autor.keynerContext.GroupSet.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (passBox.Password == passBox_Copy.Password)
            {
                aar.AddUser(fio.Text, passBox.Password, (comboBoxGroup.SelectedValue as Model.Group).Id);

                int id_user = aar.GetIdUser(fio.Text, passBox.Password);
                MainUserWindow mw = new MainUserWindow(id_user);
                this.Hide();
                mw.ShowDialog();
                this.Close();
            }
        }
    }
}
