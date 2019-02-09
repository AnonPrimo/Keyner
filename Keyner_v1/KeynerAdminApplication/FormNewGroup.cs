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
    public partial class FormNewGroup : Form
    {
        private Model.Group _group = null;
        private bool _modified = false;

        public FormNewGroup()
        {
            InitializeComponent();
        }

        public FormNewGroup(ref Model.Group group): this()
        {
            this._group = group;
            textBoxGroupName.Text = _group.Name;
            _modified = true;
        }

        private void buttonSaveGroup_Click(object sender, EventArgs e)
        {
            if (_group == null)
                _group = new Model.Group();

            _group.Name = textBoxGroupName.Text;

            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(_group);

            if (!Validator.TryValidateObject(_group, validationContext, validationResults, true))
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
                    db.Entry(_group).State = System.Data.Entity.EntityState.Modified;
                else
                    db.GroupSet.Add(_group);
                db.SaveChanges();
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }

        }
    }
}
