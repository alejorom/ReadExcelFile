namespace ReadExcelFile
{
    partial class ReadExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdExcelDataReader = new System.Windows.Forms.Button();
            this.CmdNPOI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdExcelDataReader
            // 
            this.CmdExcelDataReader.Location = new System.Drawing.Point(12, 12);
            this.CmdExcelDataReader.Name = "CmdExcelDataReader";
            this.CmdExcelDataReader.Size = new System.Drawing.Size(106, 23);
            this.CmdExcelDataReader.TabIndex = 0;
            this.CmdExcelDataReader.Text = "ExcelDataReader";
            this.CmdExcelDataReader.UseVisualStyleBackColor = true;
            this.CmdExcelDataReader.Click += new System.EventHandler(this.CmdExcelDataReader_Click);
            // 
            // CmdNPOI
            // 
            this.CmdNPOI.Location = new System.Drawing.Point(125, 13);
            this.CmdNPOI.Name = "CmdNPOI";
            this.CmdNPOI.Size = new System.Drawing.Size(75, 23);
            this.CmdNPOI.TabIndex = 1;
            this.CmdNPOI.Text = "NPOI";
            this.CmdNPOI.UseVisualStyleBackColor = true;
            this.CmdNPOI.Click += new System.EventHandler(this.CmdNPOI_Click);
            // 
            // ReadExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 49);
            this.Controls.Add(this.CmdNPOI);
            this.Controls.Add(this.CmdExcelDataReader);
            this.Name = "ReadExcel";
            this.Text = "ReadExcel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdExcelDataReader;
        private System.Windows.Forms.Button CmdNPOI;
    }
}