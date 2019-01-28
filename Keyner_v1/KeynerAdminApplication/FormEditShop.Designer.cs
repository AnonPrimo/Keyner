namespace KeynerAdminApplication
{
    partial class FormEditShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMonsters = new System.Windows.Forms.DataGridView();
            this.ColumnMonsterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMonsterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxHappy = new System.Windows.Forms.PictureBox();
            this.pictureBoxNeutral = new System.Windows.Forms.PictureBox();
            this.pictureBoxReady = new System.Windows.Forms.PictureBox();
            this.pictureBoxSad = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSaveShop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonsters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNeutral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReady)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMonsters
            // 
            this.dataGridViewMonsters.AllowUserToAddRows = false;
            this.dataGridViewMonsters.AllowUserToDeleteRows = false;
            this.dataGridViewMonsters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonsters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMonsterId,
            this.ColumnMonsterName});
            this.dataGridViewMonsters.Location = new System.Drawing.Point(10, 28);
            this.dataGridViewMonsters.MultiSelect = false;
            this.dataGridViewMonsters.Name = "dataGridViewMonsters";
            this.dataGridViewMonsters.ReadOnly = true;
            this.dataGridViewMonsters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMonsters.Size = new System.Drawing.Size(147, 290);
            this.dataGridViewMonsters.TabIndex = 0;
            this.dataGridViewMonsters.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ColumnMonsterId
            // 
            this.ColumnMonsterId.HeaderText = "Monster id";
            this.ColumnMonsterId.Name = "ColumnMonsterId";
            this.ColumnMonsterId.ReadOnly = true;
            this.ColumnMonsterId.Visible = false;
            // 
            // ColumnMonsterName
            // 
            this.ColumnMonsterName.HeaderText = "Monster name";
            this.ColumnMonsterName.Name = "ColumnMonsterName";
            this.ColumnMonsterName.ReadOnly = true;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Enabled = false;
            this.textBoxCost.Location = new System.Drawing.Point(192, 28);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(136, 20);
            this.textBoxCost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cost";
            // 
            // pictureBoxHappy
            // 
            this.pictureBoxHappy.Location = new System.Drawing.Point(371, 28);
            this.pictureBoxHappy.Name = "pictureBoxHappy";
            this.pictureBoxHappy.Size = new System.Drawing.Size(151, 133);
            this.pictureBoxHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHappy.TabIndex = 3;
            this.pictureBoxHappy.TabStop = false;
            // 
            // pictureBoxNeutral
            // 
            this.pictureBoxNeutral.Location = new System.Drawing.Point(550, 28);
            this.pictureBoxNeutral.Name = "pictureBoxNeutral";
            this.pictureBoxNeutral.Size = new System.Drawing.Size(151, 133);
            this.pictureBoxNeutral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNeutral.TabIndex = 4;
            this.pictureBoxNeutral.TabStop = false;
            // 
            // pictureBoxReady
            // 
            this.pictureBoxReady.Location = new System.Drawing.Point(550, 185);
            this.pictureBoxReady.Name = "pictureBoxReady";
            this.pictureBoxReady.Size = new System.Drawing.Size(151, 133);
            this.pictureBoxReady.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReady.TabIndex = 6;
            this.pictureBoxReady.TabStop = false;
            // 
            // pictureBoxSad
            // 
            this.pictureBoxSad.Location = new System.Drawing.Point(371, 185);
            this.pictureBoxSad.Name = "pictureBoxSad";
            this.pictureBoxSad.Size = new System.Drawing.Size(151, 133);
            this.pictureBoxSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSad.TabIndex = 5;
            this.pictureBoxSad.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Happy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Neutral";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ready";
            // 
            // buttonSaveShop
            // 
            this.buttonSaveShop.Enabled = false;
            this.buttonSaveShop.Location = new System.Drawing.Point(192, 55);
            this.buttonSaveShop.Name = "buttonSaveShop";
            this.buttonSaveShop.Size = new System.Drawing.Size(136, 23);
            this.buttonSaveShop.TabIndex = 11;
            this.buttonSaveShop.Text = "Save";
            this.buttonSaveShop.UseVisualStyleBackColor = true;
            this.buttonSaveShop.Click += new System.EventHandler(this.buttonSaveShop_Click);
            // 
            // FormEditShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 334);
            this.Controls.Add(this.buttonSaveShop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxReady);
            this.Controls.Add(this.pictureBoxSad);
            this.Controls.Add(this.pictureBoxNeutral);
            this.Controls.Add(this.pictureBoxHappy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.dataGridViewMonsters);
            this.Name = "FormEditShop";
            this.Text = "FormEditShop";
            this.Load += new System.EventHandler(this.FormEditShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonsters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNeutral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReady)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMonsters;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMonsterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMonsterName;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxHappy;
        private System.Windows.Forms.PictureBox pictureBoxNeutral;
        private System.Windows.Forms.PictureBox pictureBoxReady;
        private System.Windows.Forms.PictureBox pictureBoxSad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSaveShop;
    }
}