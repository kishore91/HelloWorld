using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class ClientForm : Form
    {
        private CustomerManager _customerManger;
        private const string sourceFilePath = @"C:\Users\U547175\documents\visual studio 2013\Projects\ClientApplication\ClientApplication\CSVFiles\CustomerImport.csv";
        private const string destinationFilePath = @"C:\Users\U547175\documents\visual studio 2013\Projects\ClientApplication\ClientApplication\CSVFiles\CustomerExport.csv";

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClietForm_Load(object sender, EventArgs e)
        {
            this._customerManger = new CustomerManager();
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            if (File.Exists(sourceFilePath))
            {
                BindData(sourceFilePath,string.Empty);
                               
            }
            else
            {
                MessageBox.Show("Source File Not found.");
            }
        }

        private void BindData(string sourceFilePath, string sortfilter)
        {
            customersGrid.DataSource = _customerManger.GetCustomers(sourceFilePath);
            if (sortfilter == "Id")
            {
                customersGrid.Sort(customersGrid.Columns["Id"], ListSortDirection.Ascending);
            }
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            ExportToCSVFile();
        }

        private void ExportToCSVFile()
        {
            StringBuilder result = new StringBuilder(); 
            
            if (File.Exists(destinationFilePath))
            {
                File.Delete(destinationFilePath);
            }               
                       
            for (int columnCounter = 0; columnCounter < customersGrid.Columns.Count; columnCounter++)
            {
                
                result.Append(customersGrid.Columns[columnCounter].HeaderText);
                result.Append(columnCounter == customersGrid.Columns.Count - 1 ? "\n" : ",");
            }
                     
            for (int rowCounter = 0; rowCounter < customersGrid.Rows.Count; rowCounter++)
            { 
                result.Append( ((DataGridViewTextBoxCell)customersGrid.Rows[rowCounter].Cells[0]).Value.ToString()+ ","+((DataGridViewTextBoxCell)customersGrid.Rows[rowCounter].Cells[1]).Value.ToString() );
                result.Append(rowCounter == customersGrid.Rows.Count - 1 ? "\n"  : "");
            }

            File.WriteAllText(destinationFilePath, result.ToString());
            MessageBox.Show("Data has been exported");
        }

        private void btnPrintData_Click(object sender, EventArgs e)
        {
            PrintDocumentDialog.Print();
        }

        private void PrintDocumentDialog_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.customersGrid.Width, this.customersGrid.Height);
            customersGrid.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, this.customersGrid.Width, this.customersGrid.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        public class CustomerManager
        {         
            public List<Customer> GetCustomers(string fromFilePath)
            {
                List<Customer> customers = File.ReadAllLines(fromFilePath)
                                        .Skip(1)
                                        .Select(v => Customer.FromCsv(v))
                                        .ToList();           
                return customers;
            }
        }

        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public static Customer FromCsv(string csvLine)
            {
                string[] values = csvLine.Split(',');
                Customer _customer = new Customer();
                _customer.Id = Convert.ToInt32(values[0]);
                _customer.Name = Convert.ToString(values[1]);                
                return _customer;
            }
        }

        private void customersGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(customersGrid.Columns[e.ColumnIndex].HeaderText=="Id")
            {
                BindData(sourceFilePath, "Id");
            }
        }
  }
}