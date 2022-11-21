using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Hatiku
{
    public partial class DiagnosisData : Form
    {
        private NpgsqlConnection conn;
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=Hatiku-Junpro";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;


        public DiagnosisData(string connectionString)
        {
            InitializeComponent();
            this.connstring = connectionString;
        }
        private void DatabaseAdministratorPage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }


        private int TempActiveSmoker = 0;
        private int TempAlcoholConsumer = 0;
        private int TempPhysicallyActive = 0;
        private int TempAtRiskOfCVD = 0;


        private void btn_Load_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "select * from st_insert(:_Age,:_Gender,:_Weight,:_Height,:_AP_high,:_AP_low,:_Cholesterol,:_Glucose,:_ActiveSmoker,:_AlcoholConsumer,:_PhysicallyActive,:_AtRiskOfCVD)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_Age", Int32.Parse(tb_Age.Text));
                cmd.Parameters.AddWithValue("_Gender", Int32.Parse(tb_Gender.Text));
                cmd.Parameters.AddWithValue("_Weight", Int32.Parse(tb_Weight.Text));
                cmd.Parameters.AddWithValue("_Height", Int32.Parse(tb_Height.Text)); 
                cmd.Parameters.AddWithValue("_AP_high", Int32.Parse(tb_AP_high.Text));
                cmd.Parameters.AddWithValue("_AP_low", Int32.Parse(tb_AP_low.Text));
                cmd.Parameters.AddWithValue("_Cholesterol", Int32.Parse(tb_Cholesterol.Text)); 
                cmd.Parameters.AddWithValue("_Glucose", Int32.Parse(tb_Glucose.Text)); 
                cmd.Parameters.AddWithValue("_ActiveSmoker", TempActiveSmoker); 
                cmd.Parameters.AddWithValue("_AlcoholConsumer", TempAlcoholConsumer); 
                cmd.Parameters.AddWithValue("_PhysicallyActive", TempPhysicallyActive);
                cmd.Parameters.AddWithValue("_AtRiskOfCVD", TempAtRiskOfCVD);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Successfully Inserted.", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btn_Load.PerformClick();
                    tb_Age.Text = tb_AP_high.Text = tb_AP_low.Text = tb_Cholesterol.Text = tb_Gender.Text = tb_Glucose.Text = tb_Height.Text = tb_Weight.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tb_Age.Text = r.Cells["_Age"].Value.ToString();
                tb_Gender.Text = r.Cells["_Gender"].Value.ToString();
                tb_Weight.Text = r.Cells["_Weight"].Value.ToString();
                tb_Height.Text = r.Cells["_Height"].Value.ToString();
                tb_AP_high.Text = r.Cells["_AP_high"].Value.ToString();
                tb_AP_low.Text = r.Cells["_AP_low"].Value.ToString();
                tb_Cholesterol.Text = r.Cells["_Cholesterol"].Value.ToString();
                tb_Glucose.Text = r.Cells["_Glucose"].Value.ToString();
                if (TempActiveSmoker == 1)
                {
                    cb_ActiveSmoker.Checked = true; 
                }
                if (TempAlcoholConsumer == 1)
                {
                    cb_AlcoholConsumer.Checked = true;
                }
                if (TempAtRiskOfCVD == 1)
                {
                    cb_AtRiskOfCVD.Checked = true;
                }
                if (TempPhysicallyActive == 1)
                {
                    cb_PhysicallyActive.Checked = true;
                }    
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
           if(r == null)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = "select * from st_update_diagnosisdata(:_Id,:_Age,:_Gender,:_Weight,:_Height,:_AP_high,:_AP_low,:_Cholesterol,:_Glucose,:_ActiveSmoker,:_AlcoholConsumer,:_PhysicallyActive,:_AtRiskOfCVD)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_Id", r.Cells["_Id"].Value.ToString());
                cmd.Parameters.AddWithValue("_Age", Int32.Parse(tb_Age.Text));
                cmd.Parameters.AddWithValue("_Gender", Int32.Parse(tb_Gender.Text));
                cmd.Parameters.AddWithValue("_Weight", Int32.Parse(tb_Weight.Text));
                cmd.Parameters.AddWithValue("_Height", Int32.Parse(tb_Height.Text));
                cmd.Parameters.AddWithValue("_AP_high", Int32.Parse(tb_AP_high.Text));
                cmd.Parameters.AddWithValue("_AP_low", Int32.Parse(tb_AP_low.Text));
                cmd.Parameters.AddWithValue("_Cholesterol", Int32.Parse(tb_Cholesterol.Text));
                cmd.Parameters.AddWithValue("_Glucose", Int32.Parse(tb_Glucose.Text));
                cmd.Parameters.AddWithValue("_ActiveSmoker", TempActiveSmoker);
                cmd.Parameters.AddWithValue("_AlcoholConsumer", TempAlcoholConsumer);
                cmd.Parameters.AddWithValue("_PhysicallyActive", TempPhysicallyActive);
                cmd.Parameters.AddWithValue("_AtRiskOfCVD", TempAtRiskOfCVD);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Successfully Updated.", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btn_Load.PerformClick();
                    tb_Age.Text = tb_AP_high.Text = tb_AP_low.Text = tb_Cholesterol.Text = tb_Gender.Text = tb_Glucose.Text = tb_Height.Text = tb_Weight.Text = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(MessageBox.Show("Are you sure? Data will be deleted permanently.", "Delete confirmed.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)== DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = @"select * from st_delete_diagnosisdata(:_id)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_Id", r.Cells["_Id"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Successfully Deleted.", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btn_Load.PerformClick();
                        tb_Age.Text = tb_AP_high.Text = tb_AP_low.Text = tb_Cholesterol.Text = tb_Gender.Text = tb_Glucose.Text = tb_Height.Text = tb_Weight.Text = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        private void cb_ActiveSmoker_CheckedChanged(object sender, EventArgs e)
        {
            if(TempActiveSmoker == 0)
            {
                TempActiveSmoker = 1;
            }
            else
            {
                TempActiveSmoker = 0;
            }
        }

        private void cb_AlcoholConsumer_CheckedChanged(object sender, EventArgs e)
        {
            if(TempAlcoholConsumer == 0)
            {
                TempAlcoholConsumer = 1;
            }
            else
            {
                TempAlcoholConsumer = 0;
            }
        }

        private void cb_PhysicallyActive_CheckedChanged(object sender, EventArgs e)
        {
            if(TempPhysicallyActive == 0)
            {
                TempPhysicallyActive = 1;
            }
            else
            {
                TempPhysicallyActive = 0;
            }
        }

        private void cb_AtRiskOfCVD_CheckedChanged(object sender, EventArgs e)
        {
            if(TempAtRiskOfCVD == 0)
            {
                TempAtRiskOfCVD = 1;
            }
            else
            {
                TempAtRiskOfCVD = 0;
            }
        }

        private static DiagnosisData _diagnosisDataForm;
        public static DiagnosisData GetMenu(Form parentContainer, string connectionString)
        {
            if (_diagnosisDataForm == null || _diagnosisDataForm.IsDisposed)
            {
                _diagnosisDataForm = new DiagnosisData(connectionString);
                _diagnosisDataForm.MdiParent = parentContainer;
                _diagnosisDataForm.Dock = DockStyle.Fill;
            }
            else
            {
                _diagnosisDataForm.WindowState = _diagnosisDataForm.WindowState == FormWindowState.Minimized ?
                                                    FormWindowState.Normal : _diagnosisDataForm.WindowState;
                _diagnosisDataForm.BringToFront();
            }
            return _diagnosisDataForm;
        }
    }
}
