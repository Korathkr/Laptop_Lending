using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public class SignUpSQL : Form
    {
        public static String ID;
        public static String PW;
        public static String Name;
        public static String BirthDay;
        public static String Student_Number;
        public static String[] PW_Q = new string[2];
        public static String PW_A;
        public static String OK = "";

        /// <summary>
        /// 회원가입 SQL 메서드
        /// </summary>
        /// <returns></returns>
        public static String SQL()
        {
            try
            {
                if (ID == "" || PW == "" || Name == "" || BirthDay == "" || Student_Number == null || PW_Q[0] == "" || PW_Q[1] == "" ||  PW_A == "")
                {
                    OK = "NO";
                    MessageBox.Show("공백인 항목이 있습니다.");
                    return OK;
                }
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    
                    String Query = $"INSERT INTO USERS VALUES ('{ID}', '{Name}', '{BirthDay}', '{Student_Number}', '{PW}', '{PW_Q[0]}', '{PW_Q[1]}', '{PW_A}')";
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Query, connection);
                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to insert data.");
                        OK = "NO";
                    }
                    else
                    {
                        MessageBox.Show("ID 신청이 완료되었습니다!");
                        OK = "OK";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message, "오류");
            }
            return OK;
        }
    }
}
