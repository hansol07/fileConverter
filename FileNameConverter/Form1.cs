using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;
namespace FileNameConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form2 textForm;
        private bool deleteMode = false;



        private void folderFindBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            // FolderBrowserDialog ����
            DialogResult result = folderBrowserDialog1.ShowDialog();

            // ����ڰ� ������ ������ ���
            if (result == DialogResult.OK)
            {
                filePathTxt.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void filePath_TextChanged(object sender, EventArgs e)
        {
            ReadFolder();
        }
        private void ReadFolder()
        {
            try
            {
                fileDgv.Rows.Clear();
                if (string.IsNullOrEmpty(filePathTxt.Text))
                {
                    // filePath.Text�� ��������� �ƹ� �۾��� �������� �ʰ� �����մϴ�.
                    return;
                }

                string folderPath = filePathTxt.Text;
                string[] files = Directory.GetFiles(folderPath);

                // fileDgv�� ù ��° ���� ���� �̸����� ä�� �ֽ��ϴ�.
                foreach (string file in files)
                {
                    // DataGridView�� ���ο� ���� �߰��ϰ� ���� �̸��� ù ��° ���� �����մϴ�.
                    fileDgv.Rows.Add(Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                // ���ܰ� �߻��� ��� �޽����� ǥ���մϴ�.
                MessageBox.Show($"���� �߻�: {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ��ȯ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textForm == null || textForm.IsDisposed)
            {
                textForm = new Form2();
                textForm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLoadConverStr();
        }
        private void GetLoadConverStr()
        {
            if (!File.Exists(CommonUse.jsonPath))
                return;

            try
            {
                using (StreamReader srFile = new StreamReader(CommonUse.jsonPath, Encoding.Default))
                {
                    string strLine = string.Empty;
                    while ((strLine = srFile.ReadLine()) != null)
                    {
                        if (strLine == string.Empty)
                            continue;

                        CommonUse.strList = JsonConvert.DeserializeObject<List<ConvertStr>>(strLine);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            ConvertFiles();
        }
        public void ConvertFiles()
        {
            try
            {
                // ���丮�� �ִ� ���� ��� ��������
                string[] files = Directory.GetFiles(filePathTxt.Text);

                // �� ���Ͽ� ���� ��ȯ �۾� ����
                foreach (string filePath in files)
                {
                    // ���ϸ��� Ȯ���ڸ� ������ �κ��� ������
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);

                    // List<ConvertStr>�� �ִ� �� �׸� ���� ��ȯ �۾� ����
                    foreach (ConvertStr item in CommonUse.strList)
                    {
                        // beforeStr�� �����ϴ��� Ȯ���ϰ� ���ϸ� ����
                        if (fileNameWithoutExtension.Contains(item.beforeStr))
                        {
                            // �� ���ϸ� ���� (beforeStr�� afterStr�� ��ü)
                            string newFileName = fileNameWithoutExtension.Replace(item.beforeStr, item.afterStr);

                            // �� ���� ��� ���� (�� ���ϸ�� ���� ��� �� Ȯ���ڸ� ��ħ)
                            string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), newFileName + Path.GetExtension(filePath));

                            // ���� ���� �� �̸� ����
                            File.Copy(filePath, newFilePath, true);

                            if (deleteMode)
                            {
                                // ���� ���� ����
                                File.Delete(filePath);

                            }

                            break; // ��ȯ�� ������ ���������Ƿ� ���� ��ȯ �׸����� �Ѿ
                        }
                    }
                }

                MessageBox.Show("���� ��ȯ�� �Ϸ�Ǿ����ϴ�.", "�Ϸ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"���� �߻�: {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void canDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (canDelete.Checked)
            {
                deleteMode = true;
            }
            else
            {
                deleteMode = false;
            }
        }

        private void dgvRefreshBtn_Click(object sender, EventArgs e)
        {
            ReadFolder();
        }
    }
}