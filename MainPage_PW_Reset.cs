using System;
using System.Drawing;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public partial class MainPage_PW_Reset : Form
    {
        public String PW;
        public String PW_Re;
        public String PW_Check;
        public String PW_Regex_Check;
        public static String ID;
        RegexClass regexclass = new RegexClass();

        public MainPage_PW_Reset()
        {
            InitializeComponent();
        }
        /* 개인정보보호 내부관리계획 
           *  제4장 개인정보의 기술적·관리적 보호조치
           *   제13조(비밀번호의 관리) 
           *    - 최소 10자리 이상 : 영어 대문자, 소문자, 숫자, 특수문자 중 2종류의 조합
           *    - 최소  8자리 이상 : 영어 대문자, 소문자, 숫자, 특수문자 중 3종류의 조합
        */
        /// <summary>
        /// 새 비밀번호 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_PW_TextChanged(object sender, EventArgs e)
        {
            PW = New_PW.Text;
        }

        /// <summary>
        /// 새 비밀번호 입력 확인 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_PW_Check_TextChanged(object sender, EventArgs e)
        {
            PW_Re = New_PW_Check.Text;
            if (PW == PW_Re)
            {
                PW_label.ForeColor = Color.Blue;
                PW_label.Text = "OK";
                PW_Check = "OK";
            }
            else
            {
                PW_label.ForeColor = Color.Red;
                PW_label.Text = "NO";
                PW_Check = "NO";
            }
        }

        /// <summary>
        /// 확인 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Btn_Click(object sender, EventArgs e)
        {
            if (PW == "" || PW_Re == "")
            {
                MessageBox.Show("공백이 있습니다.", "오류");
            }
            else
            {
                if (regexclass.PW_Regex(PW) == false)
                {
                    MessageBox.Show("소문자 또는 대문자 하나, 숫자 하나가 포함되어야 합니다.\n(8글자 이상 12글자 이하)", "오류");
                    PW_Check = "NO";
                }
                else if (regexclass.PW_Regex(PW) == true)
                {
                    PW_Regex_Check = "OK";
                }
                if (PW_Check == "NO" || PW_Regex_Check == "NO")
                {
                    MessageBox.Show("비밀번호를 다시 확인해주세요.", "오류");
                }
                if (PW_Check == "OK" && PW_Regex_Check == "OK")
                {
                    if (DBMySql.PW_Reset(PW, ID) == true)
                    {
                        MessageBox.Show("비밀번호 변경 완료.");
                        this.Close();
                    }
                }
            }
        }
    }
}
