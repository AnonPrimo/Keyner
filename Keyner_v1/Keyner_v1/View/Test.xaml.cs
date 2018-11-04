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

namespace Keyner_v1.View
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        TestController controller;
        int position;
        string text;

        public Test()
        {
            InitializeComponent();
            controller = new TestController();

            FillText();
            text = new TextRange(TextToWrite.Document.ContentStart, TextToWrite.Document.ContentEnd).Text;
            InputText.Text = text;
        }
        
        private void FillText()
        {
            int addText = controller.RepeatCount;
            while (addText > 0)
            {
                TextToWrite.AppendText(controller.CurrentStr + "\n");
                addText--;
            }
            position = 0;

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Key.ToString() == text(position, )) CorrectSymbol();
            //if (TextToWrite.Text[position] == ' ' && e.Key == Key.Space)
            //    InputText.Text += " " + position + " ";
        }

        private void CorrectSymbol()
        {
            //InputText.Text += TextToWrite.[position].ToString();
            position++;

        }

        private void ChangeColorByPosition()
        {
            //TextToWrite.
        }
    }
}
