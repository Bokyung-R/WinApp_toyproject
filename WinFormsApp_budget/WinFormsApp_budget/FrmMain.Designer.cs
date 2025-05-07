namespace WinApp1
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            CboInOut = new ComboBox();
            BtnSave = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TxtPrice = new TextBox();
            TxtValue = new TextBox();
            label2 = new Label();
            label1 = new Label();
            DtpDay = new DateTimePicker();
            groupBox2 = new GroupBox();
            DgvHistory = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            Detail = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            BtnModify = new Button();
            BtnDelete = new Button();
            groupBox3 = new GroupBox();
            TxtTotal = new TextBox();
            TxtExpenditure = new TextBox();
            TxtIncome = new TextBox();
            label8 = new Label();
            label10 = new Label();
            label7 = new Label();
            label9 = new Label();
            label6 = new Label();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvHistory).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CboInOut);
            groupBox1.Controls.Add(BtnSave);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtPrice);
            groupBox1.Controls.Add(TxtValue);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DtpDay);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 177);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "입력";
            // 
            // CboInOut
            // 
            CboInOut.FormattingEnabled = true;
            CboInOut.Items.AddRange(new object[] { "수입", "지출" });
            CboInOut.Location = new Point(88, 109);
            CboInOut.Name = "CboInOut";
            CboInOut.Size = new Size(200, 23);
            CboInOut.TabIndex = 3;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(204, 141);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 30);
            BtnSave.TabIndex = 4;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 83);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 6;
            label5.Text = "원";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 112);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "구분 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 83);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "금액 :";
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(88, 80);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(182, 23);
            TxtPrice.TabIndex = 2;
            // 
            // TxtValue
            // 
            TxtValue.Location = new Point(88, 51);
            TxtValue.Name = "TxtValue";
            TxtValue.Size = new Size(200, 23);
            TxtValue.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 54);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "항목 :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "날짜 선택 :";
            // 
            // DtpDay
            // 
            DtpDay.Location = new Point(88, 22);
            DtpDay.Name = "DtpDay";
            DtpDay.Size = new Size(200, 23);
            DtpDay.TabIndex = 0;
            DtpDay.ValueChanged += DtpDay_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvHistory);
            groupBox2.Controls.Add(BtnModify);
            groupBox2.Controls.Add(BtnDelete);
            groupBox2.Location = new Point(12, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 221);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // DgvHistory
            // 
            DgvHistory.BackgroundColor = Color.GhostWhite;
            DgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvHistory.Columns.AddRange(new DataGridViewColumn[] { Type, Detail, Price });
            DgvHistory.GridColor = Color.Silver;
            DgvHistory.Location = new Point(6, 22);
            DgvHistory.Name = "DgvHistory";
            DgvHistory.Size = new Size(298, 157);
            DgvHistory.TabIndex = 8;
            // 
            // Type
            // 
            Type.HeaderText = "구분";
            Type.Name = "Type";
            Type.Width = 55;
            // 
            // Detail
            // 
            Detail.HeaderText = "내역";
            Detail.Name = "Detail";
            // 
            // Price
            // 
            Price.HeaderText = "금액";
            Price.Name = "Price";
            // 
            // BtnModify
            // 
            BtnModify.Location = new Point(178, 185);
            BtnModify.Name = "BtnModify";
            BtnModify.Size = new Size(60, 30);
            BtnModify.TabIndex = 6;
            BtnModify.Text = "수정";
            BtnModify.UseVisualStyleBackColor = true;
            BtnModify.Click += BtnModify_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(244, 185);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(60, 30);
            BtnDelete.TabIndex = 6;
            BtnDelete.Text = "삭제";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TxtTotal);
            groupBox3.Controls.Add(TxtExpenditure);
            groupBox3.Controls.Add(TxtIncome);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label6);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(12, 422);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(310, 127);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "달 수입/지출";
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(88, 82);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(146, 23);
            TxtTotal.TabIndex = 1;
            // 
            // TxtExpenditure
            // 
            TxtExpenditure.Location = new Point(88, 56);
            TxtExpenditure.Name = "TxtExpenditure";
            TxtExpenditure.ReadOnly = true;
            TxtExpenditure.Size = new Size(146, 23);
            TxtExpenditure.TabIndex = 1;
            // 
            // TxtIncome
            // 
            TxtIncome.Location = new Point(88, 27);
            TxtIncome.Name = "TxtIncome";
            TxtIncome.ReadOnly = true;
            TxtIncome.Size = new Size(146, 23);
            TxtIncome.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 85);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 0;
            label8.Text = "잔액 :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(240, 59);
            label10.Name = "label10";
            label10.Size = new Size(19, 15);
            label10.TabIndex = 6;
            label10.Text = "원";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 59);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 0;
            label7.Text = "총 지출 :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(240, 30);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 6;
            label9.Text = "원";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 34);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 0;
            label6.Text = "총 수입 :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(240, 85);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 6;
            label11.Text = "원";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 561);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "가계부";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvHistory).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label3;
        private TextBox TxtValue;
        private Label label2;
        private Label label1;
        private DateTimePicker DtpDay;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private TextBox TxtPrice;
        private Button BtnSave;
        private ComboBox CboInOut;
        private TextBox TxtTotal;
        private TextBox TxtExpenditure;
        private TextBox TxtIncome;
        private Label label8;
        private Label label10;
        private Label label7;
        private Label label9;
        private Label label6;
        private Button BtnDelete;
        private DataGridView DgvHistory;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Detail;
        private DataGridViewTextBoxColumn Price;
        private Button BtnModify;
        private Label label11;
    }
}
