using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            CboInOut.SelectedIndex = 0;
            LoadHistory();
        }

        private void DtpDay_ValueChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtValue.Text) || string.IsNullOrWhiteSpace(TxtPrice.Text))
            {
                MessageBox.Show("항목과 금액을 모두 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!int.TryParse(TxtPrice.Text, out int price))
            {
                MessageBox.Show("금액은 숫자만 입력 가능합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string date = DtpDay.Value.ToString("yyyy-MM-dd");
            string inout = CboInOut.SelectedItem.ToString();
            string detail = TxtValue.Text.Trim();

            string filePath = DtpDay.Value.ToString("yyyy_MM") + ".txt";
            string line = $"{date}_{inout}_{detail}_{price}";

            File.AppendAllText(filePath, line + Environment.NewLine);

            TxtValue.Clear();
            TxtPrice.Clear();

            LoadHistory();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            ReWriteHistory();

            MessageBox.Show("수정 내용이 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadHistory();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgvHistory.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 항목을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("선택한 항목을 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in DgvHistory.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    DgvHistory.Rows.Remove(row);
                }
            }

            ReWriteHistory();
            
            MessageBox.Show("선택한 항목이 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadHistory();
        }

        private void ReWriteHistory()
        {
            string filePath = DtpDay.Value.ToString("yyyy_MM") + ".txt";
            string selectedDate = DtpDay.Value.ToString("yyyy-MM-dd");

            var allLines = File.ReadAllLines(filePath).ToList();

            List<string> newLines = new List<string>();

            foreach (string line in allLines)
            {
                if (!line.StartsWith(selectedDate))
                {
                    newLines.Add(line);
                }
            }

            foreach (DataGridViewRow row in DgvHistory.Rows)
            {
                if (row.IsNewRow) continue;

                string type = row.Cells[0].Value?.ToString();
                string detail = row.Cells[1].Value?.ToString();
                string price = row.Cells[2].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(type) && !string.IsNullOrWhiteSpace(detail) && int.TryParse(price, out _))
                {
                    newLines.Add($"{selectedDate}_{type}_{detail}_{price}");
                }
            }

            File.WriteAllLines(filePath, newLines);
        }

        // 
        private void LoadHistory()
        {
            string filePath = DtpDay.Value.ToString("yyyy_MM") + ".txt";
            string selectedDate = DtpDay.Value.ToString("yyyy-MM-dd");

            DgvHistory.Rows.Clear();

            int income = 0;
            int expenditure = 0;

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('_');

                    string date = parts[0];
                    string type = parts[1];
                    string detail = parts[2];
                    if (!int.TryParse(parts[3], out int price)) continue;

                    if (date == selectedDate)
                    {
                        DgvHistory.Rows.Add(type, detail, price);
                    }

                    if (type == "수입")
                    {
                        income += price;
                    }
                    else if (type == "지출")
                    {
                        expenditure += price;
                    }
                }
            }

            TxtIncome.Text = income.ToString();
            TxtExpenditure.Text = expenditure.ToString();
            TxtTotal.Text = (income - expenditure).ToString();
        }

    }
}
