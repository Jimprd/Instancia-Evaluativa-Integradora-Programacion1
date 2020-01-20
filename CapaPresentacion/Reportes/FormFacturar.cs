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
    public partial class FormFacturar : Form
    {
        private int _Comprobante;

        public FormFacturar()
        {
            InitializeComponent();
        }

        public int Comprobante
        {
            get
            {
                return _Comprobante;
            }

            set
            {
                _Comprobante = value;
            }
        }

        private void FormFacturar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MiDataSet.facturar' table. You can move, or remove it, as needed.
            this.facturarTableAdapter.Fill(this.MiDataSet.facturar,Comprobante);
            // TODO: This line of code loads data into the 'MiDataSet.spMostrar_Articulos' table. You can move, or remove it, as needed.
            this.spMostrar_ArticulosTableAdapter.Fill(this.MiDataSet.spMostrar_Articulos);

            this.reportViewer1.RefreshReport();
        }
    }
}
