namespace WindowsFormsApp1
{
    partial class ToDoList

    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.complete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFamily = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.comboBoxFamily = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.btnRegister.Location = new System.Drawing.Point(555, 293);
            this.btnRegister.Name = "button1";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // button2
            // 
            this.btnDelete.Location = new System.Drawing.Point(646, 293);
            this.btnDelete.Name = "button2";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.btnSave.Location = new System.Drawing.Point(555, 333);
            this.btnSave.Name = "button3";
            this.btnSave.Size = new System.Drawing.Size(166, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.complete,
            this.family,
            this.date,
            this.task});
            this.dataGridView.Location = new System.Drawing.Point(37, 60);
            this.dataGridView.Name = "dataGridView1";
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.Size = new System.Drawing.Size(458, 381);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Location = new System.Drawing.Point(553, 145);
            this.labelFamily.Name = "label1";
            this.labelFamily.Size = new System.Drawing.Size(27, 12);
            this.labelFamily.TabIndex = 4;
            this.labelFamily.Text = "date";
            this.labelFamily.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(555, 176);
            this.dateTimePicker.Name = "dateTimePicker1";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(553, 73);
            this.labelDate.Name = "label2";
            this.labelDate.Size = new System.Drawing.Size(36, 12);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "family";
            this.labelDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.taskTextBox.Location = new System.Drawing.Point(555, 240);
            this.taskTextBox.Name = "textBox1";
            this.taskTextBox.Size = new System.Drawing.Size(200, 19);
            this.taskTextBox.TabIndex = 7;
            this.taskTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(553, 213);
            this.labelTask.Name = "label3";
            this.labelTask.Size = new System.Drawing.Size(29, 12);
            this.labelTask.TabIndex = 8;
            this.labelTask.Text = "toDo";
            this.labelTask.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBoxFamily.FormattingEnabled = true;
            this.comboBoxFamily.Items.AddRange(new object[] {
            "ひろし",
            "みさえ",
            "しんのすけ",
            "ひまわり"});
            this.comboBoxFamily.Location = new System.Drawing.Point(555, 106);
            this.comboBoxFamily.Name = "comboBox1";
            this.comboBoxFamily.Size = new System.Drawing.Size(200, 20);
            this.comboBoxFamily.TabIndex = 9;
            this.comboBoxFamily.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Complete
            // 
            this.complete.HeaderText = "完了";
            this.complete.Name = "Complete";
            this.complete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.complete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.complete.Width = 54;
            // 
            // Family
            // 
            this.family.HeaderText = "担当";
            this.family.Name = "Family";
            // 
            // Date
            // 
            this.date.HeaderText = "期限";
            this.date.Name = "Date";
            // 
            // ToDo
            // 
            this.task.HeaderText = "やること";
            this.task.Name = "ToDo";
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 493);
            this.Controls.Add(this.comboBoxFamily);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelFamily);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dataGridView);
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn complete;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn task;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.ComboBox comboBoxFamily;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}

