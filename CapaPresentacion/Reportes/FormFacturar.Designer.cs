namespace CapaPresentacion
{
    partial class FormFacturar
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
            this.spMostrar_ArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spMostrar_ArticulosTableAdapter = new CapaPresentacion.MiDataSetTableAdapters.spMostrar_ArticulosTableAdapter();
            this.facturarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturarTableAdapter = new CapaPresentacion.MiDataSetTableAdapters.facturarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrar_ArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.facturarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Facturar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(627, 380);
            this.reportViewer1.TabIndex = 0;
            // 
            // MiDataSet
            // 
            this.MiDataSet.DataSetName = "MiDataSet";
            this.MiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spMostrar_ArticulosBindingSource
            // 
            this.spMostrar_ArticulosBindingSource.DataMember = "spMostrar_Articulos";
            this.spMostrar_ArticulosBindingSource.DataSource = this.MiDataSet;
            // 
            // spMostrar_ArticulosTableAdapter
            // 
            this.spMostrar_ArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // facturarBindingSource
            // 
            this.facturarBindingSource.DataMember = "facturar";
            this.facturarBindingSource.DataSource = this.MiDataSet;
            // 
            // facturarTableAdapter
            // 
            this.facturarTableAdapter.ClearBeforeFill = true;
            // 
            // FormFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 415);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormFacturar";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FormFacturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrar_ArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spMostrar_ArticulosBindingSource;
        private MiDataSet MiDataSet;
        private MiDataSetTableAdapters.spMostrar_ArticulosTableAdapter spMostrar_ArticulosTableAdapter;
        private System.Windows.Forms.BindingSource facturarBindingSource;
        private MiDataSetTableAdapters.facturarTableAdapter facturarTableAdapter;
    }
}