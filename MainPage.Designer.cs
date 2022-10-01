
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Name_Label = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.User_Modify = new System.Windows.Forms.LinkLabel();
            this.PW_Change = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.Labtop_Lending_Btn = new System.Windows.Forms.Button();
            this.Labtop_Lending_Record_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("굴림", 9F);
            this.Name_Label.Location = new System.Drawing.Point(12, 34);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(46, 15);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "test님";
            // 
            // Logout_btn
            // 
            this.Logout_btn.Location = new System.Drawing.Point(78, 24);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(83, 35);
            this.Logout_btn.TabIndex = 1;
            this.Logout_btn.Text = "로그아웃";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // User_Modify
            // 
            this.User_Modify.ActiveLinkColor = System.Drawing.Color.Blue;
            this.User_Modify.AutoSize = true;
            this.User_Modify.LinkColor = System.Drawing.Color.Black;
            this.User_Modify.Location = new System.Drawing.Point(202, 34);
            this.User_Modify.Name = "User_Modify";
            this.User_Modify.Size = new System.Drawing.Size(102, 15);
            this.User_Modify.TabIndex = 2;
            this.User_Modify.TabStop = true;
            this.User_Modify.Text = "개인정보 수정";
            this.User_Modify.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.User_Modify_LinkClicked);
            // 
            // PW_Change
            // 
            this.PW_Change.ActiveLinkColor = System.Drawing.Color.Blue;
            this.PW_Change.AutoSize = true;
            this.PW_Change.LinkColor = System.Drawing.Color.Black;
            this.PW_Change.Location = new System.Drawing.Point(335, 34);
            this.PW_Change.Name = "PW_Change";
            this.PW_Change.Size = new System.Drawing.Size(102, 15);
            this.PW_Change.TabIndex = 3;
            this.PW_Change.TabStop = true;
            this.PW_Change.Text = "비밀번호 변경";
            this.PW_Change.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PW_Change_LinkClicked);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-58, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(592, 2);
            this.label10.TabIndex = 43;
            // 
            // Labtop_Lending_Btn
            // 
            this.Labtop_Lending_Btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Labtop_Lending_Btn.Font = new System.Drawing.Font("굴림", 9F);
            this.Labtop_Lending_Btn.Location = new System.Drawing.Point(56, 125);
            this.Labtop_Lending_Btn.Name = "Labtop_Lending_Btn";
            this.Labtop_Lending_Btn.Size = new System.Drawing.Size(154, 83);
            this.Labtop_Lending_Btn.TabIndex = 44;
            this.Labtop_Lending_Btn.Text = "노트북 대여";
            this.Labtop_Lending_Btn.UseVisualStyleBackColor = false;
            this.Labtop_Lending_Btn.Click += new System.EventHandler(this.Labtop_Lending_Btn_Click);
            // 
            // Labtop_Lending_Record_Btn
            // 
            this.Labtop_Lending_Record_Btn.Font = new System.Drawing.Font("굴림", 9F);
            this.Labtop_Lending_Record_Btn.Location = new System.Drawing.Point(258, 125);
            this.Labtop_Lending_Record_Btn.Name = "Labtop_Lending_Record_Btn";
            this.Labtop_Lending_Record_Btn.Size = new System.Drawing.Size(154, 83);
            this.Labtop_Lending_Record_Btn.TabIndex = 45;
            this.Labtop_Lending_Record_Btn.Text = "노트북 대여 기록";
            this.Labtop_Lending_Record_Btn.UseVisualStyleBackColor = true;
            this.Labtop_Lending_Record_Btn.Click += new System.EventHandler(this.Labtop_Lending_Record_Btn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 247);
            this.Controls.Add(this.Labtop_Lending_Record_Btn);
            this.Controls.Add(this.Labtop_Lending_Btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PW_Change);
            this.Controls.Add(this.User_Modify);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Name_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(540, 250);
            this.MaximumSize = new System.Drawing.Size(488, 294);
            this.MinimumSize = new System.Drawing.Size(488, 294);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "메인 페이지";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.LinkLabel User_Modify;
        private System.Windows.Forms.LinkLabel PW_Change;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Labtop_Lending_Btn;
        private System.Windows.Forms.Button Labtop_Lending_Record_Btn;
    }
}