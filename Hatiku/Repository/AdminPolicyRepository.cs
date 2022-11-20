using Hatiku.Models;
using Hatiku.Models.IRepository;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Repository
{
    public class AdminPolicyRepository : BaseRepository, IAdminPolicyRepository
    {
        private NpgsqlConnection _conn;
        private NpgsqlCommand _cmd;
        private string _queryString;

        public AdminPolicyRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Add(AdminPolicy adminPolicy)
        {
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_insert_adminpolicy(:_adminId, :_policyId)";

            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_adminId", adminPolicy.UserId);
                _cmd.Parameters.AddWithValue("_policyId", adminPolicy.PolicyId);

                return (int)_cmd.ExecuteScalar() == 1 ? true : false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Check(int userId, int policyId)
        {
            List<AdminPolicy> adminPolicyList = new List<AdminPolicy>();
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_check_adminpolicy(:_adminId, :_policyId)";
            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_adminId", userId);
                _cmd.Parameters.AddWithValue("_policyId", policyId);
                
                bool isExist = (int)_cmd.ExecuteScalar() == 1 ? true : false;
                _conn.Close();
                return isExist;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete(int userId, int policyId)
        {
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_delete_adminpolicy(:_userId, :_policyId)";

            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_userId", userId);
                _cmd.Parameters.AddWithValue("_policyId", policyId);

                return (int)_cmd.ExecuteScalar() == 1 ? true : false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public IEnumerable<AdminPolicy> FetchAll()
        {
            List<AdminPolicy> adminPolicyList = new List<AdminPolicy>();
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_select_all_adminpolicy();";

            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                using (var reader = _cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var adminPolicy = new AdminPolicy();
                        adminPolicy.UserId = (int)reader[0];
                        adminPolicy.PolicyId = (int)reader[1];
                        adminPolicyList.Add(adminPolicy);
                    }
                }
                _conn.Close();
                return adminPolicyList;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public IEnumerable<AdminPolicy> FindByValue(string value)
        {
            List<AdminPolicy> adminPolicyList = new List<AdminPolicy>();
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from adminpolicy where userid=:_value or policyid=:_value";
            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_value", value);
                using (var reader = _cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var adminPolicy = new AdminPolicy();
                        adminPolicy.UserId = (int)reader[0];
                        adminPolicy.PolicyId= (int)reader[1];
                        adminPolicyList.Add(adminPolicy);
                    }
                }
                _conn.Close();
                return adminPolicyList;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
