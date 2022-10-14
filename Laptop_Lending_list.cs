using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public partial class Laptop_Lending_list : Form
    {

        public Laptop_Lending_list()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            Laptop_Lending_list_SQL();
            // 모든 열 사이즈 자동 조정
            Laptop_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// 노트북 대여 기록 조회 메서드
        /// </summary>
        public void Laptop_Lending_list_SQL()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"SELECT * FROM USERS_LAPTOP_LENDING WHERE Student_Number = '{DBMySql.Student_Number}'";

                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Query, connection);
                    MySqlDataReader table = command.ExecuteReader();

                    int i = 0;
                    while (table.Read())
                    {
                        // 리스트 생성
                        ListViewItem list = new ListViewItem((++i).ToString());
                        // 이름 
                        list.SubItems.Add(table["Name"].ToString());
                        // 학번
                        list.SubItems.Add(table["Student_Number"].ToString());
                        // 신청 날짜 변환
                        String A_Date = table["Application_Date"].ToString();
                        list.SubItems.Add(A_Date.Substring(0, 10));
                        // 대여 날짜 변환
                        String Rental_Date = table["Rental_Date"].ToString();
                        list.SubItems.Add(Rental_Date.Substring(0, 10));
                        // 반납 날짜 변환
                        String Return_Date = table["Return_Date"].ToString();
                        list.SubItems.Add(Return_Date.Substring(0, 10));
                        // 노트북 기종
                        list.SubItems.Add(table["LAPTOP_TYPE"].ToString());
                        // 승인 여부
                        list.SubItems.Add(table["Approval"].ToString());
                        // 반납 여부
                        list.SubItems.Add(table["Return_status"].ToString());
                        // 리스트에 추가
                        Laptop_list.Items.Add(list);
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message, "오류!!");
            }
        }
    }
}
