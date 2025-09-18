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
        public bool ArticuloEditado { get; private set; }


        public FrmArticuloABM()
        {
            InitializeComponent();
        }

        public FrmArticuloABM(Articulo ar, int Modo)
        {
            if (Modo == 1)
            {
                InitializeComponent();
                art = ar;
                Text = "Modificar Artículo";
              
            }
            else
            {
                InitializeComponent();
                art = ar;
                Text = "Detalle de Artículo";
                btnGuardar.Visible = false;
                txtCodigo.Enabled = false;
                txtNombre.Enabled = false;
                txtDescripcion.Enabled = false;
                txtPrecio.Enabled = false;
                txtUrlImagen.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
                btnCancelar.Text = "Cerrar";
                
            }
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
                txtPrecio.Text = art.precio.ToString("N2");
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
                    art = cargarArticulo();
                }
                else
                {
                    art = cargarArticulo(art.id);
                }



                if (art.id != 0)
                {
                    DialogResult result = MessageBox.Show("¿Está seguro que desea editar el articulo " + art.nombre+ "?", "Editando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        negocio.modificarArticulo(art);
                        MessageBox.Show("Modificado Exitosamente ");
                        ArticuloEditado = true;

                    }

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

        private Articulo cargarArticulo(int id = -1)
        {
            Articulo articulo = new Articulo();

            if (id != -1)
            {
                //Si viene un id, es porque se esta modificando
                articulo.id = id;
            }
   
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
                
            }
            catch (Exception)
            {
                pbImagenABM.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                
            }

        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void colocarSimbolodeMoneda()
        {

        }


    }
}
