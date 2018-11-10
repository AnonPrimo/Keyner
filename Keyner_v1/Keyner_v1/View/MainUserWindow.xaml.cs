using System;
using System.Collections.Generic;
using System.IO;
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
        Controller.UserFormController usercon;
        int indexOfCurrentTest;

        public MainUserWindow()
        {
            InitializeComponent();
            gamebutton.IsEnabled = false;

            //test
            fillWindowFields(1);
        }

        public MainUserWindow(int id) : this()
        {
            //fillWindowFields(id);
        }

        private void fillWindowFields(int id)
        {
            usercon = getUserFormController();
            CurrentTest();
            fillImage();
            fillGrid();
            fillUserInfo(usercon.CurrentUser.Name, usercon.CurrentUser.Money.ToString());
            MoneyImage.Source = new BitmapImage(new Uri("/Monster/money_im.png", UriKind.Relative));
        }

        private Controller.UserFormController getUserFormController()
        {
           return new Controller.UserFormController(1);
        }

        private void fillGrid()
        {
            datagrid1.ItemsSource = usercon.UserTest;
            datagrid1.FontSize = 15;

        }

        private void CurrentTest()
        {
            for(int i = 0; i < usercon.UserTest.Count;i++)
            {
                if (!usercon.UserTest[i].IsPassed)
                {
                    indexOfCurrentTest = i;
                    return;
                }
            }
        }

        private void fillUserInfo(string name, string money)
        {
            txt1.Text = name;
            txt1.FontSize = 20;

            txt2.Text = money;
            txt2.FontSize = 20;

            txt3.FontSize = 15;
            if(indexOfCurrentTest <= 100)
                txt3.Text = "Наступний тест №: " + indexOfCurrentTest;
            else
                txt3.Text = "Ви пройшли всі тести!!!";
        }

        private void fillImage()
        {
            BitmapImage im = new BitmapImage(new Uri("/Monster/monster_no_im.png", UriKind.Relative));
            usercon.getMonsterImage(ref im);
            monster.Source = im;
        }

        private void shopbutton_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow sw = new ShopWindow();
            sw.shopcon.CurrentUser = usercon.CurrentUser;
            sw.ShowDialog();
        }

        private void gamebutton_Click(object sender, RoutedEventArgs e)
        {
            Test test = new Test();
            this.Hide();
            test.ShowDialog();
            this.Show();
        }

        private void datagrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (((Controller.UserTests)datagrid1.SelectedItem).IsPassed || (Controller.UserTests)datagrid1.SelectedItem == usercon.UserTest[indexOfCurrentTest])
                gamebutton.IsEnabled = true;
            else
                gamebutton.IsEnabled = false;
            }
            catch { }
        }
    }
}
