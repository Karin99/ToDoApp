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

        private List<Data> taskList = new List<Data>();

        private void ToDoList_Load(object sender, EventArgs e)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = true;

            dataGridView.DataSource = dao.loadTasks();
            dataGridView.Columns[0].HeaderText = "完了";
            dataGridView.Columns[0].Name = "ColumnIsCompleted";
            dataGridView.Columns[0].Width = 55;
            dataGridView.Columns[1].HeaderText = "担当";
            dataGridView.Columns[1].Name = "ColumnName";
            dataGridView.Columns[1].Width = 70;
            dataGridView.Columns[2].HeaderText = "日付";
            dataGridView.Columns[2].Name = "ColumnDate";
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].HeaderText = "やること";
            dataGridView.Columns[3].Name = "ColumnTask";
            dataGridView.Columns[3].Width = 200;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            String name = comboBoxName.Text;
            DateTime date = dateTimePicker.Value;
            String task = taskTextBox.Text;

            //dataGridView.Rows.Add(false, name, date, task);
            dao.registerTask(name, date, task);

            MessageBox.Show("登録完了");

            comboBoxName.Text = "";
            dateTimePicker.Value = DateTime.Now;
            taskTextBox.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView.Rows.Remove(row);
                }
            }
            MessageBox.Show("削除完了");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveData();
            MessageBox.Show("保存完了");
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

        private void saveData()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    Boolean completed = Convert.ToBoolean(row.Cells[0].Value);
                    String name = row.Cells[1].Value.ToString();
                    DateTime date = Convert.ToDateTime(row.Cells[2].Value);
                    String task = row.Cells[3].Value.ToString();

                    Data data = new Data(completed, name, date, task);
                    taskList.Add(data);
                }
            }
        }
    }
}
