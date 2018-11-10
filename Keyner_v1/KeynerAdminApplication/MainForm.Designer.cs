namespace KeynerAdminApplication
{
    partial class MainForm
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
            this.dataGridViewTests = new System.Windows.Forms.DataGridView();
            this.ColumnTestNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountMistakes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditTestButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDeleteTestButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonNewTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.ColumnGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditGroupButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDeleteGroupButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonNewGroup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMonsters = new System.Windows.Forms.DataGridView();
            this.buttonNewMonster = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditMonsterButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDeleteMonsterButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonsters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTests
            // 
            this.dataGridViewTests.AllowUserToAddRows = false;
            this.dataGridViewTests.AllowUserToDeleteRows = false;
            this.dataGridViewTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTestNumber,
            this.ColumnCountMistakes,
            this.ColumnBestTime,
            this.ColumnEditTestButton,
            this.ColumnDeleteTestButton});
            this.dataGridViewTests.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewTests.MultiSelect = false;
            this.dataGridViewTests.Name = "dataGridViewTests";
            this.dataGridViewTests.ReadOnly = true;
            this.dataGridViewTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTests.Size = new System.Drawing.Size(546, 372);
            this.dataGridViewTests.TabIndex = 0;
            this.dataGridViewTests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTests_CellContentClick);
            // 
            // ColumnTestNumber
            // 
            this.ColumnTestNumber.HeaderText = "Test number";
            this.ColumnTestNumber.Name = "ColumnTestNumber";
            this.ColumnTestNumber.ReadOnly = true;
            // 
            // ColumnCountMistakes
            // 
            this.ColumnCountMistakes.HeaderText = "Count of mistakes";
            this.ColumnCountMistakes.Name = "ColumnCountMistakes";
            this.ColumnCountMistakes.ReadOnly = true;
            // 
            // ColumnBestTime
            // 
            this.ColumnBestTime.HeaderText = "BestTime";
            this.ColumnBestTime.Name = "ColumnBestTime";
            this.ColumnBestTime.ReadOnly = true;
            // 
            // ColumnEditTestButton
            // 
            this.ColumnEditTestButton.HeaderText = "";
            this.ColumnEditTestButton.Name = "ColumnEditTestButton";
            this.ColumnEditTestButton.ReadOnly = true;
            this.ColumnEditTestButton.Text = "Edit";
            this.ColumnEditTestButton.UseColumnTextForButtonValue = true;
            // 
            // ColumnDeleteTestButton
            // 
            this.ColumnDeleteTestButton.HeaderText = "";
            this.ColumnDeleteTestButton.Name = "ColumnDeleteTestButton";
            this.ColumnDeleteTestButton.ReadOnly = true;
            this.ColumnDeleteTestButton.Text = "Delete";
            this.ColumnDeleteTestButton.UseColumnTextForButtonValue = true;
            // 
            // buttonNewTest
            // 
            this.buttonNewTest.Location = new System.Drawing.Point(12, 410);
            this.buttonNewTest.Name = "buttonNewTest";
            this.buttonNewTest.Size = new System.Drawing.Size(75, 23);
            this.buttonNewTest.TabIndex = 1;
            this.buttonNewTest.Text = "New test";
            this.buttonNewTest.UseVisualStyleBackColor = true;
            this.buttonNewTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tests";
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGroupId,
            this.ColumnGroupName,
            this.ColumnEditGroupButton,
            this.ColumnDeleteGroupButton});
            this.dataGridViewGroups.Location = new System.Drawing.Point(564, 32);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            this.dataGridViewGroups.Size = new System.Drawing.Size(347, 372);
            this.dataGridViewGroups.TabIndex = 3;
            this.dataGridViewGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroups_CellContentClick);
            // 
            // ColumnGroupId
            // 
            this.ColumnGroupId.HeaderText = "ColumnGroupId";
            this.ColumnGroupId.Name = "ColumnGroupId";
            this.ColumnGroupId.ReadOnly = true;
            this.ColumnGroupId.Visible = false;
            // 
            // ColumnGroupName
            // 
            this.ColumnGroupName.HeaderText = "Group name";
            this.ColumnGroupName.Name = "ColumnGroupName";
            this.ColumnGroupName.ReadOnly = true;
            // 
            // ColumnEditGroupButton
            // 
            this.ColumnEditGroupButton.HeaderText = "";
            this.ColumnEditGroupButton.Name = "ColumnEditGroupButton";
            this.ColumnEditGroupButton.ReadOnly = true;
            this.ColumnEditGroupButton.Text = "Edit";
            this.ColumnEditGroupButton.UseColumnTextForButtonValue = true;
            // 
            // ColumnDeleteGroupButton
            // 
            this.ColumnDeleteGroupButton.HeaderText = "";
            this.ColumnDeleteGroupButton.Name = "ColumnDeleteGroupButton";
            this.ColumnDeleteGroupButton.ReadOnly = true;
            this.ColumnDeleteGroupButton.Text = "Delete";
            this.ColumnDeleteGroupButton.UseColumnTextForButtonValue = true;
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.Location = new System.Drawing.Point(564, 410);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGroup.TabIndex = 4;
            this.buttonNewGroup.Text = "New group";
            this.buttonNewGroup.UseVisualStyleBackColor = true;
            this.buttonNewGroup.Click += new System.EventHandler(this.buttonNewGroup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Groups";
            // 
            // dataGridViewMonsters
            // 
            this.dataGridViewMonsters.AllowUserToAddRows = false;
            this.dataGridViewMonsters.AllowUserToDeleteRows = false;
            this.dataGridViewMonsters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonsters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ColumnEditMonsterButton,
            this.ColumnDeleteMonsterButton});
            this.dataGridViewMonsters.Location = new System.Drawing.Point(917, 32);
            this.dataGridViewMonsters.Name = "dataGridViewMonsters";
            this.dataGridViewMonsters.ReadOnly = true;
            this.dataGridViewMonsters.Size = new System.Drawing.Size(352, 372);
            this.dataGridViewMonsters.TabIndex = 6;
            this.dataGridViewMonsters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMonsters_CellContentClick);
            // 
            // buttonNewMonster
            // 
            this.buttonNewMonster.Location = new System.Drawing.Point(917, 410);
            this.buttonNewMonster.Name = "buttonNewMonster";
            this.buttonNewMonster.Size = new System.Drawing.Size(81, 23);
            this.buttonNewMonster.TabIndex = 7;
            this.buttonNewMonster.Text = "New monster";
            this.buttonNewMonster.UseVisualStyleBackColor = true;
            this.buttonNewMonster.Click += new System.EventHandler(this.buttonNewMonster_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(914, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Monsters";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ColumnMonsterId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Monster name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ColumnEditMonsterButton
            // 
            this.ColumnEditMonsterButton.HeaderText = "";
            this.ColumnEditMonsterButton.Name = "ColumnEditMonsterButton";
            this.ColumnEditMonsterButton.ReadOnly = true;
            this.ColumnEditMonsterButton.Text = "Edit";
            this.ColumnEditMonsterButton.UseColumnTextForButtonValue = true;
            // 
            // ColumnDeleteMonsterButton
            // 
            this.ColumnDeleteMonsterButton.HeaderText = "";
            this.ColumnDeleteMonsterButton.Name = "ColumnDeleteMonsterButton";
            this.ColumnDeleteMonsterButton.ReadOnly = true;
            this.ColumnDeleteMonsterButton.Text = "Delete";
            this.ColumnDeleteMonsterButton.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonNewMonster);
            this.Controls.Add(this.dataGridViewMonsters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonNewGroup);
            this.Controls.Add(this.dataGridViewGroups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewTest);
            this.Controls.Add(this.dataGridViewTests);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonsters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTests;
        private System.Windows.Forms.Button buttonNewTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTestNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCountMistakes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBestTime;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEditTestButton;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDeleteTestButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupName;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEditGroupButton;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDeleteGroupButton;
        private System.Windows.Forms.Button buttonNewGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMonsters;
        private System.Windows.Forms.Button buttonNewMonster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEditMonsterButton;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDeleteMonsterButton;
    }
}