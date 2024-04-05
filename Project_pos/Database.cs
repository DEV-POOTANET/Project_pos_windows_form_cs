using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_pos
{
    internal class Database
    {
        static readonly string connectionString = "datasource=127.0.0.1;port=3306;database=project_pos;username=root;password=;";
        public MySqlConnection connection = new MySqlConnection(connectionString);

        public bool Connect_Db()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Disconnect_db()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
