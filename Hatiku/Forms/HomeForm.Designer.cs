namespace Hatiku.Forms
{
    partial class HomeForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblNameCalling = new System.Windows.Forms.Label();
            this.btnCheckProfile = new System.Windows.Forms.Button();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(69, 45);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(160, 45);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome,";
            // 
            // lblNameCalling
            // 
            this.lblNameCalling.AutoSize = true;
            this.lblNameCalling.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameCalling.Location = new System.Drawing.Point(235, 45);
            this.lblNameCalling.Name = "lblNameCalling";
            this.lblNameCalling.Size = new System.Drawing.Size(190, 45);
            this.lblNameCalling.TabIndex = 1;
            this.lblNameCalling.Text = "[Username].";
            // 
            // btnCheckProfile
            // 
            this.btnCheckProfile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCheckProfile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckProfile.Location = new System.Drawing.Point(235, 189);
            this.btnCheckProfile.Name = "btnCheckProfile";
            this.btnCheckProfile.Size = new System.Drawing.Size(171, 57);
            this.btnCheckProfile.TabIndex = 2;
            this.btnCheckProfile.Text = "Check Profile";
            this.btnCheckProfile.UseVisualStyleBackColor = false;
            this.btnCheckProfile.Click += new System.EventHandler(this.btnCheckProfile_Click);
            // 
            // btnStartTest
            // 
            this.btnStartTest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStartTest.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartTest.Location = new System.Drawing.Point(479, 189);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(171, 57);
            this.btnStartTest.TabIndex = 3;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = false;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Location = new System.Drawing.Point(891, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(14, 15);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(917, 415);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.btnCheckProfile);
            this.Controls.Add(this.lblNameCalling);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNameCalling;
        private System.Windows.Forms.Button btnCheckProfile;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Label lblClose;
    }
}