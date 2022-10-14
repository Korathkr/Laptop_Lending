
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class Admin_Approval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Approval));
            this.Approval_list = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Approval_학번 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Approval_이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Approval_신청날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Approval_대여날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Approval_반납날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Approval_승인여부 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Approval_반납여부 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Approval_노트북종류 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Approval_Btn = new System.Windows.Forms.Button();
            this.Approval_Cancle_Btn = new System.Windows.Forms.Button();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.ExcelFile_Save_Btn = new System.Windows.Forms.Button();
            this.ExcelSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.Return_Cancle_Btn = new System.Windows.Forms.Button();
            this.Return_Btn = new System.Windows.Forms.Button();
            this.Last_list_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Approval_list
            // 
            this.Approval_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.Approval_학번,
            this.Approval_이름,
            this.Approval_신청날짜,
            this.Approval_대여날짜,
            this.Approval_반납날짜,
            this.Approval_승인여부,
            this.Approval_반납여부,
            this.Approval_노트북종류});
            this.Approval_list.FullRowSelect = true;
            this.Approval_list.GridLines = true;
            this.Approval_list.HideSelection = false;
            this.Approval_list.Location = new System.Drawing.Point(26, 115);
            this.Approval_list.Name = "Approval_list";
            this.Approval_list.Size = new System.Drawing.Size(705, 437);
            this.Approval_list.TabIndex = 1;
            this.Approval_list.UseCompatibleStateImageBehavior = false;
            this.Approval_list.View = System.Windows.Forms.View.Details;
            this.Approval_list.SelectedIndexChanged += new System.EventHandler(this.Approval_list_SelectedIndexChanged);
            // 
            // Num
            // 
            this.Num.Text = "No.";
            this.Num.Width = 52;
            // 
            // Approval_학번
            // 
            this.Approval_학번.Text = "학번";
            // 
            // Approval_이름
            // 
            this.Approval_이름.Text = "이름";
            // 
            // Approval_신청날짜
            // 
            this.Approval_신청날짜.Text = "신청 날짜";
            this.Approval_신청날짜.Width = 89;
            // 
            // Approval_대여날짜
            // 
            this.Approval_대여날짜.Text = "대여 날짜";
            this.Approval_대여날짜.Width = 96;
            // 
            // Approval_반납날짜
            // 
            this.Approval_반납날짜.Text = "반납 날짜";
            this.Approval_반납날짜.Width = 87;
            // 
            // Approval_승인여부
            // 
            this.Approval_승인여부.Text = "승인 여부";
            this.Approval_승인여부.Width = 92;
            // 
            // Approval_반납여부
            // 
            this.Approval_반납여부.Text = "반납 여부";
            this.Approval_반납여부.Width = 90;
            // 
            // Approval_노트북종류
            // 
            this.Approval_노트북종류.Text = "기기명";
            this.Approval_노트북종류.Width = 87;
            // 
            // Approval_Btn
            // 
            this.Approval_Btn.BackColor = System.Drawing.Color.Lime;
            this.Approval_Btn.FlatAppearance.BorderSize = 0;
            this.Approval_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Approval_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Approval_Btn.Location = new System.Drawing.Point(26, 41);
            this.Approval_Btn.Name = "Approval_Btn";
            this.Approval_Btn.Size = new System.Drawing.Size(85, 42);
            this.Approval_Btn.TabIndex = 4;
            this.Approval_Btn.Text = "승인";
            this.Approval_Btn.UseVisualStyleBackColor = false;
            this.Approval_Btn.Click += new System.EventHandler(this.Approval_Btn_Click);
            // 
            // Approval_Cancle_Btn
            // 
            this.Approval_Cancle_Btn.BackColor = System.Drawing.Color.Red;
            this.Approval_Cancle_Btn.FlatAppearance.BorderSize = 0;
            this.Approval_Cancle_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Approval_Cancle_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Approval_Cancle_Btn.Location = new System.Drawing.Point(117, 41);
            this.Approval_Cancle_Btn.Name = "Approval_Cancle_Btn";
            this.Approval_Cancle_Btn.Size = new System.Drawing.Size(85, 42);
            this.Approval_Cancle_Btn.TabIndex = 5;
            this.Approval_Cancle_Btn.Text = "승인 취소";
            this.Approval_Cancle_Btn.UseVisualStyleBackColor = false;
            this.Approval_Cancle_Btn.Click += new System.EventHandler(this.Approval_Cancle_Btn_Click);
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.BackColor = System.Drawing.Color.Silver;
            this.Reset_Btn.FlatAppearance.BorderSize = 0;
            this.Reset_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Reset_Btn.Location = new System.Drawing.Point(496, 41);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(85, 42);
            this.Reset_Btn.TabIndex = 7;
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
            this.ExcelFile_Save_Btn.Location = new System.Drawing.Point(587, 41);
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
            // Return_Cancle_Btn
            // 
            this.Return_Cancle_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Return_Cancle_Btn.FlatAppearance.BorderSize = 0;
            this.Return_Cancle_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return_Cancle_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Return_Cancle_Btn.Location = new System.Drawing.Point(299, 41);
            this.Return_Cancle_Btn.Name = "Return_Cancle_Btn";
            this.Return_Cancle_Btn.Size = new System.Drawing.Size(85, 42);
            this.Return_Cancle_Btn.TabIndex = 9;
            this.Return_Cancle_Btn.Text = "반납 취소";
            this.Return_Cancle_Btn.UseVisualStyleBackColor = false;
            this.Return_Cancle_Btn.Click += new System.EventHandler(this.Return_Cancle_Btn_Click);
            // 
            // Return_Btn
            // 
            this.Return_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Return_Btn.FlatAppearance.BorderSize = 0;
            this.Return_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Return_Btn.Location = new System.Drawing.Point(208, 41);
            this.Return_Btn.Name = "Return_Btn";
            this.Return_Btn.Size = new System.Drawing.Size(85, 42);
            this.Return_Btn.TabIndex = 10;
            this.Return_Btn.Text = "반납";
            this.Return_Btn.UseVisualStyleBackColor = false;
            this.Return_Btn.Click += new System.EventHandler(this.Return_Btn_Click);
            // 
            // Last_list_Btn
            // 
            this.Last_list_Btn.BackColor = System.Drawing.Color.Navy;
            this.Last_list_Btn.FlatAppearance.BorderSize = 0;
            this.Last_list_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Last_list_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Last_list_Btn.ForeColor = System.Drawing.Color.White;
            this.Last_list_Btn.Location = new System.Drawing.Point(390, 41);
            this.Last_list_Btn.Name = "Last_list_Btn";
            this.Last_list_Btn.Size = new System.Drawing.Size(100, 42);
            this.Last_list_Btn.TabIndex = 11;
            this.Last_list_Btn.Text = "지난 승인 목록";
            this.Last_list_Btn.UseVisualStyleBackColor = false;
            this.Last_list_Btn.Click += new System.EventHandler(this.Last_list_Btn_Click);
            // 
            // Admin_Approval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 589);
            this.Controls.Add(this.Last_list_Btn);
            this.Controls.Add(this.Return_Btn);
            this.Controls.Add(this.Return_Cancle_Btn);
            this.Controls.Add(this.ExcelFile_Save_Btn);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.Approval_Cancle_Btn);
            this.Controls.Add(this.Approval_Btn);
            this.Controls.Add(this.Approval_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(787, 636);
            this.MinimumSize = new System.Drawing.Size(787, 636);
            this.Name = "Admin_Approval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[관리자] 승인/반납";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Approval_list;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.ColumnHeader Approval_학번;
        private System.Windows.Forms.ColumnHeader Approval_이름;
        private System.Windows.Forms.ColumnHeader Approval_대여날짜;
        private System.Windows.Forms.ColumnHeader Approval_반납날짜;
        private System.Windows.Forms.ColumnHeader Approval_승인여부;
        private System.Windows.Forms.ColumnHeader Approval_노트북종류;
        private System.Windows.Forms.ColumnHeader Approval_신청날짜;
        private System.Windows.Forms.Button Approval_Btn;
        private System.Windows.Forms.Button Approval_Cancle_Btn;
        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.Button ExcelFile_Save_Btn;
        private System.Windows.Forms.SaveFileDialog ExcelSaveFile;
        private System.Windows.Forms.ColumnHeader Approval_반납여부;
        private System.Windows.Forms.Button Return_Cancle_Btn;
        private System.Windows.Forms.Button Return_Btn;
        private System.Windows.Forms.Button Last_list_Btn;
    }
}