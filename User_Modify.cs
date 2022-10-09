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
    public partial class User_Modify : Form
    {
        public String Dept_ID;
        public String Dept_Name;
        public String Address1;
        public String Address2;
        public String Tell;
        public String Email1;
        public String Email2;
        public String[] PW_Q = new String[2];
        public String PW_A;

        public User_Modify()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 학과 이름 텍스트 박스(수정불가)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dept_ID_TextBox_TextChanged(object sender, EventArgs e)
        {
            User_Modify_config.Dept_ID = Dept_ID_TextBox.Text;
        }

        /// <summary>
        /// 전공 입력 텍스트 박스(수정가능)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dept_Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            User_Modify_config.Dept_Name = Dept_Name_TextBox.Text;
        }

        /// <summary>
        /// 주소 입력 텍스트 박스(수정가능)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Address1_TextBox_TextChanged(object sender, EventArgs e)
        {
            User_Modify_config.Address1 = Address1_TextBox.Text;
        }

        /// <summary>
        /// 상세 주소 입력 텍스트 박스(수정가능)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Address2_TextBox_TextChanged(object sender, EventArgs e)
        {
            User_Modify_config.Address2 = Address2_TextBox.Text;
        }

        /// <summary>
        /// 전화번호 입력 텍스트 박스(수정가능)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tell_TextBox_TextChanged(object sender, EventArgs e)
        {
            User_Modify_config.TELL = Tell_TextBox.Text;
        }

        /// <summary>
        /// 비밀번호 찾기 질문 콤보박스(수정가능)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PW_Check_Q_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PW_Q[0] = PW_Check_Q_ComboBox.Text;
            User_Modify_config.PW_Q[0] = PW_Q[0];
            if (PW_Q[0] == "직접입력")
            {
                PW_Check_Q_TextBox.ReadOnly = false;
            }
            else
            {
                PW_Check_Q_TextBox.ReadOnly = true;
            }
        }

        /// <summary>
        /// 비밀번호 찾기 질문 직접입력(수정가능)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PW_Check_Q_TextBox_TextChanged(object sender, EventArgs e)
        {
            PW_Q[1] = PW_Check_Q_TextBox.Text;
            User_Modify_config.PW_Q[1] = PW_Q[1];
        }

        /// <summary>
        /// 비밀번호 답변 텍스트 박스(수정가능)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PW_Check_A_TextBox_TextChanged(object sender, EventArgs e)
        {
            PW_A = PW_Check_A_TextBox.Text;
            User_Modify_config.PW_A = PW_A;
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modifiy_OK_Btn_Click(object sender, EventArgs e)
        {       // 전공이름 ,       주소              상세주소          전화번호       이메일       이메일 도메인    비밀번호 질문     비밀번호 답변                               
            if (Dept_ID == "" || Address1 == "" || Address2 == "" || Tell == "" || Email1 == "" || Email2 == "" || PW_Q[0] == "" || PW_A == "")
            {
                MessageBox.Show("공백인 항목이 있습니다.", "오류");
            }
            else
            {
                User_Modify_config.Email = Email1 + "@" + Email2;

            if (DBMySql.User_Modify_SQL() == true)
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            Dept_ID_TextBox.Text = "";
            Dept_Name_TextBox.Text = "";
            Address1_TextBox.Text = "";
            Address2_TextBox.Text = "";
            Tell_TextBox.Text = "";
            Email1_TextBox.Text = "";
            PW_Check_A_TextBox.Text = "";
            PW_Check_Q_ComboBox.Text = "";
            PW_Check_Q_TextBox.Text = "";
        }

        /// <summary>
        /// 취소 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Modifiy_Load(object sender, EventArgs e)
        {
            // Users, UserInformation 테이블에 있는 유저 정보를 호출
            DBMySql.User_info();
            ID_TextBox.Text = User_Modify_config.ID;
            Name_TextBox.Text = User_Modify_config.Name;
            BirthDay_TextBox.Text = User_Modify_config.BirthDay.Substring(0, 10);
            Student_Number_TextBox.Text = User_Modify_config.Student_Number;
            Dept_ID_TextBox.Text = User_Modify_config.Dept_ID;
            Dept_Name_TextBox.Text = User_Modify_config.Dept_Name;
            Address1_TextBox.Text = User_Modify_config.Address1;
            Address2_TextBox.Text = User_Modify_config.Address2;
            
            if (User_Modify_config.Email == "")
            {
                Email1_TextBox.Text = "";
            }
            else
            { 
                int Email_index = User_Modify_config.Email.LastIndexOf('@');
                Email1_TextBox.Text = User_Modify_config.Email.Substring(0, Email_index);
                Email2_TextBox.Text = User_Modify_config.Email.Substring(Email_index + 1);
            }
            Tell_TextBox.Text = User_Modify_config.TELL;
            if (User_Modify_config.PW_Q[0] == "직접입력")
            {
                PW_Check_Q_TextBox.ReadOnly = false;
                PW_Check_Q_ComboBox.Text = User_Modify_config.PW_Q[0];
                PW_Check_Q_TextBox.Text = User_Modify_config.PW_Q[1];
                PW_Check_A_TextBox.Text = User_Modify_config.PW_A;
            }
            else
            {
                PW_Check_Q_ComboBox.Text = User_Modify_config.PW_Q[0];
                PW_Check_A_TextBox.Text = User_Modify_config.PW_A;
            }
        }

        
    }
}
