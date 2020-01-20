namespace CapaPresentacion
{
    partial class FormArticulos
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
            this.Lbl_Articulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtGV_Listado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_TotalList = new System.Windows.Forms.Label();
            this.chkB_EliminarList = new System.Windows.Forms.CheckBox();
            this.btn_ImprimirList = new System.Windows.Forms.Button();
            this.btn_EliminarList = new System.Windows.Forms.Button();
            this.btn_BuscarList = new System.Windows.Forms.Button();
            this.lbl_NombreList = new System.Windows.Forms.Label();
            this.txt_BuscarList = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB_UnidadesMan = new System.Windows.Forms.TextBox();
            this.lbl_UnidadesMan = new System.Windows.Forms.Label();
            this.txtB_PrecioVentaMan = new System.Windows.Forms.TextBox();
            this.txtB_PrecioCompraMan = new System.Windows.Forms.TextBox();
            this.lbl_PrecioVenta = new System.Windows.Forms.Label();
            this.lbl_PrecioCompra = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.txtB_DescripcionMan = new System.Windows.Forms.TextBox();
            this.txtB_CodigoMan = new System.Windows.Forms.TextBox();
            this.lbl_DescripciónMan = new System.Windows.Forms.Label();
            this.lal_CodigoMan = new System.Windows.Forms.Label();
            this.error_Icono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tT_Mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Listado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Icono)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Articulo
            // 
            this.Lbl_Articulo.AutoSize = true;
            this.Lbl_Articulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Articulo.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Articulo.ForeColor = System.Drawing.Color.MediumBlue;
            this.Lbl_Articulo.Location = new System.Drawing.Point(47, 28);
            this.Lbl_Articulo.Name = "Lbl_Articulo";
            this.Lbl_Articulo.Size = new System.Drawing.Size(128, 34);
            this.Lbl_Articulo.TabIndex = 0;
            this.Lbl_Articulo.Text = "Artículos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(51, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 311);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtGV_Listado);
            this.tabPage1.Controls.Add(this.lbl_TotalList);
            this.tabPage1.Controls.Add(this.chkB_EliminarList);
            this.tabPage1.Controls.Add(this.btn_ImprimirList);
            this.tabPage1.Controls.Add(this.btn_EliminarList);
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
            this.dtGV_Listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_Listado_CellContentClick);
            this.dtGV_Listado.DoubleClick += new System.EventHandler(this.dtGV_Listado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lbl_TotalList
            // 
            this.lbl_TotalList.AutoSize = true;
            this.lbl_TotalList.Location = new System.Drawing.Point(417, 64);
            this.lbl_TotalList.Name = "lbl_TotalList";
            this.lbl_TotalList.Size = new System.Drawing.Size(31, 13);
            this.lbl_TotalList.TabIndex = 6;
            this.lbl_TotalList.Text = "Total";
            // 
            // chkB_EliminarList
            // 
            this.chkB_EliminarList.AutoSize = true;
            this.chkB_EliminarList.Location = new System.Drawing.Point(17, 63);
            this.chkB_EliminarList.Name = "chkB_EliminarList";
            this.chkB_EliminarList.Size = new System.Drawing.Size(62, 17);
            this.chkB_EliminarList.TabIndex = 5;
            this.chkB_EliminarList.Text = "Eliminar";
            this.chkB_EliminarList.UseVisualStyleBackColor = true;
            this.chkB_EliminarList.CheckedChanged += new System.EventHandler(this.chkB_EliminarList_CheckedChanged);
            // 
            // btn_ImprimirList
            // 
            this.btn_ImprimirList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImprimirList.Location = new System.Drawing.Point(521, 26);
            this.btn_ImprimirList.Name = "btn_ImprimirList";
            this.btn_ImprimirList.Size = new System.Drawing.Size(75, 23);
            this.btn_ImprimirList.TabIndex = 4;
            this.btn_ImprimirList.Text = "&Imprimir";
            this.btn_ImprimirList.UseVisualStyleBackColor = true;
            this.btn_ImprimirList.Click += new System.EventHandler(this.btn_ImprimirList_Click);
            // 
            // btn_EliminarList
            // 
            this.btn_EliminarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarList.Location = new System.Drawing.Point(395, 26);
            this.btn_EliminarList.Name = "btn_EliminarList";
            this.btn_EliminarList.Size = new System.Drawing.Size(75, 23);
            this.btn_EliminarList.TabIndex = 3;
            this.btn_EliminarList.Text = "&Eliminar";
            this.btn_EliminarList.UseVisualStyleBackColor = true;
            this.btn_EliminarList.Click += new System.EventHandler(this.btn_EliminarList_Click);
            // 
            // btn_BuscarList
            // 
            this.btn_BuscarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarList.Location = new System.Drawing.Point(264, 26);
            this.btn_BuscarList.Name = "btn_BuscarList";
            this.btn_BuscarList.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarList.TabIndex = 2;
            this.btn_BuscarList.Text = "&Buscar";
            this.btn_BuscarList.UseVisualStyleBackColor = true;
            this.btn_BuscarList.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // lbl_NombreList
            // 
            this.lbl_NombreList.AutoSize = true;
            this.lbl_NombreList.Location = new System.Drawing.Point(14, 31);
            this.lbl_NombreList.Name = "lbl_NombreList";
            this.lbl_NombreList.Size = new System.Drawing.Size(44, 13);
            this.lbl_NombreList.TabIndex = 1;
            this.lbl_NombreList.Text = "Nombre";
            // 
            // txt_BuscarList
            // 
            this.txt_BuscarList.Location = new System.Drawing.Point(107, 28);
            this.txt_BuscarList.Name = "txt_BuscarList";
            this.txt_BuscarList.Size = new System.Drawing.Size(137, 20);
            this.txt_BuscarList.TabIndex = 0;
            this.txt_BuscarList.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB_UnidadesMan);
            this.groupBox1.Controls.Add(this.lbl_UnidadesMan);
            this.groupBox1.Controls.Add(this.txtB_PrecioVentaMan);
            this.groupBox1.Controls.Add(this.txtB_PrecioCompraMan);
            this.groupBox1.Controls.Add(this.lbl_PrecioVenta);
            this.groupBox1.Controls.Add(this.lbl_PrecioCompra);
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.btn_Editar);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.btn_Nuevo);
            this.groupBox1.Controls.Add(this.txtB_DescripcionMan);
            this.groupBox1.Controls.Add(this.txtB_CodigoMan);
            this.groupBox1.Controls.Add(this.lbl_DescripciónMan);
            this.groupBox1.Controls.Add(this.lal_CodigoMan);
            this.groupBox1.Location = new System.Drawing.Point(26, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artículos";
            // 
            // txtB_UnidadesMan
            // 
            this.txtB_UnidadesMan.Location = new System.Drawing.Point(119, 181);
            this.txtB_UnidadesMan.Name = "txtB_UnidadesMan";
            this.txtB_UnidadesMan.Size = new System.Drawing.Size(92, 20);
            this.txtB_UnidadesMan.TabIndex = 16;
            // 
            // lbl_UnidadesMan
            // 
            this.lbl_UnidadesMan.AutoSize = true;
            this.lbl_UnidadesMan.Location = new System.Drawing.Point(7, 184);
            this.lbl_UnidadesMan.Name = "lbl_UnidadesMan";
            this.lbl_UnidadesMan.Size = new System.Drawing.Size(112, 13);
            this.lbl_UnidadesMan.TabIndex = 15;
            this.lbl_UnidadesMan.Text = "Cantidad de Unidades";
            // 
            // txtB_PrecioVentaMan
            // 
            this.txtB_PrecioVentaMan.Location = new System.Drawing.Point(377, 144);
            this.txtB_PrecioVentaMan.Name = "txtB_PrecioVentaMan";
            this.txtB_PrecioVentaMan.Size = new System.Drawing.Size(92, 20);
            this.txtB_PrecioVentaMan.TabIndex = 14;
            // 
            // txtB_PrecioCompraMan
            // 
            this.txtB_PrecioCompraMan.Location = new System.Drawing.Point(119, 144);
            this.txtB_PrecioCompraMan.Name = "txtB_PrecioCompraMan";
            this.txtB_PrecioCompraMan.Size = new System.Drawing.Size(92, 20);
            this.txtB_PrecioCompraMan.TabIndex = 13;
            // 
            // lbl_PrecioVenta
            // 
            this.lbl_PrecioVenta.AutoSize = true;
            this.lbl_PrecioVenta.Location = new System.Drawing.Point(277, 147);
            this.lbl_PrecioVenta.Name = "lbl_PrecioVenta";
            this.lbl_PrecioVenta.Size = new System.Drawing.Size(83, 13);
            this.lbl_PrecioVenta.TabIndex = 12;
            this.lbl_PrecioVenta.Text = "Precio de Venta";
            // 
            // lbl_PrecioCompra
            // 
            this.lbl_PrecioCompra.AutoSize = true;
            this.lbl_PrecioCompra.Location = new System.Drawing.Point(7, 147);
            this.lbl_PrecioCompra.Name = "lbl_PrecioCompra";
            this.lbl_PrecioCompra.Size = new System.Drawing.Size(91, 13);
            this.lbl_PrecioCompra.TabIndex = 11;
            this.lbl_PrecioCompra.Text = "Precio de Compra";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Location = new System.Drawing.Point(394, 220);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.Location = new System.Drawing.Point(302, 220);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 8;
            this.btn_Editar.Text = "E&ditar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.Location = new System.Drawing.Point(212, 220);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nuevo.Location = new System.Drawing.Point(119, 220);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 6;
            this.btn_Nuevo.Text = "&Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // txtB_DescripcionMan
            // 
            this.txtB_DescripcionMan.Location = new System.Drawing.Point(119, 73);
            this.txtB_DescripcionMan.Multiline = true;
            this.txtB_DescripcionMan.Name = "txtB_DescripcionMan";
            this.txtB_DescripcionMan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtB_DescripcionMan.Size = new System.Drawing.Size(350, 54);
            this.txtB_DescripcionMan.TabIndex = 4;
            // 
            // txtB_CodigoMan
            // 
            this.txtB_CodigoMan.Location = new System.Drawing.Point(119, 20);
            this.txtB_CodigoMan.Name = "txtB_CodigoMan";
            this.txtB_CodigoMan.Size = new System.Drawing.Size(350, 20);
            this.txtB_CodigoMan.TabIndex = 3;
            // 
            // lbl_DescripciónMan
            // 
            this.lbl_DescripciónMan.AutoSize = true;
            this.lbl_DescripciónMan.Location = new System.Drawing.Point(7, 76);
            this.lbl_DescripciónMan.Name = "lbl_DescripciónMan";
            this.lbl_DescripciónMan.Size = new System.Drawing.Size(63, 13);
            this.lbl_DescripciónMan.TabIndex = 1;
            this.lbl_DescripciónMan.Text = "Descripción";
            // 
            // lal_CodigoMan
            // 
            this.lal_CodigoMan.AutoSize = true;
            this.lal_CodigoMan.Location = new System.Drawing.Point(7, 20);
            this.lal_CodigoMan.Name = "lal_CodigoMan";
            this.lal_CodigoMan.Size = new System.Drawing.Size(40, 13);
            this.lal_CodigoMan.TabIndex = 0;
            this.lal_CodigoMan.Text = "Código";
            // 
            // error_Icono
            // 
            this.error_Icono.ContainerControl = this;
            // 
            // tT_Mensaje
            // 
            this.tT_Mensaje.IsBalloon = true;
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 414);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Lbl_Articulo);
            this.Name = "FormArticulos";
            this.Text = "Mantenimiento Articulos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormArticulos_FormClosing);
            this.Load += new System.EventHandler(this.FormArticulos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Listado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Icono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Articulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_ImprimirList;
        private System.Windows.Forms.Button btn_EliminarList;
        private System.Windows.Forms.Button btn_BuscarList;
        private System.Windows.Forms.Label lbl_NombreList;
        private System.Windows.Forms.TextBox txt_BuscarList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtGV_Listado;
        private System.Windows.Forms.Label lbl_TotalList;
        private System.Windows.Forms.CheckBox chkB_EliminarList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.TextBox txtB_DescripcionMan;
        private System.Windows.Forms.TextBox txtB_CodigoMan;
        private System.Windows.Forms.Label lbl_DescripciónMan;
        private System.Windows.Forms.Label lal_CodigoMan;
        private System.Windows.Forms.ErrorProvider error_Icono;
        private System.Windows.Forms.ToolTip tT_Mensaje;
        private System.Windows.Forms.Label lbl_PrecioVenta;
        private System.Windows.Forms.Label lbl_PrecioCompra;
        private System.Windows.Forms.TextBox txtB_PrecioVentaMan;
        private System.Windows.Forms.TextBox txtB_PrecioCompraMan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TextBox txtB_UnidadesMan;
        private System.Windows.Forms.Label lbl_UnidadesMan;
    }
}