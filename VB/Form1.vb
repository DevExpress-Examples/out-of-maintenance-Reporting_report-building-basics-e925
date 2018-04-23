Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private report As XtraReport1

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			report = New XtraReport1()
		End Sub

		Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			' Show the form with the report's print preview.
			report.ShowPreview()
		End Sub

		Private Sub btnPreviewModally_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreviewModally.Click
			' Modally show the form with the report's print preview.
			report.ShowPreviewDialog()
		End Sub

		Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			' Print the report using the Print dialog.
			report.PrintDialog()
		End Sub

		Private Sub btnSilentPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSilentPrint.Click
			' Silently print the report to the default printer.
			report.Print()
		End Sub

		Private Sub btnExportPDF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportPDF.Click
			' Export the report to PDF.
			report.ExportToPdf("report.pdf")
		End Sub

		Private Sub btnExportHTML_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportHTML.Click
			' Export the report to HTML.
			report.ExportToHtml("report.html")
		End Sub

		Private Sub btnExportMHT_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportMHT.Click
			' Export the report to MHT.
			report.ExportToMht("report.mht")
		End Sub

		Private Sub btnExportText_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportText.Click
			' Export the report to Text.
			report.ExportToText("report.txt")
		End Sub

		Private Sub btnExportCSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportCSV.Click
			' Export the report to CSV.
			report.ExportToCsv("report.csv")
		End Sub

		Private Sub btnExportXLS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportXLS.Click
			' Export the report to XLS.
			report.ExportToXls("report.xls")
		End Sub

		Private Sub btnExportRTF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportRTF.Click
			' Export the report to RTF.
			report.ExportToRtf("report.rtf")
		End Sub

		Private Sub btnExportImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportImage.Click
			' Export the report to Image.
			report.ExportToImage("report.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
		End Sub

		Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
			' Edit the report in the End-User Designer.
			report.ShowDesignerDialog()
		End Sub
	End Class
End Namespace