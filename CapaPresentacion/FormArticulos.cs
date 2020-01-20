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
    public partial class FormArticulos : Form
    {

        #region Formulario 
        // variables que indica si voy a editar un articulo o  si lo voy a ingresar

        private bool IsNuevo = false;
        private bool IsEditar = false;
        private static FormArticulos _Instancia;

        public static FormArticulos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormArticulos();
            }
            return _Instancia;
        }

        public FormArticulos()
        {
            InitializeComponent();

            this.tT_Mensaje.SetToolTip(this.txtB_CodigoMan, "Código del artículo en la base de datos");
            this.tT_Mensaje.SetToolTip(this.txtB_DescripcionMan, "Ingrese la descripción del artículo");
            this.tT_Mensaje.SetToolTip(this.txtB_PrecioCompraMan, "Ingrese el precio al que compró");
            this.tT_Mensaje.SetToolTip(this.txtB_PrecioVentaMan, "Ingrese el precio al que venderá");
            this.tT_Mensaje.SetToolTip(this.txtB_UnidadesMan, "Ingrese cuantas unidades tiene disponibles");
        }

        private void FormArticulos_Load(object sender, EventArgs e)
        {
            this.Top = 0; // alineando
            this.Left = 0;

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void FormArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
        #endregion

        #region METODOS
        // Mostrar Mensaje de Confirmación

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método Mostrar Mensaje de Error

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Método Limpiar todos los Controles del Formulario

        private void Limpiar()
        {
            this.txtB_CodigoMan.Text = string.Empty;
            this.txtB_DescripcionMan.Text = string.Empty;
            this.txtB_PrecioCompraMan.Text = string.Empty;
            this.txtB_PrecioVentaMan.Text = string.Empty;
            this.txtB_UnidadesMan.Text = string.Empty;
        }

        // Método Habilitar los Controles del Formulario

        private void Habilitar(bool valor)
        {
            this.txtB_CodigoMan.ReadOnly = !valor;
            this.txtB_DescripcionMan.ReadOnly = !valor;
            this.txtB_PrecioCompraMan.ReadOnly = !valor;
            this.txtB_PrecioVentaMan.ReadOnly = !valor;
            this.txtB_UnidadesMan.ReadOnly = !valor;
        }

        // Método Habilitar los Botones

        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true); // habilita los txtbox
                this.btn_Cancelar.Enabled = true;
                this.btn_Editar.Enabled = false;
                this.btn_Guardar.Enabled = true;
                this.btn_Nuevo.Enabled = false;
            }
            else
            {
                this.Habilitar(false);
                this.btn_Cancelar.Enabled = false;
                this.btn_Editar.Enabled = true;
                this.btn_Guardar.Enabled = false;
                this.btn_Nuevo.Enabled = true;
            }
        }

        // Método Ocultar Columnas

        private void OcultarColumnas()
        {
            this.dtGV_Listado.Columns[0].Visible = false;
            this.dtGV_Listado.Columns[1].Visible = false;
        }

        // Metodo Mostrar //
 
        private void Mostrar()
        {
            this.dtGV_Listado.DataSource = NArticulo.Mostar();
            this.OcultarColumnas();
            lbl_TotalList.Text = "Total de Registros: " + Convert.ToString(dtGV_Listado.Rows.Count);
        }

        // Metodo Buscar //

        private void BuscarArticulo()
        {
            this.dtGV_Listado.DataSource = NArticulo.BuscarArticulo(this.txt_BuscarList.Text);
            this.OcultarColumnas();
            lbl_TotalList.Text = "Total de Registros: " + Convert.ToString(dtGV_Listado.Rows.Count);
        }

        #endregion

        #region BOTONES
        // Botón Buscar //

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            this.BuscarArticulo();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarArticulo();
        }

        // Botón Nuevo //

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtB_DescripcionMan.Focus();
        }

        // Botón Guardar //

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                // Validación
                if (this.txtB_DescripcionMan.Text == string.Empty)
                {
                    MensajeError("Falta ingresar los datos remarcados");
                    error_Icono.SetError(txtB_DescripcionMan, "Ingrese una Descripción");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NArticulo.Insertar(this.txtB_DescripcionMan.Text.Trim().ToUpper(), Convert.ToDecimal(this.txtB_PrecioCompraMan.Text), Convert.ToDecimal(this.txtB_PrecioVentaMan.Text), Convert.ToInt32(this.txtB_UnidadesMan.Text));
                        // Trim()borra los espacios en blanco //ToUpper() pasa todo a mayúsculas
                    }
                    else
                    {
                        rpta = NArticulo.Editar(Convert.ToInt32(this.txtB_CodigoMan.Text), this.txtB_DescripcionMan.Text.Trim().ToUpper(), Convert.ToDecimal(this.txtB_PrecioCompraMan.Text), Convert.ToDecimal(this.txtB_PrecioVentaMan.Text), Convert.ToInt32(this.txtB_UnidadesMan.Text));
                    }

                    if (rpta.Equals("OK")) // si la respuesta es OK pueden pasardos cosas
                    {
                        if (this.IsNuevo) // si IsNuevo es true envio este mensaje
                        {
                            this.MensajeOk("Se insertó de forma correcta el registro");
                        }
                        else // Sino IsNuevo es false por lo que IsEditar estara en true
                        {
                            this.MensajeOk("Se actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        // Botón Editar //

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (!this.txtB_CodigoMan.Text.Equals(""))
            {
                this.IsEditar = true;
                Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar primero el registro a modificar");
            }
        }

        // Botón Cancelar //

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        // Botón Eliminar //

        private void btn_EliminarList_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eliminar los Registros", "Sistemade Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dtGV_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value); // obtenemos la primary key de lo que vamos a eliminar
                            Rpta = NArticulo.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }

                    this.Mostrar(); // muestra el listado actualizado
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        // Boton Imprimir //
        private void btn_ImprimirList_Click(object sender, EventArgs e)
        {
            FormReportArtic frm = new FormReportArtic();
            frm.ShowDialog();

        }


        #endregion

        // Data Listado Celdas //
        private void dtGV_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtGV_Listado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkB_EliminarList = (DataGridViewCheckBoxCell)dtGV_Listado.Rows[e.RowIndex].Cells["Eliminar"];
                chkB_EliminarList.Value = !Convert.ToBoolean(chkB_EliminarList.Value);
            }
        }

        // Data Listado Click//
        private void dtGV_Listado_DoubleClick(object sender, EventArgs e)
        {
            this.txtB_CodigoMan.Text = Convert.ToString(this.dtGV_Listado.CurrentRow.Cells["ArtCodigo"].Value);
            this.txtB_DescripcionMan.Text = Convert.ToString(this.dtGV_Listado.CurrentRow.Cells["ArtDescripcion"].Value);
            this.txtB_PrecioCompraMan.Text = Convert.ToString(this.dtGV_Listado.CurrentRow.Cells["ArtPrecio_Compra"].Value);
            this.txtB_PrecioVentaMan.Text = Convert.ToString(this.dtGV_Listado.CurrentRow.Cells["ArtPrecio_Venta"].Value);
            this.txtB_UnidadesMan.Text = Convert.ToString(this.dtGV_Listado.CurrentRow.Cells["ArtUnidades"].Value);

            this.tabControl1.SelectedIndex = 1;

        }

        // CheckBox //
        private void chkB_EliminarList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_EliminarList.Checked)
            {
                this.dtGV_Listado.Columns[0].Visible = true;
            }
            else
            {
                this.dtGV_Listado.Columns[0].Visible = false;
            }
        }

    }
}
