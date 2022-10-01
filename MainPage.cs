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
    public partial class MainPage : Form
    {
        public static String UserName = "";
        public static String ID = "";
        public MainPage()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        /// <summary>
        /// 로그아웃 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("로그아웃이 완료되었습니다.", "로그아웃");
            Application.Exit();
        }

        /// <summary>
        /// 개인정보 수정 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Modify_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Modify m = new User_Modify();
            m.Show();
        }

        /// <summary>
        /// 비밀번호 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PW_Change_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainPage_PW_Reset p = new MainPage_PW_Reset();
            MainPage_PW_Reset.ID = ID;
            p.Show();
        }

        /// <summary>
        /// 노트북 대여 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Labtop_Lending_Btn_Click(object sender, EventArgs e)
        {
            Laptop_Lending laptop_lending = new Laptop_Lending();
            laptop_lending.Show();
        }

        /// <summary>
        /// 노트북 대여 기록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Labtop_Lending_Record_Btn_Click(object sender, EventArgs e)
        {
            Laptop_Lending_list laptop_lending_list = new Laptop_Lending_list();
            laptop_lending_list.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            Name_Label.Text = UserName + "님"; 
        }
    }
}
