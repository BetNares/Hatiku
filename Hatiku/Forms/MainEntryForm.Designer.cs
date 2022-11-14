namespace Hatiku.Forms
{
    partial class MainEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEntryForm));
            this.btnAdmin = new System.Windows.Forms.PictureBox();
            this.btnDoctor = new System.Windows.Forms.PictureBox();
            this.lblWhoareyou = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.Location = new System.Drawing.Point(319, 218);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(387, 386);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.TabStop = false;
            // 
            // btnDoctor
            // 
            this.btnDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctor.Image")));
            this.btnDoctor.Location = new System.Drawing.Point(747, 218);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(387, 386);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.TabStop = false;
            // 
            // lblWhoareyou
            // 
            this.lblWhoareyou.AutoSize = true;
            this.lblWhoareyou.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWhoareyou.Location = new System.Drawing.Point(574, 120);
            this.lblWhoareyou.Name = "lblWhoareyou";
            this.lblWhoareyou.Size = new System.Drawing.Size(301, 46);
            this.lblWhoareyou.TabIndex = 2;
            this.lblWhoareyou.Text = "Who are you?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(442, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(861, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doctor";
            // 
            // MainEntryFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1448, 724);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWhoareyou);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainEntryFrom";
            this.Text = "MainEntryFrom";
            ((System.ComponentModel.ISupportInitialize)(this.btnAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAdmin;
        private System.Windows.Forms.PictureBox btnDoctor;
        private System.Windows.Forms.Label lblWhoareyou;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}