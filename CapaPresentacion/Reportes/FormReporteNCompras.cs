using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormReporteNCompras : Form
    {
        private int _CprComprobante;

        public int CprComprobante
        {
            get
            {
                return _CprComprobante;
            }

            set
            {
                _CprComprobante = value;
            }
        }


        public FormReporteNCompras()
        {
            InitializeComponent();
        }


        private void FormReporteNCompras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MiDataSet.spreporte_compra' table. You can move, or remove it, as needed.
            this.spreporte_compraTableAdapter.Fill(this.MiDataSet.spreporte_compra, CprComprobante); // aca hay un problema que viene de FormNotaCompra btn_ImprimirList_Click

            this.reportViewer1.RefreshReport();
        }
    }
}
