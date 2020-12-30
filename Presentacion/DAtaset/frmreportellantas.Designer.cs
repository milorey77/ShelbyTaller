namespace Presentacion.DAtaset
{
    partial class frmreportellantas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.llantasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportesdataset = new Presentacion.DAtaset.reportesdataset();
            this.rptllantas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.llantasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesdataset)).BeginInit();
            this.SuspendLayout();
            // 
            // llantasBindingSource
            // 
            this.llantasBindingSource.DataMember = "llantas";
            this.llantasBindingSource.DataSource = this.reportesdataset;
            // 
            // reportesdataset
            // 
            this.reportesdataset.DataSetName = "reportesdataset";
            this.reportesdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptllantas
            // 
            this.rptllantas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "llantas";
            reportDataSource1.Value = this.llantasBindingSource;
            this.rptllantas.LocalReport.DataSources.Add(reportDataSource1);
            this.rptllantas.LocalReport.ReportEmbeddedResource = "Presentacion.DAtaset.Reportellantas.rdlc";
            this.rptllantas.Location = new System.Drawing.Point(0, 0);
            this.rptllantas.Name = "rptllantas";
            this.rptllantas.ServerReport.BearerToken = null;
            this.rptllantas.Size = new System.Drawing.Size(900, 740);
            this.rptllantas.TabIndex = 0;
            this.rptllantas.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frmreportellantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.rptllantas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmreportellantas";
            this.Opacity = 0.9D;
            this.Text = "frmreportellantas";
            this.Load += new System.EventHandler(this.frmreportellantas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.llantasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesdataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptllantas;
        private System.Windows.Forms.BindingSource llantasBindingSource;
        private reportesdataset reportesdataset;
    }
}