using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ClosedXML;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace CanteenManagementSystem.Functions
{
    internal class HandleExcelData
    {

        public void ExportData(DataTable table,string title="",string fileName="")
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    sfd.FileName = fileName;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(table, title);
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Resource Exported Successfull", "export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Export Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
