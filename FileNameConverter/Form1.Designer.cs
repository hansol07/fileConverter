namespace FileNameConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            filePathTxt = new TextBox();
            label1 = new Label();
            folderFindBtn = new Button();
            fileDgv = new DataGridView();
            파일명 = new DataGridViewTextBoxColumn();
            canDelete = new CheckBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            변환문구설정ToolStripMenuItem = new ToolStripMenuItem();
            convertBtn = new Button();
            dgvRefreshBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)fileDgv).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // filePathTxt
            // 
            filePathTxt.Location = new Point(108, 26);
            filePathTxt.Margin = new Padding(2);
            filePathTxt.Name = "filePathTxt";
            filePathTxt.Size = new Size(196, 23);
            filePathTxt.TabIndex = 0;
            filePathTxt.TextChanged += filePath_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "폴더";
            // 
            // folderFindBtn
            // 
            folderFindBtn.Location = new Point(307, 26);
            folderFindBtn.Margin = new Padding(2);
            folderFindBtn.Name = "folderFindBtn";
            folderFindBtn.Size = new Size(37, 19);
            folderFindBtn.TabIndex = 2;
            folderFindBtn.Text = "....";
            folderFindBtn.TextAlign = ContentAlignment.TopCenter;
            folderFindBtn.UseVisualStyleBackColor = true;
            folderFindBtn.Click += folderFindBtn_Click;
            // 
            // fileDgv
            // 
            fileDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            fileDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fileDgv.Columns.AddRange(new DataGridViewColumn[] { 파일명 });
            fileDgv.Location = new Point(92, 83);
            fileDgv.Margin = new Padding(2);
            fileDgv.Name = "fileDgv";
            fileDgv.ReadOnly = true;
            fileDgv.RowHeadersVisible = false;
            fileDgv.RowHeadersWidth = 62;
            fileDgv.RowTemplate.Height = 33;
            fileDgv.Size = new Size(252, 135);
            fileDgv.TabIndex = 3;
            // 
            // 파일명
            // 
            파일명.HeaderText = "파일명";
            파일명.MinimumWidth = 8;
            파일명.Name = "파일명";
            파일명.ReadOnly = true;
            // 
            // canDelete
            // 
            canDelete.AutoSize = true;
            canDelete.Location = new Point(401, 28);
            canDelete.Margin = new Padding(2);
            canDelete.Name = "canDelete";
            canDelete.Size = new Size(102, 19);
            canDelete.TabIndex = 4;
            canDelete.Text = "기존파일 삭제";
            canDelete.UseVisualStyleBackColor = true;
            canDelete.CheckedChanged += canDelete_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(608, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { 변환문구설정ToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(43, 22);
            toolStripMenuItem1.Text = "메뉴";
            // 
            // 변환문구설정ToolStripMenuItem
            // 
            변환문구설정ToolStripMenuItem.Name = "변환문구설정ToolStripMenuItem";
            변환문구설정ToolStripMenuItem.Size = new Size(150, 22);
            변환문구설정ToolStripMenuItem.Text = "변환문구 설정";
            변환문구설정ToolStripMenuItem.Click += 변환문구설정ToolStripMenuItem_Click;
            // 
            // convertBtn
            // 
            convertBtn.Location = new Point(402, 58);
            convertBtn.Name = "convertBtn";
            convertBtn.Size = new Size(75, 23);
            convertBtn.TabIndex = 6;
            convertBtn.Text = "변환";
            convertBtn.UseVisualStyleBackColor = true;
            convertBtn.Click += convertBtn_Click;
            // 
            // dgvRefreshBtn
            // 
            dgvRefreshBtn.Location = new Point(97, 57);
            dgvRefreshBtn.Name = "dgvRefreshBtn";
            dgvRefreshBtn.Size = new Size(75, 23);
            dgvRefreshBtn.TabIndex = 7;
            dgvRefreshBtn.Text = "새로고침";
            dgvRefreshBtn.UseVisualStyleBackColor = true;
            dgvRefreshBtn.Click += dgvRefreshBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 318);
            Controls.Add(dgvRefreshBtn);
            Controls.Add(convertBtn);
            Controls.Add(canDelete);
            Controls.Add(fileDgv);
            Controls.Add(folderFindBtn);
            Controls.Add(label1);
            Controls.Add(filePathTxt);
            Controls.Add(menuStrip1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "FileNameConverter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileDgv).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox filePathTxt;
        private Label label1;
        private Button folderFindBtn;
        private DataGridView fileDgv;
        private DataGridViewTextBoxColumn 파일명;
        private CheckBox canDelete;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem 변환문구설정ToolStripMenuItem;
        private Button convertBtn;
        private Button dgvRefreshBtn;
    }
}