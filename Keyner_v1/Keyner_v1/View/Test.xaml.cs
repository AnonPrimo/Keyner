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
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        private byte perenos=0;
        private Dictionary<Key, TextBlock> dictionaryKeys = new Dictionary<Key, TextBlock>();
        
        private void FillLabelKeys()
        {
            //dictionaryKeys.Add(Key.);
            //dictionaryKeys.Add(Key.W, lbl_W);
            //dictionaryKeys.Add(Key.E, lbl_E);
            //dictionaryKeys.Add(Key.R, lbl_R);
        } 

        TestController controller;
        int position;
        string text;
        

        public Test()
        {
            InitializeComponent();
            controller = new TestController();
            position = 0;
            TextToWrite.IsReadOnly = true;
            TextToWrite.FontFamily = new FontFamily("Courier New, monospace");
            InputText.FontFamily = new FontFamily("Courier New, monospace");
            FillText();
            text = new TextRange(TextToWrite.Document.ContentStart, TextToWrite.Document.ContentEnd).Text;
            ChangeColorByPosition();

            //InputText.Text = text;
        }

        /// <summary>
        /// test method, will be replaced
        /// </summary>
        private void FillText()
        {
            
            int addText = controller.RepeatCount;
            
            string str = controller.CurrentStr;
            FlowDocument flowDoc= new FlowDocument();
            while (addText > 0)
            {
                
                flowDoc.Blocks.Add(new Paragraph(new Run(str)));

                addText--;
            }
            TextToWrite.Document = flowDoc;
            position = 2;
        }

        /// <summary>
        /// checks is pressed the correct button
        /// </summary>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Key.ToString() == text(position, )) CorrectSymbol();
            //if (TextToWrite.Text[position] == ' ' && e.Key == Key.Space)
            //    InputText.Text += " " + position + " ";
            if(e.Key.ToString() == "A")
                CorrectSymbol();
        }

        /// <summary>
        /// if pressed the correct button moves the position forward and adds the right characted in the In
        /// </summary>
        private void CorrectSymbol()
        {
            MovePosition();
            position++;

            ChangeColorByPosition();
            ChangeToBlack();
        }

        /// <summary>
        /// skips the "" in string
        /// </summary>
        private void MovePosition()
        {
            var start = TextToWrite.Document.ContentStart;
            var startPos = start.GetPositionAtOffset(position + 1);
            var endPos = start.GetPositionAtOffset(position + 2);
            TextRange textRange = new TextRange(startPos, endPos);
            while (textRange.Text == "")
            {
                perenos++;
                // if (perenos4) Придумати перенос строки
                    InputText.Text += "QQ";
                position++;
                start = TextToWrite.Document.ContentStart;
                startPos = start.GetPositionAtOffset(position + 1);
                endPos = start.GetPositionAtOffset(position + 2);
                textRange = new TextRange(startPos, endPos);
            }
        }

        /// <summary>
        /// changes color of the character you need to write
        /// </summary>
        private void ChangeColorByPosition()
        {
            var start = TextToWrite.Document.ContentStart;
            var startPos = start.GetPositionAtOffset(position);
            var endPos = start.GetPositionAtOffset(position + 1);

            TextRange textRange = new TextRange(startPos, endPos);

            textRange.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.Red));
            InputText.Text += textRange.Text;
        }

        /// <summary>
        /// returns color to black if pressed the right button
        /// </summary>
        private void ChangeToBlack()
        {
            var start = TextToWrite.Document.ContentStart;
            var startPos = start.GetPositionAtOffset(position - 5);
            var endPos = start.GetPositionAtOffset(position-2);

            TextRange textRange = new TextRange(startPos, endPos);
            textRange.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.White));
        }
    }
}