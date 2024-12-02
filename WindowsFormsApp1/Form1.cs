using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        public List<Data> taskList = new List<Data>();

        private void ToDoList_Load(object sender, EventArgs e)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = true;

            labelName.Text = "いつまでに？";
            labelDate.Text = "だれが？";
            labelTask.Text = "なにやる？";

            btnRegister.Text = "登録";
            btnDelete.Text = "削除";
            btnSave.Text = "保存";

                        // テストデータ
            dataGridView.Rows.Add(false, "ひろし", "2024/08/30", "洗車");
            dataGridView.Rows.Add(false, "みさえ", "2024/09/30", "玄関掃除");
            dataGridView.Rows.Add(false, "しんのすけ", "2024/10/30", "シロにごはんをあげる");
            dataGridView.Rows.Add(false, "ひまわり", "2024/11/30", "シロと遊ぶ");

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String name = comboBoxName.Text;
            DateTime date = dateTimePicker.Value;
            String task = taskTextBox.Text;

            dataGridView.Rows.Add(false, name, date.ToShortDateString(), task);

            name = "";
            date = DateTime.Now;
            task = "";

            MessageBox.Show("登録完了");
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
            MessageBox.Show("保存完了");
            dataGridView.Rows.Clear();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            foreach (var data in taskList)
            {
                dataGridView.Rows.Add(data.isCompleted, data.name, data.date, data.task);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
