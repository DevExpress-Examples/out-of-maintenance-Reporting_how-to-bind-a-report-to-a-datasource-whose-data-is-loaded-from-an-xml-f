Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace DataBindingXMLIntoDataSet
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            ' Create a report.
            Dim report As New XtraReport1()

            ' Create a DataSet and fill it with data from an XML file.
            Dim xmlDataSet As New DataSet()
            xmlDataSet.ReadXml("..\..\Cars.xml")

            ' Bind the report to the DataSet.
            report.DataSource = xmlDataSet

            ' Add two bound labels to the Detail bands.
            report.lbModel.DataBindings.Add("Text", report.DataSource, "Cars.Model", "Model: {0}")
            report.lbTrademark.DataBindings.Add("Text", report.DataSource, "Cars.Trademark", "Trademark: {0}")

            ' Show the report's print preview.
            report.ShowPreview()

        End Sub
    End Class
End Namespace