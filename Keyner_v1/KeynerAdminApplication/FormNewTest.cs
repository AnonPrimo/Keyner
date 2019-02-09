using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private Model.Test _test = null;
        private bool _modified = false;

        public FormNewTest()
        {
            InitializeComponent();
        }

        public FormNewTest(ref Model.Test test): this()
        {
            _test = test;
            richTextBoxText.Text = _test.Text;
            numericUpDownCountMistakes.Value = _test.CountMistakes;
            numericUpDownMaxTime.Value = _test.MaxTime;
            _modified = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_test == null)
                _test = new Model.Test();

            _test.Text = "";

            if (numericUpDownCountRepeat.Value > 0)
            {
                for (int i = 0; i < (int)numericUpDownCountRepeat.Value; i++)
                {
                    _test.Text += richTextBoxText.Text + "\n";
                }
            }
            else _test.Text = richTextBoxText.Text;
            _test.CountMistakes = (int)numericUpDownCountMistakes.Value;
            _test.MaxTime = (int)numericUpDownMaxTime.Value;

            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(_test);

            if (!Validator.TryValidateObject(_test, validationContext, validationResults, true))
            {
                string errorMesseges = "";
                foreach (ValidationResult item in validationResults)
                {
                    errorMesseges += item.ErrorMessage + "\n";
                }
                MessageBox.Show(errorMesseges, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Model.KeynerContext db = new Model.KeynerContext())
            {
                if (_modified)
                    db.Entry(_test).State = System.Data.Entity.EntityState.Modified;
                else
                    db.TestSet.Add(_test);
                db.SaveChanges();
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
    }
}
