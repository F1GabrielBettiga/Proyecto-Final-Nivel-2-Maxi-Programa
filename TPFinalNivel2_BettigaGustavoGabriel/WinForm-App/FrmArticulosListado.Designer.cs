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
            this.button1 = new System.Windows.Forms.Button();
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
            this.txtbFiltroRapido.Location = new System.Drawing.Point(75, 22);
            this.txtbFiltroRapido.Name = "txtbFiltroRapido";
            this.txtbFiltroRapido.Size = new System.Drawing.Size(190, 20);
            this.txtbFiltroRapido.TabIndex = 1;
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(12, 25);
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
            this.btnEliminar.Location = new System.Drawing.Point(174, 369);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 369);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Detalles";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmArticulosListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbImagenArticulo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.txtbFiltroRapido);
            this.Controls.Add(this.dgvListadoArticulos);
            this.Name = "FrmArticulosListado";
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
        private System.Windows.Forms.Button button1;
    }
}