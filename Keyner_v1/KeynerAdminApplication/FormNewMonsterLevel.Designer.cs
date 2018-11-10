namespace KeynerAdminApplication
{
    partial class FormNewMonsterLevel
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
            this.pictureBoxMonsterLevelImage = new System.Windows.Forms.PictureBox();
            this.buttonSaveMonsterLevel = new System.Windows.Forms.Button();
            this.buttonSetPath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonsterLevelImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMonsterLevelImage
            // 
            this.pictureBoxMonsterLevelImage.Location = new System.Drawing.Point(47, 28);
            this.pictureBoxMonsterLevelImage.Name = "pictureBoxMonsterLevelImage";
            this.pictureBoxMonsterLevelImage.Size = new System.Drawing.Size(393, 341);
            this.pictureBoxMonsterLevelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonsterLevelImage.TabIndex = 0;
            this.pictureBoxMonsterLevelImage.TabStop = false;
            // 
            // buttonSaveMonsterLevel
            // 
            this.buttonSaveMonsterLevel.Location = new System.Drawing.Point(47, 388);
            this.buttonSaveMonsterLevel.Name = "buttonSaveMonsterLevel";
            this.buttonSaveMonsterLevel.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveMonsterLevel.TabIndex = 1;
            this.buttonSaveMonsterLevel.Text = "Save";
            this.buttonSaveMonsterLevel.UseVisualStyleBackColor = true;
            this.buttonSaveMonsterLevel.Click += new System.EventHandler(this.buttonSaveMonsterLevel_Click);
            // 
            // buttonSetPath
            // 
            this.buttonSetPath.Location = new System.Drawing.Point(365, 388);
            this.buttonSetPath.Name = "buttonSetPath";
            this.buttonSetPath.Size = new System.Drawing.Size(75, 23);
            this.buttonSetPath.TabIndex = 2;
            this.buttonSetPath.Text = "Set path";
            this.buttonSetPath.UseVisualStyleBackColor = true;
            this.buttonSetPath.Click += new System.EventHandler(this.buttonSetPath_Click);
            // 
            // FormNewMonsterLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 442);
            this.Controls.Add(this.buttonSetPath);
            this.Controls.Add(this.buttonSaveMonsterLevel);
            this.Controls.Add(this.pictureBoxMonsterLevelImage);
            this.Name = "FormNewMonsterLevel";
            this.Text = "FormNewMonsterLevel";
            this.Load += new System.EventHandler(this.FormNewMonsterLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonsterLevelImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMonsterLevelImage;
        private System.Windows.Forms.Button buttonSaveMonsterLevel;
        private System.Windows.Forms.Button buttonSetPath;
    }
}