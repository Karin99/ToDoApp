using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            dataGridView.RowHeadersVisible = false;

            labelFamily.Text = "いつまでに？";
            labelDate.Text = "だれが？";
            labelTask.Text = "なにやる？";

            btnRegister.Text = "登録";
            btnDelete.Text = "削除";
            btnSave.Text = "保存";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登録完了");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("削除完了");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("保存完了");
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
