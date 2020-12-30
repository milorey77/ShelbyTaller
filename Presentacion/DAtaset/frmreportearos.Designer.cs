namespace Presentacion.DAtaset
{
    partial class frmreportearos
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
            this.rptaros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.arosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportesdataset = new Presentacion.DAtaset.reportesdataset();
            this.llantasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.arosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.llantasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptaros
            // 
            this.rptaros.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "aros";
            reportDataSource1.Value = this.arosBindingSource;
            this.rptaros.LocalReport.DataSources.Add(reportDataSource1);
            this.rptaros.LocalReport.ReportEmbeddedResource = "Presentacion.DAtaset.Reportearos.rdlc";
            this.rptaros.Location = new System.Drawing.Point(0, 0);
            this.rptaros.Name = "rptaros";
            this.rptaros.ServerReport.BearerToken = null;
            this.rptaros.Size = new System.Drawing.Size(900, 740);
            this.rptaros.TabIndex = 1;
            // 
            // arosBindingSource
            // 
            this.arosBindingSource.DataMember = "aros";
            this.arosBindingSource.DataSource = this.reportesdataset;
            // 
            // reportesdataset
            // 
            this.reportesdataset.DataSetName = "reportesdataset";
            this.reportesdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // llantasBindingSource
            // 
            this.llantasBindingSource.DataMember = "llantas";
            this.llantasBindingSource.DataSource = this.reportesdataset;
            // 
            // frmreportearos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.rptaros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmreportearos";
            this.Opacity = 0.9D;
            this.Text = "frmreportearos";
            this.Load += new System.EventHandler(this.frmreportearos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.llantasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rptaros;
        private System.Windows.Forms.BindingSource arosBindingSource;
        private reportesdataset reportesdataset;
        private System.Windows.Forms.BindingSource llantasBindingSource;
    }
}