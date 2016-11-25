namespace ClientApplication
{
    partial class ClientForm
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
            this.customersGrid = new System.Windows.Forms.DataGridView();
            this.btnImportData = new System.Windows.Forms.Button();
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnPrintData = new System.Windows.Forms.Button();
            this.PrintDocumentDialog = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersGrid
            // 
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrid.Location = new System.Drawing.Point(12, 88);
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.Size = new System.Drawing.Size(735, 262);
            this.customersGrid.TabIndex = 0;
            this.customersGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customersGrid_ColumnHeaderMouseClick);
            // 
            // btnImportData
            // 
            this.btnImportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportData.Location = new System.Drawing.Point(6, 28);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(148, 23);
            this.btnImportData.TabIndex = 1;
            this.btnImportData.Text = "Import Data";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportData.Location = new System.Drawing.Point(169, 28);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(148, 23);
            this.btnExportData.TabIndex = 2;
            this.btnExportData.Text = "Export Data";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // btnPrintData
            // 
            this.btnPrintData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintData.Location = new System.Drawing.Point(323, 28);
            this.btnPrintData.Name = "btnPrintData";
            this.btnPrintData.Size = new System.Drawing.Size(148, 23);
            this.btnPrintData.TabIndex = 3;
            this.btnPrintData.Text = "Print Data";
            this.btnPrintData.UseVisualStyleBackColor = true;
            this.btnPrintData.Click += new System.EventHandler(this.btnPrintData_Click);
            // 
            // PrintDocumentDialog
            // 
            this.PrintDocumentDialog.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocumentDialog_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImportData);
            this.groupBox1.Controls.Add(this.btnPrintData);
            this.groupBox1.Controls.Add(this.btnExportData);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customersGrid);
            this.Name = "ClientForm";
            this.Text = "ClietForm";
            this.Load += new System.EventHandler(this.ClietForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customersGrid;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.Button btnPrintData;
        private System.Drawing.Printing.PrintDocument PrintDocumentDialog;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

