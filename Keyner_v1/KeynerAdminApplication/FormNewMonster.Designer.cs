namespace KeynerAdminApplication
{
    partial class FormNewMonster
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
            this.textBoxMonsterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMonsterLevels = new System.Windows.Forms.DataGridView();
            this.MonsterLevelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMonster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditMonserLevelButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDeleteMonsterLevelButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonSaveMonster = new System.Windows.Forms.Button();
            this.pictureBoxHappy = new System.Windows.Forms.PictureBox();
            this.buttonNewLevel = new System.Windows.Forms.Button();
            this.pictureBoxSad = new System.Windows.Forms.PictureBox();
            this.pictureBoxReady = new System.Windows.Forms.PictureBox();
            this.pictureBoxNeutral = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonsterLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReady)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNeutral)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMonsterName
            // 
            this.textBoxMonsterName.Location = new System.Drawing.Point(12, 57);
            this.textBoxMonsterName.Name = "textBoxMonsterName";
            this.textBoxMonsterName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonsterName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // dataGridViewMonsterLevels
            // 
            this.dataGridViewMonsterLevels.AllowUserToAddRows = false;
            this.dataGridViewMonsterLevels.AllowUserToDeleteRows = false;
            this.dataGridViewMonsterLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonsterLevels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonsterLevelId,
            this.IdMonster,
            this.ColumnEditMonserLevelButton,
            this.ColumnDeleteMonsterLevelButton});
            this.dataGridViewMonsterLevels.Location = new System.Drawing.Point(131, 38);
            this.dataGridViewMonsterLevels.MultiSelect = false;
            this.dataGridViewMonsterLevels.Name = "dataGridViewMonsterLevels";
            this.dataGridViewMonsterLevels.ReadOnly = true;
            this.dataGridViewMonsterLevels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMonsterLevels.Size = new System.Drawing.Size(345, 424);
            this.dataGridViewMonsterLevels.TabIndex = 2;
            this.dataGridViewMonsterLevels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMonsterLevels_CellContentClick);
            this.dataGridViewMonsterLevels.DoubleClick += new System.EventHandler(this.dataGridViewMonsterLevels_DoubleClick);
            // 
            // MonsterLevelId
            // 
            this.MonsterLevelId.HeaderText = "MonsterLevelId";
            this.MonsterLevelId.Name = "MonsterLevelId";
            this.MonsterLevelId.ReadOnly = true;
            // 
            // IdMonster
            // 
            this.IdMonster.HeaderText = "IdMonster";
            this.IdMonster.Name = "IdMonster";
            this.IdMonster.ReadOnly = true;
            this.IdMonster.Visible = false;
            // 
            // ColumnEditMonserLevelButton
            // 
            this.ColumnEditMonserLevelButton.HeaderText = "";
            this.ColumnEditMonserLevelButton.Name = "ColumnEditMonserLevelButton";
            this.ColumnEditMonserLevelButton.ReadOnly = true;
            this.ColumnEditMonserLevelButton.Text = "Edit";
            this.ColumnEditMonserLevelButton.UseColumnTextForButtonValue = true;
            // 
            // ColumnDeleteMonsterLevelButton
            // 
            this.ColumnDeleteMonsterLevelButton.HeaderText = "";
            this.ColumnDeleteMonsterLevelButton.Name = "ColumnDeleteMonsterLevelButton";
            this.ColumnDeleteMonsterLevelButton.ReadOnly = true;
            this.ColumnDeleteMonsterLevelButton.Text = "Delete";
            this.ColumnDeleteMonsterLevelButton.UseColumnTextForButtonValue = true;
            // 
            // buttonSaveMonster
            // 
            this.buttonSaveMonster.Location = new System.Drawing.Point(12, 438);
            this.buttonSaveMonster.Name = "buttonSaveMonster";
            this.buttonSaveMonster.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveMonster.TabIndex = 4;
            this.buttonSaveMonster.Text = "Save";
            this.buttonSaveMonster.UseVisualStyleBackColor = true;
            this.buttonSaveMonster.Click += new System.EventHandler(this.buttonSaveMonster_Click);
            // 
            // pictureBoxHappy
            // 
            this.pictureBoxHappy.Location = new System.Drawing.Point(516, 39);
            this.pictureBoxHappy.Name = "pictureBoxHappy";
            this.pictureBoxHappy.Size = new System.Drawing.Size(194, 191);
            this.pictureBoxHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHappy.TabIndex = 5;
            this.pictureBoxHappy.TabStop = false;
            // 
            // buttonNewLevel
            // 
            this.buttonNewLevel.Location = new System.Drawing.Point(131, 468);
            this.buttonNewLevel.Name = "buttonNewLevel";
            this.buttonNewLevel.Size = new System.Drawing.Size(75, 23);
            this.buttonNewLevel.TabIndex = 6;
            this.buttonNewLevel.Text = "New level";
            this.buttonNewLevel.UseVisualStyleBackColor = true;
            this.buttonNewLevel.Click += new System.EventHandler(this.buttonNewLevel_Click);
            // 
            // pictureBoxSad
            // 
            this.pictureBoxSad.Location = new System.Drawing.Point(516, 271);
            this.pictureBoxSad.Name = "pictureBoxSad";
            this.pictureBoxSad.Size = new System.Drawing.Size(194, 191);
            this.pictureBoxSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSad.TabIndex = 7;
            this.pictureBoxSad.TabStop = false;
            // 
            // pictureBoxReady
            // 
            this.pictureBoxReady.Location = new System.Drawing.Point(744, 270);
            this.pictureBoxReady.Name = "pictureBoxReady";
            this.pictureBoxReady.Size = new System.Drawing.Size(194, 191);
            this.pictureBoxReady.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReady.TabIndex = 9;
            this.pictureBoxReady.TabStop = false;
            // 
            // pictureBoxNeutral
            // 
            this.pictureBoxNeutral.Location = new System.Drawing.Point(744, 38);
            this.pictureBoxNeutral.Name = "pictureBoxNeutral";
            this.pictureBoxNeutral.Size = new System.Drawing.Size(194, 191);
            this.pictureBoxNeutral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNeutral.TabIndex = 8;
            this.pictureBoxNeutral.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Happy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(741, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Neutral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(741, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ready";
            // 
            // FormNewMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 514);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxReady);
            this.Controls.Add(this.pictureBoxNeutral);
            this.Controls.Add(this.pictureBoxSad);
            this.Controls.Add(this.buttonNewLevel);
            this.Controls.Add(this.pictureBoxHappy);
            this.Controls.Add(this.buttonSaveMonster);
            this.Controls.Add(this.dataGridViewMonsterLevels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMonsterName);
            this.Name = "FormNewMonster";
            this.Text = "FormNewMonster";
            this.Load += new System.EventHandler(this.FormNewMonster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonsterLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReady)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNeutral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMonsterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMonsterLevels;
        private System.Windows.Forms.Button buttonSaveMonster;
        private System.Windows.Forms.PictureBox pictureBoxHappy;
        private System.Windows.Forms.Button buttonNewLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterLevelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMonster;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEditMonserLevelButton;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDeleteMonsterLevelButton;
        private System.Windows.Forms.PictureBox pictureBoxSad;
        private System.Windows.Forms.PictureBox pictureBoxReady;
        private System.Windows.Forms.PictureBox pictureBoxNeutral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}