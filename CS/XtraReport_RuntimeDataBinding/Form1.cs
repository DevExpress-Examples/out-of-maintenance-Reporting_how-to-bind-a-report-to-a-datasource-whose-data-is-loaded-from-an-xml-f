using System;
using System.Windows.Forms;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;
// ...

namespace XtraReport_RuntimeDataBinding {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create an empty report.
            XtraReport report = new XtraReport();

            // Create a data source.           
            SqlDataSource ds = new SqlDataSource(new XmlFileConnectionParameters("../../Cars.xml"));

            // Create a query to access fields of the Cars data table.
            TableQuery query = new TableQuery();
            query.Name = "Cars";
            query.AddTable("Cars")
                 .SelectColumns("ID", "Trademark", "Model", "Category", "Description");
            ds.Queries.Add(query);

            // Rebuild the data source schema to reflect the defined data hierarchy.
            ds.RebuildResultSchema();

            // Assign the data source to the report.
            report.DataSource = ds;
            report.DataMember = "Cars";

            // Add a detail band to the report.
            DetailBand detailBand = new DetailBand();
            detailBand.Height = 50;
            report.Bands.Add(detailBand);

            // Add a label to the detail band.
            XRLabel label = new XRLabel { WidthF = 300 };
            label.Text = "[Cars.Trademark] [Cars.Model]";
            detailBand.Controls.Add(label);
            
            // Show the report's print preview.
            report.ShowPreview();       
        }
    }
}
