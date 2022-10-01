using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public class DBMySql : Form
    {
        public static String ID;
        public static String PW;
        public static String DB_ID;
        public static String DB_PW;
        public static String DB_Name;
        public static String Student_Number;

        /// <summary>
        /// 로그인 체크하는 SQL 메서드
        /// </summary>
		public static bool Login_SQL()
        {
            bool check = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"SELECT * FROM USERS WHERE ID = '{ID}' AND PASSWORD = '{PW}'";
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Query, connection);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        DB_ID = table["ID"].ToString();
                        DB_PW = table["PASSWORD"].ToString();
                        DB_Name = table["Name"].ToString();
                        Student_Number = table["Student_Number"].ToString();
                    }
                }
                if (ID != DB_ID && PW != DB_PW)
                {
                    MessageBox.Show("아이디와 비밀번호가 틀립니다.", "로그인 오류");
                    check = false;
                }
                else if (ID != DB_ID)
                {
                    MessageBox.Show("아이디가 틀립니다.", "로그인 오류");
                    check = false;
                }
                else if (PW != DB_PW)
                {
                    MessageBox.Show("비밀번호가 틀립니다.", "로그인 오류");
                    check = false;
                }
                if (ID == DB_ID && PW == DB_PW)
                {
                    MessageBox.Show($"{DB_Name}님 환영합니다!", "로그인");
                    check = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message, "오류!!");
            }
            return check;
        }

        /// <summary>
        /// ID 중복체크하는 SQL 메서드
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static String ID_Check(String ID)
        {
            String id_check = "";
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"SELECT * FROM USERS WHERE ID = '{ID}'";
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Query, connection);
                    MySqlDataReader table = command.ExecuteReader();

                    if (table.HasRows)
                    {
                        MessageBox.Show("해당 아이디는 사용 중입니다.", "아이디 중복");
                        id_check = "NO";

                    }
                    else
                    {
                        MessageBox.Show("사용 가능한 아이디 입니다!!!", "사용 가능");
                        id_check = "OK";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message, "오류!!");
            }
            return id_check;
        }

        /// <summary>
        /// 학번 중복체크하는 SQL 메서드
        /// </summary>
        /// <param name="Student_Number"></param>
        /// <returns></returns>
        public static String Student_Number_Check(String Student_Number)
        {
            String student_number_check = "";
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"SELECT * FROM USERS WHERE Student_Number = '{Student_Number}'";
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Query, connection);
                    MySqlDataReader table = command.ExecuteReader();

                    if (table.HasRows)
                    {
                        MessageBox.Show("이미 존재하는 학번입니다.", "학번 중복");
                        student_number_check = "NO";

                    }
                    else
                    {
                        student_number_check = "OK";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message, "오류!!");
            }
            return student_number_check;
        }

        /// <summary>
        /// 아이디 찾기 SQL 메서드
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="BirthDay"></param>
        /// <param name="Student_Number"></param>
        /// <returns></returns>
        public static String ID_Search(String Name, String BirthDay, String Student_Number)
        {
            String ID = "";
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"SELECT ID FROM USERS WHERE Name = '{Name}' AND Birth = '{BirthDay}' AND Student_Number = '{Student_Number}'";
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Query, connection);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        ID = table["ID"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message, "오류!!");
            }
            return ID;
        }

        /// <summary>
        /// 비밀번호 찾기 SQL 메서드
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Name"></param>
        /// <param name="Student_Number"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static String[] PW_Search(String ID, String Name, String Student_Number)
        {
            String[] PW_QA = new String[2];
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"SELECT PASSWORD_QUESTION, PASSWORD_ANSWER FROM USERS WHERE ID = '{ID}' AND Name = '{Name}' AND Student_Number = '{Student_Number}'";
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Query, connection);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        PW_QA[0] = table["PASSWORD_QUESTION"].ToString();
                        PW_QA[1] = table["PASSWORD_ANSWER"].ToString();
                    }
                    if (!table.HasRows)
                    {
                        PW_QA = null;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message, "오류!!");
            }
            return PW_QA;
        }

        /// <summary>
        /// 비밀번호 재설정 SQL 메서드
        /// </summary>
        /// <param name="PW"></param>
        public static bool PW_Reset(String PW, String ID)
        {
            bool Check = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"UPDATE USERS SET PASSWORD = '{PW}' WHERE ID = '{ID}'";
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Query, connection);
                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to insert data.");
                        Check = false;
                    }
                    else
                    {
                        Check = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message, "오류!!");
            }
            return Check;
        }

        /// <summary>
        /// 개인정보 수정 기본 정보를 불러오는 SQL 메서드
        /// </summary>
        public static void User_info()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Users_Query = $"SELECT * FROM USERS_INFORMATION WHERE ID = '{ID}'";

                    connection.Open();

                    MySqlCommand command1 = new MySqlCommand(Users_Query, connection);

                    MySqlDataReader table1 = command1.ExecuteReader();


                    while (table1.Read())
                    {
                        User_Modify_config.ID = table1["ID"].ToString();
                        User_Modify_config.Name = table1["NAME"].ToString();
                        User_Modify_config.BirthDay = table1["BIRTH"].ToString();
                        User_Modify_config.Student_Number = table1["Student_Number"].ToString();
                        User_Modify_config.Dept_ID = table1["DEPT_ID"].ToString();
                        User_Modify_config.Dept_Name = table1["DEPT_NAME"].ToString();
                        User_Modify_config.Address1 = table1["ADDRESS1"].ToString();
                        User_Modify_config.Address2 = table1["ADDRESS2"].ToString();
                        User_Modify_config.TELL = table1["TELL"].ToString();
                        User_Modify_config.Email = table1["EMAIL"].ToString();
                    }
                    connection.Close();
                }
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Users_Information_Query = $"SELECT * FROM USERS WHERE ID = '{ID}'";
                    connection.Open();
                    MySqlCommand command2 = new MySqlCommand(Users_Information_Query, connection);
                    MySqlDataReader table2 = command2.ExecuteReader();
                    while (table2.Read())
                    {
                        User_Modify_config.PW_Q[0] = table2["PASSWORD_QUESTION1"].ToString();
                        User_Modify_config.PW_Q[1] = table2["PASSWORD_QUESTION2"].ToString();
                        User_Modify_config.PW_A = table2["PASSWORD_ANSWER"].ToString();
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message, "오류!!");
            }
        }

        /// <summary>
        /// 개인정보 수정하는 메서드
        /// </summary>
        public static bool User_Modify_SQL()
        {
            bool Check = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    
                    String Users_Information_Query = $"UPDATE USERS_INFORMATION SET ID = '{User_Modify_config.ID}', NAME = '{User_Modify_config.Name}', BIRTH = '{User_Modify_config.BirthDay.Substring(0, 10)}', STUDENT_NUMBER = '{User_Modify_config.Student_Number}', DEPT_ID = '{User_Modify_config.Dept_ID}', DEPT_NAME = '{User_Modify_config.Dept_Name}', ADDRESS1 = '{User_Modify_config.Address1}', ADDRESS2 = '{User_Modify_config.Address2}', TELL = '{User_Modify_config.TELL}', EMAIL = '{User_Modify_config.Email}' WHERE ID = '{ID}'";
                    String Users_Query = $"UPDATE USERS SET PASSWORD_QUESTION1 = '{User_Modify_config.PW_Q[0]}', PASSWORD_QUESTION2 = '{User_Modify_config.PW_Q[1]}', PASSWORD_ANSWER = '{User_Modify_config.PW_A}' WHERE ID = '{ID}'";
                    connection.Open();
                    
                    MySqlCommand command1 = new MySqlCommand(Users_Information_Query, connection);
                    MySqlCommand command2 = new MySqlCommand(Users_Query, connection);
                    if (command1.ExecuteNonQuery() != 1 || command2.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to insert data.");
                        Check = false;
                    }
                    else
                    {
                        Check = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message, "오류!!");
            }
            return Check;
        }

        /// <summary>
        /// 노트북 대여 메서드
        /// </summary>
        /// <returns></returns>
        public static bool Laptop_Lending_SQL()
        {
            bool Check = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query1 = $"INSERT INTO `USERS_LAPTOP_LENDING` (STUDENT_NUMBER, NAME, TELL, EMAIL, ADDRESS, PARENT_NAME, PARENT_TELL, PARENT_ADDRESS, RENTAL_DATE, RETURN_DATE, APPLICATION_DATE) VALUES ('{Laptop_Lending_config.Student_Number}', '{Laptop_Lending_config.Name}', '{Laptop_Lending_config.TELL}', '{Laptop_Lending_config.Email}', '{Laptop_Lending_config.Address}', '{Laptop_Lending_config.Parent_Name}', '{Laptop_Lending_config.Parent_TELL}', '{Laptop_Lending_config.Parent_Address}',  '{Laptop_Lending_config.Rental_Date}', '{Laptop_Lending_config.Return_Date}', '{Laptop_Lending_config.Application_Date}')";
                   // String Query2 = $"UPDATE `USERS_LAPTOP_LENDING` SET = '{Laptop_Lending_config.Student_Number}', '{Laptop_Lending_config.Name}', '{Laptop_Lending_config.TELL}', '{Laptop_Lending_config.Email}', '{Laptop_Lending_config.Address}', '{Laptop_Lending_config.Parent_Name}', '{Laptop_Lending_config.Parent_TELL}', '{Laptop_Lending_config.Parent_Address}',  '{Laptop_Lending_config.Rental_Date}', '{Laptop_Lending_config.Return_Date}', '{Laptop_Lending_config.Application_Date}' WHERE ID = '{ID}'";
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Query1, connection);
                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to insert data.");
                        Check = false;
                    }
                    else
                    {
                        Check = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message);
            }   
            return Check;
        }
    }
}
