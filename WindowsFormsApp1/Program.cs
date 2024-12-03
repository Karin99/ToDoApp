using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dao = new TaskDao("Server=localhost;Database=todoapp;User ID=root;Password=rootrootroot;");

            Application.Run(new ToDoList(dao));
        }
    }
}
