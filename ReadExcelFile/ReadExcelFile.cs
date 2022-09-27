using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ReadExcelFile
{
    public partial class ReadExcelFile : Form
    {
        public ReadExcelFile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        DataSet result;
        private void CmdOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbooks|*.xlsx|Excel Workbooks 2003-2007|*.xls ", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs);

                    var conf = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };

                    result = reader.AsDataSet(conf);
                    CboHojas.Items.Clear();

                    // Obtener las hojas del Excel.
                    foreach (DataTable dtHojas in result.Tables)
                        CboHojas.Items.Add(dtHojas.TableName);
                   
                    reader.Close();

                }
            }

        }

        private void CboHojas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboHojas.SelectedIndex == -1) return;
            lblRegistros.Text = result.Tables[CboHojas.SelectedItem.ToString()].Rows.Count.ToString();
            GrdData.DataSource = result.Tables[CboHojas.SelectedItem.ToString()];
        }
    }
}
