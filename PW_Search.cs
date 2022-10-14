using System;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public partial class PW_Search : Form
    {
        public String ID = "";
        public String Name = "";
        public String Student_Number = "";
        public String[] PW_QA = new string[2];
        RegexClass regexclass = new RegexClass();

        public PW_Search()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        /// <summary>
        /// 아이디 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ID_TextBox_TextChanged(object sender, EventArgs e)
        {
            ID = ID_TextBox.Text;
        }

        /// <summary>
        /// 성명 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            Name = Name_TextBox.Text;
        }

        /// <summary>
        /// 학번 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Student_Number_TextBox_TextChanged(object sender, EventArgs e)
        {
            Student_Number = Student_Number_TextBox.Text;
        }

        /// <summary>
        /// 확인 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Btn_Click(object sender, EventArgs e)
        {
            if (ID == "" || Name == "")
            {
                MessageBox.Show("공백인 항목이 있습니다.");
            }
            else if (!regexclass.Student_Number_Regex(Student_Number))
            {
                MessageBox.Show("학번을 정확히 입력해주세요.");
            }
            else
            {
                PW_QA = DBMySql.PW_Search(ID, Name, Student_Number);
                if (PW_QA == null)
                {
                    MessageBox.Show("입력하신 정보가 올바르지 않습니다.", "오류");
                }
                else
                {
                    PW_Search_success pw = new PW_Search_success();
                    PW_Search_success.PW_QA[0] = PW_QA[0];
                    PW_Search_success.PW_QA[1] = PW_QA[1];
                    PW_Search_success.PW_QA[2] = PW_QA[2];
                    PW_Reset.ID = ID;
                    this.Close();
                    pw.Show();
                }
            }
        }

        /// <summary>
        /// 취소 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("비밀번호 찾기를 취소하시겠습니까?", "비밀번호 찾기", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
