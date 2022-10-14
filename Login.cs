using System;
using System.Windows.Forms;

/** 개발일정 22-09-19 ~ 22-10-12
 *  영남이공대학교 소프트웨어콘텐츠계열 3학년
 *  1805040 김준영
 */

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public partial class Login : Form
    {
        public static bool Admin_Check = false;

        public Login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        
        /// <summary>
        /// 로그인 버튼
        /// </summary>
        private void Login_Btn_Click(object sender, EventArgs e)
        {
            if (ID_Input.Text == "" || ID_Input.Text == "")
            {
                MessageBox.Show("아이디 또는 비밀번호를 입력하지 않았습니다.", "로그인 오류");
            }
            else
            {
                if (DBMySql.Login_SQL() == true)
                {
                    MainPage m = new MainPage();
                    MainPage.UserName = DBMySql.DB_Name;
                    MainPage.ID = DBMySql.ID;
                    if (Admin_Check == true)
                    {
                        Admin_MainPage Admin = new Admin_MainPage();
                        Admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        m.Show();
                        this.Hide();
                    }
                }
            }
           
        }

        /// <summary>
        /// 아이디 입력 텍스트 박스
        /// </summary>
        private void ID_Input_TextChanged(object sender, EventArgs e)
        {
            DBMySql.ID = ID_Input.Text;
        }
        /// <summary>
        /// 비밀번호 입력 텍스트 박스
        /// </summary>
        private void PW_Input_TextChanged(object sender, EventArgs e)
        {
            DBMySql.PW = PW_Input.Text;
        }
        /// <summary>
        /// 회원가입
        /// </summary>
        private void SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp form2 = new SignUp();
            form2.Show();
        }
        /// <summary>
        /// 아이디 찾기
        /// </summary>
        private void ID_Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ID_Search id = new ID_Search();
            id.Show();
        }
        /// <summary>
        /// 비밀번호 찾기
        /// </summary>
        private void PW_Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PW_Search pw = new PW_Search();
            pw.Show();
        }
    }
}
