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

        public List<Model.Group> group;
        public List<Model.User> user;

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

            if (comboBoxUser.SelectedValue is Model.User)
                if (GetPassTest())
                {
                    MainUserWindow mw = new MainUserWindow((comboBoxUser.SelectedValue as Model.User).Id);
                    this.Hide();

                    mw.ShowDialog();
                    this.Close();
                }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registration r = new Registration(this);
            this.Hide();
            r.ShowDialog();
            this.Close();
        }

        public void ConTest()
        {
            user = new List<Model.User>()
            {
                 new Model.User { Id = 1, Name = "Катя1",  Password = "p1", Id_Group = 1, Id_Monster = 1, Money = 0 },
                 new Model.User { Id = 2, Name = "Катя2",  Password = "p2", Id_Group = 1, Id_Monster = 1, Money = 0 },
                 new Model.User { Id = 3, Name = "Катя3",  Password = "p3", Id_Group = 1, Id_Monster = 1, Money = 0 },
                 new Model.User { Id = 4, Name = "Катя4",  Password = "p4", Id_Group = 2, Id_Monster = 1, Money = 0 },
                 new Model.User { Id = 5, Name = "Катя5",  Password = "p5", Id_Group = 2, Id_Monster = 1, Money = 0 }
            };

            

            group = new List<Model.Group>
            {
                new Model.Group { Id = 1, Name = "RPZ3" },
                new Model.Group { Id = 2, Name = "RPZ6" }
            };
            
            comboBoxGroup.DisplayMemberPath = "Name";
            comboBoxGroup.SelectedValue = "Id";
            comboBoxGroup.ItemsSource = group;
        }

      

        public bool GetPassTest()
        {
            foreach (var item in user)
            {
                if (item.Id == (comboBoxUser.SelectedValue as Model.User).Id)
                {
                    if (item.Password == passBox.Password)
                        return true;
                }
            }
            return false;
        }

        private void comboBoxGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Model.User> us = new List<Model.User>();

            foreach (var item in user)
            {
                if ((comboBoxGroup.SelectedValue as Model.Group).Id == item.Id_Group)
                    us.Add(item);
            }

            comboBoxUser.DisplayMemberPath = "Name";
            comboBoxUser.SelectedValue = "Id";
            comboBoxUser.ItemsSource = us;
        }
    }
}
