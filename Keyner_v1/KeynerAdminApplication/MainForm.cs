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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillDataGridTests();
        }

        private void FillDataGridTests()
        {
            using (Model.KeynerContext db = new Model.KeynerContext())
            {
                dataGridViewTests.Rows.Clear();
                foreach (Model.Test item in db.TestSet.ToList())
                {
                    dataGridViewTests.Rows.Add(item.Id, item.CountMistakes, item.BestTime);
                }
            }
        }

        private void FillDataGridGroups()
        {
            using (Model.KeynerContext db = new Model.KeynerContext())
            {
                dataGridViewTests.Rows.Clear();
                foreach (Model.Test item in db.TestSet.ToList())
                {
                    dataGridViewTests.Rows.Add(item.Id, item.CountMistakes, item.BestTime);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNewTest form = new FormNewTest();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Yes)
            {
                this.FillDataGridTests();
            }
        }

        private void dataGridViewTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            DataGridViewButtonColumn button = dataGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            int id = ((int)dataGrid.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == dataGrid.Columns["ColumnEditTestButton"].Index && e.RowIndex >= 0)
            {
                using (Model.KeynerContext db = new Model.KeynerContext())
                {
                    Model.Test test = db.TestSet.FirstOrDefault(t => t.Id == id);
                    FormNewTest form = new FormNewTest(ref test);
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.Yes)
                        this.FillDataGridTests();
                }
            }

            if (e.ColumnIndex == dataGrid.Columns["ColumnDeleteTestButton"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Do you want delete this test?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (Model.KeynerContext db = new Model.KeynerContext())
                    {
                        db.Entry(db.TestSet.FirstOrDefault(t => t.Id == id)).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        dataGrid.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void dataGridViewGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonNewGroup_Click(object sender, EventArgs e)
        {
            FormNewGroup form = new FormNewGroup();
            form.ShowDialog();
            

        }
    }
}
