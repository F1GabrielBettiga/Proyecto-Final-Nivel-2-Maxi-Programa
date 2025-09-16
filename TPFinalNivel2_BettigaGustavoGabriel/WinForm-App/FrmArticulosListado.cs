using Dominio;
using Negocio;
using System;
using System.Collections;
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
        private List<Articulo> listaArticulos;
        public FrmArticulosListado()
        {
            InitializeComponent();
        }


        private void FrmArticulosListado_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            modificarAltoDeFilasDGV(dgvListadoArticulos, 315);

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

        private void dgvListadoArticulos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvListadoArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.imagenUrl);
            }

        }

        private void CargarGrilla()
        {
            dgvListadoArticulos.DataSource = null;
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listarTodosLosArticulos();

                dgvListadoArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].imagenUrl);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagenListado.Load(imagen);
                pbImagenListado.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                pbImagenListado.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                pbImagenListado.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        
        }

        private void ocultarColumnas()
        {
            dgvListadoArticulos.Columns["Id"].Visible = false;
            dgvListadoArticulos.Columns["ImagenUrl"].Visible = false;
        }

        private void modificarAltoDeFilasDGV(DataGridView dgv, int altoMaximo)
        {
            int header = dgv.ColumnHeadersVisible ? dgv.ColumnHeadersHeight : 0;
            int borders = dgv.Height - dgv.ClientSize.Height;
            int altoFila = dgv.RowTemplate.Height;

            // Calcular alto en base a filas cargadas
            int filas = dgv.Rows.Count;
            int altoDeseado = header + (filas * altoFila) + borders;

            // Asignar el alto, respetando el máximo
            dgv.Height = Math.Min(altoDeseado, altoMaximo);
        }


    }
}
