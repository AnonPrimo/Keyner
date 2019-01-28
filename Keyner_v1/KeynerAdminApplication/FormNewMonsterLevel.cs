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
            using (MemoryStream ms = new MemoryStream(_monsterLevel.HappyImage))
            {
                pictureBoxHappy.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(_monsterLevel.SadImage))
            {
                pictureBoxSad.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(_monsterLevel.NeutralImage))
            {
                pictureBoxNeutral.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(_monsterLevel.ReadyImage))
            {
                pictureBoxReady.Image = Image.FromStream(ms);
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
                pictureBoxHappy.Image.Save(ms, ImageFormat.Gif);
                _monsterLevel.HappyImage = ms.ToArray();
            }

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBoxSad.Image.Save(ms, ImageFormat.Gif);
                _monsterLevel.SadImage = ms.ToArray();
            }

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBoxNeutral.Image.Save(ms, ImageFormat.Gif);
                _monsterLevel.NeutralImage = ms.ToArray();
            }

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBoxReady.Image.Save(ms, ImageFormat.Gif);
                _monsterLevel.ReadyImage = ms.ToArray();
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
                pictureBoxHappy.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void buttonSetPathSad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxSad.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void buttonSetPathNeutral_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxNeutral.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void buttonSetPathReady_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxReady.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
