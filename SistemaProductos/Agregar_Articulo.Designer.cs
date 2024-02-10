namespace SistemaProductos
{
    partial class Agregar_Articulo
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
            this.pbxArticulo2 = new System.Windows.Forms.PictureBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.txturl = new System.Windows.Forms.TextBox();
            this.cbocategoria = new System.Windows.Forms.ComboBox();
            this.cbomarca = new System.Windows.Forms.ComboBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblpresentacion = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblvalidarcampos = new System.Windows.Forms.Label();
            this.lblsolonros = new System.Windows.Forms.Label();
            this.btnimglocal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxArticulo2
            // 
            this.pbxArticulo2.Location = new System.Drawing.Point(482, 55);
            this.pbxArticulo2.Name = "pbxArticulo2";
            this.pbxArticulo2.Size = new System.Drawing.Size(298, 216);
            this.pbxArticulo2.TabIndex = 1;
            this.pbxArticulo2.TabStop = false;
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnaceptar.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(225, 362);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(84, 32);
            this.btnaceptar.TabIndex = 7;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click_1);
            // 
            // txturl
            // 
            this.txturl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txturl.Location = new System.Drawing.Point(209, 251);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(100, 20);
            this.txturl.TabIndex = 10;
            // 
            // cbocategoria
            // 
            this.cbocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocategoria.FormattingEnabled = true;
            this.cbocategoria.Location = new System.Drawing.Point(209, 213);
            this.cbocategoria.Name = "cbocategoria";
            this.cbocategoria.Size = new System.Drawing.Size(121, 21);
            this.cbocategoria.TabIndex = 15;
            // 
            // cbomarca
            // 
            this.cbomarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomarca.FormattingEnabled = true;
            this.cbomarca.Location = new System.Drawing.Point(209, 174);
            this.cbomarca.Name = "cbomarca";
            this.cbomarca.Size = new System.Drawing.Size(121, 21);
            this.cbomarca.TabIndex = 16;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblnombre.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(27, 95);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(59, 15);
            this.lblnombre.TabIndex = 20;
            this.lblnombre.Text = "Nombre :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDesc.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(27, 138);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(84, 15);
            this.lblDesc.TabIndex = 21;
            this.lblDesc.Text = "Descripcion  :";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarca.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(27, 179);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 15);
            this.lblMarca.TabIndex = 22;
            this.lblMarca.Text = "Marca :";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategoria.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(27, 218);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(70, 15);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Categoria  :";
            // 
            // lblpresentacion
            // 
            this.lblpresentacion.AutoSize = true;
            this.lblpresentacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpresentacion.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpresentacion.Location = new System.Drawing.Point(12, 31);
            this.lblpresentacion.Name = "lblpresentacion";
            this.lblpresentacion.Size = new System.Drawing.Size(171, 15);
            this.lblpresentacion.TabIndex = 24;
            this.lblpresentacion.Text = "Ingrese los datos  del Articulo";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtdescripcion.Location = new System.Drawing.Point(209, 138);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 25;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUrl.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(27, 256);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(64, 15);
            this.lblUrl.TabIndex = 26;
            this.lblUrl.Text = "Imagen  :  ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecio.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(27, 288);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 15);
            this.lblPrecio.TabIndex = 27;
            this.lblPrecio.Text = "Precio  :";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtprecio.Location = new System.Drawing.Point(209, 283);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 28;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombre.Location = new System.Drawing.Point(209, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 29;
            // 
            // lblvalidarcampos
            // 
            this.lblvalidarcampos.AutoSize = true;
            this.lblvalidarcampos.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalidarcampos.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarcampos.Location = new System.Drawing.Point(146, 340);
            this.lblvalidarcampos.Name = "lblvalidarcampos";
            this.lblvalidarcampos.Size = new System.Drawing.Size(292, 15);
            this.lblvalidarcampos.TabIndex = 30;
            this.lblvalidarcampos.Text = " *Porfavor seleccione todos los campos a agregar";
            this.lblvalidarcampos.Visible = false;
            // 
            // lblsolonros
            // 
            this.lblsolonros.AutoSize = true;
            this.lblsolonros.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsolonros.ForeColor = System.Drawing.Color.Red;
            this.lblsolonros.Location = new System.Drawing.Point(315, 288);
            this.lblsolonros.Name = "lblsolonros";
            this.lblsolonros.Size = new System.Drawing.Size(190, 15);
            this.lblsolonros.TabIndex = 31;
            this.lblsolonros.Text = "*Ingrese solo numeros para este campo";
            this.lblsolonros.Visible = false;
            // 
            // btnimglocal
            // 
            this.btnimglocal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimglocal.Location = new System.Drawing.Point(330, 252);
            this.btnimglocal.Name = "btnimglocal";
            this.btnimglocal.Size = new System.Drawing.Size(32, 23);
            this.btnimglocal.TabIndex = 32;
            this.btnimglocal.Text = "+";
            this.btnimglocal.UseVisualStyleBackColor = false;
            this.btnimglocal.Click += new System.EventHandler(this.btnimglocal_Click);
            // 
            // Agregar_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 406);
            this.Controls.Add(this.btnimglocal);
            this.Controls.Add(this.lblsolonros);
            this.Controls.Add(this.lblvalidarcampos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.lblpresentacion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.cbomarca);
            this.Controls.Add(this.cbocategoria);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.pbxArticulo2);
            this.Name = "Agregar_Articulo";
            this.Text = "Agregar_Articulo";
            this.Load += new System.EventHandler(this.Agregar_Articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxArticulo2;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.ComboBox cbocategoria;
        private System.Windows.Forms.ComboBox cbomarca;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblpresentacion;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblvalidarcampos;
        private System.Windows.Forms.Label lblsolonros;
        private System.Windows.Forms.Button btnimglocal;
    }
}