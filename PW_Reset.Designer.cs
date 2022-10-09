
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class PW_Reset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PW_Reset));
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.New_PW_Check = new System.Windows.Forms.TextBox();
            this.New_PW = new System.Windows.Forms.TextBox();
            this.OK_Btn = new System.Windows.Forms.Button();
            this.PW_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-1, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(592, 2);
            this.label10.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "> 비밀번호를 재설정 해주세요.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F);
            this.label3.Location = new System.Drawing.Point(38, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "새 비밀번호 확인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F);
            this.label2.Location = new System.Drawing.Point(38, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "새 비밀번호";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(181, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 18);
            this.label1.TabIndex = 46;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(181, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(2, 18);
            this.label19.TabIndex = 45;
            // 
            // New_PW_Check
            // 
            this.New_PW_Check.Location = new System.Drawing.Point(198, 150);
            this.New_PW_Check.Name = "New_PW_Check";
            this.New_PW_Check.PasswordChar = '*';
            this.New_PW_Check.Size = new System.Drawing.Size(219, 25);
            this.New_PW_Check.TabIndex = 44;
            this.New_PW_Check.TextChanged += new System.EventHandler(this.New_PW_Check_TextChanged);
            // 
            // New_PW
            // 
            this.New_PW.Location = new System.Drawing.Point(198, 95);
            this.New_PW.Name = "New_PW";
            this.New_PW.PasswordChar = '*';
            this.New_PW.Size = new System.Drawing.Size(219, 25);
            this.New_PW.TabIndex = 43;
            this.New_PW.TextChanged += new System.EventHandler(this.New_PW_TextChanged);
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
            this.OK_Btn.TabIndex = 49;
            this.OK_Btn.Text = "확인";
            this.OK_Btn.UseVisualStyleBackColor = false;
            this.OK_Btn.Click += new System.EventHandler(this.OK_Btn_Click);
            // 
            // PW_label
            // 
            this.PW_label.AutoSize = true;
            this.PW_label.Location = new System.Drawing.Point(423, 160);
            this.PW_label.Name = "PW_label";
            this.PW_label.Size = new System.Drawing.Size(0, 15);
            this.PW_label.TabIndex = 50;
            // 
            // PW_Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 313);
            this.Controls.Add(this.PW_label);
            this.Controls.Add(this.OK_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.New_PW_Check);
            this.Controls.Add(this.New_PW);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(560, 360);
            this.MinimumSize = new System.Drawing.Size(506, 360);
            this.Name = "PW_Reset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "비밀번호 재설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox New_PW_Check;
        private System.Windows.Forms.TextBox New_PW;
        private System.Windows.Forms.Button OK_Btn;
        private System.Windows.Forms.Label PW_label;
    }
}