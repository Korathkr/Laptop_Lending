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
    public partial class ID_Search : Form
    {
        // 아이디 찾기 : 이름, 생일, 학번
        public String Name = "";
        public String BirthDay = "";
        public String Student_Number = "";

        RegexClass regexclass = new RegexClass();
        public ID_Search()
        {
            InitializeComponent();
            this.ControlBox = false;
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
        /// 생일 입력 달력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthDay_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            BirthDay = BirthDay_DateTimePicker.Value.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 학번 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Student_Number_TextChanged(object sender, EventArgs e)
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
            if (Name == "" || BirthDay == "")
            {
                MessageBox.Show("공백인 항목이 있습니다.");
            }
            else if (!regexclass.Student_Number_Regex(Student_Number))
            {
                MessageBox.Show("학번을 정확히 입력해주세요.");
            }
            else
            {
                ID_Search_success.return_ID = DBMySql.ID_Search(Name, BirthDay, Student_Number);
                if (ID_Search_success.return_ID == "")
                {
                    MessageBox.Show("입력하신 정보가 올바르지 않습니다.", "오류");
                }
                else
                {
                    ID_Search_success i = new ID_Search_success();
                    this.Close();
                    i.Show();
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
            DialogResult dr = MessageBox.Show("아이디 찾기를 취소하시겠습니까?", "ID 찾기", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
