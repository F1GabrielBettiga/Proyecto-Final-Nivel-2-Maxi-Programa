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
using System.IO;
using System.Drawing.Text;

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
            EstiloFormulario();
            CargarGrilla();
            modificarAltoDeFilasDGV(dgvListadoArticulos, 315);
            cargarFiltroAvanzado();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmArticuloABM Alta = new FrmArticuloABM();
            Alta.ShowDialog();
            CargarGrilla();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvListadoArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un Articulo Primero");
                return;
            }
            else
            {
                Articulo artSeleccionado;
                artSeleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                FrmArticuloABM Modificar = new FrmArticuloABM(artSeleccionado,1);
                Modificar.ShowDialog();
                if (Modificar.ArticuloEditado == true)
                {
                    CargarGrilla();
                }
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListadoArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un Articulo Primero");
                return;
            }
            else
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo artSeleccionado;
                artSeleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el artículo? " + artSeleccionado.nombre,"Eliminando", MessageBoxButtons.YesNo,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    
                        pbImagenListado.Image.Dispose();   // libera el handle del archivo para que no salte al caso de que la imagen esté en uso
                        pbImagenListado.Image = null;
                        pbImagenListado.ImageLocation = null; 
                    
                    negocio.eliminarArticulo(artSeleccionado);
                    MessageBox.Show("Eliminido Correctamente");
                    CargarGrilla();

                }
                

            }

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            FrmArticuloABM Detalles = new FrmArticuloABM();
            if (dgvListadoArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un Articulo Primero");
                return;
            }
            else
            {
                Articulo artSeleccionado;   
                artSeleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                Detalles = new FrmArticuloABM(artSeleccionado, 2);
                Detalles.Text = "Detalles del Artículo";
                Detalles.ShowDialog();

            }


        }

        private void dgvListadoArticulos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvListadoArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.imagenUrl);
            }

        }

        private void txtbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtbFiltroRapido.Text;
            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.nombre.ToUpper().Contains(filtro.ToUpper()) || x.codigo.ToUpper().Contains(filtro.ToUpper()) || x.descripcion.ToUpper().Contains(filtro.ToUpper()) || x.marca.id.ToString().ToUpper().Contains(filtro.ToUpper()) || x.marca.descripcion.ToUpper().Contains(filtro.ToUpper()) || x.categoria.id.ToString().ToUpper().Contains(filtro.ToUpper()) || x.categoria.descripcion.ToUpper().Contains(filtro.ToUpper()) || x.precio.ToString().ToString().ToUpper().Contains(filtro.ToUpper()));
                txtFiltroAvanzadoValor.Text = string.Empty;
                cboFiltroAvanzadoCriterio.Items.Clear();
                cboFiltroAvanzadoCampo.Items.Clear();
                cargarFiltroAvanzado();
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvListadoArticulos.DataSource = null;
            dgvListadoArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
            modificarAltoDeFilasDGV(dgvListadoArticulos, 315);

        }

        private void cboFiltroAvanzadoCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltroAvanzadoValor.Enabled = false;
            txtFiltroAvanzadoValor.Text = string.Empty;

            if (cboFiltroAvanzadoCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Primero selecciona un campo");
                cboFiltroAvanzadoCampo.SelectedIndex = -1;
                return;
            }
            else
            {
                string opcion = cboFiltroAvanzadoCampo.SelectedItem.ToString();
                txtbFiltroRapido.Text = string.Empty;
                cboFiltroAvanzadoCriterio.Enabled = true;

                switch (opcion)
                {
                    case "Cód Articulo":

                        cboFiltroAvanzadoCriterio.Items.Clear();
                        cboFiltroAvanzadoCriterio.Items.Add("Contiene");
                        cboFiltroAvanzadoCriterio.Items.Add("Comienza con");
                        cboFiltroAvanzadoCriterio.Items.Add("Termina con");

                        break;

                    case "Nombre":
                        cboFiltroAvanzadoCriterio.Items.Clear();
                        cboFiltroAvanzadoCriterio.Items.Add("Contiene");
                        cboFiltroAvanzadoCriterio.Items.Add("Comienza con");
                        cboFiltroAvanzadoCriterio.Items.Add("Termina con");
                        break;

                    case "Descripción":
                        cboFiltroAvanzadoCriterio.Items.Clear();
                        cboFiltroAvanzadoCriterio.Items.Add("Contiene");
                        cboFiltroAvanzadoCriterio.Items.Add("Comienza con");
                        cboFiltroAvanzadoCriterio.Items.Add("Termina con");

                        break;

                    case "Marca":
                        cboFiltroAvanzadoCriterio.Items.Clear();
                        cboFiltroAvanzadoCriterio.Items.Add("Contiene");
                        cboFiltroAvanzadoCriterio.Items.Add("Comienza con");
                        cboFiltroAvanzadoCriterio.Items.Add("Termina con");

                        break;
                    case "Categoría":
                        cboFiltroAvanzadoCriterio.Items.Clear();
                        cboFiltroAvanzadoCriterio.Items.Add("Contiene");
                        cboFiltroAvanzadoCriterio.Items.Add("Comienza con");
                        cboFiltroAvanzadoCriterio.Items.Add("Termina con");

                        break;
                    case "Precio":

                        cboFiltroAvanzadoCriterio.Items.Clear();
                        cboFiltroAvanzadoCriterio.Items.Add("Mayor a");
                        cboFiltroAvanzadoCriterio.Items.Add("Menor a");
                        cboFiltroAvanzadoCriterio.Items.Add("Igual a");

                        break;


                    default:

                        break;



                }


            }
        }

        private void btnBuscarFiltroAvanzado_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                string campo = cboFiltroAvanzadoCampo.SelectedItem.ToString();
                string criterio = cboFiltroAvanzadoCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzadoValor.Text;
                dgvListadoArticulos.DataSource = negocio.filtrarArticulos(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }

        private void cboFiltroAvanzadoCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboFiltroAvanzadoCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Primero selecciona un campo");
                cboFiltroAvanzadoCriterio.SelectedIndex = -1;
                return;
            }
            else
            {
                txtFiltroAvanzadoValor.Text = string.Empty;
                txtFiltroAvanzadoValor.Enabled = true;

            }
        }

        private void txtFiltroAvanzadoValor_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltroAvanzadoValor.Text;
            if (filtro != "")
            {
                btnBuscarFiltroAvanzado.Enabled = true;
            }
            else
            {
                btnBuscarFiltroAvanzado.Enabled = false;
            }



        }

        public void CargarGrilla()
        { 
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listarTodosLosArticulos();

                dgvListadoArticulos.DataSource = listaArticulos;
                colocarSimbolodeMoneda();


                if (dgvListadoArticulos.Rows.Count > 0)
                {
                    dgvListadoArticulos.Rows[0].Cells[1].Selected = true;

                }

                ocultarColumnas();
                
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

             }
             catch (Exception)
             {
                 pbImagenListado.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");

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

        private void colocarSimbolodeMoneda()
        {
            dgvListadoArticulos.Columns["precio"].DefaultCellStyle.Format = "C2";
            dgvListadoArticulos.Columns["precio"].DefaultCellStyle.FormatProvider =
                new System.Globalization.CultureInfo("es-AR");
        }
        private void cargarFiltroAvanzado()
        {
            cboFiltroAvanzadoCriterio.Enabled = false;
            txtFiltroAvanzadoValor.Enabled = false;
            btnBuscarFiltroAvanzado.Enabled = false;
            cboFiltroAvanzadoCampo.Items.Add("Cód Articulo");
            cboFiltroAvanzadoCampo.Items.Add("Nombre");
            cboFiltroAvanzadoCampo.Items.Add("Descripción");
            cboFiltroAvanzadoCampo.Items.Add("Marca");
            cboFiltroAvanzadoCampo.Items.Add("Categoría");
            cboFiltroAvanzadoCampo.Items.Add("Precio");


        }

        private void txtFiltroAvanzadoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // teclas de control (ej: Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            string campo = (cboFiltroAvanzadoCampo.SelectedItem ?? "").ToString().Trim();
            var tb = (TextBox)sender;
            char sep = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            if (campo == "Precio")
            {
                //SOLO NÚMEROS 
                if (char.IsDigit(e.KeyChar))
                    return;

                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == sep)
                {
                    if (!tb.Text.Contains('.') && !tb.Text.Contains(',') && !tb.Text.Contains(sep))
                        return;
                }

                e.Handled = true; // todo lo demás se bloquea
            }
            else if (campo == "Cód Articulo" || campo == "Nombre")
            {
                // letras y números
                if (char.IsLetterOrDigit(e.KeyChar))
                    return;

                e.Handled = true; // bloqueo símbolos y otros
            }
            else
            {
                // SOLO LETRAS
                if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                    return;

                e.Handled = true;
            }
        }


        //DISEÑO---------------------

        private void EstiloFormulario()
        {
            PrivateFontCollection fuentes = new PrivateFontCollection();

            // === Fondo del formulario ===
            this.BackColor = Color.FromArgb(240, 225, 166); // Beige dorado claro
            this.ForeColor = Color.FromArgb(31, 58, 95);    // Azul petróleo oscuro

            var colorPrimario = Color.FromArgb(46, 94, 168);   // Azul primario
            var colorPrimarioHover = Color.FromArgb(37, 76, 136);   // Hover primario
            var colorSecundario = Color.FromArgb(246, 240, 209); // Secundario
            var colorDanger = Color.FromArgb(192, 57, 43);   // Rojo eliminar
            var colorDangerHover = Color.FromArgb(153, 45, 34);   // Hover eliminar

            // === Tipografía ===
            fuentes.AddFontFile(@"Fonts\FiraSans-Regular.ttf");
            this.Font = new Font(fuentes.Families[0], 10, FontStyle.Regular);

            // === Paneles / GroupBox (igual al form y sin bordes) ===
            foreach (Control c in this.Controls)
            {
                if (c is GroupBox || c is Panel)
                {
                    c.BackColor = this.BackColor;
                    c.ForeColor = this.ForeColor;
                    if (c is Panel p) p.BorderStyle = BorderStyle.None;
                }
            }

            // === DataGridView ===
            if (dgvListadoArticulos != null)
            {
                var dgv = dgvListadoArticulos;
                dgv.BackgroundColor = this.BackColor;
                dgv.GridColor = Color.FromArgb(210, 195, 155);

                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = colorPrimario;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);

                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 245, 220);
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
                dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 95);
            }

            // === Botones ===
            EstilizarBotonPrimario(btnAgregar, colorPrimario, colorPrimarioHover);
            EstilizarBotonSecundario(btnModificar, colorSecundario);
            EstilizarBotonSecundario(btnDetalles, colorSecundario);
            EstilizarBotonDanger(btnEliminar, colorDanger, colorDangerHover);

            // === PictureBox ===
            if (pbImagenListado != null)
            {
                pbImagenListado.BackColor = this.BackColor; // Igual al form
                pbImagenListado.BorderStyle = BorderStyle.None;
            }
        }

        // Helpers para botones
        private void EstilizarBotonPrimario(Button b, Color baseColor, Color hover)
        {
            if (b == null) return;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = baseColor;
            b.ForeColor = Color.White;
            b.Cursor = Cursors.Hand;
            b.MouseEnter += (_, __) => b.BackColor = hover;
            b.MouseLeave += (_, __) => b.BackColor = baseColor;
        }
        private void EstilizarBotonSecundario(Button b, Color baseColor)
        {
            if (b == null) return;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.BorderColor = Color.FromArgb(210, 195, 155);
            b.BackColor = baseColor;
            b.ForeColor = Color.FromArgb(31, 58, 95);
            b.Cursor = Cursors.Hand;
        }
        private void EstilizarBotonDanger(Button b, Color baseColor, Color hover)
        {
            if (b == null) return;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = baseColor;
            b.ForeColor = Color.White;
            b.Cursor = Cursors.Hand;
            b.MouseEnter += (_, __) => b.BackColor = hover;
            b.MouseLeave += (_, __) => b.BackColor = baseColor;
        }
    }
}
