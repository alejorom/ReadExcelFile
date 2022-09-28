using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadExcelFile
{
    public partial class ReadExcel : Form
    {
        public ReadExcel()
        {
            InitializeComponent();
        }

        private void CmdExcelDataReader_Click(object sender, EventArgs e)
        {
            ReadExcelFile readExcelFile = new ReadExcelFile();
            readExcelFile.ShowDialog();
        }

        private void CmdNPOI_Click(object sender, EventArgs e)
        {
            ReadExcelFileNPOI readExcelFileNPOI = new ReadExcelFileNPOI();
            readExcelFileNPOI.ShowDialog();
        }
    }
}
