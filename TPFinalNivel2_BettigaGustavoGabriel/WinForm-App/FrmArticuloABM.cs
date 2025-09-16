using Dominio;
using Negocio;
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
    public partial class FrmArticuloABM : Form
    {
        private Articulo art = null;
        public FrmArticuloABM()
        {
            InitializeComponent();
        }

        public FrmArticuloABM(Articulo ar)
        {
            InitializeComponent();
            art = ar;
            Text = "Modificar Artículo";
        }

        private void FrmArticuloABM_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            cbMarca.DataSource = marcaNegocio.ListarMarcas();
            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "Descripcion";
            cbCategoria.DataSource = categoriaNegocio.ListarCategoria();
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "Descripcion";

            if (art != null)
            {
                txtCodigo.Text = art.codigo;
                txtNombre.Text = art.nombre;
                txtDescripcion.Text = art.descripcion;
                txtUrlImagen.Text = art.imagenUrl;
                cargarImagen(art.imagenUrl);
                txtPrecio.Text = art.precio.ToString();
                cbMarca.SelectedValue = art.marca.id;
                cbCategoria.SelectedValue = art.categoria.id;

            }




        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {   ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (art == null)
                {
                    art = new Articulo();
                }

                art = cargarArticulo();

                if (art.id != 0)
                {
                    //negocio.modificarArticulo(art);
                    MessageBox.Show("Modificado Exitosamente");
                    Close();
                }
                else
                {
                    negocio.agregarArticulo(art);
                    MessageBox.Show("Agregado Exitosamente");
                    Close();
                    

                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Articulo cargarArticulo()
        { 
            Articulo articulo = new Articulo();
            articulo.codigo = txtCodigo.Text;
            articulo.nombre = txtNombre.Text;
            articulo.descripcion = txtDescripcion.Text;
            articulo.marca = (Marca) cbMarca.SelectedItem;
            articulo.categoria= (Categoria) cbCategoria.SelectedItem;
            articulo.imagenUrl = txtUrlImagen.Text;
            articulo.precio = decimal.Parse(txtPrecio.Text);
            return articulo;

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagenABM.Load(imagen);
                pbImagenABM.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                pbImagenABM.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                pbImagenABM.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
    }
}
