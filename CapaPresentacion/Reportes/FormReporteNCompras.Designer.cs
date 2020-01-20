namespace CapaPresentacion
{
    partial class FormReporteNCompras
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MiDataSet = new CapaPresentacion.MiDataSet();
            this.spreporte_compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spreporte_compraTableAdapter = new CapaPresentacion.MiDataSetTableAdapters.spreporte_compraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_compraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spreporte_compraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.ReportNCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(970, 462);
            this.reportViewer1.TabIndex = 0;
            // 
            // MiDataSet
            // 
            this.MiDataSet.DataSetName = "MiDataSet";
            this.MiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spreporte_compraBindingSource
            // 
            this.spreporte_compraBindingSource.DataMember = "spreporte_compra";
            this.spreporte_compraBindingSource.DataSource = this.MiDataSet;
            // 
            // spreporte_compraTableAdapter
            // 
            this.spreporte_compraTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteNCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 462);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteNCompras";
            this.Text = "Comprobante Nota Compras";
            this.Load += new System.EventHandler(this.FormReporteNCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_compraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spreporte_compraBindingSource;
        private MiDataSet MiDataSet;
        private MiDataSetTableAdapters.spreporte_compraTableAdapter spreporte_compraTableAdapter;
    }
}