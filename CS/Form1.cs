using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace DataBindingXMLIntoDataSet {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a report.
            XtraReport1 report = new XtraReport1();

            // Create a DataSet and fill it with data from an XML file.
            DataSet xmlDataSet = new DataSet();
            xmlDataSet.ReadXml(@"..\..\Cars.xml");

            // Bind the report to the DataSet.
            report.DataSource = xmlDataSet;

            // Add two bound labels to the Detail bands.
            report.lbModel.DataBindings.Add("Text", report.DataSource, "Cars.Model", "Model: {0}");
            report.lbTrademark.DataBindings.Add("Text", report.DataSource, "Cars.Trademark", "Trademark: {0}");

            // Show the report's print preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();

        }
    }
}