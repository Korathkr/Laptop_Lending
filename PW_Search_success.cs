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
    public partial class PW_Search_success : Form
    {
        public static String[] PW_QA = new string[3];
        public String PW_A;
        public PW_Search_success()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        /// <summary>
        /// 비밀번호 찾기 답변 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PW_Check_A_TextBox_TextChanged(object sender, EventArgs e)
        {
            PW_A = PW_Check_A_TextBox.Text;
        }

        /// <summary>
        /// 확인 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Btn_Click(object sender, EventArgs e)
        {
            // 입력한 질문과 DB에 있는 질문이 일치하지 않을 경우
            if(PW_A != PW_QA[2])
            {
                MessageBox.Show("비밀번호 찾기 답변이 일치하지 않습니다.", "오류");
            }
            else
            {
                // 비밀번호 재설정으로 이동
                MessageBox.Show("비밀번호 재설정 화면으로 이동합니다.", "확인 완료");
                PW_Reset r = new PW_Reset();
                this.Close();
                r.Show();
            }
        }

        // 폼이 로드되어 메모리에 올라올 때, 화면에 표시되기 직전에 발생
        private void PW_Search_success_Load(object sender, EventArgs e)
        {
            // 비밀번호 찾기 질문
            if (PW_QA[0] == "")
            {
                PW_Check_Q_TextBox.Text = $"{PW_QA[1]}";
            }
            else
            {
                PW_Check_Q_TextBox.Text = $"{PW_QA[0]}";
            }
        }
    }
}
