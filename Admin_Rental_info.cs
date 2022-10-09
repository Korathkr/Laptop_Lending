using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    public partial class Admin_Rental_info : Form
    {
        String FilePath = "";
        public Admin_Rental_info()
        {
            InitializeComponent();
            ID_Rental_list_SQL();
            // 모든 열 사이즈 자동 조정
            Rental_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// 대여한 ID 리스트를 가져오는 SQL 메서드
        /// </summary>
        public void ID_Rental_list_SQL()
        {
            String application_date;
            String rental_date;
            String return_date;
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"Server={Config.Server};" + $"Port={Config.Port};" + $"Database={Config.Database};" + $"Uid={Config.UserID};" + $"Pwd={Config.UserPassword};"))
                {
                    String Query = $"SELECT * FROM USERS_LAPTOP_LENDING ORDER BY Student_Number";
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
                        list.SubItems.Add(table["tell"].ToString());
                        list.SubItems.Add(table["Email"].ToString());
                        list.SubItems.Add(table["Address"].ToString());
                        application_date = table["Application_date"].ToString();
                        list.SubItems.Add(application_date.Substring(0, 10));
                        rental_date = table["Rental_Date"].ToString();
                        return_date = table["Return_Date"].ToString();
                        list.SubItems.Add(rental_date.Substring(0, 10));
                        list.SubItems.Add(return_date.Substring(0, 10));
                        list.SubItems.Add(table["Laptop_type"].ToString());
                        Rental_list.Items.Add(list);
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
            Rental_list.Items.Clear();
            ID_Rental_list_SQL();
            // 모든 열 사이즈 자동 조정
            Rental_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// 엑셀 파일로 저장 버튼
        /// </summary>
        private void ExcelFile_Save_Btn_Click(object sender, EventArgs e)
        {
            if (this.Rental_list.Items.Count != 0)
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

            int nRow = this.Rental_list.Items.Count + 1;
            int nCol = 10;
            String[,] data = new String[nRow, nCol];
            for (int i = 0; i < nCol; i++)
            {
                data[0, i] = Rental_list.Columns[i].ToString().Substring(20);
            }

            for (int i = 0; i < this.Rental_list.Items.Count; ++i)
            {
                for (int j = 0; j < this.Rental_list.Items[i].SubItems.Count; ++j)
                {
                    data[i + 1, j] = this.Rental_list.Items[i].SubItems[j].Text;
                }
            }

            String EndCell = "J" + nRow.ToString();
            worksheet.Range["A1:" + EndCell].Value = data;
            workbook.SaveAs(FilePath, workbook.FileFormat, Type.Missing, Type.Missing, false, false,
                Excel.XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing, Type.Missing);
            workbook.Close(false, Type.Missing, Type.Missing);
            application.Quit();
        }
    }
}
