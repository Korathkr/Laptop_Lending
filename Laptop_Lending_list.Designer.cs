
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class Laptop_Lending_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laptop_Lending_list));
            this.Laptop_list = new System.Windows.Forms.ListView();
            this.Num_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student_Number_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Application_Date_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Return_Date_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_Date_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Laptop_type_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Approval_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Return_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Laptop_list
            // 
            this.Laptop_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num_list,
            this.Name_list,
            this.Student_Number_list,
            this.Application_Date_list,
            this.Return_Date_list,
            this.Rental_Date_list,
            this.Laptop_type_list,
            this.Approval_list,
            this.Return_Status});
            this.Laptop_list.HideSelection = false;
            this.Laptop_list.Location = new System.Drawing.Point(29, 181);
            this.Laptop_list.Name = "Laptop_list";
            this.Laptop_list.Size = new System.Drawing.Size(729, 297);
            this.Laptop_list.TabIndex = 0;
            this.Laptop_list.UseCompatibleStateImageBehavior = false;
            this.Laptop_list.View = System.Windows.Forms.View.Details;
            // 
            // Num_list
            // 
            this.Num_list.Text = "No.";
            this.Num_list.Width = 47;
            // 
            // Name_list
            // 
            this.Name_list.Text = "이름";
            // 
            // Student_Number_list
            // 
            this.Student_Number_list.Text = "학번";
            this.Student_Number_list.Width = 56;
            // 
            // Application_Date_list
            // 
            this.Application_Date_list.Text = "신청 날짜";
            this.Application_Date_list.Width = 85;
            // 
            // Return_Date_list
            // 
            this.Return_Date_list.Text = "반납 날짜";
            this.Return_Date_list.Width = 80;
            // 
            // Rental_Date_list
            // 
            this.Rental_Date_list.Text = "대여 날짜";
            this.Rental_Date_list.Width = 90;
            // 
            // Laptop_type_list
            // 
            this.Laptop_type_list.Text = "기종";
            this.Laptop_type_list.Width = 134;
            // 
            // Approval_list
            // 
            this.Approval_list.Text = "승인 여부";
            this.Approval_list.Width = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::소프트웨어콘텐츠계열_노트북_대여_프로그램.Properties.Resources.software;
            this.pictureBox1.Location = new System.Drawing.Point(218, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Return_Status
            // 
            this.Return_Status.Text = "반납 여부";
            this.Return_Status.Width = 91;
            // 
            // Laptop_Lending_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Laptop_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "Laptop_Lending_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "노트북 대여 기록";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Laptop_list;
        private System.Windows.Forms.ColumnHeader Num_list;
        private System.Windows.Forms.ColumnHeader Name_list;
        private System.Windows.Forms.ColumnHeader Application_Date_list;
        private System.Windows.Forms.ColumnHeader Rental_Date_list;
        private System.Windows.Forms.ColumnHeader Return_Date_list;
        private System.Windows.Forms.ColumnHeader Student_Number_list;
        private System.Windows.Forms.ColumnHeader Laptop_type_list;
        private System.Windows.Forms.ColumnHeader Approval_list;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Return_Status;
    }
}