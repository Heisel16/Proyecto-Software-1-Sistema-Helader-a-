using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS.Controller
{
    public class ControladorServicioExcel
    {
        #region Excel de usuarios
        public void exportaraexcel(DataGridView tabla)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);

                Microsoft.Office.Interop.Excel._Worksheet worksheet = excel.ActiveSheet;

                int IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    if (col is DataGridViewButtonColumn)
                    {
                        continue;
                    }

                    IndiceColumna++;

                    worksheet.Cells[1, IndiceColumna] = col.Name;
                }

                int IndiceFila = 0;

                foreach (DataGridViewRow row in tabla.Rows)
                {
                    IndiceFila++;
                    IndiceColumna = 0;

                    foreach (DataGridViewColumn col in tabla.Columns)
                    {
                        if (col is DataGridViewButtonColumn)
                        {
                            continue;
                        }

                        IndiceColumna++;
                        worksheet.Cells[IndiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                    }
                }
                worksheet.Columns.AutoFit();
                var headerRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, IndiceColumna]];
                headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                headerRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                headerRange.Font.Bold = true;

                excel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}");
            }
        }
        #endregion
    }
}
