using System;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public partial class Admin_User_Info : Form
    {
        public Admin_User_Info()
        {
            InitializeComponent();
        }

        private void Admin_User_Info_Load(object sender, EventArgs e)
        {
            // Users_Information 
            ID_TextBox.Text = Admin_Config.ID;
            Name_TextBox.Text = Admin_Config.Name;
            BirthDay_TextBox.Text = Admin_Config.Birth;
            Student_Number_TextBox.Text = Admin_Config.Student_Number;
            Dept_ID_TextBox.Text = Admin_Config.Dept_ID;
            Dept_Name_TextBox.Text = Admin_Config.Dept_Name;
            Address_TextBox.Text = Admin_Config.Address[0];
            Tell_TextBox.Text = Admin_Config.Tell;
            Email1_TextBox.Text = Admin_Config.Email;

            Admin_DBMySql.User_info();
            // Users_laptop_lending
            Parent_Name_TextBox.Text = Admin_Config.Parent_Name;
            Parent_Address_TextBox.Text = Admin_Config.Parent_Address;
            Parent_Tell_TextBox.Text = Admin_Config.Parent_Tell;
            Rental_Date_TextBox.Text = Admin_Config.Rental_Date;
            Return_Date_TextBox.Text = Admin_Config.Return_Date;
            Late_TextBox.Text = Admin_Config.Late;
        }
    }
}
