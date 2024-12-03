using System;

using MySql.Data.MySqlClient;
using System.Data;

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

            string cmdText = "SELECT * FROM tasks";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdText, conn);
            adapter.Fill(tbl);
            conn.Close();
            return tbl;
        }

        public void registerTask(string name, DateTime date, string task)
        {
            string cmdText =
                "INSERT INTO tasks (name, date, task) VALUES (@name, @date, @task)";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = new MySqlCommand(cmdText, conn);

            conn.Open();
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@task", task);

            command.ExecuteNonQuery();

            conn.Close();
        }

        public void deleteTask(int id)
        {
            string cmdText = "DELETE FROM tasks WHERE id=@id";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = new MySqlCommand(cmdText, conn);

            conn.Open();
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            conn.Close();
        }

        public void saveTask(Boolean isCompleted, int id)
        {
            string cmdText = "UPDATE tasks SET is_completed=@isCompleted WHERE id=@id";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = new MySqlCommand(cmdText, conn);

            conn.Open();
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@isCompleted", isCompleted);
            command.ExecuteNonQuery();

            conn.Close();
        }
    }
}
