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
    public partial class Laptop_Lending : Form
    {
        public Laptop_Lending()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        /// <summary>
        /// 학번 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Student_Number_TextBox_TextChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.Student_Number = Student_Number_TextBox.Text;
        }

        /// <summary>
        /// 성명 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.Name = Name_TextBox.Text;
        }

        /// <summary>
        /// 전화번호 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tell_TextBox_TextChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.TELL = Tell_TextBox.Text;
        }

        /// <summary>
        /// 이메일 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Email_TextBox_TextChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.Email = Email_TextBox.Text;
        }

        /// <summary>
        /// 주소 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Address_TextBox_TextChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.Address = Address_TextBox.Text;
        }

        /// <summary>
        /// 보호자 성함 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Parent_Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.Parent_Name = Parent_Name_TextBox.Text;
        }

        /// <summary>
        /// 보호자 휴대폰 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Parent_Tell_TextBox_TextChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.Parent_TELL = Parent_Tell_TextBox.Text;
        }

        /// <summary>
        /// 보호자 주소 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Parent_Address_TextBox_TextChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.Parent_Address = Parent_Address_TextBox.Text;
        }
        /// <summary>
        /// 대여 날짜 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rental_date_ValueChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.Rental_Date = rental_date.Value.ToString("yyyy-MM-dd");
        }
        /// <summary>
        /// 반납 날짜 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void return_date_ValueChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.Return_Date = return_date.Value.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 신청 날짜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_date_ValueChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.Application_Date = Application_date.Value.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 신청자 이름 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Name_TextChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.Application_Name = Application_Name.Text;
        }

        /// <summary>
        /// 보호자 성함 입력 텍스트 박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Parent_Name_TextChanged(object sender, EventArgs e)
        {
            Laptop_Lending_config.Application_Parent_Name = Application_Parent_Name.Text;
        }

        /// <summary>
        /// 신청 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Btn_Click(object sender, EventArgs e)
        {
            if(agree_btn.Checked == false || disagree_btn.Checked == true)
            {
                MessageBox.Show("개인정보 동의를 하셔야 대여가 가능합니다.", "오류");
            }
            else if(Rental_Btn.Checked == false || Return_Btn.Checked == false)
            {
                MessageBox.Show("대여 물품 또는 반납 물품을 확인해주세요.", "오류");
            }
            else if(Application_Name.Text != Name_TextBox.Text)
            {
                MessageBox.Show("신청자 이름을 확인해주세요.", "오류");
            }
            else if(Application_Parent_Name.Text != Parent_Name_TextBox.Text)
            {
                MessageBox.Show("보호자 성함을 확인해주세요.", "오류");
            }
            else
            {
                Laptop_Lending_config.Student_Number = Student_Number_TextBox.Text;
                Laptop_Lending_config.Name = Name_TextBox.Text;
                Laptop_Lending_config.TELL = Tell_TextBox.Text;
                Laptop_Lending_config.Email = Email_TextBox.Text;
                Laptop_Lending_config.Address = Address_TextBox.Text;
                if(DBMySql.Laptop_Lending_Check_SQL() == true)
                {
                    if(DBMySql.Laptop_Lending_SQL() == true)
                    {
                        MessageBox.Show("신청이 완료되었습니다.", "신청완료");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("이미 대여 내역이 있거나, 승인 대기 중입니다.", "오류");
                }
            }
        }

        /// <summary>
        /// 해당 폼이 로드되고 화면에 표시되기 전 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Labtop_Lending_Load(object sender, EventArgs e)
        {
            // 날짜 초기화
            Application_date.Value = DateTime.Now;
            rental_date.Value = DateTime.Now;
            return_date.Value = DateTime.Now;

            // 개인정보에 있는 값을 가져옴
            DBMySql.User_info();
            Student_Number_TextBox.Text = User_Modify_config.Student_Number;
            Name_TextBox.Text = User_Modify_config.Name;
            Tell_TextBox.Text = User_Modify_config.TELL;
            Email_TextBox.Text = User_Modify_config.Email;
            Address_TextBox.Text = User_Modify_config.Address1 + " " + User_Modify_config.Address2;
        }
    }
}
