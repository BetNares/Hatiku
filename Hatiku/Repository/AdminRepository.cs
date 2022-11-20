using Hatiku.Models;
using Hatiku.Models.IRepository;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Repository
{
    public class AdminRepository : BaseRepository, IAdminRepository
    {
        private NpgsqlConnection _conn;
        private NpgsqlCommand _cmd;
        private string _queryString;

        public AdminRepository(string connectionString)
        {
            this.connectionString = connectionString;

        }

        public bool Add(Admin admin)
        {
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_insert_admin(:_username, :_password)";

            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_username", admin.Username);
                _cmd.Parameters.AddWithValue("_password", admin.Password);

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

            _queryString = @"select * from st_delete_admin(:_userid)";

            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_userid", id);

                return (int)_cmd.ExecuteScalar() == 1 ? true : false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Edit(Admin admin)
        {
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_update_admin(:_userid, :_username, :_password)";

            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_userid", admin.Id);
                _cmd.Parameters.AddWithValue("_username", admin.Username);
                _cmd.Parameters.AddWithValue("_password", admin.Password);

                return (int)_cmd.ExecuteScalar() == 1 ? true : false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public IEnumerable<Admin> FetchAll()
        {
            List<Admin> adminList = new List<Admin>();
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_select_all_admin();";

            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                using (var reader = _cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var admin = new Admin();
                        admin.Id = (int)reader[0];
                        admin.Username = reader[1].ToString();
                        admin.Password = reader[2].ToString();
                        adminList.Add(admin);
                    }
                }
                _conn.Close();
                return adminList;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }       

        public IEnumerable<Admin> FindByValue(string value)
        {
            if (int.TryParse(value, out _))
                return FindByValue(Convert.ToInt32(value));

            List<Admin> adminList = new List<Admin>();
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_select_admin_by_value(:_value)";
            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_value", value);
                using (var reader = _cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var admin = new Admin();
                        admin.Id = (int)reader[0];
                        admin.Username = reader[1].ToString();
                        admin.Password = reader[2].ToString();
                        adminList.Add(admin);
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

        public IEnumerable<Admin> FindByValue(int value)
        {
            List<Admin> adminList = new List<Admin>();
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from st_select_admin_by_id(:_value)";
            _cmd = new NpgsqlCommand(_queryString, _conn);

            try
            {
                _conn.Open();
                _cmd.Parameters.AddWithValue("_value", value);
                using (var reader = _cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var admin = new Admin();
                        admin.Id = (int)reader[0];
                        admin.Username = reader[1].ToString();
                        admin.Password = reader[2].ToString();
                        adminList.Add(admin);
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


        public bool Login(string username, string password)
        {
            Admin admin = (Admin)FindByValue(username);
            if(admin?.Username == username && admin?.Password == password)
                return true;

            return false;
        }
    }
}
