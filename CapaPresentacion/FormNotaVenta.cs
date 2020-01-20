using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FormNotaVenta : Form
    {

        private bool IsNuevo = false;
        private DataTable dtDetalle;
        private decimal ImporteTotal = 0;
        int codigo = 0;
        decimal venta = 0;
        int stockact = 0;


        private static FormNotaVenta _Instancia;
        public static FormNotaVenta GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormNotaVenta();
            }
            return _Instancia;
        }

        #region Formulario
        public FormNotaVenta()
        {
            InitializeComponent();

            this.tT_Mensaje.SetToolTip(this.txtB_Proveedor, "Ingrese el nombre de su proveedor");
            this.tT_Mensaje.SetToolTip(this.txtB_importetotal, "Importe de la factura");

            this.tT_Mensaje.SetToolTip(this.txtB_DescripcionMan, "Oprima el botón Buscar y luego seleccionar el artículo");
            this.tT_Mensaje.SetToolTip(this.txtB_NumRenglon, "Ingrese el número de item o renglon");
            this.tT_Mensaje.SetToolTip(this.txtB_PrecioVenta, "Ingrese el precio de venta");
            this.tT_Mensaje.SetToolTip(this.txtB_UnidadesMan, "Ingrese la cantidad de unidades adquiridas");

            this.txtB_DescripcionMan.ReadOnly = true;
            this.txtB_CodigoMan.ReadOnly = true;
        }

        private void FormNotaVenta_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.crearTabla();
        }

        private void FormNotaVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
        #endregion

        #region Metodos

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtB_NumComprobante.Text = string.Empty;
            this.txtB_Proveedor.Text = string.Empty;
            this.txtB_importetotal.Text = string.Empty;

            this.crearTabla();
        }

        // Limpiar Detalle

        private void limpiarDetalle()
        {
            this.txtB_NumRenglon.Text = string.Empty;
            this.txtB_CodigoMan.Text = string.Empty;
            this.txtB_DescripcionMan.Text = string.Empty;
            this.txtB_PrecioVenta.Text = string.Empty;
            this.txtB_UnidadesMan.Text = string.Empty;
        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtB_NumComprobante.ReadOnly = !valor;
            this.txtB_Proveedor.ReadOnly = !valor;
            this.txtB_importetotal.ReadOnly = !valor;

            this.txtB_NumRenglon.ReadOnly = !valor;
            this.txtB_CodigoMan.ReadOnly = !valor;
            this.txtB_DescripcionMan.ReadOnly = !valor;
            this.txtB_PrecioVenta.ReadOnly = !valor;
            this.txtB_UnidadesMan.ReadOnly = !valor;
            this.txtB_StockMan.ReadOnly = !valor;

            this.dt_Fecha.Enabled = valor;
            this.dtFechaInicio.Enabled = valor;
            this.dtFechaFin.Enabled = valor;

            this.btn_BuscarArt.Enabled = valor;
            this.btn_Agregar.Enabled = valor;
            this.btn_Borrar.Enabled = valor;
            this.btn_Guardar.Enabled = valor;
            this.btn_Cancelar.Enabled = valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo)
            {
                this.Habilitar(true);
                this.btn_Nuevo.Enabled = false;
                this.btn_Guardar.Enabled = true;
                this.btn_Cancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btn_Nuevo.Enabled = true;
                this.btn_Guardar.Enabled = false;
                this.btn_Cancelar.Enabled = false;
            }
        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dtGV_Listado.Columns[0].Visible = false; // es la columna del check box eliminar
            this.dtGV_Listado.Columns[1].Visible = false; // es la columna de la llave primaria
        }

        //Método Mostrar
        private void Mostrar()
        {
            this.dtGV_Listado.DataSource = NNotaVenta.Mostrar();
            this.OcultarColumnas();
            lbl_TotalList.Text = "Total de Registros: " + Convert.ToString(dtGV_Listado.Rows.Count);
        }

        //Método BuscarFechas
        private void BuscarFechas()
        {
            this.dtGV_Listado.DataSource = NNotaVenta.BuscarFechas(this.dtFechaInicio.Value.ToString("dd/MM/yyyy"), this.dtFechaFin.Value.ToString("dd/MM/yyyy"));
            this.OcultarColumnas();
            lbl_TotalList.Text = "Total de Registros: " + Convert.ToString(dtGV_Listado.Rows.Count);
        }

        // Metodo Mostar Detalle
        private void MostrarDetalle()
        {
            this.dtGV_ListadoDetalle.DataSource = NNotaVenta.MostrarDetalle(Convert.ToInt32(this.txtB_NumComprobante.Text));
        }

        // Metodo Set Articulo recibe los valores del formulario vista
        public void setArticulo(string codigoarticulo, string articulo, decimal precioventa, int unidades)
        {
            this.txtB_CodigoMan.Text = codigoarticulo;
            this.txtB_DescripcionMan.Text = articulo;
            this.txtB_PrecioVenta.Text = precioventa.ToString();
            this.txtB_StockMan.Text = unidades.ToString();
        }

        private void crearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");

            this.dtDetalle.Columns.Add("Renglon", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("ArtCodigo", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Artdescripcion", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Precioventa", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Unidades", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Stock Actual", System.Type.GetType("System.Int32"));

            this.dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));

            //Relacionar nuestro DataGRidView con nuestro DataTable
            this.dtGV_ListadoDetalle.DataSource = this.dtDetalle;
        }
        #endregion

        private void btn_BuscarArt_Click(object sender, EventArgs e)
        {
            FrmVistaArticuloVenta vista = new FrmVistaArticuloVenta();
            vista.ShowDialog();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtB_CodigoMan.Text == string.Empty || this.txtB_DescripcionMan.Text == string.Empty
                   || this.txtB_PrecioVenta.Text == string.Empty || this.txtB_UnidadesMan.Text == string.Empty)
                {
                    MensajeError("Falta ingresar alguno de los datos remarcados");

                    error_Icono.SetError(txtB_DescripcionMan, "Ingrese un Valor");
                    error_Icono.SetError(txtB_CodigoMan, "Ingrese un Valor");
                    error_Icono.SetError(txtB_PrecioVenta, "Ingrese un Valor");
                    error_Icono.SetError(txtB_UnidadesMan, "Ingrese un Valor");
                }
                else
                {
                    bool registrar = true;
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["ArtCodigo"]) == Convert.ToInt32(this.txtB_CodigoMan.Text))
                        {
                            registrar = false;
                            this.MensajeError("YA se encuentra el artículo en el detalle");
                        }
                    }
                    if (registrar)
                    {
                        decimal subTotal = Convert.ToDecimal(this.txtB_UnidadesMan.Text) * Convert.ToDecimal(this.txtB_PrecioVenta.Text);
                        ImporteTotal = ImporteTotal + subTotal;
                        this.txtB_importetotal.Text = ImporteTotal.ToString("#0.00#");

                        //Agregar ese detalle al datalistadoDetalle

                        DataRow row = this.dtDetalle.NewRow();

                        // renglon = renglon + 1;
                        //  txtB_NumRenglon.Text = Convert.ToString(renglon);
                        // row["Renglon"] = renglon;

                        row["Renglon"] = Convert.ToInt32(this.txtB_NumRenglon.Text);
                        row["ArtCodigo"] = Convert.ToInt32(this.txtB_CodigoMan.Text);
                        row["Artdescripcion"] = this.txtB_DescripcionMan.Text;
                        row["Precioventa"] = Convert.ToDecimal(this.txtB_PrecioVenta.Text);
                        row["Unidades"] = Convert.ToDecimal(this.txtB_UnidadesMan.Text);
                        row["Stock Actual"] = Convert.ToDecimal(Convert.ToInt32(txtB_StockMan.Text) - Convert.ToInt32(txtB_UnidadesMan.Text));
                        row["subtotal"] = subTotal;

                        codigo = Convert.ToInt32(row["ArtCodigo"]);
                        venta = Convert.ToDecimal(row["Precioventa"]);
                        stockact = Convert.ToInt32(row["Stock Actual"]);

                        this.dtDetalle.Rows.Add(row);
                        this.limpiarDetalle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                int indicefila = this.dtGV_ListadoDetalle.CurrentCell.RowIndex;
                DataRow row = this.dtDetalle.Rows[indicefila];

                //Disminuir el importe total
                this.ImporteTotal = this.ImporteTotal - Convert.ToDecimal(row["subtotal"].ToString());
                this.txtB_importetotal.Text = ImporteTotal.ToString("#0,00#");

                // remover la fila
                this.dtDetalle.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("No hay fila para remover");
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtB_Proveedor.Focus();
            this.limpiarDetalle();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {
                string rpta = "";
                if (this.txtB_Proveedor.Text == string.Empty || this.txtB_importetotal.Text == string.Empty)
                {
                    MensajeError("Falta ingresar alguno de los datos remarcados");

                    error_Icono.SetError(txtB_Proveedor, "Ingrese un Valor");
                    error_Icono.SetError(txtB_importetotal, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NNotaVenta.Insertar(dt_Fecha.Value, this.txtB_Proveedor.Text.Trim().ToUpper(), Convert.ToDecimal(this.txtB_importetotal.Text), dtDetalle);
                        NArticulo.Editar(codigo, venta, stockact);
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correctamente capa presentacion");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
                    this.limpiarDetalle();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.limpiarDetalle();
        }

        private void btn_BuscarList_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
        }

        private void dtGV_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtGV_Listado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dtGV_Listado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dtGV_Listado_DoubleClick(object sender, EventArgs e)
        {
            this.txtB_NumComprobante.Text = Convert.ToString(this.dtGV_Listado.CurrentRow.Cells["NVNroComprobante"].Value);
            this.dt_Fecha.Value = Convert.ToDateTime(this.dtGV_Listado.CurrentRow.Cells["NVFecha"].Value);
            this.txtB_Proveedor.Text = Convert.ToString(this.dtGV_Listado.CurrentRow.Cells["NVCliente"].Value);
            this.txtB_importetotal.Text = Convert.ToString(this.dtGV_Listado.CurrentRow.Cells["NVImporteTotal"].Value);

            this.MostrarDetalle();
            this.tabControl1.SelectedIndex = 1;
        }

        private void btn_ImprimirList_Click(object sender, EventArgs e)
        {

        }

        private void btn_Facturar_Click(object sender, EventArgs e)
        {
            FormFacturar frm = new FormFacturar();
            frm.Comprobante = Convert.ToInt32(this.dtGV_Listado.CurrentRow.Cells["NVNroComprobante"].Value); // aca hay un problema que va a FormReporteNCompras_Load(object sender, EventArgs e)
            frm.ShowDialog();
        }
    }
}
