using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    class Admin_DBMySql
    {
        /// <summary>
        /// ID 삭제 SQL
        /// </summary>
        public static void ID_DELETE_SQL()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query1 = $"DELETE FROM USERS WHERE STUDENT_NUMBER = '{Admin_Config.Student_Number}'";
                    String Query2 = $"DELETE FROM USERS_INFORMATION WHERE STUDENT_NUMBER = '{Admin_Config.Student_Number}'";
                    String Query3 = $"DELETE FROM USERS_LAPTOP_LENDING WHERE STUDENT_NUMBER = '{Admin_Config.Student_Number}'";
                    connection.Open();

                    DialogResult dr = MessageBox.Show("정말 삭제하시겠습니까?", "삭제", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                    {
                        MySqlCommand command1 = new MySqlCommand(Query1, connection);
                        MySqlCommand command2 = new MySqlCommand(Query2, connection);
                        MySqlCommand command3 = new MySqlCommand(Query3, connection);
                        if (command1.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1 && command3.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("삭제가 완료되었습니다.", "삭제 완료");
                        }
                        else
                        {
                            MessageBox.Show("삭제에 실패했습니다.", "삭제 실패");
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message);
            }
        }

        /// <summary>
        /// ID 정보 SQL
        /// </summary>
        public static void User_info()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Users_Query = $"SELECT * FROM USERS_INFORMATION WHERE Student_Number = '{Admin_Config.Student_Number}'";
                    String User_Laptop_Lending_Query = $"SELECT * FROM USERS_LAPTOP_LENDING WHERE Student_Number = '{Admin_Config.Student_Number}'";

                    connection.Open();

                    MySqlCommand command1 = new MySqlCommand(Users_Query, connection);
                    MySqlCommand command2 = new MySqlCommand(User_Laptop_Lending_Query, connection);

                    MySqlDataReader table1 = command1.ExecuteReader();

                    String Rental_Date = "";
                    String Return_Date = "";
                    while (table1.Read())
                    {
                        Admin_Config.ID = table1["ID"].ToString();
                        Admin_Config.Name = table1["NAME"].ToString();
                        Admin_Config.Birth = table1["BIRTH"].ToString();
                        Admin_Config.Student_Number = table1["Student_Number"].ToString();
                        Admin_Config.Dept_ID = table1["DEPT_ID"].ToString();
                        Admin_Config.Dept_Name = table1["DEPT_NAME"].ToString();
                        Admin_Config.Address[0] = table1["ADDRESS1"].ToString();
                        Admin_Config.Address[1] = table1["ADDRESS2"].ToString();
                        Admin_Config.Tell = table1["TELL"].ToString();
                        Admin_Config.Email = table1["EMAIL"].ToString();
                    }
                    table1.Close();
                    MySqlDataReader table2 = command2.ExecuteReader();
                    while (table2.Read())
                    {
                        Admin_Config.Parent_Name = table2["Parent_Name"].ToString();
                        Admin_Config.Parent_Address = table2["Parent_Address"].ToString();
                        Admin_Config.Parent_Tell = table2["Parent_Tell"].ToString();
                        Rental_Date = table2["Rental_Date"].ToString();
                        Admin_Config.Rental_Date = Rental_Date.Substring(0, 10);
                        Return_Date = table2["Return_Date"].ToString();
                        Admin_Config.Return_Date = Return_Date.Substring(0, 10);
                        Admin_Config.Late = table2["Return_Date"].ToString();
                    }
                    if (table2.HasRows == false)
                    {
                        Admin_Config.Parent_Name = "";
                        Admin_Config.Parent_Address = "";
                        Admin_Config.Parent_Tell = "";
                        Admin_Config.Rental_Date = "";
                        Admin_Config.Return_Date = "";
                        Admin_Config.Late = "";
                    }
                    table2.Close();

                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message, "오류!!");
            }
        }

        /// <summary>
        /// ID 수정 SQL
        /// </summary>
        public static bool User_Modify_SQL()
        {
            bool Check = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Check_Query = $"SELECT * FROM USERS_LAPTOP_LENDING WHERE STUDENT_NUMBER = '{Admin_Config.Student_Number}'";
                    String Users_Information_Query = $"UPDATE USERS_INFORMATION SET ID = '{Admin_Config.ID}', NAME = '{Admin_Config.Name}', BIRTH = '{Admin_Config.Birth.Substring(0, 10)}', STUDENT_NUMBER = '{Admin_Config.Student_Number}', DEPT_ID = '{Admin_Config.Dept_ID}', DEPT_NAME = '{Admin_Config.Dept_Name}', ADDRESS1 = '{Admin_Config.Address[0]}', ADDRESS2 = '{Admin_Config.Address[1]}', TELL = '{Admin_Config.Tell}', EMAIL = '{Admin_Config.Email}' WHERE Student_Number = '{Admin_Config.Student_Number}'";
                    String Users_Query = $"UPDATE USERS SET ID = '{Admin_Config.ID}', NAME = '{Admin_Config.Name}', BIRTH = '{Admin_Config.Birth.Substring(0,10)}', PASSWORD_QUESTION1 = '비밀번호 재설정 답변', PASSWORD_QUESTION2 = '', PASSWORD_ANSWER = '1234' WHERE Student_Number = '{Admin_Config.Student_Number}'";
                    String Users_laptop_lending = $"UPDATE USERS_LAPTOP_LENDING SET NAME = '{Admin_Config.Name}', TELL = '{Admin_Config.Tell}', Email = '{Admin_Config.Email}', Address = '{Admin_Config.Address}' WHERE STUDENT_NUMBER = '{Admin_Config.Student_Number}'";
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Check_Query, connection);

                    if (command.ExecuteNonQuery() != 1)
                    {
                        MySqlCommand command1 = new MySqlCommand(Users_Information_Query, connection);
                        MySqlCommand command2 = new MySqlCommand(Users_Query, connection);
                        if (command1.ExecuteNonQuery() != 1 || command2.ExecuteNonQuery() != 1)
                        {
                            Check = false;
                        }
                        else
                        {
                            Check = true;
                            MessageBox.Show("비밀번호 답변이 초기화 되었습니다.\n 초기화된 답변은 '1234'입니다.", "비밀번호");
                        }
                    }
                    else
                    {
                        MySqlCommand command1 = new MySqlCommand(Users_Information_Query, connection);
                        MySqlCommand command2 = new MySqlCommand(Users_Query, connection);
                        MySqlCommand command3 = new MySqlCommand(Users_laptop_lending, connection);
                        if (command1.ExecuteNonQuery() != 1 || command2.ExecuteNonQuery() != 1 || command3.ExecuteNonQuery() != 1)
                        {
                            Check = false;
                        }
                        else
                        {
                            Check = true;
                            MessageBox.Show("비밀번호 답변이 초기화 되었습니다.\n 초기화된 답변은 '1234'입니다.", "비밀번호");
                        }
                    }           
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message, "오류!!");
            }
            return Check;
            Admin_ID_Management i = new Admin_ID_Management();
            i.ID_Management_SQL();
        }

        /// <summary>
        /// 노트북 대여 승인 SQL
        /// </summary>
        public static void User_Laptop_Approval_SQL()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"UPDATE USERS_LAPTOP_LENDING SET APPROVAL = '승인' WHERE STUDENT_NUMBER = '{Admin_Approval.student_number}'";
                    connection.Open();

                    DialogResult dr = MessageBox.Show("승인하시겠습니까?", "승인", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                    {
                        if (Admin_Approval.approval == "승인")
                        {
                            MessageBox.Show("이미 승인되었습니다.", "승인 오류");
                        }
                        else
                        {
                            MySqlCommand command = new MySqlCommand(Query, connection);

                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("승인 완료되었습니다.", "승인 완료");
                            }
                            else
                            {
                                MessageBox.Show("승인에 실패했습니다.", "승인 실패");
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message);
            }
        }

        /// <summary>
        /// 노트북 대여 승인 취소 SQL
        /// </summary>
        public static void User_Laptop_Approval_Cancle_SQL()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"UPDATE USERS_LAPTOP_LENDING SET APPROVAL = '미승인' WHERE STUDENT_NUMBER = '{Admin_Approval.student_number}'";
                    connection.Open();

                    DialogResult dr = MessageBox.Show("승인 취소하시겠습니까?", "승인 취소", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                    {
                        if (Admin_Approval.approval == "미승인")
                        {
                            MessageBox.Show("이미 미승인되었습니다.", "승인 오류");
                        }
                        else
                        {
                            MySqlCommand command = new MySqlCommand(Query, connection);

                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("승인 취소되었습니다.", "승인 취소 완료");
                            }
                            else
                            {
                                MessageBox.Show("승인 취소에 실패했습니다.", "승인 취소 실패");
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류 내용 : " + e.Message);
            }
        }
    }
}
