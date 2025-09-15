using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_App
{
    public partial class FrmArticulosListado : Form
    {
        public FrmArticulosListado()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmArticuloABM Alta = new FrmArticuloABM();
            Alta.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmArticuloABM Modificar = new FrmArticuloABM();
            Modificar.Text = "Modificar Artículo";
            Modificar.ShowDialog();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            FrmArticuloABM Detalles = new FrmArticuloABM();
            Detalles.Text = "Detalles del Artículo";
            Detalles.ShowDialog();
        }
    }
}
