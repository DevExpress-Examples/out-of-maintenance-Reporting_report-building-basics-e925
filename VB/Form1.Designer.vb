Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btnPreview = New System.Windows.Forms.Button()
			Me.btnPreviewModally = New System.Windows.Forms.Button()
			Me.btnPrint = New System.Windows.Forms.Button()
			Me.btnSilentPrint = New System.Windows.Forms.Button()
			Me.btnExportPDF = New System.Windows.Forms.Button()
			Me.btnExportHTML = New System.Windows.Forms.Button()
			Me.btnExportMHT = New System.Windows.Forms.Button()
			Me.btnExportText = New System.Windows.Forms.Button()
			Me.btnExportImage = New System.Windows.Forms.Button()
			Me.btnExportRTF = New System.Windows.Forms.Button()
			Me.btnExportXLS = New System.Windows.Forms.Button()
			Me.btnExportCSV = New System.Windows.Forms.Button()
			Me.btnEdit = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' btnPreview
			' 
			Me.btnPreview.Location = New System.Drawing.Point(12, 12)
			Me.btnPreview.Name = "btnPreview"
			Me.btnPreview.Size = New System.Drawing.Size(106, 40)
			Me.btnPreview.TabIndex = 0
			Me.btnPreview.Text = "Preview"
			Me.btnPreview.UseVisualStyleBackColor = True
'			Me.btnPreview.Click += New System.EventHandler(Me.btnPreview_Click);
			' 
			' btnPreviewModally
			' 
			Me.btnPreviewModally.Location = New System.Drawing.Point(141, 12)
			Me.btnPreviewModally.Name = "btnPreviewModally"
			Me.btnPreviewModally.Size = New System.Drawing.Size(106, 40)
			Me.btnPreviewModally.TabIndex = 1
			Me.btnPreviewModally.Text = "Preview Modally"
			Me.btnPreviewModally.UseVisualStyleBackColor = True
'			Me.btnPreviewModally.Click += New System.EventHandler(Me.btnPreviewModally_Click);
			' 
			' btnPrint
			' 
			Me.btnPrint.Location = New System.Drawing.Point(270, 12)
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.Size = New System.Drawing.Size(106, 40)
			Me.btnPrint.TabIndex = 2
			Me.btnPrint.Text = "Print"
			Me.btnPrint.UseVisualStyleBackColor = True
'			Me.btnPrint.Click += New System.EventHandler(Me.btnPrint_Click);
			' 
			' btnSilentPrint
			' 
			Me.btnSilentPrint.Location = New System.Drawing.Point(399, 12)
			Me.btnSilentPrint.Name = "btnSilentPrint"
			Me.btnSilentPrint.Size = New System.Drawing.Size(106, 40)
			Me.btnSilentPrint.TabIndex = 3
			Me.btnSilentPrint.Text = "Silent Print"
			Me.btnSilentPrint.UseVisualStyleBackColor = True
'			Me.btnSilentPrint.Click += New System.EventHandler(Me.btnSilentPrint_Click);
			' 
			' btnExportPDF
			' 
			Me.btnExportPDF.Location = New System.Drawing.Point(12, 68)
			Me.btnExportPDF.Name = "btnExportPDF"
			Me.btnExportPDF.Size = New System.Drawing.Size(106, 40)
			Me.btnExportPDF.TabIndex = 4
			Me.btnExportPDF.Text = "Export to PDF"
			Me.btnExportPDF.UseVisualStyleBackColor = True
'			Me.btnExportPDF.Click += New System.EventHandler(Me.btnExportPDF_Click);
			' 
			' btnExportHTML
			' 
			Me.btnExportHTML.Location = New System.Drawing.Point(141, 68)
			Me.btnExportHTML.Name = "btnExportHTML"
			Me.btnExportHTML.Size = New System.Drawing.Size(106, 40)
			Me.btnExportHTML.TabIndex = 5
			Me.btnExportHTML.Text = "Export to HTML"
			Me.btnExportHTML.UseVisualStyleBackColor = True
'			Me.btnExportHTML.Click += New System.EventHandler(Me.btnExportHTML_Click);
			' 
			' btnExportMHT
			' 
			Me.btnExportMHT.Location = New System.Drawing.Point(270, 68)
			Me.btnExportMHT.Name = "btnExportMHT"
			Me.btnExportMHT.Size = New System.Drawing.Size(106, 40)
			Me.btnExportMHT.TabIndex = 6
			Me.btnExportMHT.Text = "Export to MHT"
			Me.btnExportMHT.UseVisualStyleBackColor = True
