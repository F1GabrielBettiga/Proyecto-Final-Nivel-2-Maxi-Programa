namespace WinForm_App
{
    partial class FrmArticuloABM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.pbImagenABM = new System.Windows.Forms.PictureBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pnlDatosArticulo = new System.Windows.Forms.Panel();
            this.lblvalMensage = new System.Windows.Forms.Label();
            this.lblValPrecio = new System.Windows.Forms.Label();
            this.lblValDescripcion = new System.Windows.Forms.Label();
            this.lblValNombre = new System.Windows.Forms.Label();
            this.lblValCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenABM)).BeginInit();
            this.pnlDatosArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(95, 140);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(156, 21);
            this.cbCategoria.TabIndex = 4;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(95, 113);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(156, 21);
            this.cbMarca.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(95, 87);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(156, 20);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(34, 200);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(8, 174);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(73, 13);
            this.lblUrlImagen.TabIndex = 5;
            this.lblUrlImagen.Text = "URL Imagen: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(95, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(156, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(20, 148);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(95, 167);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(156, 20);
            this.txtUrlImagen.TabIndex = 5;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(34, 121);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(8, 94);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(95, 237);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(176, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Location = new System.Drawing.Point(8, 38);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(71, 13);
            this.lblCodArticulo.TabIndex = 0;
            this.lblCodArticulo.Text = "Cod. artículo:";
            // 
            // pbImagenABM
            // 
            this.pbImagenABM.Location = new System.Drawing.Point(290, 8);
            this.pbImagenABM.MaximumSize = new System.Drawing.Size(302, 273);
            this.pbImagenABM.MinimumSize = new System.Drawing.Size(302, 273);
            this.pbImagenABM.Name = "pbImagenABM";
            this.pbImagenABM.Size = new System.Drawing.Size(302, 273);
            this.pbImagenABM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenABM.TabIndex = 16;
            this.pbImagenABM.TabStop = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(95, 193);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(156, 20);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // pnlDatosArticulo
            // 
            this.pnlDatosArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosArticulo.Controls.Add(this.lblvalMensage);
            this.pnlDatosArticulo.Controls.Add(this.lblValPrecio);
            this.pnlDatosArticulo.Controls.Add(this.lblValDescripcion);
            this.pnlDatosArticulo.Controls.Add(this.lblValNombre);
            this.pnlDatosArticulo.Controls.Add(this.lblValCodigo);
            this.pnlDatosArticulo.Controls.Add(this.txtPrecio);
            this.pnlDatosArticulo.Controls.Add(this.pbImagenABM);
            this.pnlDatosArticulo.Controls.Add(this.lblCodArticulo);
            this.pnlDatosArticulo.Controls.Add(this.btnCancelar);
            this.pnlDatosArticulo.Controls.Add(this.lblNombre);
            this.pnlDatosArticulo.Controls.Add(this.btnGuardar);
            this.pnlDatosArticulo.Controls.Add(this.lblDescripcion);
            this.pnlDatosArticulo.Controls.Add(this.lblMarca);
            this.pnlDatosArticulo.Controls.Add(this.txtUrlImagen);
            this.pnlDatosArticulo.Controls.Add(this.lblCategoria);
            this.pnlDatosArticulo.Controls.Add(this.txtCodigo);
            this.pnlDatosArticulo.Controls.Add(this.lblUrlImagen);
            this.pnlDatosArticulo.Controls.Add(this.txtNombre);
            this.pnlDatosArticulo.Controls.Add(this.lblPrecio);
            this.pnlDatosArticulo.Controls.Add(this.txtDescripcion);
            this.pnlDatosArticulo.Controls.Add(this.cbMarca);
            this.pnlDatosArticulo.Controls.Add(this.cbCategoria);
            this.pnlDatosArticulo.Location = new System.Drawing.Point(2, 4);
            this.pnlDatosArticulo.Name = "pnlDatosArticulo";
            this.pnlDatosArticulo.Size = new System.Drawing.Size(595, 300);
            this.pnlDatosArticulo.TabIndex = 17;
            // 
            // lblvalMensage
            // 
            this.lblvalMensage.AutoSize = true;
            this.lblvalMensage.Location = new System.Drawing.Point(86, 267);
            this.lblvalMensage.Name = "lblvalMensage";
            this.lblvalMensage.Size = new System.Drawing.Size(11, 13);
            this.lblvalMensage.TabIndex = 22;
            this.lblvalMensage.Text = "*";
            // 
            // lblValPrecio
            // 
            this.lblValPrecio.AutoSize = true;
            this.lblValPrecio.Location = new System.Drawing.Point(83, 200);
            this.lblValPrecio.Name = "lblValPrecio";
            this.lblValPrecio.Size = new System.Drawing.Size(11, 13);
            this.lblValPrecio.TabIndex = 21;
            this.lblValPrecio.Text = "*";
            // 
            // lblValDescripcion
            // 
            this.lblValDescripcion.AutoSize = true;
            this.lblValDescripcion.Location = new System.Drawing.Point(83, 94);
            this.lblValDescripcion.Name = "lblValDescripcion";
            this.lblValDescripcion.Size = new System.Drawing.Size(11, 13);
            this.lblValDescripcion.TabIndex = 19;
            this.lblValDescripcion.Text = "*";
            // 
            // lblValNombre
            // 
            this.lblValNombre.AutoSize = true;
            this.lblValNombre.Location = new System.Drawing.Point(83, 68);
            this.lblValNombre.Name = "lblValNombre";
            this.lblValNombre.Size = new System.Drawing.Size(11, 13);
            this.lblValNombre.TabIndex = 18;
            this.lblValNombre.Text = "*";
            // 
            // lblValCodigo
            // 
            this.lblValCodigo.AutoSize = true;
            this.lblValCodigo.Location = new System.Drawing.Point(83, 38);
            this.lblValCodigo.Name = "lblValCodigo";
            this.lblValCodigo.Size = new System.Drawing.Size(11, 13);
            this.lblValCodigo.TabIndex = 17;
            this.lblValCodigo.Text = "*";
            // 
            // FrmArticuloABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 311);
            this.Controls.Add(this.pnlDatosArticulo);
            this.Name = "FrmArticuloABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Articulo";
            this.Load += new System.EventHandler(this.FrmArticuloABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenABM)).EndInit();
            this.pnlDatosArticulo.ResumeLayout(false);
            this.pnlDatosArticulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.PictureBox pbImagenABM;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Panel pnlDatosArticulo;
        private System.Windows.Forms.Label lblvalMensage;
        private System.Windows.Forms.Label lblValPrecio;
        private System.Windows.Forms.Label lblValDescripcion;
        private System.Windows.Forms.Label lblValNombre;
        private System.Windows.Forms.Label lblValCodigo;
    }
}