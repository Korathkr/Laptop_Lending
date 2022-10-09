
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class ID_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ID_Search));
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BirthDay_DateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "> 아이디 찾기";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-1, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(592, 2);
            this.label10.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F);
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "이름";
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Location = new System.Drawing.Point(107, 94);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(2, 18);
            this.label25.TabIndex = 41;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(124, 90);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(156, 25);
            this.Name_TextBox.TabIndex = 42;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F);
            this.label3.Location = new System.Drawing.Point(31, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "생년월일";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(107, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 18);
            this.label4.TabIndex = 44;
            // 
            // BirthDay_DateTimePicker
            // 
            this.BirthDay_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDay_DateTimePicker.Location = new System.Drawing.Point(124, 140);
            this.BirthDay_DateTimePicker.Name = "BirthDay_DateTimePicker";
            this.BirthDay_DateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.BirthDay_DateTimePicker.TabIndex = 45;
            this.BirthDay_DateTimePicker.ValueChanged += new System.EventHandler(this.BirthDay_DateTimePicker_ValueChanged);
            // 
            // Student_Number_TextBox
            // 
            this.Student_Number_TextBox.Location = new System.Drawing.Point(124, 190);
            this.Student_Number_TextBox.Name = "Student_Number_TextBox";
            this.Student_Number_TextBox.Size = new System.Drawing.Size(156, 25);
            this.Student_Number_TextBox.TabIndex = 48;
            this.Student_Number_TextBox.TextChanged += new System.EventHandler(this.Student_Number_TextChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(107, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 18);
            this.label5.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F);
            this.label6.Location = new System.Drawing.Point(31, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "학번";
            // 
            // OK_Btn
            // 
            this.OK_Btn.BackColor = System.Drawing.Color.Navy;
            this.OK_Btn.FlatAppearance.BorderSize = 0;
            this.OK_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OK_Btn.ForeColor = System.Drawing.Color.White;
            this.OK_Btn.Location = new System.Drawing.Point(124, 256);
            this.OK_Btn.Name = "OK_Btn";
            this.OK_Btn.Size = new System.Drawing.Size(68, 45);
            this.OK_Btn.TabIndex = 49;
            this.OK_Btn.Text = "확인";
            this.OK_Btn.UseVisualStyleBackColor = false;
            this.OK_Btn.Click += new System.EventHandler(this.OK_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.BackColor = System.Drawing.Color.Red;
            this.Cancel_Btn.FlatAppearance.BorderSize = 0;
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.Cancel_Btn.Location = new System.Drawing.Point(212, 256);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(68, 45);
            this.Cancel_Btn.TabIndex = 50;
            this.Cancel_Btn.Text = "취소";
            this.Cancel_Btn.UseVisualStyleBackColor = false;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // ID_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(382, 328);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.OK_Btn);
            this.Controls.Add(this.Student_Number_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BirthDay_DateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 375);
            this.MinimumSize = new System.Drawing.Size(400, 375);
            this.Name = "ID_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "아이디 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker BirthDay_DateTimePicker;
        private System.Windows.Forms.TextBox Student_Number_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OK_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
    }
}