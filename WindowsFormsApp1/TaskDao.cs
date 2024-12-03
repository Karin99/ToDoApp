using System.Text;
using System;

using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class TaskDao
    {
        private string connStr = "server=localhost;user id=root;password=rootrootroot;database=todoapp;charset=utf8";

        public TaskDao(string connStr)
        {
            this.connStr = connStr;
        }

        public void sampleMethod()
        {
            try
            {            
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                Console.WriteLine("MySQLに接続しました！");

                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
}
