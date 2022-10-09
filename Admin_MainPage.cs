using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public partial class Admin_MainPage : Form
    {
        public Admin_MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 로그아웃 버튼
        /// </summary>
        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("로그아웃이 완료되었습니다.", "로그아웃");
            Application.Exit();
        }

        /// <summary>
        /// ID 관리 버튼
        /// </summary>
        private void ID_Management_Btn_Click(object sender, EventArgs e)
        {
            Admin_ID_Management i = new Admin_ID_Management();
            i.Show();
        }

        /// <summary>
        /// 승인 요청 버튼
        /// </summary>
        private void Approval_Btn_Click(object sender, EventArgs e)
        {
            Admin_Approval a = new Admin_Approval();
            a.Show();
        }

        /// <summary>
        /// 대여 목록 버튼
        /// </summary>
        private void Rental_list_Btn_Click(object sender, EventArgs e)
        {
            Admin_Rental_info rental = new Admin_Rental_info();
            rental.Show();
        }

        /// <summary>
        /// 연체 목록 버튼
        /// </summary>
        private void Overdue_list_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
