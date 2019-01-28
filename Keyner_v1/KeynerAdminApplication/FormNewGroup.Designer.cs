namespace KeynerAdminApplication
{
    partial class FormNewGroup
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
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.buttonSaveGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(24, 28);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(100, 20);
            this.textBoxGroupName.TabIndex = 0;
            // 
            // buttonSaveGroup
            // 
            this.buttonSaveGroup.Location = new System.Drawing.Point(24, 55);
            this.buttonSaveGroup.Name = "buttonSaveGroup";
            this.buttonSaveGroup.Size = new System.Drawing.Size(100, 23);
            this.buttonSaveGroup.TabIndex = 1;
            this.buttonSaveGroup.Text = "Save";
            this.buttonSaveGroup.UseVisualStyleBackColor = true;
            this.buttonSaveGroup.Click += new System.EventHandler(this.buttonSaveGroup_Click);
            // 
            // FormNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 109);
            this.Controls.Add(this.buttonSaveGroup);
            this.Controls.Add(this.textBoxGroupName);
            this.Name = "FormNewGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Button buttonSaveGroup;
    }
}