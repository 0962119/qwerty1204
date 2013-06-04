using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Office.Interop.Excel;


namespace Restaurant
{
    public class ThongKe_XuatExcel
    {
        Application oExcel = new Application();
        Workbooks oBooks;
        Sheets oSheets;
        Workbook oBook;
        Worksheet oSheet;
        public void Excel_Head(string title, string sheetName)
        {
            //tao 1 excel wordbook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn
            Range head = oSheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // Tạo báo cáo ngày?
            Range ngayBC = oSheet.get_Range("A2", "F2");
            ngayBC.MergeCells = true;
            ngayBC.Value2 = " (Ngày" + DateTime.Now + ")";
            ngayBC.Font.Italic = true;
            //ngayBC.Font.Color("Red");
            ngayBC.Font.Name = "Tahoma";
            ngayBC.Font.Size = "12";
            ngayBC.HorizontalAlignment = XlHAlign.xlHAlignCenter;
        }
        public void ThietLapVungDuLieu(System.Data.DataTable dt)
        {
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;
            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;

            // Kẻ viền
            range.Borders.LineStyle = Constants.xlSolid;
            // Căn giữa cột STT
            Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = XlHAlign.xlHAlignCenter;
        }
        public void Export_Ban(System.Data.DataTable dt, string sheetName, string title)
        {
            Excel_Head(title, sheetName);
            // Tạo tiêu đề cột
            Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Khu vực";
            cl1.ColumnWidth = 13.5;

            Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Bàn";
            cl2.ColumnWidth = 13.5;

            Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Số hóa đơn";
            cl3.ColumnWidth = 20;

            Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Tổng tiền";
            cl4.ColumnWidth = 13.5;

            Range rowHead = oSheet.get_Range("A3", "D3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ThietLapVungDuLieu(dt);

        }
        public void Export_MonAn(System.Data.DataTable dt, string sheetName, string title)
        {

            Excel_Head(title, sheetName);
            // Tạo tiêu đề cột
            Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Tên loại món ăn";
            cl1.ColumnWidth = 13.5;

            Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tến món ăn";
            cl2.ColumnWidth = 25;

            Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Số lượng";
            cl3.ColumnWidth = 13.5;

            Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Số hóa đơn";
            cl4.ColumnWidth = 13.5;

            Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Tổng tiền";
            cl5.ColumnWidth = 13.5;

            Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ThietLapVungDuLieu(dt);
        }
    }
}
