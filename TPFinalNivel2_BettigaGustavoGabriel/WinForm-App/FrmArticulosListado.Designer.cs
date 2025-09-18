namespace WinForm_App
{
    partial class FrmArticulosListado
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
            this.dgvListadoArticulos = new System.Windows.Forms.DataGridView();
            this.txtbFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pbImagenListado = new System.Windows.Forms.PictureBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.cboFiltroAvanzadoCampo = new System.Windows.Forms.ComboBox();
            this.cboFiltroAvanzadoCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltroAvanzadoValor = new System.Windows.Forms.TextBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.lblBuscarEn = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.pnlFiltroAvanzado = new System.Windows.Forms.Panel();
            this.btnBuscarFiltroAvanzado = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.pnlFiltroRapido = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenListado)).BeginInit();
            this.pnlFiltroAvanzado.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlFiltroRapido.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoArticulos
            // 
            this.dgvListadoArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoArticulos.Location = new System.Drawing.Point(12, 48);
            this.dgvListadoArticulos.MultiSelect = false;
            this.dgvListadoArticulos.Name = "dgvListadoArticulos";
            this.dgvListadoArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoArticulos.Size = new System.Drawing.Size(802, 315);
            this.dgvListadoArticulos.TabIndex = 3;
            this.dgvListadoArticulos.SelectionChanged += new System.EventHandler(this.dgvListadoArticulos_SelectionChanged);
            // 
            // txtbFiltroRapido
            // 
            this.txtbFiltroRapido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbFiltroRapido.Location = new System.Drawing.Point(77, 6);
            this.txtbFiltroRapido.Name = "txtbFiltroRapido";
            this.txtbFiltroRapido.Size = new System.Drawing.Size(444, 20);
            this.txtbFiltroRapido.TabIndex = 1;
            this.txtbFiltroRapido.TextChanged += new System.EventHandler(this.txtbFiltroRapido_TextChanged);
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(2, 9);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(69, 13);
            this.lblFiltroRapido.TabIndex = 0;
            this.lblFiltroRapido.Text = "Filtro Rapido:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 46);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(3, 107);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 46);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(3, 55);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 46);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pbImagenListado
            // 
            this.pbImagenListado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagenListado.Location = new System.Drawing.Point(824, 48);
            this.pbImagenListado.MaximumSize = new System.Drawing.Size(302, 273);
            this.pbImagenListado.MinimumSize = new System.Drawing.Size(302, 273);
            this.pbImagenListado.Name = "pbImagenListado";
            this.pbImagenListado.Size = new System.Drawing.Size(302, 273);
            this.pbImagenListado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenListado.TabIndex = 6;
            this.pbImagenListado.TabStop = false;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalles.Location = new System.Drawing.Point(102, 55);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(75, 46);
            this.btnDetalles.TabIndex = 3;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // cboFiltroAvanzadoCampo
            // 
            this.cboFiltroAvanzadoCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFiltroAvanzadoCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroAvanzadoCampo.FormattingEnabled = true;
            this.cboFiltroAvanzadoCampo.Location = new System.Drawing.Point(58, 22);
            this.cboFiltroAvanzadoCampo.Name = "cboFiltroAvanzadoCampo";
            this.cboFiltroAvanzadoCampo.Size = new System.Drawing.Size(194, 21);
            this.cboFiltroAvanzadoCampo.TabIndex = 0;
            this.cboFiltroAvanzadoCampo.SelectedIndexChanged += new System.EventHandler(this.cboFiltroAvanzadoCampo_SelectedIndexChanged);
            // 
            // cboFiltroAvanzadoCriterio
            // 
            this.cboFiltroAvanzadoCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFiltroAvanzadoCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroAvanzadoCriterio.FormattingEnabled = true;
            this.cboFiltroAvanzadoCriterio.Location = new System.Drawing.Point(58, 70);
            this.cboFiltroAvanzadoCriterio.Name = "cboFiltroAvanzadoCriterio";
            this.cboFiltroAvanzadoCriterio.Size = new System.Drawing.Size(194, 21);
            this.cboFiltroAvanzadoCriterio.TabIndex = 1;
            this.cboFiltroAvanzadoCriterio.SelectedIndexChanged += new System.EventHandler(this.cboFiltroAvanzadoCriterio_SelectedIndexChanged);
            // 
            // txtFiltroAvanzadoValor
            // 
            this.txtFiltroAvanzadoValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltroAvanzadoValor.Location = new System.Drawing.Point(58, 108);
            this.txtFiltroAvanzadoValor.Name = "txtFiltroAvanzadoValor";
            this.txtFiltroAvanzadoValor.Size = new System.Drawing.Size(194, 20);
            this.txtFiltroAvanzadoValor.TabIndex = 2;
            this.txtFiltroAvanzadoValor.TextChanged += new System.EventHandler(this.txtFiltroAvanzadoValor_TextChanged);
            this.txtFiltroAvanzadoValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroAvanzadoValor_KeyPress);
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(102, 6);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(80, 13);
            this.lblFiltroAvanzado.TabIndex = 3;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado";
            // 
            // lblBuscarEn
            // 
            this.lblBuscarEn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscarEn.AutoSize = true;
            this.lblBuscarEn.Location = new System.Drawing.Point(3, 25);
            this.lblBuscarEn.Name = "lblBuscarEn";
            this.lblBuscarEn.Size = new System.Drawing.Size(58, 13);
            this.lblBuscarEn.TabIndex = 4;
            this.lblBuscarEn.Text = "Buscar en:";
            // 
            // lblOperador
            // 
            this.lblOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(7, 73);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(54, 13);
            this.lblOperador.TabIndex = 5;
            this.lblOperador.Text = "Operador:";
            // 
            // lblValor
            // 
            this.lblValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(27, 111);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor:";
            // 
            // pnlFiltroAvanzado
            // 
            this.pnlFiltroAvanzado.Controls.Add(this.btnBuscarFiltroAvanzado);
            this.pnlFiltroAvanzado.Controls.Add(this.cboFiltroAvanzadoCriterio);
            this.pnlFiltroAvanzado.Controls.Add(this.lblValor);
            this.pnlFiltroAvanzado.Controls.Add(this.cboFiltroAvanzadoCampo);
            this.pnlFiltroAvanzado.Controls.Add(this.lblOperador);
            this.pnlFiltroAvanzado.Controls.Add(this.txtFiltroAvanzadoValor);
            this.pnlFiltroAvanzado.Controls.Add(this.lblBuscarEn);
            this.pnlFiltroAvanzado.Controls.Add(this.lblFiltroAvanzado);
            this.pnlFiltroAvanzado.Location = new System.Drawing.Point(538, 369);
            this.pnlFiltroAvanzado.Name = "pnlFiltroAvanzado";
            this.pnlFiltroAvanzado.Size = new System.Drawing.Size(273, 166);
            this.pnlFiltroAvanzado.TabIndex = 2;
            // 
            // btnBuscarFiltroAvanzado
            // 
            this.btnBuscarFiltroAvanzado.Location = new System.Drawing.Point(105, 140);
            this.btnBuscarFiltroAvanzado.Name = "btnBuscarFiltroAvanzado";
            this.btnBuscarFiltroAvanzado.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFiltroAvanzado.TabIndex = 7;
            this.btnBuscarFiltroAvanzado.Text = "BUSCAR";
            this.btnBuscarFiltroAvanzado.UseVisualStyleBackColor = true;
            this.btnBuscarFiltroAvanzado.Click += new System.EventHandler(this.btnBuscarFiltroAvanzado_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnModificar);
            this.pnlBotones.Controls.Add(this.btnAgregar);
            this.pnlBotones.Controls.Add(this.btnDetalles);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Location = new System.Drawing.Point(12, 370);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(273, 153);
            this.pnlBotones.TabIndex = 1;
            // 
            // pnlFiltroRapido
            // 
            this.pnlFiltroRapido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiltroRapido.Controls.Add(this.txtbFiltroRapido);
            this.pnlFiltroRapido.Controls.Add(this.lblFiltroRapido);
            this.pnlFiltroRapido.Location = new System.Drawing.Point(284, 13);
            this.pnlFiltroRapido.Name = "pnlFiltroRapido";
            this.pnlFiltroRapido.Size = new System.Drawing.Size(527, 29);
            this.pnlFiltroRapido.TabIndex = 0;
            // 
            // FrmArticulosListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 576);
            this.Controls.Add(this.pnlFiltroRapido);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlFiltroAvanzado);
            this.Controls.Add(this.pbImagenListado);
            this.Controls.Add(this.dgvListadoArticulos);
            this.Name = "FrmArticulosListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.FrmArticulosListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenListado)).EndInit();
            this.pnlFiltroAvanzado.ResumeLayout(false);
            this.pnlFiltroAvanzado.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlFiltroRapido.ResumeLayout(false);
            this.pnlFiltroRapido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoArticulos;
        private System.Windows.Forms.TextBox txtbFiltroRapido;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pbImagenListado;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.ComboBox cboFiltroAvanzadoCampo;
        private System.Windows.Forms.ComboBox cboFiltroAvanzadoCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzadoValor;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Label lblBuscarEn;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Panel pnlFiltroAvanzado;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlFiltroRapido;
        private System.Windows.Forms.Button btnBuscarFiltroAvanzado;
    }
}