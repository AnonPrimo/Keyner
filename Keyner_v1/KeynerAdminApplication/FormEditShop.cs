using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeynerAdminApplication
{
    public partial class FormEditShop : Form
    {
        Model.Shop _shop = null;
        private int _id;

        public FormEditShop()
        {
            InitializeComponent();
        }

        private void FillDataGridShop()
        {
            using (Model.KeynerContext db = new Model.KeynerContext())
            {
                foreach (Model.Monster item in db.MonsterSet.ToList())
                {
                    dataGridViewMonsters.Rows.Add(item.Id, item.Name);
                }
            }
        }

        private void FormEditShop_Load(object sender, EventArgs e)
        {
            this.FillDataGridShop();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            _id = (int)dataGridViewMonsters.SelectedRows[0].Cells[0].Value;

            pictureBoxHappy.Image = null;
            pictureBoxSad.Image = null;
            pictureBoxNeutral.Image = null;
            pictureBoxReady.Image = null;

            using (Model.KeynerContext db = new Model.KeynerContext())
            {
                _shop = db.ShopSet.FirstOrDefault(s => s.Id_Monster == _id);

                try
                {
                    Model.MonsterLevel monster = db.MonsterLevelSet.FirstOrDefault(m => m.Id_Monster == _id);
                    pictureBoxHappy.Image = Image.FromStream(new MemoryStream(monster.HappyImage));
                    pictureBoxSad.Image = Image.FromStream(new MemoryStream(monster.SadImage));
                    pictureBoxNeutral.Image = Image.FromStream(new MemoryStream(monster.NeutralImage));
                    pictureBoxReady.Image = Image.FromStream(new MemoryStream(monster.ReadyImage));
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Not all pictures uploaded");
                }
            }

            if (_shop != null)
            {
                textBoxCost.Text = _shop.Cost.ToString();

            }
            else textBoxCost.Text = "";

            if (buttonSaveShop.Enabled == false)
            {
                buttonSaveShop.Enabled = true;
                textBoxCost.Enabled = true;
            }

        }

        private void buttonSaveShop_Click(object sender, EventArgs e)
        {
            if (textBoxCost.Text == "")
            {
                MessageBox.Show("Text box for cost is empty");
                return;
            }

            using (Model.KeynerContext db = new Model.KeynerContext())
            {
                if (_shop == null)
                {
                    _shop = new Model.Shop
                    {
                        Id_Monster = _id,
                        Cost = Convert.ToInt32(textBoxCost.Text)
                    };
                    db.ShopSet.Add(_shop);
                }
                else
                {
                    _shop.Cost = Convert.ToInt32(textBoxCost.Text);
                    db.Entry(_shop).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                buttonSaveShop.Enabled = false;
                textBoxCost.Enabled = false;
            }
        }
    }
}
