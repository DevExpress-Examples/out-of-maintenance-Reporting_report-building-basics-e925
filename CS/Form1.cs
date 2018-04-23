using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        XtraReport1 report;

        private void Form1_Load(object sender, EventArgs e) {
            report = new XtraReport1();
        }

        private void btnPreview_Click(object sender, EventArgs e) {
            // Show the form with the report's print preview.
            report.ShowPreview();
        }

        private void btnPreviewModally_Click(object sender, EventArgs e) {
            // Modally show the form with the report's print preview.
            report.ShowPreviewDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            // Print the report using the Print dialog.
            report.PrintDialog();
        }

        private void btnSilentPrint_Click(object sender, EventArgs e) {
            // Silently print the report to the default printer.
            report.Print();
        }

        private void btnExportPDF_Click(object sender, EventArgs e) {
            // Export the report to PDF.
            report.ExportToPdf("report.pdf");
        }

        private void btnExportHTML_Click(object sender, EventArgs e) {
            // Export the report to HTML.
            report.ExportToHtml("report.html");
        }

        private void btnExportMHT_Click(object sender, EventArgs e) {
            // Export the report to MHT.
            report.ExportToMht("report.mht");
        }

        private void btnExportText_Click(object sender, EventArgs e) {
            // Export the report to Text.
            report.ExportToText("report.txt");
        }

        private void btnExportCSV_Click(object sender, EventArgs e) {
            // Export the report to CSV.
            report.ExportToCsv("report.csv");
        }

        private void btnExportXLS_Click(object sender, EventArgs e) {
            // Export the report to XLS.
            report.ExportToXls("report.xls");
        }

        private void btnExportRTF_Click(object sender, EventArgs e) {
            // Export the report to RTF.
            report.ExportToRtf("report.rtf");
        }

        private void btnExportImage_Click(object sender, EventArgs e) {
            // Export the report to Image.
            report.ExportToImage("report.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            // Edit the report in the End-User Designer.
            report.ShowDesignerDialog();
        }
    }
}