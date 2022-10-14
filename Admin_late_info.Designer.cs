
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class Admin_late_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_late_info));
            this.late_list = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.late_학번 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.late_이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.late_기기명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.late_신청날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.late_대여날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.late_반납날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.late_연체일수 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.late_반납여부 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.ExcelFile_Save_Btn = new System.Windows.Forms.Button();
            this.ExcelSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // late_list
            // 
            this.late_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.late_학번,
            this.late_이름,
            this.late_기기명,
            this.late_신청날짜,
            this.late_대여날짜,
            this.late_반납날짜,
            this.late_연체일수,
            this.late_반납여부});
            this.late_list.FullRowSelect = true;
            this.late_list.GridLines = true;
            this.late_list.HideSelection = false;
            this.late_list.Location = new System.Drawing.Point(28, 90);
            this.late_list.Name = "late_list";
            this.late_list.Size = new System.Drawing.Size(732, 388);
            this.late_list.TabIndex = 2;
            this.late_list.UseCompatibleStateImageBehavior = false;
            this.late_list.View = System.Windows.Forms.View.Details;
            // 
            // Num
            // 
            this.Num.Text = "No.";
            this.Num.Width = 52;
            // 
            // late_학번
            // 
            this.late_학번.Text = "학번";
            this.late_학번.Width = 80;
            // 
            // late_이름
            // 
            this.late_이름.Text = "이름";
            // 
            // late_기기명
            // 
            this.late_기기명.Text = "기기명";
            this.late_기기명.Width = 88;
            // 
            // late_신청날짜
            // 
            this.late_신청날짜.Text = "신청 날짜";
            this.late_신청날짜.Width = 107;
            // 
            // late_대여날짜
            // 
            this.late_대여날짜.Text = "대여 날짜";
            this.late_대여날짜.Width = 125;
            // 
            // late_반납날짜
            // 
            this.late_반납날짜.Text = "반납 날짜";
            this.late_반납날짜.Width = 112;
            // 
            // late_연체일수
            // 
            this.late_연체일수.Text = "연체일";
            this.late_연체일수.Width = 104;
            // 
            // late_반납여부
            // 
            this.late_반납여부.Text = "반납 여부";
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.BackColor = System.Drawing.Color.Silver;
            this.Reset_Btn.FlatAppearance.BorderSize = 0;
            this.Reset_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Reset_Btn.Location = new System.Drawing.Point(550, 29);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(60, 42);
            this.Reset_Btn.TabIndex = 9;
            this.Reset_Btn.Text = "조회";
            this.Reset_Btn.UseVisualStyleBackColor = false;
            this.Reset_Btn.Click += new System.EventHandler(this.Reset_Btn_Click);
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
            this.ExcelFile_Save_Btn.Location = new System.Drawing.Point(616, 29);
            this.ExcelFile_Save_Btn.Name = "ExcelFile_Save_Btn";
            this.ExcelFile_Save_Btn.Size = new System.Drawing.Size(144, 42);
            this.ExcelFile_Save_Btn.TabIndex = 8;
            this.ExcelFile_Save_Btn.Text = "Excel 파일로 저장";
            this.ExcelFile_Save_Btn.UseVisualStyleBackColor = false;
            this.ExcelFile_Save_Btn.Click += new System.EventHandler(this.ExcelFile_Save_Btn_Click);
            // 
            // ExcelSaveFile
            // 
            this.ExcelSaveFile.CreatePrompt = true;
            this.ExcelSaveFile.Filter = "모든 파일(*.*) | *.*";
            // 
            // Admin_late_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 501);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.ExcelFile_Save_Btn);
            this.Controls.Add(this.late_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(814, 548);
            this.MinimumSize = new System.Drawing.Size(814, 548);
            this.Name = "Admin_late_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[관리자] 연체 목록";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView late_list;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.ColumnHeader late_학번;
        private System.Windows.Forms.ColumnHeader late_이름;
        private System.Windows.Forms.ColumnHeader late_신청날짜;
        private System.Windows.Forms.ColumnHeader late_대여날짜;
        private System.Windows.Forms.ColumnHeader late_반납날짜;
        private System.Windows.Forms.ColumnHeader late_기기명;
        private System.Windows.Forms.ColumnHeader late_연체일수;
        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.Button ExcelFile_Save_Btn;
        private System.Windows.Forms.SaveFileDialog ExcelSaveFile;
        private System.Windows.Forms.ColumnHeader late_반납여부;
    }
}