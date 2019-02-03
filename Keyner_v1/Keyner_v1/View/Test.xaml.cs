using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Keyner_v1.Controller;
using System.Text.RegularExpressions;
using System.Windows.Threading;
using System.Diagnostics;

namespace Keyner_v1.View
{
    class KeyboardKey
    {
        public TextBlock txt;
        public Key key;
        public string charKey;
        public Brush background;

        public KeyboardKey(TextBlock txt, Key k, string ch)
        {
            this.txt = txt;
            key = k;
            charKey = ch;
            background = txt.Background;
        }

        public bool EqualsKey(Key k)
        {
            return k == key;
        }

        public bool EqualsString(string s)
        {
            return s == charKey;
        }
    }

    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>

    public partial class Test : Window
    {
        Stopwatch startTime;
        DispatcherTimer updateTime;
        List<KeyboardKey> listKeys;
        TestController controller;
        TextPointer position;
        string current;
        int mistakes = 0;
        bool isTestCompleted = false;
        TextRange textRange;
        int IdUser;
        int IdTest;
        string str;
        bool IsTestNew = false;
        int finishTime;

        //testing 
        bool error = false;
        int c = 0;

        public Test()
        {
            InitializeComponent();
            FillForm(1);
            FillText();
            ClearColors();
            label_error.Visibility = Visibility.Collapsed;
        }

        public Test(int user_id, int test_id, bool newTest)
        {
            InitializeComponent();
            FillForm(test_id);
            FillTextFromDatabase();
            ClearColors();
            label_error.Visibility = Visibility.Collapsed;
            IdUser = user_id;
            IdTest = test_id;
            IsTestNew = newTest;

            Monster(2); ///int - mood: 1- Happy 2 - Neutral 3 - Ready 4 - Sad
        }

        private void FillForm(int test_id)
        {
            controller = new TestController(test_id);
            startTime = new Stopwatch();
            listKeys = new List<KeyboardKey>();
            FillKeys();
            TextToWrite.IsReadOnly = true;
            TextToWrite.FontFamily = new FontFamily("Courier New, monospace");
            InputText.FontFamily = new FontFamily("Courier New, monospace");
            updateTime = new DispatcherTimer();
            updateTime.Interval = new TimeSpan(0, 0, 0, 0, 10);
            updateTime.Tick += timer_tick;
        }

        private void timer_tick(object sender, EventArgs e)
        {
            TimeSpentLabel.Content = "Час: " + TimeSpent();
            if (error)
            {
                startTime.Stop();
                c++;
                this.PreviewTextInput -= Window_PreviewTextInput;
                Debug.WriteLine(c.ToString());
            }

            if (c == 20)
            {
                startTime.Start();
                c = 0;
                error = false;
                this.PreviewTextInput += Window_PreviewTextInput;
                Monster(2);
                label_error.Visibility = Visibility.Collapsed;
                ClearColors();
            }
        }
        
        /// test method will be replaced
        private void FillText()
        {
            int addText = controller.RepeatCount;

            str = controller.CurrentStr;
            FlowDocument flowDoc = new FlowDocument();
            while (addText > 0)
            {
                flowDoc.Blocks.Add(new Paragraph(new Run(str)));
                addText--;
            }
            TextToWrite.Document = flowDoc;
            position = TextToWrite.Document.ContentStart.GetPositionAtOffset(0);
        }
        
        /// Gets the text to write from database
        private void FillTextFromDatabase()
        {
            str = controller.GetText();
            FlowDocument flowDoc = new FlowDocument();
            flowDoc.Blocks.Add(new Paragraph(new Run(str)));
            TextToWrite.Document = flowDoc;
            position = TextToWrite.Document.ContentStart.GetPositionAtOffset(0);
        }
        

