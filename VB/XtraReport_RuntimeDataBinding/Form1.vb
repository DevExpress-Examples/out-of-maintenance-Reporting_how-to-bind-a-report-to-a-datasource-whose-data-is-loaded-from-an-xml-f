Imports System
Imports System.Windows.Forms
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraReports.UI
' ...

Namespace XtraReport_RuntimeDataBinding
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            ' Create an empty report.
            Dim report As New XtraReport()

            ' Create a data source.           
            Dim ds As New SqlDataSource(New XmlFileConnectionParameters("../../Cars.xml"))

            ' Create a query to access fields of the Cars data table.
            Dim query As New TableQuery()
            query.Name = "Cars"
            query.AddTable("Cars").SelectColumns("ID", "Trademark", "Model", "Category", "Description")
            ds.Queries.Add(query)

            ' Rebuild the data source schema to reflect the defined data hierarchy.
            ds.RebuildResultSchema()

            ' Assign the data source to the report.
            report.DataSource = ds
            report.DataMember = "Cars"

            ' Add a detail band to the report.
            Dim detailBand As New DetailBand()
            detailBand.Height = 50
            report.Bands.Add(detailBand)

            ' Add a label to the detail band.
            Dim label As XRLabel = New XRLabel With {.WidthF = 300}
            label.Text = "[Cars.Trademark] [Cars.Model]"
            detailBand.Controls.Add(label)

            ' Show the report's print preview.
            report.ShowPreview()
        End Sub
    End Class
End Namespace
