Imports Microsoft.VisualBasic
Imports System
Namespace DataBindingXMLIntoDataSet
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.lbTrademark = New DevExpress.XtraReports.UI.XRLabel()
			Me.lbModel = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbModel, Me.lbTrademark})
			Me.Detail.Height = 41
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbTrademark
			' 
			Me.lbTrademark.Location = New System.Drawing.Point(17, 8)
			Me.lbTrademark.Name = "lbTrademark"
			Me.lbTrademark.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbTrademark.Size = New System.Drawing.Size(192, 25)
			Me.lbTrademark.Text = "lbTrademark"
			' 
			' lbModel
			' 
			Me.lbModel.Location = New System.Drawing.Point(217, 8)
			Me.lbModel.Name = "lbModel"
			Me.lbModel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbModel.Size = New System.Drawing.Size(217, 25)
			Me.lbModel.Text = "lbModel"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
			Me.Version = "8.1"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Public lbTrademark As DevExpress.XtraReports.UI.XRLabel
		Public lbModel As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
