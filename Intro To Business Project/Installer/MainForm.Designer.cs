namespace Installer
{
    partial class frmInstaller
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
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnChangeDir = new System.Windows.Forms.Button();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblDefaultDir = new System.Windows.Forms.Label();
            this.lblDirDesc = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(42, 132);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(559, 26);
            this.txtDirectory.TabIndex = 0;
            // 
            // btnChangeDir
            // 
            this.btnChangeDir.Location = new System.Drawing.Point(607, 127);
            this.btnChangeDir.Name = "btnChangeDir";
            this.btnChangeDir.Size = new System.Drawing.Size(171, 37);
            this.btnChangeDir.TabIndex = 1;
            this.btnChangeDir.Text = "Change Directory";
            this.btnChangeDir.UseVisualStyleBackColor = true;
            this.btnChangeDir.Click += new System.EventHandler(this.btnChangeDir_Click);
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(35, 39);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(743, 37);
            this.lblThanks.TabIndex = 2;
            this.lblThanks.Text = "Thank You For Installing Lion Ware Web Studio";
            this.lblThanks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDefaultDir
            // 
            this.lblDefaultDir.AutoSize = true;
            this.lblDefaultDir.Location = new System.Drawing.Point(38, 174);
            this.lblDefaultDir.Name = "lblDefaultDir";
            this.lblDefaultDir.Size = new System.Drawing.Size(181, 20);
            this.lblDefaultDir.TabIndex = 3;
            this.lblDefaultDir.Text = "[Insert Default Directory]";
            // 
            // lblDirDesc
            // 
            this.lblDirDesc.AutoSize = true;
            this.lblDirDesc.Location = new System.Drawing.Point(38, 233);
            this.lblDirDesc.Name = "lblDirDesc";
            this.lblDirDesc.Size = new System.Drawing.Size(209, 20);
            this.lblDirDesc.TabIndex = 4;
            this.lblDirDesc.Text = "[Insert Directory Description]";
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.Location = new System.Drawing.Point(726, 393);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 30);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // frmInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 435);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblDirDesc);
            this.Controls.Add(this.lblDefaultDir);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.btnChangeDir);
            this.Controls.Add(this.txtDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInstaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lion Ware Web Studio Installer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnChangeDir;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label lblDefaultDir;
        private System.Windows.Forms.Label lblDirDesc;
        private System.Windows.Forms.Button btnNext;
    }
}

