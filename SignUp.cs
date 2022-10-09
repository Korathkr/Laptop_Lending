using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public partial class SignUp : Form
    {
        public bool Terms;

        // 아이디, 비밀번호, 학번 체크
        public bool ID_Check = false;
        public bool PW_Check = false;
        public bool Student_Number_Check = false;

        // 정규식 클래스 선언
        RegexClass regexclass = new RegexClass();
        public SignUp()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(ID_TextBox, "영문 또는 숫자 조합 10자리");
            toolTip1.SetToolTip(PW_TextBox, "8자리 이상 12자리 이하");
        }
        /// <summary>
        /// ID 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ID_TextBox_TextChanged(object sender, EventArgs e)
        {
            SignUp_config.ID = ID_TextBox.Text;
        }
        /// <summary>
        /// 아이디 중복 체크 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ID_Check_Btn_Click(object sender, EventArgs e)
        {
            ID_Check_Method();
        }
        /// <summary>
        /// 아이디 체크 메서드
        /// </summary>
        private void ID_Check_Method()
        {
            if (SignUp_config.ID == "")
            {
                ID_Check_Text.ForeColor = Color.Blue;
                MessageBox.Show("아이디를 입력해주세요.", "아이디 입력 오류");
            }
            else if (ID_TextBox.Text.Length < 5)
            {
                ID_Check_Text.ForeColor = Color.Red;
                ID_Check_Text.Text = "아이디는 5자리 이상으로 해주세요.";
            }
            else if (regexclass.ID_Regex(SignUp_config.ID) == false)
            {
                ID_Check_Text.ForeColor = Color.Red;
                ID_Check_Text.Text = "영문 또는 숫자 조합 최대 12자리까지 해주세요.";
            }
            else if (regexclass.ID_Regex(SignUp_config.ID) == true)
            {
                ID_Check = DBMySql.ID_Check(SignUp_config.ID);
                if (ID_Check == true)
                {
                    ID_Check_Text.ForeColor = Color.Blue;
                    ID_Check_Text.Text = "멋진 아이디네요!";
                }
            }
        }

        /// <summary>
        /// 이름 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            SignUp_config.Name = Name_TextBox.Text;
        }
        /// <summary>
        /// 약관 동의 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Terms_Agreed_CheckedChanged(object sender, EventArgs e)
        {
            Terms = Terms_Agreed.Checked;
        }
        /// <summary>
        /// 생일 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthDay_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SignUp_config.BirthDay = BirthDay_DateTimePicker.Value.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 학번 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Student_Number_TextBox_TextChanged(object sender, EventArgs e)
        {
            SignUp_config.Student_Number = Student_Number_TextBox.Text;
        }
        /// <summary>
        /// 학번 중복 체크 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Student_Number_Check_Click(object sender, EventArgs e)
        {
            if (Student_Number_TextBox.Text == "")
            {
                MessageBox.Show("학번을 입력해주세요.", "학번 입력 오류");
            }
            else if (!(regexclass.Student_Number_Regex(SignUp_config.Student_Number)))
            {
                MessageBox.Show("학번은 숫자 8자리 입니다.");
            }
            else
            {
                Student_Number_Check = DBMySql.Student_Number_Check(SignUp_config.Student_Number);
                if (Student_Number_Check == true)
                {
                    MessageBox.Show("학번 체크 완료");
                }
            }

        }
        /* 개인정보보호 내부관리계획 
           *  제4장 개인정보의 기술적·관리적 보호조치
           *   제13조(비밀번호의 관리) 
           *    - 최소 10자리 이상 : 영어 대문자, 소문자, 숫자, 특수문자 중 2종류의 조합
           *    - 최소  8자리 이상 : 영어 대문자, 소문자, 숫자, 특수문자 중 3종류의 조합
      * */
        /// <summary>
        /// 비밀번호 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PW_TextBox_TextChanged(object sender, EventArgs e)
        {
            SignUp_config.PW = PW_TextBox.Text;
            if (regexclass.PW_Regex(SignUp_config.PW) == false)
            {
                PW_label.ForeColor = Color.Red;
                PW_label.Text = "소문자 또는 대문자 하나, 숫자 하나가 포함되어야 함(8글자 이상 12글자 이하)";
                PW_Check = false;
            }
            else if (regexclass.PW_Regex(SignUp_config.PW) == true)
            {
                PW_label.ForeColor = Color.Blue;
                PW_label.Text = "Great!";
                PW_Check = true;
            }
        }
        /// <summary>
        /// 비밀번호 확인 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PW_Check_TextBox_TextChanged(object sender, EventArgs e)
        {
            SignUp_config.PW_Re = PW_Check_TextBox.Text;
            if (SignUp_config.PW_Re == SignUp_config.PW)
            {
                PW_Check_OK_TextBox.ForeColor = Color.Blue;
                PW_Check_OK_TextBox.Text = "비밀번호가 일치합니다.";
            }
            else
            {
                PW_Check_OK_TextBox.ForeColor = Color.Red;
                PW_Check_OK_TextBox.Text = "비밀번호가 일치하지 않습니다.";
            }
        }
 


        /// <summary>
        /// 비밀번호 분실 시 질문 목록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PW_Check_Q_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PW_Check_Q_ComboBox.Text == "직접입력")
            {
                PW_Check_Q_TextBox.ReadOnly = false;
            }
            else
            {
                PW_Check_Q_TextBox.ReadOnly = true;
                SignUp_config.PW_Q[0] = PW_Check_Q_ComboBox.Text;
            }
        }
        /// <summary>
        /// 비밀번호 분실 시 직접입력하는 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PW_Check_Q_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (PW_Check_Q_ComboBox.Text == "직접입력")
            {
                SignUp_config.PW_Q[1] = PW_Check_Q_TextBox.Text;
            }
        }

        /// <summary>
        /// 비밀번호 분실 시 답변
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PW_Check_A_TextBox_TextChanged(object sender, EventArgs e)
        {
            SignUp_config.PW_A = PW_Check_A_TextBox.Text;
        }

        /// <summary>
        /// 회원가입 완료 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUp_OK_Btn_Click(object sender, EventArgs e)
        {
            if (SignUp_config.ID == "" || SignUp_config.PW == "" || SignUp_config.Name == "" || SignUp_config.BirthDay == "" || SignUp_config.Student_Number == null || SignUp_config.PW_Q[0] == "" || SignUp_config.PW_Q[1] == "" || SignUp_config.PW_A == "")
            {
                MessageBox.Show("공백인 항목이 있습니다.");
            }
            if (ID_Check != true)
            {
                MessageBox.Show("아이디 중복체크를 하지 않았습니다.");
            }
            else if (PW_Check != true)
            {
                MessageBox.Show("비밀번호 중복체크를 하지 않았습니다.");
            }
            else if (Student_Number_Check != true)
            {
                MessageBox.Show("학번 중복체크를 하지 않았습니다.");
            }
            else if (Terms == false)
            {
                MessageBox.Show("약관 동의를 하셔야 서비스 이용이 가능합니다.");
            }
            else if (BirthDay_DateTimePicker.Value == DateTime.Now)
            {
                MessageBox.Show("생일을 정확히 입력해주세요.");
            }
            else
            {
                if (DBMySql.SQL() == true)
                {
                    this.Close();
                }
            }
        }
        /// <summary>
        /// 다시입력 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            ID_TextBox.Text = "";
            Name_TextBox.Text = "";
            PW_Check_A_TextBox.Text = "";
            PW_Check_Q_TextBox.Text = "";
            PW_Check_Q_ComboBox.Text = "";
            PW_TextBox.Text = "";
            PW_Check_TextBox.Text = "";
            Student_Number_TextBox.Text = "";
            BirthDay_DateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// 취소 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("ID 신청을 취소하시겠습니까?", "ID 신청", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
