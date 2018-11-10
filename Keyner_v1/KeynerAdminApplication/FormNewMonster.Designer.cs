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
            this.pictureBoxMonsterLevelImage = new System.Windows.Forms.PictureBox();
            this.buttonNewLevel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonsterLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonsterLevelImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMonsterName
            // 
            this.textBoxMonsterName.Location = new System.Drawing.Point(12, 33);
            this.textBoxMonsterName.Name = "textBoxMonsterName";
            this.textBoxMonsterName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonsterName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
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
            this.dataGridViewMonsterLevels.Location = new System.Drawing.Point(131, 14);
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
            this.buttonSaveMonster.Location = new System.Drawing.Point(12, 414);
            this.buttonSaveMonster.Name = "buttonSaveMonster";
            this.buttonSaveMonster.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveMonster.TabIndex = 4;
            this.buttonSaveMonster.Text = "Save";
            this.buttonSaveMonster.UseVisualStyleBackColor = true;
            this.buttonSaveMonster.Click += new System.EventHandler(this.buttonSaveMonster_Click);
            // 
            // pictureBoxMonsterLevelImage
            // 
            this.pictureBoxMonsterLevelImage.Location = new System.Drawing.Point(519, 15);
            this.pictureBoxMonsterLevelImage.Name = "pictureBoxMonsterLevelImage";
            this.pictureBoxMonsterLevelImage.Size = new System.Drawing.Size(381, 423);
            this.pictureBoxMonsterLevelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonsterLevelImage.TabIndex = 5;
            this.pictureBoxMonsterLevelImage.TabStop = false;
            // 
            // buttonNewLevel
            // 
            this.buttonNewLevel.Location = new System.Drawing.Point(131, 444);
            this.buttonNewLevel.Name = "buttonNewLevel";
            this.buttonNewLevel.Size = new System.Drawing.Size(75, 23);
            this.buttonNewLevel.TabIndex = 6;
            this.buttonNewLevel.Text = "New level";
            this.buttonNewLevel.UseVisualStyleBackColor = true;
            this.buttonNewLevel.Click += new System.EventHandler(this.buttonNewLevel_Click);
            // 
            // FormNewMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 480);
            this.Controls.Add(this.buttonNewLevel);
            this.Controls.Add(this.pictureBoxMonsterLevelImage);
            this.Controls.Add(this.buttonSaveMonster);
            this.Controls.Add(this.dataGridViewMonsterLevels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMonsterName);
            this.Name = "FormNewMonster";
            this.Text = "FormNewMonster";
            this.Load += new System.EventHandler(this.FormNewMonster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonsterLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonsterLevelImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMonsterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMonsterLevels;
        private System.Windows.Forms.Button buttonSaveMonster;
        private System.Windows.Forms.PictureBox pictureBoxMonsterLevelImage;
        private System.Windows.Forms.Button buttonNewLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterLevelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMonster;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEditMonserLevelButton;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDeleteMonsterLevelButton;
    }
}