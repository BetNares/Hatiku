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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Admin admin)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admin> FetchAll()
        {
            List<Admin> adminList = new List<Admin>();
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from admin;";

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

        public Admin FindById(int id)
        {

            Admin admin = new Admin();
            _conn = new NpgsqlConnection(connectionString);

            _queryString = @"select * from admin 
                             where userId=@id
                             order by userId;";

            _cmd = new NpgsqlCommand(_queryString, _conn);
            _cmd.Parameters.Add("@id", NpgsqlDbType.Integer).Value = id;

            try
            {
                _conn.Open();

                using (var reader = _cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        admin.Id = (int)reader[0];
                        admin.Username = reader[1].ToString();
                        admin.Password = reader[2].ToString();
                    }
                }

                _conn.Close();
                return admin;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public IEnumerable<Admin> FindByValue(string value)
        {
            throw new NotImplementedException();
            //int userId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 00000;

            //List<Admin> adminList = new List<Admin>();
            //_conn = new NpgsqlConnection(connectionString);

            //_queryString = @"select * from admin 
            //                 where userId=@id or
            //                 username like @username+`%`
            //                 order by userId desc";
            //MessageBox.Show(_queryString);
            //_cmd = new NpgsqlCommand(_queryString, _conn);
            //_cmd.Parameters.Add("@id", NpgsqlDbType.Integer).Value = userId;
            //_cmd.Parameters.Add("@username", NpgsqlDbType.Varchar).Value = value;

            //try
            //{
            //    _conn.Open();
            //    using (var reader = _cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            var admin = new Admin();
            //            admin.Id = (int)reader[0];
            //            admin.Username = reader[1].ToString();
            //            admin.Password = reader[2].ToString();
            //            adminList.Add(admin);
            //        }
            //    }
            //    _conn.Close();
            //    return adminList;
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("Error: " + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
        }
    }
}
