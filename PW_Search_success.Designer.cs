
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class PW_Search_success
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PW_Search_success));
            this.OK_Btn = new System.Windows.Forms.Button();
            this.PW_Check_Q_TextBox = new System.Windows.Forms.TextBox();
            this.PW_Check_A_TextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK_Btn
            // 
            this.OK_Btn.BackColor = System.Drawing.Color.Navy;
            this.OK_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OK_Btn.ForeColor = System.Drawing.Color.White;
            this.OK_Btn.Location = new System.Drawing.Point(181, 223);
            this.OK_Btn.Name = "OK_Btn";
            this.OK_Btn.Size = new System.Drawing.Size(81, 50);
            this.OK_Btn.TabIndex = 3;
            this.OK_Btn.Text = "확인";
            this.OK_Btn.UseVisualStyleBackColor = false;
            this.OK_Btn.Click += new System.EventHandler(this.OK_Btn_Click);
            // 
            // PW_Check_Q_TextBox
            // 
            this.PW_Check_Q_TextBox.Location = new System.Drawing.Point(198, 95);
            this.PW_Check_Q_TextBox.Name = "PW_Check_Q_TextBox";
            this.PW_Check_Q_TextBox.Size = new System.Drawing.Size(219, 25);
            this.PW_Check_Q_TextBox.TabIndex = 19;
            // 
            // PW_Check_A_TextBox
            // 
            this.PW_Check_A_TextBox.Location = new System.Drawing.Point(198, 150);
            this.PW_Check_A_TextBox.Name = "PW_Check_A_TextBox";
            this.PW_Check_A_TextBox.Size = new System.Drawing.Size(219, 25);
            this.PW_Check_A_TextBox.TabIndex = 20;
            this.PW_Check_A_TextBox.TextChanged += new System.EventHandler(this.PW_Check_A_TextBox_TextChanged);
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(181, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(2, 18);
            this.label19.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(181, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 18);
            this.label1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F);
            this.label2.Location = new System.Drawing.Point(38, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "비밀번호 찾기 질문";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F);
            this.label3.Location = new System.Drawing.Point(38, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "비밀번호 찾기 답변";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-1, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(592, 2);
            this.label10.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "> 비밀번호 찾기 질문에 답변 해주세요.";
            // 
            // PW_Search_success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 313);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.PW_Check_A_TextBox);
            this.Controls.Add(this.PW_Check_Q_TextBox);
            this.Controls.Add(this.OK_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(475, 360);
            this.MinimumSize = new System.Drawing.Size(475, 360);
            this.Name = "PW_Search_success";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "비밀번호 찾기";
            this.Load += new System.EventHandler(this.PW_Search_success_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_Btn;
        private System.Windows.Forms.TextBox PW_Check_Q_TextBox;
        private System.Windows.Forms.TextBox PW_Check_A_TextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
    }
}