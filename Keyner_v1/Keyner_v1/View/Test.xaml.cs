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
        string charKey;
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
        List<KeyboardKey> dictionaryKeys;
        TestController controller;
        TextPointer position;
        string current;
        int mistakes = 0;
        bool isTestCompleted = false;
        TextRange textRange;
        public Test()
        {
            InitializeComponent();
            FillForm();
            FillText();
            ClearColors();
            label_error.Visibility = Visibility.Collapsed;
        }

        public Test(int user_id, int test_id)
        {
            FillForm();
            FillTextFromDatabase(test_id);
            ClearColors();
            label_error.Visibility = Visibility.Collapsed;
        }

        private void FillForm()
        {
            startTime = new Stopwatch();
            dictionaryKeys = new List<KeyboardKey>();
            FillKeys();
            controller = new TestController();
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
        }

        /// <summary>
        /// test method will be replaced
        /// </summary>
        private void FillText()
        {
            int addText = controller.RepeatCount;

            string str = controller.CurrentStr;
            FlowDocument flowDoc = new FlowDocument();
            while (addText > 0)
            {
                flowDoc.Blocks.Add(new Paragraph(new Run(str)));
                addText--;
            }
            TextToWrite.Document = flowDoc;
            position = TextToWrite.Document.ContentStart.GetPositionAtOffset(0);
        }

        /// <summary>
        /// Gets the text to write from database
        /// </summary>
        private void FillTextFromDatabase(int id_test)
        {
            string str = controller.GetText(id_test);
            TextToWrite.Document.Blocks.Add(new Paragraph(new Run(str)));
            position = TextToWrite.Document.ContentStart.GetPositionAtOffset(0);
        }
        /// <summary>
        /// fills keys dictionary
        /// </summary>
        private void FillKeys()
        {
            dictionaryKeys.Add(new KeyboardKey(txt_a, Key.A, "ф"));
            dictionaryKeys.Add(new KeyboardKey(txt_b, Key.B, "и"));
            dictionaryKeys.Add(new KeyboardKey(txt_c, Key.C, "с"));
            dictionaryKeys.Add(new KeyboardKey(txt_d, Key.D, "в"));
            dictionaryKeys.Add(new KeyboardKey(txt_e, Key.E, "у"));
            dictionaryKeys.Add(new KeyboardKey(txt_f, Key.F, "а"));
            dictionaryKeys.Add(new KeyboardKey(txt_g, Key.G, "п"));
            dictionaryKeys.Add(new KeyboardKey(txt_h, Key.H, "р"));
            dictionaryKeys.Add(new KeyboardKey(txt_i, Key.I, "ш"));
            dictionaryKeys.Add(new KeyboardKey(txt_j, Key.J, "о"));
            dictionaryKeys.Add(new KeyboardKey(txt_k, Key.K, "л"));
            dictionaryKeys.Add(new KeyboardKey(txt_l, Key.L, "д"));
            dictionaryKeys.Add(new KeyboardKey(txt_m, Key.M, "ь"));
            dictionaryKeys.Add(new KeyboardKey(txt_n, Key.N, "т"));
            dictionaryKeys.Add(new KeyboardKey(txt_o, Key.O, "щ"));
            dictionaryKeys.Add(new KeyboardKey(txt_p, Key.P, "з"));
            dictionaryKeys.Add(new KeyboardKey(txt_q, Key.Q, "й"));
            dictionaryKeys.Add(new KeyboardKey(txt_r, Key.R, "к"));
            dictionaryKeys.Add(new KeyboardKey(txt_s, Key.S, "і"));
            dictionaryKeys.Add(new KeyboardKey(txt_t, Key.T, "е"));
            dictionaryKeys.Add(new KeyboardKey(txt_u, Key.U, "г"));
            dictionaryKeys.Add(new KeyboardKey(txt_v, Key.V, "м"));
            dictionaryKeys.Add(new KeyboardKey(txt_w, Key.W, "ц"));
            dictionaryKeys.Add(new KeyboardKey(txt_x, Key.X, "ч"));
            dictionaryKeys.Add(new KeyboardKey(txt_y, Key.Y, "н"));
            dictionaryKeys.Add(new KeyboardKey(txt_z, Key.Z, "я"));
            dictionaryKeys.Add(new KeyboardKey(txt_apostrof, Key.Oem3, "'"));
            dictionaryKeys.Add(new KeyboardKey(txt_minus, Key.OemMinus, "-"));
            dictionaryKeys.Add(new KeyboardKey(txt_eql, Key.OemPlus, "="));
            dictionaryKeys.Add(new KeyboardKey(txt_backspace, Key.Back, "bcksp"));
            dictionaryKeys.Add(new KeyboardKey(txt_tab, Key.Tab, "tab"));
            dictionaryKeys.Add(new KeyboardKey(txt_sqrBracketLeft, Key.OemOpenBrackets, "х"));
            dictionaryKeys.Add(new KeyboardKey(txt_sqrBracketRight, Key.Oem6, "ї"));
            dictionaryKeys.Add(new KeyboardKey(txt_caps, Key.Capital, "caps"));
            dictionaryKeys.Add(new KeyboardKey(txt_semikolon, Key.Oem1, "ж"));
            dictionaryKeys.Add(new KeyboardKey(txt_quotes, Key.OemQuotes, "є"));
            dictionaryKeys.Add(new KeyboardKey(txt_enter, Key.Return, "enter"));
            dictionaryKeys.Add(new KeyboardKey(txt_shift, Key.LeftShift, "lShift"));
            dictionaryKeys.Add(new KeyboardKey(txt_coma, Key.OemComma, "б"));
            dictionaryKeys.Add(new KeyboardKey(txt_slash, Key.OemQuestion, "."));
            dictionaryKeys.Add(new KeyboardKey(txt_dot, Key.OemPeriod, "ю"));
            dictionaryKeys.Add(new KeyboardKey(txt_rightShift, Key.RightShift, "rShift"));
            dictionaryKeys.Add(new KeyboardKey(txt_leftCtrl, Key.LeftCtrl, "lCtrl"));
            dictionaryKeys.Add(new KeyboardKey(txt_leftAlt, Key.LeftAlt, "lAlt"));
            dictionaryKeys.Add(new KeyboardKey(txt_Space, Key.Space, " "));
            dictionaryKeys.Add(new KeyboardKey(txt_rightAlt, Key.RightAlt, "rAlt"));
            dictionaryKeys.Add(new KeyboardKey(txt_rightPKM, Key.Apps, "apps"));
            dictionaryKeys.Add(new KeyboardKey(txt_rightCtrl, Key.RightCtrl, "rCtrl"));
        }

        /// <summary>
        /// checks is pressed the correct button
        /// </summary>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (!updateTime.IsEnabled)
            {
                startTime.Start();
                updateTime.Start();
                
            }
            if (!isTestCompleted)
            {
                label_error.Visibility = Visibility.Collapsed;
                ClearColors();
                Key pressedKey = e.Key;
                if (pressedKey == dictionaryKeys[FindByChar(TestController.collection[0].ToString())].key)
                {
                    CorrectSymbol();
                    TestController.collection.RemoveAt(0);
                    if (TestController.collection.Count == 0) isTestCompleted = true;
                    ClearColors();
                }
                else
                {
                    int i = FindByKey(pressedKey);
                    if (i >= 0)
                        dictionaryKeys[i].txt.Background = Brushes.Red;
                    label_error.Visibility = Visibility.Visible;
                    mistakes++;
                    MistakesLabel.Content = "Кількість помилок: " + mistakes;
                    if (mistakes > 3) EndTest();
                }
            }
            else
            {
                updateTime.Stop();
                string avgSpeed = Math.Round(InputText.Text.Length / (TimeSpentMinutes()), 2).ToString();
                string accuracy = Math.Round((((double)(InputText.Text.Length) / (double)((InputText.Text.Length + mistakes))) * 100), 2).ToString();
                string toShow = "Ви успішно пройшли тест!\nЧасу витрачено: " + TimeSpent() + "\nЗароблено монет: \nСередня швидкість: " + avgSpeed + "\nКількість помилок: " + mistakes + "\nТочність: " + accuracy + "%";
                MessageBox.Show(toShow);
                this.Close();
            }
        }

        private void EndTest()
        {
            updateTime.Stop();
            string avgSpeed = Math.Round(InputText.Text.Length / (TimeSpentMinutes()), 2).ToString();
            string accuracy = Math.Round((((double)(InputText.Text.Length) / (double)((InputText.Text.Length + mistakes))) * 100), 2).ToString();
            string toShow = "Ви провалили тест.\nЧасу витрачено: " + TimeSpent() + "\nЗароблено монет: \nСередня швидкість: " + avgSpeed + "\nКількість помилок: " + mistakes + "\nТочність: " + accuracy + "%";
            MessageBox.Show(toShow);
            this.Close();
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

        /// <summary>
        /// if pressed the correct button moves the position forward and adds the right characted in the In
        /// </summary>
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
                if (c==4)
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
            foreach (KeyboardKey k in dictionaryKeys)
            {
                k.txt.Background = k.background;
            }
            if (TestController.collection.Count != 0)
                dictionaryKeys[FindByChar(TestController.collection[0].ToString())].txt.Background = Brushes.Green;

        }
        /// <summary>
        /// changes color of the character you need to write
        /// </summary>
        private void ChangeColorByPosition()
        {
            textRange.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.Green));
            current = textRange.Text;

        }

        /// <summary>
        /// returns color to black if pressed the right button
        /// </summary>


        /// <summary>
        /// finds a needed dictionaryKeys index by Key
        /// </summary>
        /// <param name="k"></param>
        private int FindByKey(Key k)
        {
            for (int i = 0; i < dictionaryKeys.Count; i++)
            {
                if (dictionaryKeys[i].EqualsKey(k)) return i;
            }
            return -1;
        }

        private int FindByChar(string k)
        {
            for (int i = 0; i < dictionaryKeys.Count; i++)
            {
                if (dictionaryKeys[i].EqualsString(k.ToLower())) return i;
            }
            return -1;
        }
    }
}