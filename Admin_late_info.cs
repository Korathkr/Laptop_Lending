using MySql.Data.MySqlClient;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public partial class Admin_late_info : Form
    {
        String FilePath = "";

        public Admin_late_info()
        {
            InitializeComponent();
            ID_late_list_SQL();
            // 모든 열 사이즈 자동 조정
            late_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }


        /// <summary>
        /// 연체한 ID 리스트를 가져오는 SQL 메서드
        /// </summary>
        public void ID_late_list_SQL()
        {
            String application_date;
            String rental_date;
            String return_date;
 
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"SELECT *, TIMESTAMPDIFF(day, return_date, Date_Format(now(), '%Y-%m-%d')) AS late_day FROM users_laptop_lending WHERE TIMESTAMPDIFF(day, return_date, Date_Format(now(), '%Y-%m-%d')) > 0 and return_status = '미반납'";
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
                        list.SubItems.Add(table["Laptop_type"].ToString());
                        application_date = table["Application_date"].ToString();
                        list.SubItems.Add(application_date.Substring(0, 10));
                        rental_date = table["Rental_Date"].ToString();
                        return_date = table["Return_Date"].ToString();
                        list.SubItems.Add(rental_date.Substring(0, 10));
                        list.SubItems.Add(return_date.Substring(0, 10));
                        list.SubItems.Add(table["late_day"].ToString() + "일 지남");
                        list.SubItems.Add(table["return_status"].ToString());
                        // 리스트에 추가
                        late_list.Items.Add(list);
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
        /// 조회 버튼
        /// </summary>
        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            late_list.Items.Clear();
            ID_late_list_SQL();
            // 모든 열 사이즈 자동 조정
            late_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// 엑셀 파일로 저장 버튼
        /// </summary>
        private void ExcelFile_Save_Btn_Click(object sender, EventArgs e)
        {
            if (this.late_list.Items.Count != 0)
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

            int nRow = this.late_list.Items.Count + 1;
            int nCol = 9;
            String[,] data = new String[nRow, nCol];
            for (int i = 0; i < nCol; i++)
            {
                data[0, i] = late_list.Columns[i].ToString().Substring(20);
            }

            for (int i = 0; i < this.late_list.Items.Count; ++i)
            {
                for (int j = 0; j < this.late_list.Items[i].SubItems.Count; ++j)
                {
                    data[i + 1, j] = this.late_list.Items[i].SubItems[j].Text;
                }
            }

            String EndCell = "I" + nRow.ToString();
            worksheet.Range["A1:" + EndCell].Value = data;
            workbook.SaveAs(FilePath, workbook.FileFormat, Type.Missing, Type.Missing, false, false,
                Excel.XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing, Type.Missing);
            workbook.Close(false, Type.Missing, Type.Missing);
            application.Quit();
        }
    }
}
