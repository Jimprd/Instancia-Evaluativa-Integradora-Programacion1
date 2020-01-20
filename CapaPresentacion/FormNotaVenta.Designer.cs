﻿namespace CapaPresentacion
{
    partial class FormNotaVenta
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
            this.error_Icono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tT_Mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.txtB_UnidadesMan = new System.Windows.Forms.TextBox();
            this.chkB_EliminarList = new System.Windows.Forms.CheckBox();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.btn_BuscarList = new System.Windows.Forms.Button();
            this.lbl_NombreList = new System.Windows.Forms.Label();
            this.lbl_Compras = new System.Windows.Forms.Label();
            this.btn_ImprimirList = new System.Windows.Forms.Button();
            this.dtGV_ListadoDetalle = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtGV_Listado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_TotalList = new System.Windows.Forms.Label();
            this.txtB_importetotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtB_CodigoMan = new System.Windows.Forms.TextBox();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.lbl_CodigoArt = new System.Windows.Forms.Label();
            this.lbl_DescripciónMan = new System.Windows.Forms.Label();
            this.txtB_PrecioVenta = new System.Windows.Forms.TextBox();
            this.txtB_NumRenglon = new System.Windows.Forms.TextBox();
            this.txtB_DescripcionMan = new System.Windows.Forms.TextBox();
            this.lbl_NumRenglon = new System.Windows.Forms.Label();
            this.txtB_StockMan = new System.Windows.Forms.TextBox();
            this.lbl_PrecioVenta = new System.Windows.Forms.Label();
            this.btn_BuscarArt = new System.Windows.Forms.Button();
            this.lbl_StockMant = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_UnidadesMan = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB_NumComprobante = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_Fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.txtB_Proveedor = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_Icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_ListadoDetalle)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Listado)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // error_Icono
            // 
            this.error_Icono.ContainerControl = this;
            // 
            // tT_Mensaje
            // 
            this.tT_Mensaje.IsBalloon = true;
            // 
            // txtB_UnidadesMan
            // 
            this.txtB_UnidadesMan.Location = new System.Drawing.Point(453, 54);
            this.txtB_UnidadesMan.Name = "txtB_UnidadesMan";
            this.txtB_UnidadesMan.Size = new System.Drawing.Size(117, 20);
            this.txtB_UnidadesMan.TabIndex = 16;
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
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Facturar.Location = new System.Drawing.Point(404, 31);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(75, 23);
            this.btn_Facturar.TabIndex = 3;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.UseVisualStyleBackColor = true;
            this.btn_Facturar.Click += new System.EventHandler(this.btn_Facturar_Click);
            // 
            // btn_BuscarList
            // 
            this.btn_BuscarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarList.Location = new System.Drawing.Point(292, 29);
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
            this.lbl_NombreList.Location = new System.Drawing.Point(14, 14);
            this.lbl_NombreList.Name = "lbl_NombreList";
            this.lbl_NombreList.Size = new System.Drawing.Size(65, 13);
            this.lbl_NombreList.TabIndex = 1;
            this.lbl_NombreList.Text = "Fecha Inicio";
            // 
            // lbl_Compras
            // 
            this.lbl_Compras.AutoSize = true;
            this.lbl_Compras.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Compras.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compras.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_Compras.Location = new System.Drawing.Point(26, 9);
            this.lbl_Compras.Name = "lbl_Compras";
            this.lbl_Compras.Size = new System.Drawing.Size(99, 34);
            this.lbl_Compras.TabIndex = 4;
            this.lbl_Compras.Text = "Ventas";
            // 
            // btn_ImprimirList
            // 
            this.btn_ImprimirList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImprimirList.Location = new System.Drawing.Point(521, 31);
            this.btn_ImprimirList.Name = "btn_ImprimirList";
            this.btn_ImprimirList.Size = new System.Drawing.Size(75, 23);
            this.btn_ImprimirList.TabIndex = 4;
            this.btn_ImprimirList.Text = "&Imprimir";
            this.btn_ImprimirList.UseVisualStyleBackColor = true;
            this.btn_ImprimirList.Click += new System.EventHandler(this.btn_ImprimirList_Click);
            // 
            // dtGV_ListadoDetalle
            // 
            this.dtGV_ListadoDetalle.AllowUserToAddRows = false;
            this.dtGV_ListadoDetalle.AllowUserToDeleteRows = false;
            this.dtGV_ListadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_ListadoDetalle.Location = new System.Drawing.Point(27, 219);
            this.dtGV_ListadoDetalle.Name = "dtGV_ListadoDetalle";
            this.dtGV_ListadoDetalle.Size = new System.Drawing.Size(817, 191);
            this.dtGV_ListadoDetalle.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtFechaFin);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtFechaInicio);
            this.tabPage1.Controls.Add(this.dtGV_Listado);
            this.tabPage1.Controls.Add(this.lbl_TotalList);
            this.tabPage1.Controls.Add(this.chkB_EliminarList);
            this.tabPage1.Controls.Add(this.btn_ImprimirList);
            this.tabPage1.Controls.Add(this.btn_Facturar);
            this.tabPage1.Controls.Add(this.btn_BuscarList);
            this.tabPage1.Controls.Add(this.lbl_NombreList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(912, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(155, 30);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(87, 20);
            this.dtFechaFin.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha Fin";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(17, 30);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(87, 20);
            this.dtFechaInicio.TabIndex = 8;
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
            this.lbl_TotalList.Location = new System.Drawing.Point(467, 64);
            this.lbl_TotalList.Name = "lbl_TotalList";
            this.lbl_TotalList.Size = new System.Drawing.Size(129, 13);
            this.lbl_TotalList.TabIndex = 6;
            this.lbl_TotalList.Text = "Total de Registros: 00000";
            // 
            // txtB_importetotal
            // 
            this.txtB_importetotal.Location = new System.Drawing.Point(716, 61);
            this.txtB_importetotal.Name = "txtB_importetotal";
            this.txtB_importetotal.Size = new System.Drawing.Size(117, 20);
            this.txtB_importetotal.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtB_CodigoMan);
            this.groupBox2.Controls.Add(this.btn_Borrar);
            this.groupBox2.Controls.Add(this.lbl_CodigoArt);
            this.groupBox2.Controls.Add(this.lbl_DescripciónMan);
            this.groupBox2.Controls.Add(this.txtB_PrecioVenta);
            this.groupBox2.Controls.Add(this.txtB_NumRenglon);
            this.groupBox2.Controls.Add(this.txtB_DescripcionMan);
            this.groupBox2.Controls.Add(this.lbl_NumRenglon);
            this.groupBox2.Controls.Add(this.txtB_StockMan);
            this.groupBox2.Controls.Add(this.lbl_PrecioVenta);
            this.groupBox2.Controls.Add(this.btn_BuscarArt);
            this.groupBox2.Controls.Add(this.lbl_StockMant);
            this.groupBox2.Controls.Add(this.btn_Agregar);
            this.groupBox2.Controls.Add(this.lbl_UnidadesMan);
            this.groupBox2.Controls.Add(this.txtB_UnidadesMan);
            this.groupBox2.Location = new System.Drawing.Point(27, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 118);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // txtB_CodigoMan
            // 
            this.txtB_CodigoMan.Location = new System.Drawing.Point(110, 54);
            this.txtB_CodigoMan.Name = "txtB_CodigoMan";
            this.txtB_CodigoMan.Size = new System.Drawing.Size(118, 20);
            this.txtB_CodigoMan.TabIndex = 38;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Borrar.Location = new System.Drawing.Point(689, 52);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(117, 22);
            this.btn_Borrar.TabIndex = 36;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // lbl_CodigoArt
            // 
            this.lbl_CodigoArt.AutoSize = true;
            this.lbl_CodigoArt.Location = new System.Drawing.Point(17, 59);
            this.lbl_CodigoArt.Name = "lbl_CodigoArt";
            this.lbl_CodigoArt.Size = new System.Drawing.Size(80, 13);
            this.lbl_CodigoArt.TabIndex = 37;
            this.lbl_CodigoArt.Text = "Código Artículo";
            // 
            // lbl_DescripciónMan
            // 
            this.lbl_DescripciónMan.AutoSize = true;
            this.lbl_DescripciónMan.Location = new System.Drawing.Point(17, 24);
            this.lbl_DescripciónMan.Name = "lbl_DescripciónMan";
            this.lbl_DescripciónMan.Size = new System.Drawing.Size(84, 13);
            this.lbl_DescripciónMan.TabIndex = 1;
            this.lbl_DescripciónMan.Text = "Articulo Descrip.";
            // 
            // txtB_PrecioVenta
            // 
            this.txtB_PrecioVenta.Location = new System.Drawing.Point(453, 21);
            this.txtB_PrecioVenta.Name = "txtB_PrecioVenta";
            this.txtB_PrecioVenta.Size = new System.Drawing.Size(117, 20);
            this.txtB_PrecioVenta.TabIndex = 35;
            // 
            // txtB_NumRenglon
            // 
            this.txtB_NumRenglon.Location = new System.Drawing.Point(110, 89);
            this.txtB_NumRenglon.Name = "txtB_NumRenglon";
            this.txtB_NumRenglon.Size = new System.Drawing.Size(117, 20);
            this.txtB_NumRenglon.TabIndex = 28;
            // 
            // txtB_DescripcionMan
            // 
            this.txtB_DescripcionMan.Location = new System.Drawing.Point(110, 21);
            this.txtB_DescripcionMan.Name = "txtB_DescripcionMan";
            this.txtB_DescripcionMan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtB_DescripcionMan.Size = new System.Drawing.Size(117, 20);
            this.txtB_DescripcionMan.TabIndex = 4;
            // 
            // lbl_NumRenglon
            // 
            this.lbl_NumRenglon.AutoSize = true;
            this.lbl_NumRenglon.Location = new System.Drawing.Point(17, 92);
            this.lbl_NumRenglon.Name = "lbl_NumRenglon";
            this.lbl_NumRenglon.Size = new System.Drawing.Size(62, 13);
            this.lbl_NumRenglon.TabIndex = 27;
            this.lbl_NumRenglon.Text = "Nº Renglón";
            // 
            // txtB_StockMan
            // 
            this.txtB_StockMan.Location = new System.Drawing.Point(453, 89);
            this.txtB_StockMan.Name = "txtB_StockMan";
            this.txtB_StockMan.Size = new System.Drawing.Size(117, 20);
            this.txtB_StockMan.TabIndex = 25;
            // 
            // lbl_PrecioVenta
            // 
            this.lbl_PrecioVenta.AutoSize = true;
            this.lbl_PrecioVenta.Location = new System.Drawing.Point(341, 24);
            this.lbl_PrecioVenta.Name = "lbl_PrecioVenta";
            this.lbl_PrecioVenta.Size = new System.Drawing.Size(83, 13);
            this.lbl_PrecioVenta.TabIndex = 34;
            this.lbl_PrecioVenta.Text = "Precio de Venta";
            // 
            // btn_BuscarArt
            // 
            this.btn_BuscarArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarArt.Location = new System.Drawing.Point(233, 20);
            this.btn_BuscarArt.Name = "btn_BuscarArt";
            this.btn_BuscarArt.Size = new System.Drawing.Size(50, 21);
            this.btn_BuscarArt.TabIndex = 32;
            this.btn_BuscarArt.Text = "Buscar";
            this.btn_BuscarArt.UseVisualStyleBackColor = true;
            this.btn_BuscarArt.Click += new System.EventHandler(this.btn_BuscarArt_Click);
            // 
            // lbl_StockMant
            // 
            this.lbl_StockMant.AutoSize = true;
            this.lbl_StockMant.Location = new System.Drawing.Point(341, 92);
            this.lbl_StockMant.Name = "lbl_StockMant";
            this.lbl_StockMant.Size = new System.Drawing.Size(65, 13);
            this.lbl_StockMant.TabIndex = 24;
            this.lbl_StockMant.Text = "Stock Inicial";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.Location = new System.Drawing.Point(689, 20);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(117, 22);
            this.btn_Agregar.TabIndex = 33;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_UnidadesMan
            // 
            this.lbl_UnidadesMan.AutoSize = true;
            this.lbl_UnidadesMan.Location = new System.Drawing.Point(341, 57);
            this.lbl_UnidadesMan.Name = "lbl_UnidadesMan";
            this.lbl_UnidadesMan.Size = new System.Drawing.Size(80, 13);
            this.lbl_UnidadesMan.TabIndex = 15;
            this.lbl_UnidadesMan.Text = "Cant. Unidades";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(912, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB_importetotal);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtGV_ListadoDetalle);
            this.groupBox1.Controls.Add(this.txtB_NumComprobante);
            this.groupBox1.Controls.Add(this.lbl_Total);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dt_Fecha);
            this.groupBox1.Controls.Add(this.lbl_Cliente);
            this.groupBox1.Controls.Add(this.txtB_Proveedor);
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.btn_Nuevo);
            this.groupBox1.Location = new System.Drawing.Point(26, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nota Ventas";
            // 
            // txtB_NumComprobante
            // 
            this.txtB_NumComprobante.Location = new System.Drawing.Point(139, 28);
            this.txtB_NumComprobante.Name = "txtB_NumComprobante";
            this.txtB_NumComprobante.Size = new System.Drawing.Size(115, 20);
            this.txtB_NumComprobante.TabIndex = 22;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(740, 45);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(69, 13);
            this.lbl_Total.TabIndex = 29;
            this.lbl_Total.Text = "Importe Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Comprobante Nº";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha";
            // 
            // dt_Fecha
            // 
            this.dt_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Fecha.Location = new System.Drawing.Point(480, 61);
            this.dt_Fecha.Name = "dt_Fecha";
            this.dt_Fecha.Size = new System.Drawing.Size(121, 20);
            this.dt_Fecha.TabIndex = 19;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Location = new System.Drawing.Point(44, 66);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(39, 13);
            this.lbl_Cliente.TabIndex = 18;
            this.lbl_Cliente.Text = "Cliente";
            // 
            // txtB_Proveedor
            // 
            this.txtB_Proveedor.Location = new System.Drawing.Point(139, 61);
            this.txtB_Proveedor.Name = "txtB_Proveedor";
            this.txtB_Proveedor.Size = new System.Drawing.Size(115, 20);
            this.txtB_Proveedor.TabIndex = 17;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Location = new System.Drawing.Point(769, 426);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.Location = new System.Drawing.Point(655, 426);
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
            this.btn_Nuevo.Location = new System.Drawing.Point(539, 426);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 6;
            this.btn_Nuevo.Text = "&Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(33, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 522);
            this.tabControl1.TabIndex = 5;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNotaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 583);
            this.Controls.Add(this.lbl_Compras);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormNotaVenta";
            this.Text = "Formulario Nota de Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNotaVenta_FormClosing);
            this.Load += new System.EventHandler(this.FormNotaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_Icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_ListadoDetalle)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Listado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider error_Icono;
        private System.Windows.Forms.ToolTip tT_Mensaje;
        private System.Windows.Forms.Label lbl_Compras;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.DataGridView dtGV_Listado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lbl_TotalList;
        private System.Windows.Forms.CheckBox chkB_EliminarList;
        private System.Windows.Forms.Button btn_ImprimirList;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.Button btn_BuscarList;
        private System.Windows.Forms.Label lbl_NombreList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtB_importetotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtB_CodigoMan;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Label lbl_CodigoArt;
        private System.Windows.Forms.Label lbl_DescripciónMan;
        private System.Windows.Forms.TextBox txtB_PrecioVenta;
        private System.Windows.Forms.TextBox txtB_NumRenglon;
        private System.Windows.Forms.TextBox txtB_DescripcionMan;
        private System.Windows.Forms.Label lbl_NumRenglon;
        private System.Windows.Forms.TextBox txtB_StockMan;
        private System.Windows.Forms.Label lbl_PrecioVenta;
        private System.Windows.Forms.Button btn_BuscarArt;
        private System.Windows.Forms.Label lbl_StockMant;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_UnidadesMan;
        private System.Windows.Forms.TextBox txtB_UnidadesMan;
        private System.Windows.Forms.DataGridView dtGV_ListadoDetalle;
        private System.Windows.Forms.TextBox txtB_NumComprobante;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_Fecha;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.TextBox txtB_Proveedor;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}