        /// fills keys dictionary
        private void FillKeys()
        {
            listKeys.Add(new KeyboardKey(txt_a, Key.A, "ф"));
            listKeys.Add(new KeyboardKey(txt_b, Key.B, "и"));
            listKeys.Add(new KeyboardKey(txt_c, Key.C, "с"));
            listKeys.Add(new KeyboardKey(txt_d, Key.D, "в"));
            listKeys.Add(new KeyboardKey(txt_e, Key.E, "у"));
            listKeys.Add(new KeyboardKey(txt_f, Key.F, "а"));
            listKeys.Add(new KeyboardKey(txt_g, Key.G, "п"));
            listKeys.Add(new KeyboardKey(txt_h, Key.H, "р"));
            listKeys.Add(new KeyboardKey(txt_i, Key.I, "ш"));
            listKeys.Add(new KeyboardKey(txt_j, Key.J, "о"));
            listKeys.Add(new KeyboardKey(txt_k, Key.K, "л"));
            listKeys.Add(new KeyboardKey(txt_l, Key.L, "д"));
            listKeys.Add(new KeyboardKey(txt_m, Key.M, "ь"));
            listKeys.Add(new KeyboardKey(txt_n, Key.N, "т"));
            listKeys.Add(new KeyboardKey(txt_o, Key.O, "щ"));
            listKeys.Add(new KeyboardKey(txt_p, Key.P, "з"));
            listKeys.Add(new KeyboardKey(txt_q, Key.Q, "й"));
            listKeys.Add(new KeyboardKey(txt_r, Key.R, "к"));
            listKeys.Add(new KeyboardKey(txt_s, Key.S, "і"));
            listKeys.Add(new KeyboardKey(txt_t, Key.T, "е"));
            listKeys.Add(new KeyboardKey(txt_u, Key.U, "г"));
            listKeys.Add(new KeyboardKey(txt_v, Key.V, "м"));
            listKeys.Add(new KeyboardKey(txt_w, Key.W, "ц"));
            listKeys.Add(new KeyboardKey(txt_x, Key.X, "ч"));
            listKeys.Add(new KeyboardKey(txt_y, Key.Y, "н"));
            listKeys.Add(new KeyboardKey(txt_z, Key.Z, "я"));            
            listKeys.Add(new KeyboardKey(txt_apostrof, Key.Oem3, "'"));
            listKeys.Add(new KeyboardKey(txt_minus, Key.OemMinus, "-"));
            listKeys.Add(new KeyboardKey(txt_eql, Key.OemPlus, "="));
            listKeys.Add(new KeyboardKey(txt_backspace, Key.Back, "bcksp"));
            listKeys.Add(new KeyboardKey(txt_tab, Key.Tab, "tab"));
            listKeys.Add(new KeyboardKey(txt_sqrBracketLeft, Key.OemOpenBrackets, "х"));
            listKeys.Add(new KeyboardKey(txt_sqrBracketRight, Key.Oem6, "ї"));
            listKeys.Add(new KeyboardKey(txt_caps, Key.Capital, "caps"));
            listKeys.Add(new KeyboardKey(txt_semikolon, Key.Oem1, "ж"));
            listKeys.Add(new KeyboardKey(txt_quotes, Key.OemQuotes, "є"));
            listKeys.Add(new KeyboardKey(txt_enter, Key.Return, "\n"));
            listKeys.Add(new KeyboardKey(txt_shift, Key.LeftShift, "lShift"));
            listKeys.Add(new KeyboardKey(txt_coma, Key.OemComma, "б"));
            listKeys.Add(new KeyboardKey(txt_slash, Key.OemQuestion, "."));
            listKeys.Add(new KeyboardKey(txt_dot, Key.OemPeriod, "ю"));            
            listKeys.Add(new KeyboardKey(txt_rightShift, Key.RightShift, "rShift"));
            listKeys.Add(new KeyboardKey(txt_leftCtrl, Key.LeftCtrl, "lCtrl"));
            listKeys.Add(new KeyboardKey(txt_leftAlt, Key.LeftAlt, "lAlt"));
            listKeys.Add(new KeyboardKey(txt_Space, Key.Space, " "));
            listKeys.Add(new KeyboardKey(txt_rightAlt, Key.RightAlt, "rAlt"));
            listKeys.Add(new KeyboardKey(txt_rightPKM, Key.Apps, "apps"));
            listKeys.Add(new KeyboardKey(txt_rightCtrl, Key.RightCtrl, "rCtrl"));
        }


        private int GetMark(bool is_passed)
        {
            double procMistakes = 100 * mistakes / controller.currentTest.CountMistakes;
            int time = controller.currentTest.MaxTime;
            if (is_passed)
            {
                if (IdTest < 185)
                    if (finishTime <= time && procMistakes <= 20)
                        return 3;
                    else
                    if (finishTime <= time && procMistakes <= 60)
                        return 2;
                    else
                        return 1;
                else
                    if (IdTest < 213)
                    if (finishTime <= time && procMistakes <= 20)
                        return 3;
                    else
                   if (finishTime <= time && procMistakes <= 60)
                        return 2;
                    else
                        return 1;
                else
                    if (IdTest >= 213)
                    if (finishTime <= time && procMistakes <= 20)
                        return 3;
                    else
                   if (finishTime <= time && procMistakes <= 60)
                        return 2;
                    else
                        return 1;
            }
            return 0;
        }

        private string TimeSpent()
        {
            string timeSpent = startTime.Elapsed.Minutes + ":" + startTime.Elapsed.Seconds + ":" + startTime.Elapsed.Milliseconds / 10;
            return timeSpent;
        }

        private double TimeSpentMinutes()
        {
            double timeSpentMinutes = startTime.Elapsed.Minutes + (startTime.Elapsed.Seconds + startTime.Elapsed.Milliseconds / 1000) / 60;
            return timeSpentMinutes;
        }
        
        /// if pressed the correct button moves the position forward and adds the right characted in the In
        private void CorrectSymbol()
        {
            SkipEmpty();
            ChangeColorByPosition();
            InputText.Text += textRange.Text;
            ChangeColorByPosition();
            position = position.GetPositionAtOffset(1);
        }

