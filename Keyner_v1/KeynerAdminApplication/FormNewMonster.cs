using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeynerAdminApplication
{
    public partial class FormNewMonster : Form
    {
        private Model.Monster _monster = null;
        private bool _modified = false;

        public FormNewMonster()
        {
            InitializeComponent();
        }

        public FormNewMonster(ref Model.Monster monster): this()
        {
            this._monster = monster;
            textBoxMonsterName.Text = _monster.Name;
            _modified = true;
            this.FillDataGridLevels();
        }

        private void FillDataGridLevels()
        {
            using (Model.KeynerContext db = new Model.KeynerContext())
            {
                dataGridViewMonsterLevels.Rows.Clear();
                foreach (Model.MonsterLevel item in db.MonsterLevelSet.Where(l => l.Id_Monster == _monster.Id).ToList())
                {
                    dataGridViewMonsterLevels.Rows.Add(item.Id, item.Id_Monster);
                }
            }
        }

        private void FormNewMonster_Load(object sender, EventArgs e)
        {
            if (!_modified)
                this.buttonNewLevel.Visible = false;
        }

        private void buttonNewLevel_Click(object sender, EventArgs e)
        {
            FormNewMonsterLevel form = new FormNewMonsterLevel(_monster.Id);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Yes)
                this.FillDataGridLevels();
        }

        private void buttonSaveMonster_Click(object sender, EventArgs e)
        {
            if (_monster == null)
                _monster = new Model.Monster();

            _monster.Name = textBoxMonsterName.Text;

            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(_monster);

            if (!Validator.TryValidateObject(_monster, validationContext, validationResults, true))
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
                    db.Entry(_monster).State = System.Data.Entity.EntityState.Modified;
                else
                    db.MonsterSet.Add(_monster);
                db.SaveChanges();
            }

            if (_modified == false)
            {
                buttonNewLevel.Visible = true;
                _modified = true;
            }
            else this.Close();
        }

        private void dataGridViewMonsterLevels_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dataGridViewMonsterLevels.SelectedRows[0].Cells[0].Value;
            using (Model.KeynerContext db = new Model.KeynerContext())
            {
                MemoryStream ms = new MemoryStream(db.MonsterLevelSet.FirstOrDefault(l => l.Id == id).Image);
                pictureBoxMonsterLevelImage.Image = Image.FromStream(ms);
            }
        }

        private void dataGridViewMonsterLevels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            DataGridViewButtonColumn button = dataGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            int id = ((int)dataGrid.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == dataGrid.Columns["ColumnEditMonserLevelButton"].Index && e.RowIndex >= 0)
            {
                using (Model.KeynerContext db = new Model.KeynerContext())
                {
                    Model.MonsterLevel monsterLevel = db.MonsterLevelSet.FirstOrDefault(m => m.Id == id);
                    FormNewMonsterLevel form = new FormNewMonsterLevel(ref monsterLevel, _monster.Id);
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.Yes)
                        this.FillDataGridLevels();
                }
            }

            if (e.ColumnIndex == dataGrid.Columns["ColumnDeleteMonsterLevelButton"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Do you want delete this monster level?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (Model.KeynerContext db = new Model.KeynerContext())
                    {
                        db.Entry(db.MonsterLevelSet.FirstOrDefault(m => m.Id == id)).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        dataGrid.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
    }
}
