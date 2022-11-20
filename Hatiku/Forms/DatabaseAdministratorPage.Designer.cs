using System.Windows.Forms;

namespace Hatiku
{
    partial class DatabaseAdministratorPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tb_Age = new System.Windows.Forms.TextBox();
            this.tb_Weight = new System.Windows.Forms.TextBox();
            this.tb_Height = new System.Windows.Forms.TextBox();
            this.tb_AP_high = new System.Windows.Forms.TextBox();
            this.tb_AP_low = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Gender = new System.Windows.Forms.TextBox();
            this.tb_Glucose = new System.Windows.Forms.TextBox();
            this.tb_Cholesterol = new System.Windows.Forms.TextBox();
            this.cb_ActiveSmoker = new System.Windows.Forms.CheckBox();
            this.cb_AlcoholConsumer = new System.Windows.Forms.CheckBox();
            this.cb_PhysicallyActive = new System.Windows.Forms.CheckBox();
            this.cb_AtRiskOfCVD = new System.Windows.Forms.CheckBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "AP_high";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(17, 165);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(57, 20);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "AP_low";
            // 
            // tb_Age
            // 
            this.tb_Age.Location = new System.Drawing.Point(116, 30);
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(125, 27);
            this.tb_Age.TabIndex = 12;
            // 
            // tb_Weight
            // 
            this.tb_Weight.Location = new System.Drawing.Point(116, 65);
            this.tb_Weight.Name = "tb_Weight";
            this.tb_Weight.Size = new System.Drawing.Size(125, 27);
            this.tb_Weight.TabIndex = 13;
            // 
            // tb_Height
            // 
            this.tb_Height.Location = new System.Drawing.Point(116, 96);
            this.tb_Height.Name = "tb_Height";
            this.tb_Height.Size = new System.Drawing.Size(125, 27);
            this.tb_Height.TabIndex = 14;
            // 
            // tb_AP_high
            // 
            this.tb_AP_high.Location = new System.Drawing.Point(116, 129);
            this.tb_AP_high.Name = "tb_AP_high";
            this.tb_AP_high.Size = new System.Drawing.Size(125, 27);
            this.tb_AP_high.TabIndex = 15;
            // 
            // tb_AP_low
            // 
            this.tb_AP_low.Location = new System.Drawing.Point(116, 162);
            this.tb_AP_low.Name = "tb_AP_low";
            this.tb_AP_low.Size = new System.Drawing.Size(125, 27);
            this.tb_AP_low.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cholesterol";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Glucose";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender";
            // 
            // tb_Gender
            // 
            this.tb_Gender.Location = new System.Drawing.Point(116, 195);
            this.tb_Gender.Name = "tb_Gender";
            this.tb_Gender.Size = new System.Drawing.Size(125, 27);
            this.tb_Gender.TabIndex = 25;
            // 
            // tb_Glucose
            // 
            this.tb_Glucose.Location = new System.Drawing.Point(116, 228);
            this.tb_Glucose.Name = "tb_Glucose";
            this.tb_Glucose.Size = new System.Drawing.Size(125, 27);
            this.tb_Glucose.TabIndex = 26;
            // 
            // tb_Cholesterol
            // 
            this.tb_Cholesterol.Location = new System.Drawing.Point(116, 258);
            this.tb_Cholesterol.Name = "tb_Cholesterol";
            this.tb_Cholesterol.Size = new System.Drawing.Size(125, 27);
            this.tb_Cholesterol.TabIndex = 27;
            // 
            // cb_ActiveSmoker
            // 
            this.cb_ActiveSmoker.AutoSize = true;
            this.cb_ActiveSmoker.Location = new System.Drawing.Point(18, 291);
            this.cb_ActiveSmoker.Name = "cb_ActiveSmoker";
            this.cb_ActiveSmoker.Size = new System.Drawing.Size(122, 24);
            this.cb_ActiveSmoker.TabIndex = 28;
            this.cb_ActiveSmoker.Text = "ActiveSmoker";
            this.cb_ActiveSmoker.UseVisualStyleBackColor = true;
            this.cb_ActiveSmoker.CheckedChanged += new System.EventHandler(this.cb_ActiveSmoker_CheckedChanged);
            // 
            // cb_AlcoholConsumer
            // 
            this.cb_AlcoholConsumer.AutoSize = true;
            this.cb_AlcoholConsumer.Location = new System.Drawing.Point(18, 321);
            this.cb_AlcoholConsumer.Name = "cb_AlcoholConsumer";
            this.cb_AlcoholConsumer.Size = new System.Drawing.Size(148, 24);
            this.cb_AlcoholConsumer.TabIndex = 29;
            this.cb_AlcoholConsumer.Text = "AlcoholConsumer";
            this.cb_AlcoholConsumer.UseVisualStyleBackColor = true;
            this.cb_AlcoholConsumer.CheckedChanged += new System.EventHandler(this.cb_AlcoholConsumer_CheckedChanged);
            // 
            // cb_PhysicallyActive
            // 
            this.cb_PhysicallyActive.AutoSize = true;
            this.cb_PhysicallyActive.Location = new System.Drawing.Point(18, 351);
            this.cb_PhysicallyActive.Name = "cb_PhysicallyActive";
            this.cb_PhysicallyActive.Size = new System.Drawing.Size(135, 24);
            this.cb_PhysicallyActive.TabIndex = 30;
            this.cb_PhysicallyActive.Text = "PhysicallyActive";
            this.cb_PhysicallyActive.UseVisualStyleBackColor = true;
            this.cb_PhysicallyActive.CheckedChanged += new System.EventHandler(this.cb_PhysicallyActive_CheckedChanged);
            // 
            // cb_AtRiskOfCVD
            // 
            this.cb_AtRiskOfCVD.AutoSize = true;
            this.cb_AtRiskOfCVD.Location = new System.Drawing.Point(18, 381);
            this.cb_AtRiskOfCVD.Name = "cb_AtRiskOfCVD";
            this.cb_AtRiskOfCVD.Size = new System.Drawing.Size(117, 24);
            this.cb_AtRiskOfCVD.TabIndex = 31;
            this.cb_AtRiskOfCVD.Text = "AtRiskOfCVD";
            this.cb_AtRiskOfCVD.UseVisualStyleBackColor = true;
            this.cb_AtRiskOfCVD.CheckedChanged += new System.EventHandler(this.cb_AtRiskOfCVD_CheckedChanged);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(275, 30);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 29;
            this.dgvData.Size = new System.Drawing.Size(752, 375);
            this.dgvData.TabIndex = 32;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(275, 409);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(94, 29);
            this.btn_Insert.TabIndex = 33;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(375, 409);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 29);
            this.btn_Update.TabIndex = 34;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(475, 409);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 29);
            this.btn_Delete.TabIndex = 35;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(933, 411);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(94, 29);
            this.btn_Load.TabIndex = 36;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // DatabaseAdministratorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.cb_AtRiskOfCVD);
            this.Controls.Add(this.cb_PhysicallyActive);
            this.Controls.Add(this.cb_AlcoholConsumer);
            this.Controls.Add(this.cb_ActiveSmoker);
            this.Controls.Add(this.tb_Cholesterol);
            this.Controls.Add(this.tb_Glucose);
            this.Controls.Add(this.tb_Gender);
            this.Controls.Add(this.tb_AP_low);
            this.Controls.Add(this.tb_AP_high);
            this.Controls.Add(this.tb_Height);
            this.Controls.Add(this.tb_Weight);
            this.Controls.Add(this.tb_Age);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatabaseAdministratorPage";
            this.Text = "DatabaseAdministratorPage";
            this.Load += new System.EventHandler(this.DatabaseAdministratorPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbl3;
        private TextBox tb_Age;
        private TextBox tb_Weight;
        private TextBox tb_Height;
        private TextBox tb_AP_high;
        private TextBox tb_AP_low;
        private Label label7;
        private Label label8;
        private Label label2;
        private TextBox tb_Gender;
        private TextBox tb_Glucose;
        private TextBox tb_Cholesterol;
        private CheckBox cb_ActiveSmoker;
        private CheckBox cb_AlcoholConsumer;
        private CheckBox cb_PhysicallyActive;
        private CheckBox cb_AtRiskOfCVD;
        private DataGridView dgvData;
        private Button btn_Insert;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Load;
    }
}