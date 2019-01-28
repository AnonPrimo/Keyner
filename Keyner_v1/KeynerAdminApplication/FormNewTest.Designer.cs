namespace KeynerAdminApplication
{
    partial class FormNewTest
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
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownCountMistakes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCountRepeat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountMistakes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountRepeat)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(12, 33);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(951, 350);
            this.richTextBoxText.TabIndex = 0;
            this.richTextBoxText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(969, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownCountMistakes
            // 
            this.numericUpDownCountMistakes.Location = new System.Drawing.Point(969, 49);
            this.numericUpDownCountMistakes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountMistakes.Name = "numericUpDownCountMistakes";
            this.numericUpDownCountMistakes.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCountMistakes.TabIndex = 2;
            this.numericUpDownCountMistakes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(969, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Count of mistakes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text";
            // 
            // numericUpDownCountRepeat
            // 
            this.numericUpDownCountRepeat.Location = new System.Drawing.Point(969, 96);
            this.numericUpDownCountRepeat.Name = "numericUpDownCountRepeat";
            this.numericUpDownCountRepeat.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCountRepeat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(969, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Count of repeat";
            // 
            // FormNewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 410);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownCountRepeat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownCountMistakes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxText);
            this.Name = "FormNewTest";
            this.Text = "FormNewTest";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountMistakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountRepeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownCountMistakes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCountRepeat;
        private System.Windows.Forms.Label label3;
    }
}