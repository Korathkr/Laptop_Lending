using MySql.Data.MySqlClient;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public partial class Admin_ID_Management : Form
    {
        String FilePath = "";
        String Name = "";
        public Admin_ID_Management()
        {
            InitializeComponent();
            ID_Management_SQL();
            // 모든 열 사이즈 자동 조정
            ID_Management_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// ID 검색 SQL 메서드
        /// </summary>
        public void ID_Search_SQL()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Search_Query = $"SELECT DISTINCT a.id, a.student_number, a.birth, b.ADDRESS1, b.ADDRESS2, b.email, b.tell, b.dept_id, b.dept_name, a.name " +
                    "FROM USERS AS a  " +
                    "INNER JOIN USERS_INFORMATION AS b " +
                    "ON a.student_number = b.student_number " +
                    $"WHERE a.Name Like '%{Name}%' " +
                    "ORDER BY Student_Number";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(Search_Query, connection);
                    MySqlDataReader table = command.ExecuteReader();

                    String[] Address = new string[2];
                    int i = 0;
                    while (table.Read())
                    {
                        i++;
                        // 리스트 생성
                        ListViewItem list = new ListViewItem(i.ToString());
                        list.SubItems.Add(table["ID"].ToString());
                        list.SubItems.Add(table["Name"].ToString());
                        list.SubItems.Add(table["Student_Number"].ToString());
                        list.SubItems.Add(table["dept_id"].ToString());
                        list.SubItems.Add(table["dept_name"].ToString());
                        String Birth = table["Birth"].ToString();
                        list.SubItems.Add(Birth.Substring(0, 10));
                        list.SubItems.Add(table["tell"].ToString());
                        Address[0] = table["Address1"].ToString();
                        Address[1] = table["Address2"].ToString();
                        list.SubItems.Add(Address[0] + " " + Address[1]);
                        list.SubItems.Add(table["Email"].ToString());

                        ID_Management_list.Items.Add(list);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 내용 : " + ex.Message);
            }
        }
        
        /// <summary>
        /// ID 리스트를 가져오는 SQL 메서드
        /// </summary>
        public void ID_Management_SQL()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                { 
                    String Query = $"SELECT DISTINCT a.id, a.student_number, a.birth, b.ADDRESS1, b.ADDRESS2, b.email, b.tell, b.dept_id, b.dept_name, a.name " +
                    "FROM USERS AS a  " +
                    "INNER JOIN USERS_INFORMATION AS b " +
                    "ON a.student_number = b.student_number " +
                    "ORDER BY Student_Number";
                    String Search_Query = $"SELECT DISTINCT a.id, a.student_number, a.birth, b.ADDRESS1, b.ADDRESS2, b.email, b.tell, b.dept_id, b.dept_name, a.name " +
                    "FROM USERS AS a  " +
                    "INNER JOIN USERS_INFORMATION AS b " +
                    "ON a.student_number = b.student_number " +
                    $"WHERE a.Name = '{Name}' "+
                    "ORDER BY Student_Number";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(Query, connection);       
                    MySqlDataReader table = command.ExecuteReader();

                    String[] Address = new string[2];
                    int i = 0;
                    while (table.Read())
                    {
                        i++;
                        // 리스트 생성
                        ListViewItem list = new ListViewItem(i.ToString());
                        list.SubItems.Add(table["ID"].ToString());
                        list.SubItems.Add(table["Name"].ToString());
                        list.SubItems.Add(table["Student_Number"].ToString());
                        list.SubItems.Add(table["dept_id"].ToString());
                        list.SubItems.Add(table["dept_name"].ToString());
                        String Birth = table["Birth"].ToString();
                        list.SubItems.Add(Birth.Substring(0, 10));
                        list.SubItems.Add(table["tell"].ToString());
                        Address[0] = table["Address1"].ToString();
                        Address[1] = table["Address2"].ToString();
                        list.SubItems.Add(Address[0] + " " + Address[1]);
                        list.SubItems.Add(table["Email"].ToString());
                      
                        ID_Management_list.Items.Add(list);
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
        /// 행 선택시 데이터 넘김
        /// </summary>
        private void ID_Management_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ID_Management_list.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = ID_Management_list.SelectedItems;
                ListViewItem i = items[0];
                Admin_Config.ID = i.SubItems[1].Text;
                Admin_Config.Name = i.SubItems[2].Text;
                Admin_Config.Student_Number = i.SubItems[3].Text;
                Admin_Config.Dept_ID = i.SubItems[4].Text;
                Admin_Config.Dept_Name = i.SubItems[5].Text;
                Admin_Config.Birth = i.SubItems[6].Text;
                Admin_Config.Tell = i.SubItems[7].Text;
                Admin_Config.Address[0] = i.SubItems[8].Text;
                Admin_Config.Email = i.SubItems[9].Text;
            }
        }

        /// <summary>
        /// ID 삭제 버튼
        /// </summary>
        private void ID_Delete_Btn_Click(object sender, EventArgs e)
        {
            Admin_DBMySql.ID_DELETE_SQL();
        }

        /// <summary>
        /// ID 수정 버튼
        /// </summary>
        private void ID_Modify_Btn_Click(object sender, EventArgs e)
        {
            Admin_DBMySql.User_info();
            Admin_User_Modify Admin_user_m = new Admin_User_Modify();
            Admin_user_m.Show();
        }

        /// <summary>
        /// ID 추가 버튼
        /// </summary>
        private void ID_Add_Btn_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
        }

        /// <summary>
        /// ID 정보 버튼
        /// </summary>
        private void ID_Info_Btn_Click(object sender, EventArgs e)
        {
            Admin_User_Info admin_user_info = new Admin_User_Info();
            admin_user_info.Show();
        }

        /// <summary>
        /// 조회 버튼
        /// </summary>
        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            ID_Management_list.Items.Clear();
            ID_Management_SQL();
            // 모든 열 사이즈 자동 조정
            ID_Management_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// 엑셀 파일로 저장하는 버튼
        /// </summary>
        private void ExcelFile_Save_Btn_Click(object sender, EventArgs e)
        {
            if(this.ID_Management_list.Items.Count != 0)
            {
                this.ExcelSaveFile.Filter = "엑셀 파일(*.xlsx) | *.xlsx";
                if(this.ExcelSaveFile.ShowDialog() == DialogResult.OK)
                {
                    
                    FilePath = this.ExcelSaveFile.FileName;
                    ExcelFileSave();
                }
            }
        }

        /// <summary>
        /// 엑셀 파일 저장 메서드
        /// </summary>
        private void ExcelFileSave()
        {
            Excel.Application application;
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;

            application = new Excel.Application();
            workbook = application.Workbooks.Add(true);
            worksheet = (Excel.Worksheet)workbook.Sheets[1]; // 엑셀 Sheet 1부터 시작

            int nRow = this.ID_Management_list.Items.Count + 1;
            int nCol = 10;
            String[,] data = new String[nRow, nCol];
            for (int i = 0; i < nCol; i++)
            {
                data[0, i] = ID_Management_list.Columns[i].ToString().Substring(20);
            }

            for(int i = 0; i < this.ID_Management_list.Items.Count; ++i)
            {
                for(int j = 0; j < this.ID_Management_list.Items[i].SubItems.Count; ++j)
                {
                    data[i + 1, j] = this.ID_Management_list.Items[i].SubItems[j].Text;
                }
            }

            String EndCell = "J" + nRow.ToString();
            worksheet.Range["A1:" + EndCell].Value = data;
            workbook.SaveAs(FilePath, workbook.FileFormat, Type.Missing, Type.Missing, false, false,
                Excel.XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing, Type.Missing);
            workbook.Close(false, Type.Missing, Type.Missing);
            application.Quit();
        }

        /// <summary>
        /// 이름 검색 텍스트 박스
        /// </summary>
        private void ID_Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            Name = ID_Search_TextBox.Text;
        }

        /// <summary>
        /// 이름 검색 버튼
        /// </summary>
        private void ID_Search_Btn_Click(object sender, EventArgs e)
        {
            ID_Management_list.Items.Clear();
            ID_Search_SQL();
            // 모든 열 사이즈 자동 조정
            ID_Management_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
