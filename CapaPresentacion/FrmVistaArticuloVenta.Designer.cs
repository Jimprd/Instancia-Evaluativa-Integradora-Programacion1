namespace CapaPresentacion
{
    partial class FrmVistaArticuloVenta
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_TotalList = new System.Windows.Forms.Label();
            this.dtGV_Listado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_BuscarList = new System.Windows.Forms.Button();
            this.lbl_NombreList = new System.Windows.Forms.Label();
            this.txt_BuscarList = new System.Windows.Forms.TextBox();
            this.Lbl_Articulo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Listado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(37, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 311);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_TotalList);
            this.tabPage1.Controls.Add(this.dtGV_Listado);
            this.tabPage1.Controls.Add(this.btn_BuscarList);
            this.tabPage1.Controls.Add(this.lbl_NombreList);
            this.tabPage1.Controls.Add(this.txt_BuscarList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_TotalList
            // 
            this.lbl_TotalList.AutoSize = true;
            this.lbl_TotalList.Location = new System.Drawing.Point(455, 71);
            this.lbl_TotalList.Name = "lbl_TotalList";
            this.lbl_TotalList.Size = new System.Drawing.Size(99, 13);
            this.lbl_TotalList.TabIndex = 8;
            this.lbl_TotalList.Text = "Total de Registros: ";
            // 
            // dtGV_Listado
            // 
            this.dtGV_Listado.AllowUserToAddRows = false;
            this.dtGV_Listado.AllowUserToDeleteRows = false;
            this.dtGV_Listado.AllowUserToOrderColumns = true;
            this.dtGV_Listado.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtGV_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_Listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dtGV_Listado.Location = new System.Drawing.Point(17, 87);
            this.dtGV_Listado.MultiSelect = false;
            this.dtGV_Listado.Name = "dtGV_Listado";
            this.dtGV_Listado.ReadOnly = true;
            this.dtGV_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGV_Listado.Size = new System.Drawing.Size(579, 170);
            this.dtGV_Listado.TabIndex = 7;
            this.dtGV_Listado.DoubleClick += new System.EventHandler(this.dtGV_Listado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // btn_BuscarList
            // 
            this.btn_BuscarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarList.Location = new System.Drawing.Point(17, 55);
            this.btn_BuscarList.Name = "btn_BuscarList";
            this.btn_BuscarList.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarList.TabIndex = 2;
            this.btn_BuscarList.Text = "&Buscar";
            this.btn_BuscarList.UseVisualStyleBackColor = true;
            this.btn_BuscarList.Click += new System.EventHandler(this.btn_BuscarList_Click);
            // 
            // lbl_NombreList
            // 
            this.lbl_NombreList.AutoSize = true;
            this.lbl_NombreList.Location = new System.Drawing.Point(14, 13);
            this.lbl_NombreList.Name = "lbl_NombreList";
            this.lbl_NombreList.Size = new System.Drawing.Size(44, 13);
            this.lbl_NombreList.TabIndex = 1;
            this.lbl_NombreList.Text = "Nombre";
            // 
            // txt_BuscarList
            // 
            this.txt_BuscarList.Location = new System.Drawing.Point(17, 31);
            this.txt_BuscarList.Name = "txt_BuscarList";
            this.txt_BuscarList.Size = new System.Drawing.Size(137, 20);
            this.txt_BuscarList.TabIndex = 0;
            // 
            // Lbl_Articulo
            // 
            this.Lbl_Articulo.AutoSize = true;
            this.Lbl_Articulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Articulo.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Articulo.ForeColor = System.Drawing.Color.MediumBlue;
            this.Lbl_Articulo.Location = new System.Drawing.Point(31, 6);
            this.Lbl_Articulo.Name = "Lbl_Articulo";
            this.Lbl_Articulo.Size = new System.Drawing.Size(235, 34);
            this.Lbl_Articulo.TabIndex = 12;
            this.Lbl_Articulo.Text = "Vista de Artículos";
            // 
            // FrmVistaArticuloVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 380);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Lbl_Articulo);
            this.Name = "FrmVistaArticuloVenta";
            this.Text = "FrmVistaArticuloVenta";
            this.Load += new System.EventHandler(this.FrmVistaArticuloVenta_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_TotalList;
        private System.Windows.Forms.DataGridView dtGV_Listado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btn_BuscarList;
        private System.Windows.Forms.Label lbl_NombreList;
        private System.Windows.Forms.TextBox txt_BuscarList;
        private System.Windows.Forms.Label Lbl_Articulo;
    }
}