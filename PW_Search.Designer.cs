
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class PW_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PW_Search));
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Student_Number_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OK_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "> 비밀번호 찾기";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-1, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(592, 2);
            this.label10.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F);
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID";
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Location = new System.Drawing.Point(107, 94);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(2, 18);
            this.label25.TabIndex = 42;
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.Location = new System.Drawing.Point(124, 90);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(156, 25);
            this.ID_TextBox.TabIndex = 43;
            this.ID_TextBox.TextChanged += new System.EventHandler(this.ID_TextBox_TextChanged);
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(124, 137);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(156, 25);
            this.Name_TextBox.TabIndex = 46;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(107, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 18);
            this.label3.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F);
            this.label4.Location = new System.Drawing.Point(31, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "성명";
            // 
            // Student_Number_TextBox
            // 
            this.Student_Number_TextBox.Location = new System.Drawing.Point(124, 185);
            this.Student_Number_TextBox.Name = "Student_Number_TextBox";
            this.Student_Number_TextBox.Size = new System.Drawing.Size(156, 25);
            this.Student_Number_TextBox.TabIndex = 49;
            this.Student_Number_TextBox.TextChanged += new System.EventHandler(this.Student_Number_TextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(107, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 18);
            this.label5.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F);
            this.label6.Location = new System.Drawing.Point(31, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "학번";
            // 
            // OK_Btn
            // 
            this.OK_Btn.Location = new System.Drawing.Point(124, 241);
            this.OK_Btn.Name = "OK_Btn";
            this.OK_Btn.Size = new System.Drawing.Size(68, 45);
            this.OK_Btn.TabIndex = 50;
            this.OK_Btn.Text = "확인";
            this.OK_Btn.UseVisualStyleBackColor = true;
            this.OK_Btn.Click += new System.EventHandler(this.OK_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(212, 241);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(68, 45);
            this.Cancel_Btn.TabIndex = 51;
            this.Cancel_Btn.Text = "취소";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // PW_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 321);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.OK_Btn);
            this.Controls.Add(this.Student_Number_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID_TextBox);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(540, 250);
            this.MaximumSize = new System.Drawing.Size(400, 368);
            this.MinimumSize = new System.Drawing.Size(400, 368);
            this.Name = "PW_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "비밀번호 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Student_Number_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OK_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
    }
}