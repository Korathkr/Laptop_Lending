
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class Admin_Rental_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Rental_info));
            this.Rental_list = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_학번 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_전화번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_주소 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_이메일 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExcelFile_Save_Btn = new System.Windows.Forms.Button();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.Rental_신청날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_대여날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_반납날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_기기명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExcelSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Rental_list
            // 
            this.Rental_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.Rental_학번,
            this.Rental_이름,
            this.Rental_전화번호,
            this.Rental_이메일,
            this.Rental_주소,
            this.Rental_신청날짜,
            this.Rental_대여날짜,
            this.Rental_반납날짜,
            this.Rental_기기명});
            this.Rental_list.FullRowSelect = true;
            this.Rental_list.GridLines = true;
            this.Rental_list.HideSelection = false;
            this.Rental_list.Location = new System.Drawing.Point(27, 105);
            this.Rental_list.Name = "Rental_list";
            this.Rental_list.Size = new System.Drawing.Size(978, 388);
            this.Rental_list.TabIndex = 1;
            this.Rental_list.UseCompatibleStateImageBehavior = false;
            this.Rental_list.View = System.Windows.Forms.View.Details;
            // 
            // Num
            // 
            this.Num.Text = "No.";
            this.Num.Width = 52;
            // 
            // Rental_학번
            // 
            this.Rental_학번.Text = "학번";
            this.Rental_학번.Width = 80;
            // 
            // Rental_이름
            // 
            this.Rental_이름.Text = "이름";
            // 
            // Rental_전화번호
            // 
            this.Rental_전화번호.Text = "전화번호";
            this.Rental_전화번호.Width = 93;
            // 
            // Rental_주소
            // 
            this.Rental_주소.Text = "주소";
            this.Rental_주소.Width = 143;
            // 
            // Rental_이메일
            // 
            this.Rental_이메일.Text = "이메일";
            this.Rental_이메일.Width = 124;
            // 
            // ExcelFile_Save_Btn
            // 
            this.ExcelFile_Save_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ExcelFile_Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExcelFile_Save_Btn.FlatAppearance.BorderSize = 0;
            this.ExcelFile_Save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExcelFile_Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcelFile_Save_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExcelFile_Save_Btn.ForeColor = System.Drawing.Color.White;
            this.ExcelFile_Save_Btn.Location = new System.Drawing.Point(861, 45);
            this.ExcelFile_Save_Btn.Name = "ExcelFile_Save_Btn";
            this.ExcelFile_Save_Btn.Size = new System.Drawing.Size(144, 42);
            this.ExcelFile_Save_Btn.TabIndex = 6;
            this.ExcelFile_Save_Btn.Text = "Excel 파일로 저장";
            this.ExcelFile_Save_Btn.UseVisualStyleBackColor = false;
            this.ExcelFile_Save_Btn.Click += new System.EventHandler(this.ExcelFile_Save_Btn_Click);
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.BackColor = System.Drawing.Color.Silver;
            this.Reset_Btn.FlatAppearance.BorderSize = 0;
            this.Reset_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Reset_Btn.Location = new System.Drawing.Point(776, 45);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(60, 42);
            this.Reset_Btn.TabIndex = 7;
            this.Reset_Btn.Text = "조회";
            this.Reset_Btn.UseVisualStyleBackColor = false;
            this.Reset_Btn.Click += new System.EventHandler(this.Reset_Btn_Click);
            // 
            // Rental_신청날짜
            // 
            this.Rental_신청날짜.Text = "신청 날짜";
            this.Rental_신청날짜.Width = 107;
            // 
            // Rental_대여날짜
            // 
            this.Rental_대여날짜.Text = "대여 날짜";
            this.Rental_대여날짜.Width = 125;
            // 
            // Rental_반납날짜
            // 
            this.Rental_반납날짜.Text = "반납 날짜";
            this.Rental_반납날짜.Width = 112;
            // 
            // Rental_기기명
            // 
            this.Rental_기기명.Text = "기기명";
            this.Rental_기기명.Width = 88;
            // 
            // ExcelSaveFile
            // 
            this.ExcelSaveFile.CreatePrompt = true;
            this.ExcelSaveFile.Filter = "모든 파일(*.*) | *.*";
            // 
            // Admin_Rental_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 527);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.ExcelFile_Save_Btn);
            this.Controls.Add(this.Rental_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1049, 574);
            this.MinimumSize = new System.Drawing.Size(1049, 574);
            this.Name = "Admin_Rental_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[관리자] 대여 목록";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Rental_list;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.ColumnHeader Rental_학번;
        private System.Windows.Forms.ColumnHeader Rental_이름;
        private System.Windows.Forms.ColumnHeader Rental_전화번호;
        private System.Windows.Forms.ColumnHeader Rental_주소;
        private System.Windows.Forms.ColumnHeader Rental_이메일;
        private System.Windows.Forms.Button ExcelFile_Save_Btn;
        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.ColumnHeader Rental_신청날짜;
        private System.Windows.Forms.ColumnHeader Rental_대여날짜;
        private System.Windows.Forms.ColumnHeader Rental_반납날짜;
        private System.Windows.Forms.ColumnHeader Rental_기기명;
        private System.Windows.Forms.SaveFileDialog ExcelSaveFile;
    }
}