'			Me.btnExportMHT.Click += New System.EventHandler(Me.btnExportMHT_Click);
			' 
			' btnExportText
			' 
			Me.btnExportText.Location = New System.Drawing.Point(399, 68)
			Me.btnExportText.Name = "btnExportText"
			Me.btnExportText.Size = New System.Drawing.Size(106, 40)
			Me.btnExportText.TabIndex = 7
			Me.btnExportText.Text = "Export to Text"
			Me.btnExportText.UseVisualStyleBackColor = True
'			Me.btnExportText.Click += New System.EventHandler(Me.btnExportText_Click);
			' 
			' btnExportImage
			' 
			Me.btnExportImage.Location = New System.Drawing.Point(399, 124)
			Me.btnExportImage.Name = "btnExportImage"
			Me.btnExportImage.Size = New System.Drawing.Size(106, 40)
			Me.btnExportImage.TabIndex = 11
			Me.btnExportImage.Text = "Export to Image"
			Me.btnExportImage.UseVisualStyleBackColor = True
'			Me.btnExportImage.Click += New System.EventHandler(Me.btnExportImage_Click);
			' 
			' btnExportRTF
			' 
			Me.btnExportRTF.Location = New System.Drawing.Point(270, 124)
			Me.btnExportRTF.Name = "btnExportRTF"
			Me.btnExportRTF.Size = New System.Drawing.Size(106, 40)
			Me.btnExportRTF.TabIndex = 10
			Me.btnExportRTF.Text = "Export to RTF"
			Me.btnExportRTF.UseVisualStyleBackColor = True
'			Me.btnExportRTF.Click += New System.EventHandler(Me.btnExportRTF_Click);
			' 
			' btnExportXLS
			' 
			Me.btnExportXLS.Location = New System.Drawing.Point(141, 124)
			Me.btnExportXLS.Name = "btnExportXLS"
			Me.btnExportXLS.Size = New System.Drawing.Size(106, 40)
			Me.btnExportXLS.TabIndex = 9
			Me.btnExportXLS.Text = "Export to XLS"
			Me.btnExportXLS.UseVisualStyleBackColor = True
'			Me.btnExportXLS.Click += New System.EventHandler(Me.btnExportXLS_Click);
			' 
			' btnExportCSV
			' 
			Me.btnExportCSV.Location = New System.Drawing.Point(12, 124)
			Me.btnExportCSV.Name = "btnExportCSV"
			Me.btnExportCSV.Size = New System.Drawing.Size(106, 40)
			Me.btnExportCSV.TabIndex = 8
			Me.btnExportCSV.Text = "Export to CSV"
			Me.btnExportCSV.UseVisualStyleBackColor = True
'			Me.btnExportCSV.Click += New System.EventHandler(Me.btnExportCSV_Click);
			' 
			' btnEdit
			' 
			Me.btnEdit.Location = New System.Drawing.Point(204, 180)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New System.Drawing.Size(106, 40)
			Me.btnEdit.TabIndex = 12
			Me.btnEdit.Text = "Edit in the End-User Designer "
			Me.btnEdit.UseVisualStyleBackColor = True
'			Me.btnEdit.Click += New System.EventHandler(Me.btnEdit_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(515, 232)
			Me.Controls.Add(Me.btnSilentPrint)
			Me.Controls.Add(Me.btnPrint)
			Me.Controls.Add(Me.btnPreviewModally)
			Me.Controls.Add(Me.btnEdit)
			Me.Controls.Add(Me.btnExportCSV)
			Me.Controls.Add(Me.btnExportXLS)
			Me.Controls.Add(Me.btnExportRTF)
			Me.Controls.Add(Me.btnExportImage)
			Me.Controls.Add(Me.btnExportText)
			Me.Controls.Add(Me.btnExportMHT)
			Me.Controls.Add(Me.btnExportHTML)
			Me.Controls.Add(Me.btnExportPDF)
			Me.Controls.Add(Me.btnPreview)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnPreview As System.Windows.Forms.Button
		Private WithEvents btnPreviewModally As System.Windows.Forms.Button
		Private WithEvents btnPrint As System.Windows.Forms.Button
		Private WithEvents btnSilentPrint As System.Windows.Forms.Button
		Private WithEvents btnExportPDF As System.Windows.Forms.Button
		Private WithEvents btnExportHTML As System.Windows.Forms.Button
		Private WithEvents btnExportMHT As System.Windows.Forms.Button
		Private WithEvents btnExportText As System.Windows.Forms.Button
		Private WithEvents btnExportImage As System.Windows.Forms.Button
		Private WithEvents btnExportRTF As System.Windows.Forms.Button
		Private WithEvents btnExportXLS As System.Windows.Forms.Button
		Private WithEvents btnExportCSV As System.Windows.Forms.Button
		Private WithEvents btnEdit As System.Windows.Forms.Button
	End Class
End Namespace

