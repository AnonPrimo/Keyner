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

namespace Keyner_v1.View
{
    class KeyboardKey
    {
        TextBlock txt;
        Key key;
        string charKey;
        public bool IsHighlighted { get; set; }

        public KeyboardKey(TextBlock txt, Key k, string ch)
        {
            this.txt = txt;
            key = k;
            charKey = ch;
            IsHighlighted = false;
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
        List<KeyboardKey> dictionaryKeys;
        TestController controller;
        TextPointer position;
        bool isTestCompleted = false;
        public Test()
        {
            InitializeComponent();
            dictionaryKeys = new List<KeyboardKey>();
            FillKeys();
            controller = new TestController();
            TextToWrite.IsReadOnly = true;
            TextToWrite.FontFamily = new FontFamily("Courier New, monospace");
            InputText.FontFamily = new FontFamily("Courier New, monospace");
            FillText();
            ChangeColorByPosition();
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
            position = TextToWrite.Document.ContentStart.GetPositionAtOffset(3);
        }






        private void StartContinueTest()
        {
            for (position = TextToWrite.Document.ContentStart; position != TextToWrite.Document.ContentEnd; position = position.GetPositionAtOffset(1))
            {
                while (IsEmptyRange())
                {
                    ChangeToBlack();
                    position = position.GetPositionAtOffset(1);
                }
                ChangeToBlack();
                position = position.GetPositionAtOffset(1);
                ChangeColorByPosition();
            }
        }

        private bool IsEmptyRange()
        {
            var endPos = position.GetPositionAtOffset(1);
            TextRange textRange = new TextRange(position, endPos);
            foreach (char c in textRange.Text)
            {
                if (c == '\n')
                {
                    InputText.Text += Environment.NewLine;
                    return true;
                }
                if(c == '\r')
                {
                    return true;
                }
            }
            return false;

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
            dictionaryKeys.Add(new KeyboardKey(txt_leftSpace, Key.Space, " "));
            dictionaryKeys.Add(new KeyboardKey(txt_rightSpace, Key.Space, " "));
            dictionaryKeys.Add(new KeyboardKey(txt_rightAlt, Key.RightAlt, "rAlt"));
            dictionaryKeys.Add(new KeyboardKey(txt_rightPKM, Key.Apps, "apps"));
            dictionaryKeys.Add(new KeyboardKey(txt_rightCtrl, Key.RightCtrl, "rCtrl"));
        }

        /// <summary>
        /// checks is pressed the correct button
        /// </summary>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isTestCompleted)
            {
                StartContinueTest();
                Key pressedKey = e.Key;
                //if (dictionaryKeys[FindByKey(pressedKey)].IsHighlighted == true) CorrectSymbol();
                CorrectSymbol();
            }
        }

        /// <summary>
        /// if pressed the correct button moves the position forward and adds the right characted in the In
        /// </summary>
        private void CorrectSymbol()
        {
            MovePosition();
            ChangeToBlack();

            var startPos = position;
            var endPos = position.GetPositionAtOffset(1);

            TextRange textRange = new TextRange(startPos, endPos);
            InputText.Text += textRange.Text;
            ChangeToBlack();
            ChangeColorByPosition();
            position = position.GetPositionAtOffset(1);

        }

        /// <summary>
        /// skips the "" in string
        /// </summary>
        private void MovePosition()
        {
            var startPos = position.GetPositionAtOffset(-1);
            var endPos = position;
            TextRange textRange = new TextRange(startPos, endPos);
            while (textRange.Text == "")
            {
                foreach (char c in textRange.Text)
                {
                    if (c == '\r')
                    {
                        ChangeToBlack();
                    }
                    if (c == '\n')
                    {
                        ChangeToBlack();
                        InputText.Text += Environment.NewLine;
                    }
                }
                position = position.GetPositionAtOffset(1);
                startPos = position;
                endPos = position.GetPositionAtOffset(1);
                textRange = new TextRange(startPos, endPos);
            }
        }

        /// <summary>
        /// changes color of the character you need to write
        /// </summary>
        private void ChangeColorByPosition()
        {

            var startPos = position.GetPositionAtOffset(-1);
            var endPos = position;
            TextRange textRange = new TextRange(startPos, endPos);

            textRange.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.Red));
            textRange.Text = textRange.Text.Replace("", " ");
            dictionaryKeys[FindByChar(textRange.Text)].IsHighlighted = true;
        }

        /// <summary>
        /// returns color to black if pressed the right button
        /// </summary>
        private void ChangeToBlack()
        {
            var startPos = position;
            var endPos = position.GetPositionAtOffset(1);

            TextRange textRange = new TextRange(startPos, endPos);
            textRange.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.White));
            foreach (char c in textRange.Text)
            {
                dictionaryKeys[FindByChar(c.ToString())].IsHighlighted = false;
            }
        }

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