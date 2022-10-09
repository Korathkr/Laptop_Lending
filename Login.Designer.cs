
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_Btn = new System.Windows.Forms.Button();
            this.ID_Input = new System.Windows.Forms.TextBox();
            this.ID_Label = new System.Windows.Forms.Label();
            this.PW_Label = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.LinkLabel();
            this.ID_Search = new System.Windows.Forms.LinkLabel();
            this.PW_Search = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PW_Input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Btn
            // 
            this.Login_Btn.BackColor = System.Drawing.Color.Navy;
            this.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Login_Btn.ForeColor = System.Drawing.Color.White;
            this.Login_Btn.Location = new System.Drawing.Point(313, 146);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(87, 76);
            this.Login_Btn.TabIndex = 3;
            this.Login_Btn.Text = "로그인";
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // ID_Input
            // 
            this.ID_Input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_Input.Location = new System.Drawing.Point(147, 149);
            this.ID_Input.Name = "ID_Input";
            this.ID_Input.Size = new System.Drawing.Size(144, 25);
            this.ID_Input.TabIndex = 1;
            this.ID_Input.TextChanged += new System.EventHandler(this.ID_Input_TextChanged);
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(56, 149);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(52, 15);
            this.ID_Label.TabIndex = 3;
            this.ID_Label.Text = "아이디";
            // 
            // PW_Label
            // 
            this.PW_Label.AutoSize = true;
            this.PW_Label.Location = new System.Drawing.Point(56, 197);
            this.PW_Label.Name = "PW_Label";
            this.PW_Label.Size = new System.Drawing.Size(67, 15);
            this.PW_Label.TabIndex = 4;
            this.PW_Label.Text = "비밀번호";
            // 
            // SignUp
            // 
            this.SignUp.ActiveLinkColor = System.Drawing.Color.Black;
            this.SignUp.AutoSize = true;
            this.SignUp.LinkColor = System.Drawing.Color.Black;
            this.SignUp.Location = new System.Drawing.Point(140, 245);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(90, 15);
            this.SignUp.TabIndex = 4;
            this.SignUp.TabStop = true;
            this.SignUp.Text = "학과 ID 신청";
            this.SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUp_LinkClicked);
            // 
            // ID_Search
            // 
            this.ID_Search.ActiveLinkColor = System.Drawing.Color.Black;
            this.ID_Search.AutoSize = true;
            this.ID_Search.LinkColor = System.Drawing.Color.Black;
            this.ID_Search.Location = new System.Drawing.Point(236, 245);
            this.ID_Search.Name = "ID_Search";
            this.ID_Search.Size = new System.Drawing.Size(55, 15);
            this.ID_Search.TabIndex = 5;
            this.ID_Search.TabStop = true;
            this.ID_Search.Text = "ID 찾기";
            this.ID_Search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ID_Search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ID_Search_LinkClicked);
            // 
            // PW_Search
            // 
            this.PW_Search.ActiveLinkColor = System.Drawing.Color.Black;
            this.PW_Search.AutoSize = true;
            this.PW_Search.LinkColor = System.Drawing.Color.Black;
            this.PW_Search.Location = new System.Drawing.Point(298, 245);
            this.PW_Search.Name = "PW_Search";
            this.PW_Search.Size = new System.Drawing.Size(102, 15);
            this.PW_Search.TabIndex = 6;
            this.PW_Search.TabStop = true;
            this.PW_Search.Text = "비밀번호 찾기";
            this.PW_Search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PW_Search_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "|";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PW_Input
            // 
            this.PW_Input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PW_Input.Location = new System.Drawing.Point(147, 197);
            this.PW_Input.Name = "PW_Input";
            this.PW_Input.PasswordChar = '*';
            this.PW_Input.Size = new System.Drawing.Size(144, 25);
            this.PW_Input.TabIndex = 2;
            this.PW_Input.TextChanged += new System.EventHandler(this.PW_Input_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(474, 312);
            this.Controls.Add(this.PW_Input);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PW_Search);
            this.Controls.Add(this.ID_Search);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.PW_Label);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.ID_Input);
            this.Controls.Add(this.Login_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(492, 359);
            this.MinimumSize = new System.Drawing.Size(492, 359);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.TextBox ID_Input;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label PW_Label;
        private System.Windows.Forms.LinkLabel SignUp;
        private System.Windows.Forms.LinkLabel ID_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel PW_Search;
        private System.Windows.Forms.TextBox PW_Input;
    }
}

