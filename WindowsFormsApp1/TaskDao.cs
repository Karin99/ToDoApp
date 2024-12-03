using System.Text;
using System;

using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class TaskDao
    {
        private string connStr = "server=localhost;user id=root;password=rootrootroot;database=todoapp;charset=utf8";

        public TaskDao(string connStr)
        {
            this.connStr = connStr;
        }

        public DataTable loadTasks()
        {
            DataTable tbl = new DataTable();
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string cmdText = "SELECT is_completed, name, date, task FROM tasks";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdText, conn);
            adapter.Fill(tbl);
            conn.Close();
            return tbl;
        }

    }
}
