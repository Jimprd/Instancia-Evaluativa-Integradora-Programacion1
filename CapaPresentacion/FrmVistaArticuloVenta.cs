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
    public partial class FrmVistaArticuloVenta : Form
    {
        public FrmVistaArticuloVenta()
        {
            InitializeComponent();
        }

        private void FrmVistaArticuloVenta_Load(object sender, EventArgs e)
        {
            this.Mostrar();
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

        private void btn_BuscarList_Click(object sender, EventArgs e)
        {
            this.BuscarArticulo();
        }

        private void dtGV_Listado_DoubleClick(object sender, EventArgs e)
        {
            FormNotaVenta form = FormNotaVenta.GetInstancia();
            string par1, par2;
            decimal par3;
            int par4;

            par1 = Convert.ToString(this.dtGV_Listado.CurrentRow.Cells["ArtCodigo"].Value);
            par2 = Convert.ToString(this.dtGV_Listado.CurrentRow.Cells["ArtDescripcion"].Value);
            par3 = Convert.ToDecimal(this.dtGV_Listado.CurrentRow.Cells["ArtPrecio_Venta"].Value);
            par4 = Convert.ToInt32(this.dtGV_Listado.CurrentRow.Cells["ArtUnidades"].Value);

            form.setArticulo(par1, par2, par3, par4);
            this.Hide();
        }
    }
}
