﻿using System;
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
            autor = a;

            comboBoxGroup.DisplayMemberPath = "Name";
            comboBoxGroup.SelectedValue = "Id";
            comboBoxGroup.ItemsSource = autor.group;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(passBox.Password == passBox_Copy.Password)
                aar.AddUserTest(fio.Text, passBox.Password, (comboBoxGroup.SelectedValue as Model.Group).Id, autor.user);

            int id_user = aar.GetIdUserTest(fio.Text, passBox.Password, autor);
            MainUserWindow mw = new MainUserWindow(id_user);
            mw.Show();
            
           // this.Close();
        }

      
    }
}
