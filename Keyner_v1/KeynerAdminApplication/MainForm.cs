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
        private List<Model.Test> _testList;

        public MainForm()
        {
            InitializeComponent();
            using (Model.KeynerContext db = new Model.KeynerContext())
            {
                _testList = db.TestSet.ToList();
            }
            int index = 0;
            foreach (Model.Test item in _testList)
            {
                dataGridViewTests.Rows.Add(item.Id, item.CountMistakes, item.BestTime);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNewTest form = new FormNewTest();
            form.ShowDialog();
        }
    }
}
