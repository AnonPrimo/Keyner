using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeynerAdminApplication
{
    public partial class FormNewTest : Form
    {
        private Model.Test _test;

        public FormNewTest()
        {
            InitializeComponent();
        }

        public FormNewTest(ref Model.Test test): this()
        {
            _test = test;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBoxText.Text;
            int countMistakes = (int)numericUpDownCountMistakes.Value;

            using (Model.KeynerContext db = new Model.KeynerContext())
            {
                if (_test != null)
                {
                    _test.Text = text;
                    _test.CountMistakes = countMistakes;
                    db.Entry(_test).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    this.Close();
                }
                _test = new Model.Test
                {
                    Text = text,
                    CountMistakes = countMistakes,
                    BestTime = 0
                };
                db.TestSet.Add(_test);
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
