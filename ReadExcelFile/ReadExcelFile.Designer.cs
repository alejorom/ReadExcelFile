namespace ReadExcelFile
{
    partial class ReadExcelFile
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
            this.CmdOpen = new System.Windows.Forms.Button();
            this.GrdData = new System.Windows.Forms.DataGridView();
            this.CboHojas = new System.Windows.Forms.ComboBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdData)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdOpen
            // 
            this.CmdOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdOpen.Location = new System.Drawing.Point(713, 13);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(75, 23);
            this.CmdOpen.TabIndex = 0;
            this.CmdOpen.Text = "Open";
            this.CmdOpen.UseVisualStyleBackColor = true;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // GrdData
            // 
            this.GrdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdData.Location = new System.Drawing.Point(12, 42);
            this.GrdData.Name = "GrdData";
            this.GrdData.Size = new System.Drawing.Size(776, 379);
            this.GrdData.TabIndex = 1;
            // 
            // CboHojas
            // 
            this.CboHojas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboHojas.FormattingEnabled = true;
            this.CboHojas.Location = new System.Drawing.Point(13, 14);
            this.CboHojas.Name = "CboHojas";
            this.CboHojas.Size = new System.Drawing.Size(694, 21);
            this.CboHojas.TabIndex = 2;
            this.CboHojas.SelectedIndexChanged += new System.EventHandler(this.CboHojas_SelectedIndexChanged);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(72, 424);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(70, 13);
            this.lblRegistros.TabIndex = 3;
            this.lblRegistros.Text = "<<registros>>";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 424);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Registros:";
            // 
            // ReadExcelFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.CboHojas);
            this.Controls.Add(this.GrdData);
            this.Controls.Add(this.CmdOpen);
            this.Name = "ReadExcelFile";
            this.Text = "ReadExcelFile with ExcelDataReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.DataGridView GrdData;
        private System.Windows.Forms.ComboBox CboHojas;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblTotal;
    }
}

