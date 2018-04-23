namespace WindowsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPreviewModally = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSilentPrint = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnExportHTML = new System.Windows.Forms.Button();
            this.btnExportMHT = new System.Windows.Forms.Button();
            this.btnExportText = new System.Windows.Forms.Button();
            this.btnExportImage = new System.Windows.Forms.Button();
            this.btnExportRTF = new System.Windows.Forms.Button();
            this.btnExportXLS = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(12, 12);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(106, 40);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPreviewModally
            // 
            this.btnPreviewModally.Location = new System.Drawing.Point(141, 12);
            this.btnPreviewModally.Name = "btnPreviewModally";
            this.btnPreviewModally.Size = new System.Drawing.Size(106, 40);
            this.btnPreviewModally.TabIndex = 1;
            this.btnPreviewModally.Text = "Preview Modally";
            this.btnPreviewModally.UseVisualStyleBackColor = true;
            this.btnPreviewModally.Click += new System.EventHandler(this.btnPreviewModally_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(270, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 40);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSilentPrint
            // 
            this.btnSilentPrint.Location = new System.Drawing.Point(399, 12);
            this.btnSilentPrint.Name = "btnSilentPrint";
            this.btnSilentPrint.Size = new System.Drawing.Size(106, 40);
            this.btnSilentPrint.TabIndex = 3;
            this.btnSilentPrint.Text = "Silent Print";
            this.btnSilentPrint.UseVisualStyleBackColor = true;
            this.btnSilentPrint.Click += new System.EventHandler(this.btnSilentPrint_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Location = new System.Drawing.Point(12, 68);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(106, 40);
            this.btnExportPDF.TabIndex = 4;
            this.btnExportPDF.Text = "Export to PDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // btnExportHTML
            // 
            this.btnExportHTML.Location = new System.Drawing.Point(141, 68);
            this.btnExportHTML.Name = "btnExportHTML";
            this.btnExportHTML.Size = new System.Drawing.Size(106, 40);
            this.btnExportHTML.TabIndex = 5;
            this.btnExportHTML.Text = "Export to HTML";
            this.btnExportHTML.UseVisualStyleBackColor = true;
            this.btnExportHTML.Click += new System.EventHandler(this.btnExportHTML_Click);
            // 
            // btnExportMHT
            // 
            this.btnExportMHT.Location = new System.Drawing.Point(270, 68);
            this.btnExportMHT.Name = "btnExportMHT";
            this.btnExportMHT.Size = new System.Drawing.Size(106, 40);
            this.btnExportMHT.TabIndex = 6;
            this.btnExportMHT.Text = "Export to MHT";
            this.btnExportMHT.UseVisualStyleBackColor = true;
            this.btnExportMHT.Click += new System.EventHandler(this.btnExportMHT_Click);
            // 
            // btnExportText
            // 
            this.btnExportText.Location = new System.Drawing.Point(399, 68);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(106, 40);
            this.btnExportText.TabIndex = 7;
            this.btnExportText.Text = "Export to Text";
            this.btnExportText.UseVisualStyleBackColor = true;
            this.btnExportText.Click += new System.EventHandler(this.btnExportText_Click);
            // 
            // btnExportImage
            // 
            this.btnExportImage.Location = new System.Drawing.Point(399, 124);
            this.btnExportImage.Name = "btnExportImage";
            this.btnExportImage.Size = new System.Drawing.Size(106, 40);
            this.btnExportImage.TabIndex = 11;
            this.btnExportImage.Text = "Export to Image";
            this.btnExportImage.UseVisualStyleBackColor = true;
            this.btnExportImage.Click += new System.EventHandler(this.btnExportImage_Click);
            // 
            // btnExportRTF
            // 
            this.btnExportRTF.Location = new System.Drawing.Point(270, 124);
            this.btnExportRTF.Name = "btnExportRTF";
            this.btnExportRTF.Size = new System.Drawing.Size(106, 40);
            this.btnExportRTF.TabIndex = 10;
            this.btnExportRTF.Text = "Export to RTF";
            this.btnExportRTF.UseVisualStyleBackColor = true;
            this.btnExportRTF.Click += new System.EventHandler(this.btnExportRTF_Click);
            // 
            // btnExportXLS
            // 
            this.btnExportXLS.Location = new System.Drawing.Point(141, 124);
            this.btnExportXLS.Name = "btnExportXLS";
            this.btnExportXLS.Size = new System.Drawing.Size(106, 40);
            this.btnExportXLS.TabIndex = 9;
            this.btnExportXLS.Text = "Export to XLS";
            this.btnExportXLS.UseVisualStyleBackColor = true;
            this.btnExportXLS.Click += new System.EventHandler(this.btnExportXLS_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(12, 124);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(106, 40);
            this.btnExportCSV.TabIndex = 8;
            this.btnExportCSV.Text = "Export to CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(204, 180);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 40);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit in the End-User Designer ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 232);
            this.Controls.Add(this.btnSilentPrint);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreviewModally);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnExportXLS);
            this.Controls.Add(this.btnExportRTF);
            this.Controls.Add(this.btnExportImage);
            this.Controls.Add(this.btnExportText);
            this.Controls.Add(this.btnExportMHT);
            this.Controls.Add(this.btnExportHTML);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.btnPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPreviewModally;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSilentPrint;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnExportHTML;
        private System.Windows.Forms.Button btnExportMHT;
        private System.Windows.Forms.Button btnExportText;
        private System.Windows.Forms.Button btnExportImage;
        private System.Windows.Forms.Button btnExportRTF;
        private System.Windows.Forms.Button btnExportXLS;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnEdit;
    }
}

