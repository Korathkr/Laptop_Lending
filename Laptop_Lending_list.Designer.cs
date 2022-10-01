
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
            this.Rental_Date_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Return_Date_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.Rental_Date_list});
            this.Laptop_list.HideSelection = false;
            this.Laptop_list.Location = new System.Drawing.Point(22, 62);
            this.Laptop_list.Name = "Laptop_list";
            this.Laptop_list.Size = new System.Drawing.Size(592, 297);
            this.Laptop_list.TabIndex = 0;
            this.Laptop_list.UseCompatibleStateImageBehavior = false;
            this.Laptop_list.View = System.Windows.Forms.View.Details;
            // 
            // Num_list
            // 
            this.Num_list.Text = "No.";
            // 
            // Name_list
            // 
            this.Name_list.Text = "이름";
            // 
            // Student_Number_list
            // 
            this.Student_Number_list.Text = "학번";
            this.Student_Number_list.Width = 94;
            // 
            // Application_Date_list
            // 
            this.Application_Date_list.Text = "신청 날짜";
            this.Application_Date_list.Width = 99;
            // 
            // Rental_Date_list
            // 
            this.Rental_Date_list.Text = "대여 날짜";
            this.Rental_Date_list.Width = 111;
            // 
            // Return_Date_list
            // 
            this.Return_Date_list.Text = "반납 날짜";
            this.Return_Date_list.Width = 128;
            // 
            // Laptop_Lending_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 387);
            this.Controls.Add(this.Laptop_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Laptop_Lending_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "노트북 대여 기록";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Laptop_list;
        private System.Windows.Forms.ColumnHeader Num_list;
        private System.Windows.Forms.ColumnHeader Name_list;
        private System.Windows.Forms.ColumnHeader Application_Date_list;
        private System.Windows.Forms.ColumnHeader Rental_Date_list;
        private System.Windows.Forms.ColumnHeader Return_Date_list;
        private System.Windows.Forms.ColumnHeader Student_Number_list;
    }
}