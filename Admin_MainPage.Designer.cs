
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class Admin_MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.ID_Management_Btn = new System.Windows.Forms.Button();
            this.Approval_Btn = new System.Windows.Forms.Button();
            this.Overdue_list_Btn = new System.Windows.Forms.Button();
            this.Rental_list_Btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "관리자님이 로그인하셨습니다.";
            // 
            // ID_Management_Btn
            // 
            this.ID_Management_Btn.BackColor = System.Drawing.Color.SkyBlue;
            this.ID_Management_Btn.FlatAppearance.BorderSize = 0;
            this.ID_Management_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_Management_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_Management_Btn.ForeColor = System.Drawing.Color.White;
            this.ID_Management_Btn.Location = new System.Drawing.Point(72, 78);
            this.ID_Management_Btn.Name = "ID_Management_Btn";
            this.ID_Management_Btn.Size = new System.Drawing.Size(101, 39);
            this.ID_Management_Btn.TabIndex = 1;
            this.ID_Management_Btn.Text = "ID 관리";
            this.ID_Management_Btn.UseVisualStyleBackColor = false;
            this.ID_Management_Btn.Click += new System.EventHandler(this.ID_Management_Btn_Click);
            // 
            // Approval_Btn
            // 
            this.Approval_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Approval_Btn.FlatAppearance.BorderSize = 0;
            this.Approval_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Approval_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Approval_Btn.ForeColor = System.Drawing.Color.White;
            this.Approval_Btn.Location = new System.Drawing.Point(193, 78);
            this.Approval_Btn.Name = "Approval_Btn";
            this.Approval_Btn.Size = new System.Drawing.Size(101, 39);
            this.Approval_Btn.TabIndex = 2;
            this.Approval_Btn.Text = "승인 요청";
            this.Approval_Btn.UseVisualStyleBackColor = false;
            this.Approval_Btn.Click += new System.EventHandler(this.Approval_Btn_Click);
            // 
            // Overdue_list_Btn
            // 
            this.Overdue_list_Btn.BackColor = System.Drawing.Color.Red;
            this.Overdue_list_Btn.FlatAppearance.BorderSize = 0;
            this.Overdue_list_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Overdue_list_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Overdue_list_Btn.ForeColor = System.Drawing.Color.White;
            this.Overdue_list_Btn.Location = new System.Drawing.Point(435, 78);
            this.Overdue_list_Btn.Name = "Overdue_list_Btn";
            this.Overdue_list_Btn.Size = new System.Drawing.Size(101, 39);
            this.Overdue_list_Btn.TabIndex = 4;
            this.Overdue_list_Btn.Text = "연체 목록";
            this.Overdue_list_Btn.UseVisualStyleBackColor = false;
            this.Overdue_list_Btn.Click += new System.EventHandler(this.Overdue_list_Btn_Click);
            // 
            // Rental_list_Btn
            // 
            this.Rental_list_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rental_list_Btn.FlatAppearance.BorderSize = 0;
            this.Rental_list_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rental_list_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Rental_list_Btn.ForeColor = System.Drawing.Color.White;
            this.Rental_list_Btn.Location = new System.Drawing.Point(312, 78);
            this.Rental_list_Btn.Name = "Rental_list_Btn";
            this.Rental_list_Btn.Size = new System.Drawing.Size(101, 39);
            this.Rental_list_Btn.TabIndex = 5;
            this.Rental_list_Btn.Text = "대여 목록";
            this.Rental_list_Btn.UseVisualStyleBackColor = false;
            this.Rental_list_Btn.Click += new System.EventHandler(this.Rental_list_Btn_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-6, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(592, 2);
            this.label10.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::소프트웨어콘텐츠계열_노트북_대여_프로그램.Properties.Resources.software;
            this.pictureBox1.Location = new System.Drawing.Point(110, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Logout_Btn
            // 
            this.Logout_Btn.BackColor = System.Drawing.Color.Navy;
            this.Logout_Btn.FlatAppearance.BorderSize = 0;
            this.Logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Logout_Btn.ForeColor = System.Drawing.Color.White;
            this.Logout_Btn.Location = new System.Drawing.Point(239, 12);
            this.Logout_Btn.Name = "Logout_Btn";
            this.Logout_Btn.Size = new System.Drawing.Size(101, 39);
            this.Logout_Btn.TabIndex = 46;
            this.Logout_Btn.Text = "로그아웃";
            this.Logout_Btn.UseVisualStyleBackColor = false;
            this.Logout_Btn.Click += new System.EventHandler(this.Logout_Btn_Click);
            // 
            // Admin_MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 278);
            this.Controls.Add(this.Logout_Btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Rental_list_Btn);
            this.Controls.Add(this.Overdue_list_Btn);
            this.Controls.Add(this.Approval_Btn);
            this.Controls.Add(this.ID_Management_Btn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 325);
            this.MinimumSize = new System.Drawing.Size(600, 325);
            this.Name = "Admin_MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "관리자 메인페이지";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ID_Management_Btn;
        private System.Windows.Forms.Button Approval_Btn;
        private System.Windows.Forms.Button Overdue_list_Btn;
        private System.Windows.Forms.Button Rental_list_Btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Logout_Btn;
    }
}