#region #reference
using System;
using System.Windows.Forms;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;
// ...
#endregion #reference

namespace XtraReport_RuntimeDataBinding {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

#region #code
XtraReport CreateReport() {
    // Create a new report instance.
    XtraReport report = new XtraReport();

    // Create a data source.           
    SqlDataSource ds = new SqlDataSource(new XmlFileConnectionParameters("../../Cars.xml"));

    // Create a query to access fields of the Cars data table.
    SelectQuery query = SelectQueryFluentBuilder
        .AddTable("Cars")
        .SelectColumns("ID", "Trademark", "Model", "Category", "Description")
        .Build("MyQuery");
    ds.Queries.Add(query);

    // Make the data source structure displayed  
    // in the Field List of an End-User Report Designer. 
    ds.RebuildResultSchema();

    // Assign the data source to the report.
    report.DataSource = ds;
    report.DataMember = "MyQuery";

    // Add a detail band to the report.
    DetailBand detailBand = new DetailBand();
    report.Bands.Add(detailBand);

    // Add a label to the detail band.
    XRLabel label = new XRLabel { WidthF = 300 };
    label.Text = "[MyQuery.Trademark] [MyQuery.Model]";
    label.LeftF = 30;
    detailBand.Controls.Add(label);
    detailBand.Height = (int)label.HeightF;

    // Create a group header band and add it to the report.
    GroupHeaderBand ghBand = new GroupHeaderBand();
    report.Bands.Add(ghBand);

    // Create a grouping criteria. 
    ghBand.GroupFields.Add(new GroupField("Category"));

    // Display the grouping criteria in the group header.
    XRLabel labelGroup = new XRLabel();
    labelGroup.Text = "[MyQuery.Category]";
    ghBand.Controls.Add(labelGroup);
    ghBand.Height = (int)labelGroup.HeightF;

    return report;
}

private void button1_Click(object sender, EventArgs e) {
    // Show the report's print preview.
    ReportPrintTool printTool = new ReportPrintTool(CreateReport());
    printTool.ShowPreview();
}

private void button2_Click(object sender, EventArgs e) {
    // Open the report in an End-User Designer. 
    ReportDesignTool designTool = new ReportDesignTool(CreateReport());
    designTool.ShowRibbonDesignerDialog();
}
#endregion #code


    }
}
