using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Keyner_v1.View
{
    /// <summary>
    /// Логика взаимодействия для MainUserWindow.xaml
    /// </summary>
    public partial class MainUserWindow : Window
    {
        Controller.UserFormController usercon;
        int indexOfCurrentTest;
        int userLevel;

        public MainUserWindow()
        {
            InitializeComponent();
            gamebutton.IsEnabled = false;

            //test
            //fillWindowFields(1);
        }

        public MainUserWindow(int id) : this()
        {
            usercon = getUserFormController(id);
            fillWindowFields(id);
        }

        //fill all user info
        private void fillWindowFields(int id)
        {
            usercon.UpdateUser(id);     //filling user data
            fillGrid();             //filling test grid
            fillUserInfo(usercon.CurrentUser.Name, usercon.CurrentUser.Money.ToString());   
            CurrentTest();          //find current test number
            fillNextTest(usercon.getTestCount());   
            MoneyImage.Source = new BitmapImage(new Uri("/Pictures/money_im.png", UriKind.Relative));

            datagrid1.SelectedIndex = indexOfCurrentTest;

            userLevel = (int)usercon.GetUserLevel(indexOfCurrentTest);  //find user level
            //testing
            //int tmp = indexOfCurrentTest + 23;
            //userLevel = (int)usercon.GetUserLevel(tmp);  //find user level
            fillImage();            //filling monster image
        }

        private Controller.UserFormController getUserFormController(int id)
        {
            return new Controller.UserFormController(id);
        }

        private void fillGrid()
        {
            usercon.UpdateUserTests();
            datagrid1.ItemsSource = null;
            datagrid1.ItemsSource = usercon.UserTest;
            datagrid1.FontSize = 15;
        }

        //index of current test
        private void CurrentTest()
        {
            for (int i = 0; i < usercon.UserTest.Count; i++)
            {
                if (!usercon.UserTest[i].IsPassed)
                {
                    indexOfCurrentTest = i;
                    return;
                }
            }
        }

        //fill user name and money
        private void fillUserInfo(string name, string money)
        {
            txt1.Text = name;

            txt2.Text = money;
            txt2.FontSize = 20;
        }

        private void fillNextTest(int count)
        {
            txt3.FontSize = 15;
            if (indexOfCurrentTest <= count)
                txt3.Text = "Наступний тест № " + (indexOfCurrentTest + 1);
            else
                txt3.Text = "Ви пройшли всі тести!!!";
        }

        //monster image filling
        private void fillImage()
        {
            BitmapImage im = new BitmapImage(new Uri("/Pictures/monster_no_im.png", UriKind.Relative));
            usercon.getMonsterImage(ref im, userLevel);
            monster.Source = im;
        }

        //shop window
        private void shopbutton_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow sw = new ShopWindow(usercon.CurrentUser.Id);
            this.Hide();
            sw.ShowDialog();

            fillWindowFields(usercon.CurrentUser.Id);
            this.ShowDialog();
        }

        //test window
        private void gamebutton_Click(object sender, RoutedEventArgs e)
        {
            int id;
            string testNum = txt3.Text;
            if (datagrid1.SelectedItem != null)
            {
                testNum = ((Controller.UserTests)datagrid1.SelectedItem).TestName;
                id = ((Controller.UserTests)datagrid1.SelectedItem).IdTest; //id of selected test (if is available)
            }
            else
                id = usercon.UserTest[indexOfCurrentTest].IdTest;   //id of current test

            bool isOld = usercon.StatisticTestCheck(id);
            Test test = new Test(usercon.CurrentUser.Id, id, isOld);
            test.Title = "Тест " + GetTestNum(testNum);
            this.Hide();
            try
            {
                test.ShowDialog();
            }
            catch { }

            int oldLvl = userLevel;
            //update window after test
            fillWindowFields(usercon.CurrentUser.Id);

            if (LvlChangeCheck(oldLvl))
                MessageBox.Show("\tВІТАЄМО!!!\nВаш монстр став дорослішим!");

            this.ShowDialog();
        }

        private bool LvlChangeCheck(int lvl)
        {
            if (userLevel > lvl)
                return true;
            return false;
        }

        //getting number of test to be done
        private int GetTestNum(string s)
        {
            string num = s.Split('№')[1];
            int i;
            int.TryParse(num, out i);
            return i;
        }

        //check if test is available
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

        //setting window
        private void settingbutton_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow sw = new SettingsWindow();
            sw.IdUser = usercon.CurrentUser.Id;
            this.Hide();
            sw.ShowDialog();

            //update window
            fillWindowFields(usercon.CurrentUser.Id);
            this.ShowDialog();
        }

        //exit
        private void exitbutton_Click(object sender, RoutedEventArgs e)
        {
            if (usercon.CurrentUser != null)
                usercon.CurrentUser = null;

            this.DialogResult = true;
        }
    }
}
