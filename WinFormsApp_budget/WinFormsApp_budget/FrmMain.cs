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
                MessageBox.Show("�׸�� �ݾ��� ��� �Է����ּ���.", "�Է� ����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!int.TryParse(TxtPrice.Text, out int price))
            {
                MessageBox.Show("�ݾ��� ���ڸ� �Է� �����մϴ�.", "�Է� ����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            MessageBox.Show("���� ������ ����Ǿ����ϴ�.", "���� �Ϸ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadHistory();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgvHistory.SelectedRows.Count == 0)
            {
                MessageBox.Show("������ �׸��� �������ּ���.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("������ �׸��� �����Ͻðڽ��ϱ�?", "���� Ȯ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            
            MessageBox.Show("������ �׸��� �����Ǿ����ϴ�.", "���� �Ϸ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    if (type == "����")
                    {
                        income += price;
                    }
                    else if (type == "����")
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
