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
            this.labelName = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnUnhide = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(18, 56);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 12);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "いつまでに？";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(20, 71);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(137, 19);
            this.dateTimePicker.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(18, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 12);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "だれが？";
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(179, 24);
            this.taskTextBox.Multiline = true;
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(167, 66);
            this.taskTextBox.TabIndex = 7;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(177, 9);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(64, 12);
            this.labelTask.TabIndex = 8;
            this.labelTask.Text = "なにをやる？";
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Items.AddRange(new object[] {
            "ひろし",
            "みさえ",
            "しんのすけ",
            "ひまわり"});
            this.comboBoxName.Location = new System.Drawing.Point(20, 24);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(137, 20);
            this.comboBoxName.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(380, 50);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 40);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "登録";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(108, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(195, 371);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 40);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "呼出";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnHide
            // 
            this.btnHide.AllowDrop = true;
            this.btnHide.Location = new System.Drawing.Point(285, 371);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 40);
            this.btnHide.TabIndex = 11;
            this.btnHide.Text = "完了済みを非表示";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnUnhide
            // 
            this.btnUnhide.Location = new System.Drawing.Point(375, 371);
            this.btnUnhide.Name = "btnUnhide";
            this.btnUnhide.Size = new System.Drawing.Size(75, 40);
            this.btnUnhide.TabIndex = 12;
            this.btnUnhide.Text = "全表示";
            this.btnUnhide.UseVisualStyleBackColor = true;
            this.btnUnhide.Click += new System.EventHandler(this.btnUnhide_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;            
            this.dataGridView.Location = new System.Drawing.Point(20, 109);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.Size = new System.Drawing.Size(430, 240);
            this.dataGridView.TabIndex = 3;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 435);
            this.Controls.Add(this.btnUnhide);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelName);
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn complete;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn task;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnUnhide;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

