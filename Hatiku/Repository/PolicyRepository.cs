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
    public class PolicyRepository : BaseRepository, IPolicyRepository
    {
        private NpgsqlConnection _conn;
        private NpgsqlCommand _cmd;
        private string _queryString;

        public PolicyRepository(string connectionString)
        {
            this.connectionString = connectionString;

        }

        public bool Add(Policy policy)
        {
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_insert_policy(:_policyname, :_detail)";

            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_policyname", policy.Name);
                _cmd.Parameters.AddWithValue("_detail", policy.Detail);

                return (int)_cmd.ExecuteScalar() == 1 ? true : false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete(int id)
        {
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_delete_policy(:_policyid)";

            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_policyid", id);

                return (int)_cmd.ExecuteScalar() == 1 ? true : false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Edit(Policy policy)
        {
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_update_policy(:_policyid, :_policyname, :_detail)";

            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_policyid", policy.PolicyId);
                _cmd.Parameters.AddWithValue("_policyname", policy.Name);
                _cmd.Parameters.AddWithValue("_detail", policy.Detail);

                return (int)_cmd.ExecuteScalar() == 1 ? true : false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public IEnumerable<Policy> FetchAll()
        {
            List<Policy> policyList = new List<Policy>();
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_select_all_policy();";

            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                using (var reader = _cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var policy = new Policy();
                        policy.PolicyId = (int)reader[0];
                        policy.Name = reader[1].ToString();
                        policy.Detail = reader[2].ToString();
                        policyList.Add(policy);
                    }
                }
                _conn.Close();
                return policyList;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public IEnumerable<Policy> FindByValue(int id)
        {
            List<Policy> policyList = new List<Policy>();
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_select_admin_by_id(:_value)";
            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_value");
                using (var reader = _cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var policy = new Policy();
                        policy.PolicyId = (int)reader[0];
                        policy.Name = reader[1].ToString();
                        policy.Detail = reader[2].ToString();
                        policyList.Add(policy);
                    }
                }
                _conn.Close();
                return policyList ;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public IEnumerable<Policy> FindByValue(string value)
        {
            if (int.TryParse(value, out _))
                return FindByValue(Convert.ToInt32(value));

            List<Policy> adminList = new List<Policy>();
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_select_policy_by_value(:_value)";
            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_value", value);
                using (var reader = _cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var policy = new Policy();
                        policy.PolicyId = (int)reader[0];
                        policy.Name = reader[1].ToString();
                        policy.Detail = reader[2].ToString();
                        adminList.Add(policy);
                    }
                }
                _conn.Close();
                return adminList;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public int GetId(string policyName)
        {
            Policy policy = FindByValue(policyName).First();
            MessageBox.Show(policy.Name.ToString());
            return GetId(policy);
        }

        public int GetId(Policy policy)
        {
            return policy.PolicyId;
        }
    }
}
