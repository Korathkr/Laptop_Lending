using MySql.Data.MySqlClient;
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
    public partial class Laptop_Lending_list : Form
    {

        public Laptop_Lending_list()
        {
            InitializeComponent();
            Laptop_Lending_list_SQL();
        }

        /// <summary>
        /// 노트북 대여 목록
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

                    int idx = 0;
                    while (table.Read())
                    {
                        ListViewItem list = new ListViewItem((++idx).ToString());
                        list.SubItems.Add(table["Name"].ToString());
                        list.SubItems.Add(table["Student_Number"].ToString());
                        list.SubItems.Add(table["Application_Date"].ToString());
                        list.SubItems.Add(table["Rental_Date"].ToString());
                        list.SubItems.Add(table["Return_Date"].ToString());
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
