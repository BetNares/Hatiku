
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnExpertSystem = new System.Windows.Forms.Button();
            this.btnPolicy = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.dataHomePanel = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.pnlDataMenu.SuspendLayout();
            this.buttonPanel.SuspendLayout();
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
            this.buttonPanel.Controls.Add(this.button4);
            this.buttonPanel.Controls.Add(this.btnExpertSystem);
            this.buttonPanel.Controls.Add(this.btnPolicy);
            this.buttonPanel.Controls.Add(this.btnAdmin);
            resources.ApplyResources(this.buttonPanel, "buttonPanel");
            this.buttonPanel.Name = "buttonPanel";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.button4, "button4");
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Image = global::Hatiku.Properties.Resources.api;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnExpertSystem
            // 
            this.btnExpertSystem.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.btnExpertSystem, "btnExpertSystem");
            this.btnExpertSystem.FlatAppearance.BorderSize = 0;
            this.btnExpertSystem.Image = global::Hatiku.Properties.Resources.brain_circuit;
            this.btnExpertSystem.Name = "btnExpertSystem";
            this.btnExpertSystem.UseVisualStyleBackColor = false;
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
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.btnAdmin, "btnAdmin");
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            // 
            // dataHomePanel
            // 
            resources.ApplyResources(this.dataHomePanel, "dataHomePanel");
            this.dataHomePanel.Name = "dataHomePanel";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.titlePanel.Controls.Add(this.title);
            resources.ApplyResources(this.titlePanel, "titlePanel");
            this.titlePanel.Name = "titlePanel";
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.Name = "title";
            // 
            // AdminMainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.pnlDataMenu);
            this.Name = "AdminMainMenu";
            this.pnlDataMenu.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExpertSystem;
        private System.Windows.Forms.Button btnPolicy;
    }
}