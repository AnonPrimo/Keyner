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
            this.buttonNewTest = new System.Windows.Forms.Button();
            this.ColumnTestNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountMistakes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditTestButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTests
            // 
            this.dataGridViewTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTestNumber,
            this.ColumnCountMistakes,
            this.ColumnBestTime,
            this.ColumnEditTestButton});
            this.dataGridViewTests.Location = new System.Drawing.Point(51, 43);
            this.dataGridViewTests.Name = "dataGridViewTests";
            this.dataGridViewTests.Size = new System.Drawing.Size(618, 372);
            this.dataGridViewTests.TabIndex = 0;
            // 
            // buttonNewTest
            // 
            this.buttonNewTest.Location = new System.Drawing.Point(903, 477);
            this.buttonNewTest.Name = "buttonNewTest";
            this.buttonNewTest.Size = new System.Drawing.Size(75, 23);
            this.buttonNewTest.TabIndex = 1;
            this.buttonNewTest.Text = "New test";
            this.buttonNewTest.UseVisualStyleBackColor = true;
            this.buttonNewTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColumnTestNumber
            // 
            this.ColumnTestNumber.HeaderText = "Test number";
            this.ColumnTestNumber.Name = "ColumnTestNumber";
            // 
            // ColumnCountMistakes
            // 
            this.ColumnCountMistakes.HeaderText = "Count of mistakes";
            this.ColumnCountMistakes.Name = "ColumnCountMistakes";
            // 
            // ColumnBestTime
            // 
            this.ColumnBestTime.HeaderText = "BestTime";
            this.ColumnBestTime.Name = "ColumnBestTime";
            // 
            // ColumnEditTestButton
            // 
            this.ColumnEditTestButton.HeaderText = "";
            this.ColumnEditTestButton.Name = "ColumnEditTestButton";
            this.ColumnEditTestButton.Text = "Edit";
            this.ColumnEditTestButton.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 526);
            this.Controls.Add(this.buttonNewTest);
            this.Controls.Add(this.dataGridViewTests);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTests;
        private System.Windows.Forms.Button buttonNewTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTestNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCountMistakes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBestTime;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEditTestButton;
    }
}