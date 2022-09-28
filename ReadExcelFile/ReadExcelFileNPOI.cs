using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ReadExcelFile
{
    public partial class ReadExcelFileNPOI : Form
    {
        public ReadExcelFileNPOI()
        {
            InitializeComponent();
        }

        IWorkbook book;

        private void CmdOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbooks|*.xlsx|Excel Workbooks 2003-2007|*.xls ", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    string extension = Path.GetExtension(ofd.FileName);
                    if (extension.Equals(".xls")) book = new HSSFWorkbook(fs);
                    if (extension.Equals(".xlsx")) book = new XSSFWorkbook(fs);
                    fs.Close();

                    CboHojas.Items.Clear();
                    for (int i = 0; i <= book.NumberOfSheets - 1; i++)
                    {
                        ISheet sheet = book.GetSheetAt(i);
                        CboHojas.Items.Add(sheet.SheetName);
                    }
                }
            }
        }

        private void CboHojas_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> rowList = new List<string>();

            if (CboHojas.SelectedIndex == -1) return;
            ISheet sheet = book.GetSheet(CboHojas.SelectedItem.ToString());
            if (sheet == null) return;
            lblRegistros.Text = sheet.LastRowNum.ToString();

            IRow headerRow = sheet.GetRow(0);           // Leer la primera fila encabezados.

            // Estructura de la tabla
            DataTable dtTable = new DataTable();
            for (int j = headerRow.FirstCellNum; j < headerRow.LastCellNum; j++)       // Recorrer las columnas / celdas
            {
                ICell cell = headerRow.GetCell(j);
                dtTable.Columns.Add(cell.ToString());
            }

            // Datos de la tabla por filas
            for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
            {
                IRow dataRow = sheet.GetRow(i);
                if (dataRow == null) continue;

                // Datos de la tabla por columnas de una fila
                for (int j = dataRow.FirstCellNum; j < dataRow.LastCellNum; j++)
                {
                    rowList.Add(dataRow.GetCell(j).ToString());
                }

                if (rowList.Count > 0) dtTable.Rows.Add(rowList.ToArray());
                rowList.Clear();
            }

            // Llenar grilla de datos.
            GrdData.DataSource = dtTable;

        }
    }
}
