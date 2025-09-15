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
            this.pbImagenArticulo = new System.Windows.Forms.PictureBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.lblBuscarEn = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoArticulos
            // 
            this.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulos.Location = new System.Drawing.Point(12, 48);
            this.dgvListadoArticulos.Name = "dgvListadoArticulos";
            this.dgvListadoArticulos.Size = new System.Drawing.Size(548, 315);
            this.dgvListadoArticulos.TabIndex = 0;
            // 
            // txtbFiltroRapido
            // 
            this.txtbFiltroRapido.Location = new System.Drawing.Point(370, 22);
            this.txtbFiltroRapido.Name = "txtbFiltroRapido";
            this.txtbFiltroRapido.Size = new System.Drawing.Size(190, 20);
            this.txtbFiltroRapido.TabIndex = 1;
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(295, 25);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(69, 13);
            this.lblFiltroRapido.TabIndex = 2;
            this.lblFiltroRapido.Text = "Filtro Rapido:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 369);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 427);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 398);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // pbImagenArticulo
            // 
            this.pbImagenArticulo.Location = new System.Drawing.Point(595, 48);
            this.pbImagenArticulo.Name = "pbImagenArticulo";
            this.pbImagenArticulo.Size = new System.Drawing.Size(300, 300);
            this.pbImagenArticulo.TabIndex = 6;
            this.pbImagenArticulo.TabStop = false;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(93, 390);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(75, 39);
            this.btnDetalles.TabIndex = 7;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(439, 390);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(439, 417);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 444);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(459, 369);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(80, 13);
            this.lblFiltroAvanzado.TabIndex = 11;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado";
            // 
            // lblBuscarEn
            // 
            this.lblBuscarEn.AutoSize = true;
            this.lblBuscarEn.Location = new System.Drawing.Point(375, 393);
            this.lblBuscarEn.Name = "lblBuscarEn";
            this.lblBuscarEn.Size = new System.Drawing.Size(58, 13);
            this.lblBuscarEn.TabIndex = 12;
            this.lblBuscarEn.Text = "Buscar en:";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(375, 420);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(54, 13);
            this.lblOperador.TabIndex = 13;
            this.lblOperador.Text = "Operador:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(395, 447);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 14;
            this.lblValor.Text = "Valor:";
            // 
            // FrmArticulosListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 469);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblBuscarEn);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.pbImagenArticulo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.txtbFiltroRapido);
            this.Controls.Add(this.dgvListadoArticulos);
            this.Name = "FrmArticulosListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoArticulos;
        private System.Windows.Forms.TextBox txtbFiltroRapido;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pbImagenArticulo;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Label lblBuscarEn;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblValor;
    }
}