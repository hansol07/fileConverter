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

            // FolderBrowserDialog 열기
            DialogResult result = folderBrowserDialog1.ShowDialog();

            // 사용자가 폴더를 선택한 경우
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
                    // filePath.Text가 비어있으면 아무 작업도 수행하지 않고 리턴합니다.
                    return;
                }

                string folderPath = filePathTxt.Text;
                string[] files = Directory.GetFiles(folderPath);

                // fileDgv의 첫 번째 셀에 파일 이름들을 채워 넣습니다.
                foreach (string file in files)
                {
                    // DataGridView에 새로운 행을 추가하고 파일 이름을 첫 번째 셀에 설정합니다.
                    fileDgv.Rows.Add(Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                // 예외가 발생한 경우 메시지를 표시합니다.
                MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void 변환문구설정ToolStripMenuItem_Click(object sender, EventArgs e)
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
                // 디렉토리에 있는 파일 목록 가져오기
                string[] files = Directory.GetFiles(filePathTxt.Text);

                // 각 파일에 대해 변환 작업 수행
                foreach (string filePath in files)
                {
                    // 파일명에서 확장자를 제외한 부분을 가져옴
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);

                    // List<ConvertStr>에 있는 각 항목에 대해 변환 작업 수행
                    foreach (ConvertStr item in CommonUse.strList)
                    {
                        // beforeStr을 포함하는지 확인하고 파일명 변경
                        if (fileNameWithoutExtension.Contains(item.beforeStr))
                        {
                            // 새 파일명 생성 (beforeStr을 afterStr로 교체)
                            string newFileName = fileNameWithoutExtension.Replace(item.beforeStr, item.afterStr);

                            // 새 파일 경로 생성 (새 파일명과 기존 경로 및 확장자를 합침)
                            string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), newFileName + Path.GetExtension(filePath));

                            // 파일 복사 및 이름 변경
                            File.Copy(filePath, newFilePath, true);

                            if (deleteMode)
                            {
                                // 기존 파일 삭제
                                File.Delete(filePath);

                            }

                            break; // 변환된 파일을 복사했으므로 다음 변환 항목으로 넘어감
                        }
                    }
                }

                MessageBox.Show("파일 변환이 완료되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
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