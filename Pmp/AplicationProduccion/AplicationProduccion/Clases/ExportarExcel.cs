using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationProduccion.Clases
{
    class ExportarExcel
    {
        public DataTable exportarExcel(string nomArch)
        {
            DataTable dt = new DataTable();
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                }
            }


            // Lots of options here. See the documentation.  
            wb.SaveAs(@"C:\Users\Cristian\Desktop" + nomArch);
            //wb.SaveAs(@"C:\Users\U558606\Desktop\" + nomArch);
            wb.Close();
            app.Quit();

            return dt;
            
       }
    }
}
