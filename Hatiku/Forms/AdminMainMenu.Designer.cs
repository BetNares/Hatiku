namespace Hatiku.Forms
{
    partial class AdminMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainMenu));
            this.pnlDataMenu = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.pnlAdminAndPolicy = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPolicy = new System.Windows.Forms.Button();
            this.lblAdminAndPolicy = new System.Windows.Forms.Label();
            this.btnAdminPolicy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDiagnosisData = new System.Windows.Forms.Button();
            this.lblMLAndExpertSystem = new System.Windows.Forms.Label();
            this.dataHomePanel = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDataMenu.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.pnlAdminAndPolicy.SuspendLayout();
            this.panel1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDataMenu
            // 
            this.pnlDataMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlDataMenu.Controls.Add(this.buttonPanel);
            this.pnlDataMenu.Controls.Add(this.dataHomePanel);
            resources.ApplyResources(this.pnlDataMenu, "pnlDataMenu");
            this.pnlDataMenu.Name = "pnlDataMenu";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.pnlAdminAndPolicy);
            this.buttonPanel.Controls.Add(this.panel1);
            resources.ApplyResources(this.buttonPanel, "buttonPanel");
            this.buttonPanel.Name = "buttonPanel";
            // 
            // pnlAdminAndPolicy
            // 
            this.pnlAdminAndPolicy.Controls.Add(this.btnAdmin);
            this.pnlAdminAndPolicy.Controls.Add(this.btnPolicy);
            this.pnlAdminAndPolicy.Controls.Add(this.lblAdminAndPolicy);
            this.pnlAdminAndPolicy.Controls.Add(this.btnAdminPolicy);
            resources.ApplyResources(this.pnlAdminAndPolicy, "pnlAdminAndPolicy");
            this.pnlAdminAndPolicy.Name = "pnlAdminAndPolicy";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.btnAdmin, "btnAdmin");
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.Image = global::Hatiku.Properties.Resources.users_alt_32px;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnPolicy
            // 
            this.btnPolicy.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.btnPolicy, "btnPolicy");
            this.btnPolicy.FlatAppearance.BorderSize = 0;
            this.btnPolicy.Image = global::Hatiku.Properties.Resources.assept_document;
            this.btnPolicy.Name = "btnPolicy";
            this.btnPolicy.UseVisualStyleBackColor = false;
            // 
            // lblAdminAndPolicy
            // 
            resources.ApplyResources(this.lblAdminAndPolicy, "lblAdminAndPolicy");
            this.lblAdminAndPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdminAndPolicy.Name = "lblAdminAndPolicy";
            // 
            // btnAdminPolicy
            // 
            this.btnAdminPolicy.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.btnAdminPolicy, "btnAdminPolicy");
            this.btnAdminPolicy.FlatAppearance.BorderSize = 0;
            this.btnAdminPolicy.Image = global::Hatiku.Properties.Resources.role;
            this.btnAdminPolicy.Name = "btnAdminPolicy";
            this.btnAdminPolicy.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDiagnosisData);
            this.panel1.Controls.Add(this.lblMLAndExpertSystem);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnDiagnosisData
            // 
            this.btnDiagnosisData.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDiagnosisData.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDiagnosisData, "btnDiagnosisData");
            this.btnDiagnosisData.Image = global::Hatiku.Properties.Resources.cards;
            this.btnDiagnosisData.Name = "btnDiagnosisData";
            this.btnDiagnosisData.UseVisualStyleBackColor = false;
            // 
            // lblMLAndExpertSystem
            // 
            resources.ApplyResources(this.lblMLAndExpertSystem, "lblMLAndExpertSystem");
            this.lblMLAndExpertSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMLAndExpertSystem.Name = "lblMLAndExpertSystem";
            // 
            // dataHomePanel
            // 
            resources.ApplyResources(this.dataHomePanel, "dataHomePanel");
            this.dataHomePanel.Name = "dataHomePanel";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.titlePanel.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.titlePanel, "titlePanel");
            this.titlePanel.Name = "titlePanel";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // AdminMainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.pnlDataMenu);
            this.IsMdiContainer = true;
            this.Name = "AdminMainMenu";
            this.pnlDataMenu.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.pnlAdminAndPolicy.ResumeLayout(false);
            this.pnlAdminAndPolicy.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDataMenu;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel dataHomePanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdminPolicy;
        private System.Windows.Forms.Panel pnlAdminAndPolicy;
        private System.Windows.Forms.Label lblAdminAndPolicy;
        private System.Windows.Forms.Button btnPolicy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDiagnosisData;
        private System.Windows.Forms.Label lblMLAndExpertSystem;
    }
}