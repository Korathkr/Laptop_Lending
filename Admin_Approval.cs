using MySql.Data.MySqlClient;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public partial class Admin_Approval : Form
    {
        public static String student_number;
        public static String approval;
        public static String return_status;
        public static String application_date;
        String FilePath = "";

        public Admin_Approval()
        {
            InitializeComponent();
            ID_Approval_SQL();
            // 모든 열 사이즈 자동 조정
            Approval_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// 대여 미승인 ID 리스트를 가져오는 SQL 메서드
        /// </summary>
        public void ID_Approval_SQL()
        {
            String rental_date = "";
            String return_date = "";
            String application_date = "";
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"SELECT * FROM USERS_LAPTOP_LENDING WHERE APPROVAL = '미승인' OR RETURN_STATUS = '미반납' ORDER BY Student_Number, RETURN_STATUS";
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Query, connection);
                    MySqlDataReader table = command.ExecuteReader();

                    int i = 0;
                    while (table.Read())
                    {
                        i++;
                        // 리스트 생성
                        ListViewItem list = new ListViewItem(i.ToString());
                        list.SubItems.Add(table["Student_Number"].ToString());
                        list.SubItems.Add(table["Name"].ToString());
                        application_date = table["Application_date"].ToString();
                        list.SubItems.Add(application_date.Substring(0, 10));
                        rental_date = table["Rental_Date"].ToString();
                        return_date = table["Return_Date"].ToString();
                        list.SubItems.Add(rental_date.Substring(0, 10));
                        list.SubItems.Add(return_date.Substring(0, 10));
                        list.SubItems.Add(table["Approval"].ToString());
                        list.SubItems.Add(table["Return_status"].ToString());
                        list.SubItems.Add(table["Laptop_type"].ToString());
                        Approval_list.Items.Add(list);
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
        /// 지난 승인/반납 ID 리스트를 가져오는 SQL 메서드
        /// </summary>
        public void ID_Last_Approval_SQL()
        {
            String rental_date = "";
            String return_date = "";
            String application_date = "";
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"SELECT * FROM USERS_LAPTOP_LENDING WHERE APPROVAL LIKE '%승인%' ORDER BY Student_Number, RETURN_STATUS";
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Query, connection);
                    MySqlDataReader table = command.ExecuteReader();

                    int i = 0;
                    while (table.Read())
                    {
                        i++;
                        // 리스트 생성
                        ListViewItem list = new ListViewItem(i.ToString());
                        list.SubItems.Add(table["Student_Number"].ToString());
                        list.SubItems.Add(table["Name"].ToString());
                        application_date = table["Application_date"].ToString();
                        list.SubItems.Add(application_date.Substring(0, 10));
                        rental_date = table["Rental_Date"].ToString();
                        return_date = table["Return_Date"].ToString();
                        list.SubItems.Add(rental_date.Substring(0, 10));
                        list.SubItems.Add(return_date.Substring(0, 10));
                        list.SubItems.Add(table["Approval"].ToString());
                        list.SubItems.Add(table["Return_status"].ToString());
                        list.SubItems.Add(table["Laptop_type"].ToString());
                        Approval_list.Items.Add(list);
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
        private void Approval_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Approval_list.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = Approval_list.SelectedItems;
                ListViewItem i = items[0];
                student_number = i.SubItems[1].Text;
                application_date = i.SubItems[3].Text;
                approval = i.SubItems[7].Text;
                return_status = i.SubItems[8].Text;
                
            }
        }

        /// <summary>
        /// 조회 버튼
        /// </summary>
        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            Approval_list.Items.Clear();
            ID_Approval_SQL();
            // 모든 열 사이즈 자동 조정
            Approval_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// 엑셀 파일로 저장 버튼
        /// </summary>
        private void ExcelFile_Save_Btn_Click(object sender, EventArgs e)
        {
            if(this.Approval_list.Items.Count != 0)
            {
                this.ExcelSaveFile.Filter = "엑셀 파일(*.xlsx) | *.xlsx";
                if (this.ExcelSaveFile.ShowDialog() == DialogResult.OK)
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

            int nRow = this.Approval_list.Items.Count + 1;
            int nCol = 9;
            String[,] data = new String[nRow, nCol];
            for (int i = 0; i < nCol; i++)
            {
                data[0, i] = Approval_list.Columns[i].ToString().Substring(20);
            }

            for (int i = 0; i < this.Approval_list.Items.Count; ++i)
            {
                for (int j = 0; j < this.Approval_list.Items[i].SubItems.Count; ++j)
                {
                    data[i + 1, j] = this.Approval_list.Items[i].SubItems[j].Text;
                }
            }

            String EndCell = "H" + nRow.ToString();
            worksheet.Range["A1:" + EndCell].Value = data;
            workbook.SaveAs(FilePath, workbook.FileFormat, Type.Missing, Type.Missing, false, false,
                Excel.XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing, Type.Missing);
            workbook.Close(false, Type.Missing, Type.Missing);
            application.Quit();
        }

        /// <summary>
        /// 승인 버튼
        /// </summary>
        private void Approval_Btn_Click(object sender, EventArgs e)
        {
            Admin_DBMySql.User_Laptop_Approval_SQL();
        }

        /// <summary>
        /// 승인 취소 버튼
        /// </summary>
        private void Approval_Cancle_Btn_Click(object sender, EventArgs e)
        {
            Admin_DBMySql.User_Laptop_Approval_Cancle_SQL();
        }

        /// <summary>
        /// 반납 버튼
        /// </summary>
        private void Return_Btn_Click(object sender, EventArgs e)
        {
            Admin_DBMySql.User_Laptop_Return_SQL();
        }

        /// <summary>
        /// 반납 취소 버튼
        /// </summary>
        private void Return_Cancle_Btn_Click(object sender, EventArgs e)
        {
            Admin_DBMySql.User_Laptop_Return_Cancle_SQL();
        }

        /// <summary>
        /// 지난 승인/반납 목록 버튼
        /// </summary>
        private void Last_list_Btn_Click(object sender, EventArgs e)
        {
            Approval_list.Items.Clear();
            ID_Last_Approval_SQL();
            // 모든 열 사이즈 자동 조정
            Approval_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
