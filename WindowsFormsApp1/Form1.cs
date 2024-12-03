using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ToDoList : Form
    {
        private TaskDao dao;

        public ToDoList(TaskDao dao)
        {
            InitializeComponent();
            this.dao = dao;
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = true;

            dataGridView.DataSource = dao.loadTasks();
            dataGridView.Columns[0].Name = "ColumnId";
            dataGridView.Columns[1].Name = "ColumnIsCompleted";
            dataGridView.Columns[2].Name = "ColumnName";
            dataGridView.Columns[3].Name = "ColumnDate";
            dataGridView.Columns[4].Name = "ColumnTask";

            dataGridView.Columns["ColumnId"].Visible = false;
            dataGridView.Columns["ColumnId"].ReadOnly = true;
            dataGridView.Columns["ColumnIsCompleted"].HeaderText = "完了";
            dataGridView.Columns["ColumnIsCompleted"].Width = 55;
            dataGridView.Columns["ColumnName"].HeaderText = "担当";
            dataGridView.Columns["ColumnName"].ReadOnly = true;
            dataGridView.Columns["ColumnName"].Width = 70;
            dataGridView.Columns["ColumnDate"].HeaderText = "日付";
            dataGridView.Columns["ColumnDate"].ReadOnly = true;
            dataGridView.Columns["ColumnDate"].Width = 100;
            dataGridView.Columns["ColumnTask"].HeaderText = "やること";
            dataGridView.Columns["ColumnTask"].ReadOnly = true;
            dataGridView.Columns["ColumnTask"].Width = 200;
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

            ToDoList_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["ColumnId"].Value);

                    dao.deleteTask(id);
                }
                MessageBox.Show("削除完了");
            }
            else
            {
                MessageBox.Show("削除するタスクを選択してください");
            }
            ToDoList_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                Boolean isCompleted = Convert.ToBoolean(row.Cells["ColumnIsCompleted"].Value);
                int id = Convert.ToInt32(row.Cells["ColumnId"].Value);

                dao.saveTask(isCompleted, id);
            }
            MessageBox.Show("保存完了");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ToDoList_Load(sender, e);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["ColumnIsCompleted"].Value is true)
                {
                    row.Visible = false;
                }
                else
                {
                }
            }
        }

        private void btnUnhide_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
