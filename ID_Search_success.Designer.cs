
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class ID_Search_success
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
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OK_Btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(76, 86);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 15);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "로그인 하시려면 \'확인\' 버튼을 누르세요.";
            // 
            // OK_Btn
            // 
            this.OK_Btn.BackColor = System.Drawing.Color.Navy;
            this.OK_Btn.FlatAppearance.BorderSize = 0;
            this.OK_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OK_Btn.ForeColor = System.Drawing.Color.White;
            this.OK_Btn.Location = new System.Drawing.Point(162, 201);
            this.OK_Btn.Name = "OK_Btn";
            this.OK_Btn.Size = new System.Drawing.Size(81, 50);
            this.OK_Btn.TabIndex = 2;
            this.OK_Btn.Text = "확인";
            this.OK_Btn.UseVisualStyleBackColor = false;
            this.OK_Btn.Click += new System.EventHandler(this.OK_Btn_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-20, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(592, 2);
            this.label10.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "> 아이디를 찾았습니다!";
            // 
            // ID_Search_success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 313);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OK_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.MaximumSize = new System.Drawing.Size(451, 360);
            this.MinimumSize = new System.Drawing.Size(451, 360);
            this.Name = "ID_Search_success";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "아이디 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OK_Btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
    }
}