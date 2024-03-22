using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileNameConverter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetConvertStrList();
        }
        private void GetConvertStrList()
        {
            dataGridView1.Rows.Clear();
            foreach (ConvertStr item in CommonUse.strList)
            {
                int rowIndex = dataGridView1.Rows.Add(); // 새로운 행 추가

                // DataGridView의 각 셀에 값을 넣어줍니다.
                dataGridView1.Rows[rowIndex].Cells[1].Value = item.beforeStr; // 첫 번째 열에 beforeStr 값 넣기
                dataGridView1.Rows[rowIndex].Cells[2].Value = item.afterStr; // 두 번째 열에 afterStr 값 넣기
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveList();
            MakeJsonFile();
        }
        private void SaveList()
        {
            CommonUse.strList.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                ConvertStr cStr = new ConvertStr();
                // DataGridViewRow의 Cells 속성을 이용하여 셀에 접근할 수 있음
                cStr.beforeStr = row.Cells[1].Value?.ToString(); // cell[1]에 해당하는 값 가져오기
                cStr.afterStr = row.Cells[2].Value?.ToString(); // cell[2]에 해당하는 값 가져오기

                // beforeStr  유효한 경우에만 List에 추가
                if (!string.IsNullOrEmpty(cStr.beforeStr))
                {
                    CommonUse.strList.Add(cStr);
                }
            }

        }
        private void MakeJsonFile()
        {
            // JSON 직렬화
            string jsonData = JsonConvert.SerializeObject(CommonUse.strList);
            // 파일 경로 설정
            try
            {
                using (StreamWriter swBackUp = new StreamWriter(CommonUse.jsonPath, false, Encoding.Default))
                    swBackUp.WriteLine(jsonData);
            }
            catch (Exception ex)
            {
                //// 오류 발생 시 예외 처리
                MessageBox.Show($"MakeJungDangColorFile()\n오류: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            GetConvertStrList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 삭제 버튼이 클릭된 경우
            if (e.ColumnIndex == dataGridView1.Columns["삭제"].Index && e.RowIndex >= 0)
            {
                // 선택된 행 삭제
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
