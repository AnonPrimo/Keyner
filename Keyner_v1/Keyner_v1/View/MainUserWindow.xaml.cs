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
        int index;

        public MainUserWindow()
        {
            InitializeComponent();
            gamebutton.IsEnabled = false;
            usercon = getUserFormController();
            CurrentTest();
            fillImage(usercon.getMonsterImage());
            fillGrid();
            fillInfo(usercon.CurrentUser.Name, usercon.CurrentUser.Money.ToString());
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
                    index = i;
                    return;
                }
            }
        }

        private void fillInfo(string name, string money)
        {
            txt1.Text = name;
            txt1.FontSize = 20;

            txt2.Text = money;
            txt2.FontSize = 20;
            
            if(index <= 100)
                txt3.Text = "Наступний тест №: " + index;
            else
                txt3.Text = "Ви пройшли всі тести!!!";
        }

        private void fillImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();

            monster.Source = image;
        }

        private void shopbutton_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow sw = new ShopWindow();
            sw.Show();
        }

        private void gamebutton_Click(object sender, RoutedEventArgs e)
        {
            Test test = new Test();
            this.Visibility = Visibility.Hidden;
            test.ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void datagrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (((Controller.UserTests)datagrid1.SelectedItem).IsPassed || (Controller.UserTests)datagrid1.SelectedItem == usercon.UserTest[index])
                gamebutton.IsEnabled = true;
            else
                gamebutton.IsEnabled = false;
            }
            catch { }
        }
    }
}
