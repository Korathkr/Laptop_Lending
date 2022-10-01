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
    public partial class ID_Search_success : Form
    {
        public static string return_ID = "";
        public ID_Search_success()
        {
            InitializeComponent();
            this.ControlBox = false;
            ID.Text = $"입력하신 정보의 아이디(ID)는 '{return_ID}'입니다.";
        }

        private void OK_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
