namespace FileNameConverter
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            삭제 = new DataGridViewButtonColumn();
            변환전 = new DataGridViewTextBoxColumn();
            변환후 = new DataGridViewTextBoxColumn();
            refreshBtn = new Button();
            resetBtn = new Button();
            saveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 삭제, 변환전, 변환후 });
            dataGridView1.Location = new Point(109, 61);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(324, 162);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // 삭제
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            삭제.DefaultCellStyle = dataGridViewCellStyle1;
            삭제.FillWeight = 42.613636F;
            삭제.HeaderText = "";
            삭제.MinimumWidth = 8;
            삭제.Name = "삭제";
            삭제.Text = "삭제";
            삭제.UseColumnTextForButtonValue = true;
            // 
            // 변환전
            // 
            변환전.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            변환전.FillWeight = 128.693176F;
            변환전.HeaderText = "변환 전";
            변환전.MinimumWidth = 8;
            변환전.Name = "변환전";
            // 
            // 변환후
            // 
            변환후.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            변환후.FillWeight = 128.693176F;
            변환후.HeaderText = "변환 후";
            변환후.MinimumWidth = 8;
            변환후.Name = "변환후";
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(109, 27);
            refreshBtn.Margin = new Padding(2);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(78, 20);
            refreshBtn.TabIndex = 1;
            refreshBtn.Text = "새로고침";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(206, 27);
            resetBtn.Margin = new Padding(2);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(78, 20);
            resetBtn.TabIndex = 2;
            resetBtn.Text = "초기화";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(300, 27);
            saveBtn.Margin = new Padding(2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(78, 20);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "저장";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(saveBtn);
            Controls.Add(resetBtn);
            Controls.Add(refreshBtn);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "textForm";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn 삭제;
        private DataGridViewTextBoxColumn 변환전;
        private DataGridViewTextBoxColumn 변환후;
        private Button refreshBtn;
        private Button resetBtn;
        private Button saveBtn;
    }
}