namespace SistemaProductos
{
    partial class FormularioArticulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxarticulo = new System.Windows.Forms.PictureBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnverdetalle = new System.Windows.Forms.Button();
            this.txtBusquedarapida = new System.Windows.Forms.TextBox();
            this.lblBusquedarapida = new System.Windows.Forms.Label();
            this.lblBusquedaAvanzada = new System.Windows.Forms.Label();
            this.lbllistadoarticulos = new System.Windows.Forms.Label();
            this.cbocampo = new System.Windows.Forms.ComboBox();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblcriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbocriterio = new System.Windows.Forms.ComboBox();
            this.txtBusquedaAvanzada = new System.Windows.Forms.TextBox();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.lblavisodgv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxarticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvArticulos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvArticulos.Location = new System.Drawing.Point(12, 50);
            this.DgvArticulos.MultiSelect = false;
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(480, 212);
            this.DgvArticulos.TabIndex = 0;
            this.DgvArticulos.SelectionChanged += new System.EventHandler(this.DgvArticulos_SelectionChanged);
            // 
            // pbxarticulo
            // 
            this.pbxarticulo.Location = new System.Drawing.Point(510, 50);
            this.pbxarticulo.Name = "pbxarticulo";
            this.pbxarticulo.Size = new System.Drawing.Size(343, 280);
            this.pbxarticulo.TabIndex = 1;
            this.pbxarticulo.TabStop = false;
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(442, 425);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(164, 425);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(117, 23);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "Agregar Articulo";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(302, 425);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(97, 23);
            this.btnmodificar.TabIndex = 4;
            this.btnmodificar.Text = "Modificar Articulo";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnverdetalle
            // 
            this.btnverdetalle.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverdetalle.Location = new System.Drawing.Point(26, 425);
            this.btnverdetalle.Name = "btnverdetalle";
            this.btnverdetalle.Size = new System.Drawing.Size(118, 23);
            this.btnverdetalle.TabIndex = 5;
            this.btnverdetalle.Text = "Ver a Detalle ";
            this.btnverdetalle.UseVisualStyleBackColor = true;
            this.btnverdetalle.Click += new System.EventHandler(this.btnverdetalle_Click);
            // 
            // txtBusquedarapida
            // 
            this.txtBusquedarapida.Location = new System.Drawing.Point(135, 295);
            this.txtBusquedarapida.Name = "txtBusquedarapida";
            this.txtBusquedarapida.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedarapida.TabIndex = 6;
            this.txtBusquedarapida.TextChanged += new System.EventHandler(this.txtBusquedarapida_TextChanged);
            // 
            // lblBusquedarapida
            // 
            this.lblBusquedarapida.AutoSize = true;
            this.lblBusquedarapida.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedarapida.Location = new System.Drawing.Point(13, 297);
            this.lblBusquedarapida.Name = "lblBusquedarapida";
            this.lblBusquedarapida.Size = new System.Drawing.Size(110, 15);
            this.lblBusquedarapida.TabIndex = 7;
            this.lblBusquedarapida.Text = "Busqueda Rapida :";
            // 
            // lblBusquedaAvanzada
            // 
            this.lblBusquedaAvanzada.AutoSize = true;
            this.lblBusquedaAvanzada.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaAvanzada.Location = new System.Drawing.Point(17, 342);
            this.lblBusquedaAvanzada.Name = "lblBusquedaAvanzada";
            this.lblBusquedaAvanzada.Size = new System.Drawing.Size(127, 15);
            this.lblBusquedaAvanzada.TabIndex = 8;
            this.lblBusquedaAvanzada.Text = "Busqueda Avanzada : ";
            // 
            // lbllistadoarticulos
            // 
            this.lbllistadoarticulos.AutoSize = true;
            this.lbllistadoarticulos.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllistadoarticulos.Location = new System.Drawing.Point(17, 19);
            this.lbllistadoarticulos.Name = "lbllistadoarticulos";
            this.lbllistadoarticulos.Size = new System.Drawing.Size(124, 15);
            this.lbllistadoarticulos.TabIndex = 9;
            this.lbllistadoarticulos.Text = "Su lista de Articulos :";
            // 
            // cbocampo
            // 
            this.cbocampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocampo.FormattingEnabled = true;
            this.cbocampo.Location = new System.Drawing.Point(97, 370);
            this.cbocampo.Name = "cbocampo";
            this.cbocampo.Size = new System.Drawing.Size(121, 21);
            this.cbocampo.TabIndex = 10;
            this.cbocampo.SelectedIndexChanged += new System.EventHandler(this.cbocampo_SelectedIndexChanged);
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(466, 372);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(71, 15);
            this.lblContenido.TabIndex = 11;
            this.lblContenido.Text = "Contenido :";
            // 
            // lblcriterio
            // 
            this.lblcriterio.AutoSize = true;
            this.lblcriterio.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcriterio.Location = new System.Drawing.Point(236, 372);
            this.lblcriterio.Name = "lblcriterio";
            this.lblcriterio.Size = new System.Drawing.Size(57, 15);
            this.lblcriterio.TabIndex = 12;
            this.lblcriterio.Text = "Criterio :";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(17, 376);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(53, 15);
            this.lblCampo.TabIndex = 13;
            this.lblCampo.Text = "Campo :";
            // 
            // cbocriterio
            // 
            this.cbocriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocriterio.FormattingEnabled = true;
            this.cbocriterio.Location = new System.Drawing.Point(324, 370);
            this.cbocriterio.Name = "cbocriterio";
            this.cbocriterio.Size = new System.Drawing.Size(121, 21);
            this.cbocriterio.TabIndex = 14;
            // 
            // txtBusquedaAvanzada
            // 
            this.txtBusquedaAvanzada.Location = new System.Drawing.Point(543, 370);
            this.txtBusquedaAvanzada.Name = "txtBusquedaAvanzada";
            this.txtBusquedaAvanzada.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaAvanzada.TabIndex = 15;
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(671, 368);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(75, 23);
            this.btnBusquedaAvanzada.TabIndex = 16;
            this.btnBusquedaAvanzada.Text = "Buscar";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // lblavisodgv
            // 
            this.lblavisodgv.AutoSize = true;
            this.lblavisodgv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavisodgv.ForeColor = System.Drawing.Color.Red;
            this.lblavisodgv.Location = new System.Drawing.Point(17, 269);
            this.lblavisodgv.Name = "lblavisodgv";
            this.lblavisodgv.Size = new System.Drawing.Size(237, 14);
            this.lblavisodgv.TabIndex = 17;
            this.lblavisodgv.Text = "*No se encuentra ningun articulo seleccionado";
            this.lblavisodgv.UseMnemonic = false;
            this.lblavisodgv.Visible = false;
            // 
            // FormularioArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 471);
            this.Controls.Add(this.lblavisodgv);
            this.Controls.Add(this.btnBusquedaAvanzada);
            this.Controls.Add(this.txtBusquedaAvanzada);
            this.Controls.Add(this.cbocriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.lblcriterio);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.cbocampo);
            this.Controls.Add(this.lbllistadoarticulos);
            this.Controls.Add(this.lblBusquedaAvanzada);
            this.Controls.Add(this.lblBusquedarapida);
            this.Controls.Add(this.txtBusquedarapida);
            this.Controls.Add(this.btnverdetalle);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.pbxarticulo);
            this.Controls.Add(this.DgvArticulos);
            this.Name = "FormularioArticulos";
            this.Text = "Sistema Productos";
            this.Load += new System.EventHandler(this.FormularioArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxarticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.PictureBox pbxarticulo;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnverdetalle;
        private System.Windows.Forms.TextBox txtBusquedarapida;
        private System.Windows.Forms.Label lblBusquedarapida;
        private System.Windows.Forms.Label lblBusquedaAvanzada;
        private System.Windows.Forms.Label lbllistadoarticulos;
        private System.Windows.Forms.ComboBox cbocampo;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblcriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbocriterio;
        private System.Windows.Forms.TextBox txtBusquedaAvanzada;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.Label lblavisodgv;
    }
}

