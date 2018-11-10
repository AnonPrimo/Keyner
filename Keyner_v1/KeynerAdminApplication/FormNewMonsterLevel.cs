using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeynerAdminApplication
{
    public partial class FormNewMonsterLevel : Form
    {
        private int _monsterId;
        private Model.MonsterLevel _monsterLevel = null;
        private bool _modified = false;

        public FormNewMonsterLevel(int monsterId)
        {
            InitializeComponent();
            this._monsterId = monsterId;
        }

        public FormNewMonsterLevel(ref Model.MonsterLevel monsterLevel, int monsterId) : this(monsterId)
        {
            this._monsterLevel = monsterLevel;
            using (Model.KeynerContext db = new Model.KeynerContext())
            {
                MemoryStream ms = new MemoryStream(_monsterLevel.Image);
                pictureBoxMonsterLevelImage.Image = Image.FromStream(ms);
            }
            _modified = true;
        }

        private void FormNewMonsterLevel_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSaveMonsterLevel_Click(object sender, EventArgs e)
        {
            if (_monsterLevel == null)
                _monsterLevel = new Model.MonsterLevel();

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBoxMonsterLevelImage.Image.Save(ms, ImageFormat.Jpeg);
                _monsterLevel.Image = ms.ToArray();
            }

            using (Model.KeynerContext db = new Model.KeynerContext())
            {
                if (_modified)
                    db.Entry(_monsterLevel).State = System.Data.Entity.EntityState.Modified;
                else
                {
                    _monsterLevel.Id_Monster = _monsterId;
                    db.MonsterLevelSet.Add(_monsterLevel);
                }
                db.SaveChanges();
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }

        }

        private void buttonSetPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMonsterLevelImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
