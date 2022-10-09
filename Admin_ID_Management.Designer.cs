
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class Admin_ID_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_ID_Management));
            this.ID_Management_list = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.아이디 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.학번 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.학과 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.전공 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.생일 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.전화번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.주소 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.이메일 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Delete_Btn = new System.Windows.Forms.Button();
            this.ID_Add_Btn = new System.Windows.Forms.Button();
            this.ID_Modify_Btn = new System.Windows.Forms.Button();
            this.ExcelFile_Save_Btn = new System.Windows.Forms.Button();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.ExcelSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.ID_Info_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_Management_list
            // 
            this.ID_Management_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.아이디,
            this.이름,
            this.학번,
            this.학과,
            this.전공,
            this.생일,
            this.전화번호,
            this.주소,
            this.이메일});
            this.ID_Management_list.FullRowSelect = true;
            this.ID_Management_list.GridLines = true;
            this.ID_Management_list.HideSelection = false;
            this.ID_Management_list.Location = new System.Drawing.Point(35, 99);
            this.ID_Management_list.Name = "ID_Management_list";
            this.ID_Management_list.Size = new System.Drawing.Size(978, 387);
            this.ID_Management_list.TabIndex = 0;
            this.ID_Management_list.UseCompatibleStateImageBehavior = false;
            this.ID_Management_list.View = System.Windows.Forms.View.Details;
            this.ID_Management_list.SelectedIndexChanged += new System.EventHandler(this.ID_Management_list_SelectedIndexChanged);
            this.ID_Management_list.DoubleClick += new System.EventHandler(this.ID_Info_Btn_Click);
            // 
            // Num
            // 
            this.Num.Text = "No.";
            this.Num.Width = 52;
            // 
            // 아이디
            // 
            this.아이디.Text = "아이디";
            this.아이디.Width = 80;
            // 
            // 이름
            // 
            this.이름.Text = "이름";
            // 
            // 학번
            // 
            this.학번.Text = "학번";
            this.학번.Width = 89;
            // 
            // 학과
            // 
            this.학과.Text = "학과";
            this.학과.Width = 93;
            // 
            // 전공
            // 
            this.전공.Text = "전공";
            this.전공.Width = 66;
            // 
            // 생일
            // 
            this.생일.Text = "생년월일";
            this.생일.Width = 100;
            // 
            // 전화번호
            // 
            this.전화번호.Text = "전화번호";
            this.전화번호.Width = 93;
            // 
            // 주소
            // 
            this.주소.Text = "주소";
            this.주소.Width = 187;
            // 
            // 이메일
            // 
            this.이메일.Text = "이메일";
            this.이메일.Width = 136;
            // 
            // ID_Delete_Btn
            // 
            this.ID_Delete_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ID_Delete_Btn.FlatAppearance.BorderSize = 0;
            this.ID_Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_Delete_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_Delete_Btn.Location = new System.Drawing.Point(205, 34);
            this.ID_Delete_Btn.Name = "ID_Delete_Btn";
            this.ID_Delete_Btn.Size = new System.Drawing.Size(79, 42);
            this.ID_Delete_Btn.TabIndex = 1;
            this.ID_Delete_Btn.Text = "ID 삭제";
            this.ID_Delete_Btn.UseVisualStyleBackColor = false;
            this.ID_Delete_Btn.Click += new System.EventHandler(this.ID_Delete_Btn_Click);
            // 
            // ID_Add_Btn
            // 
            this.ID_Add_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ID_Add_Btn.FlatAppearance.BorderSize = 0;
            this.ID_Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_Add_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_Add_Btn.Location = new System.Drawing.Point(35, 34);
            this.ID_Add_Btn.Name = "ID_Add_Btn";
            this.ID_Add_Btn.Size = new System.Drawing.Size(79, 42);
            this.ID_Add_Btn.TabIndex = 3;
            this.ID_Add_Btn.Text = "ID 추가";
            this.ID_Add_Btn.UseVisualStyleBackColor = false;
            this.ID_Add_Btn.Click += new System.EventHandler(this.ID_Add_Btn_Click);
            // 
            // ID_Modify_Btn
            // 
            this.ID_Modify_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ID_Modify_Btn.FlatAppearance.BorderSize = 0;
            this.ID_Modify_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_Modify_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_Modify_Btn.Location = new System.Drawing.Point(120, 34);
            this.ID_Modify_Btn.Name = "ID_Modify_Btn";
            this.ID_Modify_Btn.Size = new System.Drawing.Size(79, 42);
            this.ID_Modify_Btn.TabIndex = 4;
            this.ID_Modify_Btn.Text = "ID 수정";
            this.ID_Modify_Btn.UseVisualStyleBackColor = false;
            this.ID_Modify_Btn.Click += new System.EventHandler(this.ID_Modify_Btn_Click);
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
            this.ExcelFile_Save_Btn.Location = new System.Drawing.Point(869, 34);
            this.ExcelFile_Save_Btn.Name = "ExcelFile_Save_Btn";
            this.ExcelFile_Save_Btn.Size = new System.Drawing.Size(144, 42);
            this.ExcelFile_Save_Btn.TabIndex = 5;
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
            this.Reset_Btn.Location = new System.Drawing.Point(410, 34);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(60, 42);
            this.Reset_Btn.TabIndex = 6;
            this.Reset_Btn.Text = "조회";
            this.Reset_Btn.UseVisualStyleBackColor = false;
            this.Reset_Btn.Click += new System.EventHandler(this.Reset_Btn_Click);
            // 
            // ExcelSaveFile
            // 
            this.ExcelSaveFile.CreatePrompt = true;
            this.ExcelSaveFile.Filter = "모든 파일(*.*) | *.*";
            // 
            // ID_Info_Btn
            // 
            this.ID_Info_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ID_Info_Btn.FlatAppearance.BorderSize = 0;
            this.ID_Info_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_Info_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_Info_Btn.Location = new System.Drawing.Point(290, 34);
            this.ID_Info_Btn.Name = "ID_Info_Btn";
            this.ID_Info_Btn.Size = new System.Drawing.Size(79, 42);
            this.ID_Info_Btn.TabIndex = 7;
            this.ID_Info_Btn.Text = "ID 정보";
            this.ID_Info_Btn.UseVisualStyleBackColor = false;
            this.ID_Info_Btn.Click += new System.EventHandler(this.ID_Info_Btn_Click);
            // 
            // Admin_ID_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 517);
            this.Controls.Add(this.ID_Info_Btn);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.ExcelFile_Save_Btn);
            this.Controls.Add(this.ID_Modify_Btn);
            this.Controls.Add(this.ID_Add_Btn);
            this.Controls.Add(this.ID_Delete_Btn);
            this.Controls.Add(this.ID_Management_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1061, 564);
            this.MinimumSize = new System.Drawing.Size(1061, 564);
            this.Name = "Admin_ID_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[관리자] ID 관리";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView ID_Management_list;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.ColumnHeader 아이디;
        private System.Windows.Forms.ColumnHeader 주소;
        private System.Windows.Forms.ColumnHeader 이메일;
        private System.Windows.Forms.ColumnHeader 생일;
        private System.Windows.Forms.Button ID_Delete_Btn;
        private System.Windows.Forms.Button ID_Add_Btn;
        private System.Windows.Forms.Button ID_Modify_Btn;
        private System.Windows.Forms.Button ExcelFile_Save_Btn;
        private System.Windows.Forms.ColumnHeader 전화번호;
        private System.Windows.Forms.ColumnHeader 학번;
        private System.Windows.Forms.ColumnHeader 학과;
        private System.Windows.Forms.ColumnHeader 전공;
        private System.Windows.Forms.ColumnHeader 이름;
        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.SaveFileDialog ExcelSaveFile;
        private System.Windows.Forms.Button ID_Info_Btn;
    }
}