        private void SkipEmpty()
        {
            SetPositions();
            int c = 0;
            while (textRange.Text == "")
            {
                c++;
                if (c == 4)
                    InputText.Text += Environment.NewLine;

                SetPositions();
                position = position.GetPositionAtOffset(1);
            }
        }

        private void SetPositions()
        {
            var startPos = position.GetPositionAtOffset(0);
            var endPos = position.GetPositionAtOffset(1);
            textRange = new TextRange(startPos, endPos);
        }

        private void ClearColors()
        {
            foreach (KeyboardKey k in listKeys)
            {
                k.txt.Background = k.background;
            }

            if (TestController.collection.Count != 0)
            {
                if (char.IsUpper(TestController.collection[0]))
                    listKeys.Where(k => k.charKey == "lShift").First().txt.Background = Brushes.Green;
                else
                    listKeys.Where(k => k.charKey == "lShift").First().txt.Background = Brushes.LightBlue;

                listKeys[FindByChar(TestController.collection[0].ToString())].txt.Background = Brushes.Green;
            }
        }
        
        /// changes color of the character you need to write
        private void ChangeColorByPosition()
        {
            textRange.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.Green));
            current = textRange.Text;
        }
        
        private int FindByChar(string k)
        {
            for (int i = 0; i < listKeys.Count; i++)
            {
                if (listKeys[i].EqualsString(k.ToLower())) return i;
            }
            return -1;
        }

        private void Monster(int mood)
        {
            MonsterImage.Source = controller.GetMonster(IdUser, mood);
        }
        
        private void RulesOfTest()
        {
            startTime.Stop();
            if (MessageBox.Show("Умови проходження тесту: \nМаксимальний час: " + controller.currentTest.MaxTime + " секунд \nДопустима кількість помилок: " + controller.currentTest.CountMistakes + "\nУдачі!") == MessageBoxResult.OK)
                startTime.Start();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.Title == "Тест 1")
                RulesOfTest();
        }

        private void Rules_Click(object sender, RoutedEventArgs e)
        {
            RulesOfTest();
            Rules.Focusable = false;

        }

        private void Window_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            //string keyChar1 = (Char)System.Text.Encoding.Unicode.GetBytes(e.Text)[0] + (Char)System.Text.Encoding.Unicode.GetBytes(e.Text)[1]+"";
            //Char keyChar = (Char)int.Parse(keyChar1); 
            //Debug.WriteLine("Key code: " + keyChar1 + "Key: " + keyChar );
         
            if (!updateTime.IsEnabled)
            {
                startTime.Start();
                updateTime.Start();
            }

            if (!isTestCompleted)
            {
                //Monster(2);
                //label_error.Visibility = Visibility.Collapsed;
                //ClearColors();
                string pressedSmth = e.Text;

                if (Keyboard.IsKeyDown(Key.Enter))
                    pressedSmth = "\n";

           
                if (pressedSmth == TestController.collection[0].ToString())
                {
                    
                    Monster(1);
                    CorrectSymbol();
                    TestController.collection.RemoveAt(0);
                    if (TestController.collection.Count == 1)
                        isTestCompleted = true;
                    ClearColors();
                }
                else
                {
                    //startTime.Stop();
                    
                    Monster(3);
                    int i = FindByChar(pressedSmth.ToString());
                    if (i >= 0)
                        listKeys[i].txt.Background = Brushes.Red;
                    label_error.Visibility = Visibility.Visible;
                    mistakes++;
                    MistakesLabel.Content = "Кількість помилок: " + mistakes;

                    if (mistakes > controller.currentTest.CountMistakes)
                        EndTest();

                    error = true;
                }
            }
            else
                EndTest();
        }
        
        private void EndTest()
        {
            updateTime.Stop();
            startTime.Stop();
            ClearColors();
            finishTime = startTime.Elapsed.Minutes * 60 + startTime.Elapsed.Seconds;
            bool is_passed = false;
            string avgSpeed = controller.GetSpeed(IdUser, finishTime).ToString();
            string accuracy = Math.Round((((double)(InputText.Text.Length) / (double)(InputText.Text.Length + mistakes)) * 100), 2).ToString();
            string toShow;
            if (mistakes > controller.currentTest.CountMistakes)
            {
                Monster(4);
                toShow = "Ви провалили тест.\nЧасу витрачено: " + TimeSpent() + "\nКількість помилок: " + mistakes + "\nТочність: " + accuracy + "%";
            }
            else
            {
                Monster(1);
                is_passed = true;
                toShow = "Ви успішно пройшли тест!\nЧасу витрачено: " + TimeSpent() + "\nЗароблено монет: " + controller.GetMoney(GetMark(is_passed)) + "\nСередня швидкість: " + avgSpeed + "\nКількість помилок: " + mistakes + "\nТочність: " + accuracy + "%";
            }
            MessageBox.Show(toShow);
            if (!IsTestNew)
                controller.FillNewStatistic(IdUser, finishTime, is_passed, mistakes, GetMark(is_passed));
            else
                controller.UpdateStatisctic(IdUser, finishTime, mistakes, GetMark(is_passed), is_passed);
            this.Close();
        }
    }
}
