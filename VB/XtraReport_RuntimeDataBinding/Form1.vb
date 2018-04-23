#Region "#reference"
Imports System
Imports System.Windows.Forms
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraReports.UI
' ...
#End Region ' #reference

Namespace XtraReport_RuntimeDataBinding
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

#Region "#code"
        Private Function CreateReport() As XtraReport
            ' Create a new report instance.
            Dim report As New XtraReport()

            ' Create a data source.           
            Dim ds As New SqlDataSource(New XmlFileConnectionParameters("../../Cars.xml"))

            ' Create a query to access fields of the Cars data table.
            Dim query As SelectQuery = SelectQueryFluentBuilder.
                AddTable("Cars").
                SelectColumns("ID", "Trademark", "Model", "Category", "Description").
                Build("MyQuery")
            ds.Queries.Add(query)

            ' Make the data source structure displayed  
            ' in the Field List of an End-User Report Designer. 
            ds.RebuildResultSchema()

            ' Assign the data source to the report.
            report.DataSource = ds
            report.DataMember = "MyQuery"

            ' Add a detail band to the report.
            Dim detailBand As New DetailBand()
            report.Bands.Add(detailBand)

            ' Add a label to the detail band.
            Dim label As XRLabel = New XRLabel With {.WidthF = 300}
            'label.DataBindings.Add("Text", Nothing, "customQuery1.ProductName")
            label.Text = "[MyQuery.Trademark] [MyQuery.Model]"
            label.LeftF = 30
            detailBand.Controls.Add(label)
            detailBand.Height = CInt(label.HeightF)

            ' Create a group header band and add it to the report.
            Dim ghBand As New GroupHeaderBand()
            report.Bands.Add(ghBand)

            ' Create a grouping criteria. 
            ghBand.GroupFields.Add(New GroupField("Category"))

            ' Display the grouping criteria in the group header.
            Dim labelGroup As New XRLabel()
            labelGroup.Text = "[MyQuery.Category]"
            ghBand.Controls.Add(labelGroup)
            ghBand.Height = CInt(labelGroup.HeightF)

            Return report
        End Function

        Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
            ' Show the report's print preview.
            Dim printTool As New ReportPrintTool(CreateReport())
            printTool.ShowPreview()
        End Sub

        Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            ' Open the report in an End-User Designer. 
            Dim designTool As New ReportDesignTool(CreateReport())
            designTool.ShowRibbonDesignerDialog()
        End Sub
#End Region

        
    End Class
End Namespace
