using System;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public partial class Admin_User_Modify : Form
    {
        public String Email1;
        public String Email2;

        public Admin_User_Modify()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ID 입력 텍스트 박스
        /// </summary>
        private void ID_TextBox_TextChanged(object sender, EventArgs e)
        {
            Admin_Config.ID = ID_TextBox.Text;
        }

        /// <summary>
        /// 이름 입력 텍스트 박스
        /// </summary>
        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            Admin_Config.Name = Name_TextBox.Text;
        }

        /// <summary>
        /// 학과 이름 텍스트 박스
        /// </summary>
        private void Dept_ID_TextBox_TextChanged(object sender, EventArgs e)
        {
            Admin_Config.Dept_ID = Dept_ID_TextBox.Text;
        }

        /// <summary>
        /// 전공 입력 텍스트 박스
        /// </summary>
        private void Dept_Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            Admin_Config.Dept_Name = Dept_Name_TextBox.Text;
        }

        /// <summary>
        /// 주소 입력 텍스트 박스
        /// </summary>
        private void Address1_TextBox_TextChanged(object sender, EventArgs e)
        {
            Admin_Config.Address[0] = Address1_TextBox.Text;
        }

        /// <summary>
        /// 상세 주소 입력 텍스트 박스
        /// </summary>
        private void Address2_TextBox_TextChanged(object sender, EventArgs e)
        {
            Admin_Config.Address[1] = Address2_TextBox.Text;
        }

        /// <summary>
        /// 전화번호 입력 텍스트 박스
        /// </summary>
        private void Tell_TextBox_TextChanged(object sender, EventArgs e)
        {
            Admin_Config.Tell = Tell_TextBox.Text;
        }

        /// <summary>
        /// 생년월일 입력 텍스트 박스
        /// </summary>
        private void BirthDay_TextBox_TextChanged(object sender, EventArgs e)
        {
            Admin_Config.Birth = BirthDay_TextBox.Text;
        }

        /// <summary>
        /// 이메일 주소 입력 텍스트 박스
        /// </summary>
        private void Email1_TextBox_TextChanged(object sender, EventArgs e)
        {
            Email1 = Email1_TextBox.Text;
        }

        /// <summary>
        /// 이메일 도메인 입력 텍스트 박스
        /// </summary>
        private void Email2_TextBox_TextChanged(object sender, EventArgs e)
        {
            Email2 = Email2_TextBox.Text;
        }

        /// <summary>
        /// 이메일 도메인 선택
        /// </summary>
        private void Email2_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Email2_Select.Text == "직접입력")
            {
                Email2_TextBox.ReadOnly = false;
            }
            else
            {
                Email2_TextBox.ReadOnly = true;
                Email2 = Email2_Select.Text;
            }
        }

        /// <summary>
        /// 수정 확인 버튼
        /// </summary>
        private void Modifiy_OK_Btn_Click(object sender, EventArgs e)
        {       //  아이디                     이름                         생년월일                           전공이름                         주소                         상세주소                전화번호              이메일       이메일 도메인                               
            if (ID_TextBox.Text == "" || Name_TextBox.Text == "" || BirthDay_TextBox.Text == "" || Dept_ID_TextBox.Text == "" || Address1_TextBox.Text == "" || Address2_TextBox.Text == "" || Tell_TextBox.Text == "" || Email1 == "" || Email2 == "")
            {
                MessageBox.Show("공백인 항목이 있습니다.", "오류");
            }
            else
            {
                Admin_Config.Email = Email1 + "@" + Email2;

            if (Admin_DBMySql.User_Modify_SQL() == true)
            {
                MessageBox.Show("개인정보 수정이 완료되었습니다.", "수정 완료");
                this.Close();
            }
            else
            {
                MessageBox.Show("입력하신 정보가 올바르지 않습니다.", "오류");
            }
        }
    }

        /// <summary>
        /// 다시 입력 버튼
        /// </summary>
        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            ID_TextBox.Text = "";
            Dept_ID_TextBox.Text = "";
            Dept_Name_TextBox.Text = "";
            Address1_TextBox.Text = "";
            Address2_TextBox.Text = "";
            Tell_TextBox.Text = "";
            Email1_TextBox.Text = "";
            PW_Check_A_TextBox.Text = "";
            PW_Check_Q_TextBox1.Text = "";
            PW_Check_Q_TextBox2.Text = "";
        }

        /// <summary>
        /// 취소 버튼
        /// </summary>
        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("개인정보 수정을 취소하시겠습니까?", "개인정보 수정", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 해당 폼이 로드되고 화면에 표시되기 전에 실행되는 메서드
        /// </summary>
        private void User_Modifiy_Load(object sender, EventArgs e)
        {
            // Users, UserInformation 테이블에 있는 유저 정보를 호출
            Admin_DBMySql.User_info();
            ID_TextBox.Text = Admin_Config.ID;
            Name_TextBox.Text = Admin_Config.Name;
            BirthDay_TextBox.Text = Admin_Config.Birth.Substring(0, 10);
            Student_Number_TextBox.Text = Admin_Config.Student_Number;
            Dept_ID_TextBox.Text = Admin_Config.Dept_ID;
            Dept_Name_TextBox.Text = Admin_Config.Dept_Name;
            Address1_TextBox.Text = Admin_Config.Address[0];
            Address2_TextBox.Text = Admin_Config.Address[1];
            Tell_TextBox.Text = Admin_Config.Tell;

            if (Admin_Config.Email == "")
            {
                Email1_TextBox.Text = "";
            }
            else
            { 
                int Email_index = Admin_Config.Email.LastIndexOf('@');
                Email1_TextBox.Text = Admin_Config.Email.Substring(0, Email_index);
                Email2_TextBox.Text = Admin_Config.Email.Substring(Email_index + 1);
            }
        }

        

       
    }
}
