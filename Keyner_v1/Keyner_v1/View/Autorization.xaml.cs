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

        List<GroupTest> group;
        public List<UserTest> user;

        public Autorization()
        {
            InitializeComponent();
            //   Con();
            ConTest();
        }

        private void Con()
        {
            keynerContext = new Model.KeynerContext();
            aar = new Controller.AutorizAndRegistr();

            comboBoxGroup.DataContext = keynerContext.GroupSet.ToList();
            comboBoxGroup.DisplayMemberPath = "Name";
            comboBoxGroup.SelectedValue = "Id";

            comboBoxUser.DataContext = keynerContext.UserSet.ToList();
            comboBoxUser.DisplayMemberPath = "Name";
            comboBoxUser.SelectedValue = "Id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (aar.GetPass((comboBoxUser.SelectedValue as UserTest).Id, passBox.Password, this))
            //{
            //    MainUserWindow mw = new MainUserWindow(/*(int)comboBoxUser.SelectedValue*/);
            //    mw.Show();
            //    this.Close();
            //}

            if (comboBoxUser.SelectedValue is UserTest)
                if (GetPassTest())
                {
                    MainUserWindow mw = new MainUserWindow((comboBoxUser.SelectedValue as UserTest).Id);
                    mw.Show();
                    this.Close();
                }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registration r = new Registration();
            r.Owner = this;
            r.Show();
            this.Close();
        }

        public void ConTest()
        {
            user = new List<UserTest>();
            user.Add(new UserTest(1, "Катя1", 1, "p1"));
            user.Add(new UserTest(2, "Катя2", 1, "p2"));
            user.Add(new UserTest(3, "Катя3", 1, "p3"));
            user.Add(new UserTest(4, "Катя4", 2, "p4"));
            user.Add(new UserTest(5, "Катя5", 2, "p5"));

            comboBoxUser.DisplayMemberPath = "Name";
            comboBoxUser.SelectedValue = "Id";
            comboBoxUser.ItemsSource = user;

            group = new List<GroupTest>();
            group.Add(new GroupTest(1, "RPZ3"));
            group.Add(new GroupTest(2, "RPZ6"));

            comboBoxGroup.DisplayMemberPath = "Name";
            comboBoxGroup.SelectedValue = "Id";
            comboBoxGroup.ItemsSource = group;
        }

        public class UserTest
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
            public int Id_Group { get; set; }

            public UserTest(int i, string n, int g, string p)
            {
                Id = i;
                Name = n;
                Id_Group = g;
                Password = p;
            }
        }

        public class GroupTest
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public GroupTest(int i, string n)
            {
                Id = i;
                Name = n;
            }
        }

        public bool GetPassTest()
        {
            foreach (var item in user)
            {
                if (item.Id == (comboBoxUser.SelectedValue as UserTest).Id)
                {
                    if (item.Password == passBox.Password)
                        return true;
                }
            }
            return false;
        }

    }
}
