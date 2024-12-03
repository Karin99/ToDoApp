using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ToDoList : Form
    {
        public ToDoList(TaskDao dao)
        {
            InitializeComponent();
            this.dao = dao;
        }

        private TaskDao dao;

        private void ToDoList_Load(object sender, EventArgs e)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = true;

            dataGridView.DataSource = dao.loadTasks();
            dataGridView.Columns[0].Name = "ColumnId";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Name = "ColumnIsCompleted";
            dataGridView.Columns[1].HeaderText = "完了";
            dataGridView.Columns[1].Width = 55;
            dataGridView.Columns[2].Name = "ColumnName";
            dataGridView.Columns[2].HeaderText = "担当";
            dataGridView.Columns[2].Width = 70;
            dataGridView.Columns[3].Name = "ColumnDate";
            dataGridView.Columns[3].HeaderText = "日付";
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Name = "ColumnTask";
            dataGridView.Columns[4].HeaderText = "やること";
            dataGridView.Columns[4].Width = 200;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            String name = comboBoxName.Text;
            DateTime date = dateTimePicker.Value;
            String task = taskTextBox.Text;

            dao.registerTask(name, date, task);

            MessageBox.Show("登録完了");

            comboBoxName.Text = "";
            dateTimePicker.Value = DateTime.Now;
            taskTextBox.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["ColumnId"].Value);

            dao.deleteTask(id);

            MessageBox.Show("削除完了");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ToDoList_Load(sender, e);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (dataGridView.DataSource is DataTable dataTable)
            {
                DataView dataView = dataTable.DefaultView;
                dataView.RowFilter = "is_completed = false";
                dataGridView.DataSource = dataView;
            }
        }

        private void btnUnhide_Click(object sender, EventArgs e)
        {
            if (dataGridView.DataSource is DataView dataView)
            {
                dataView.RowFilter = string.Empty;
            }
        }
    }
}
