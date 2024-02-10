using Gestor4;
using Producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Configuration;
using System.Drawing.Text;

namespace SistemaProductos
{
    public partial class Agregar_Articulo : Form

    {
        private Articulo articulo = null;
        private OpenFileDialog imglocal = null;
        public Agregar_Articulo()
        {
            InitializeComponent();
        }
        public Agregar_Articulo(Articulo Seleccionado)
        {
            InitializeComponent();
            this.articulo = Seleccionado;
            Text = "Articulo a Modificar";
        }



        private void Agregar_Articulo_Load(object sender, EventArgs e)
        {
            try
            {
                FuncionalidadCategoria categoria = new FuncionalidadCategoria();
                cbocategoria.DataSource = categoria.listarcat();
                cbocategoria.DisplayMember = "Descripcion";
                cbocategoria.ValueMember = "Id";
                FuncionalidadMarca marca = new FuncionalidadMarca();
                cbomarca.DataSource = marca.ListaMarca();
                cbomarca.DisplayMember = "Descripcion";
                cbomarca.ValueMember = "Id";

                if (articulo != null)
                {
                    txtNombre.Text = articulo.Nombre;
                    txtdescripcion.Text = articulo.Descripcion;
                    txtprecio.Text = articulo.Precio.ToString();
                    txturl.Text = articulo.Imagen;
                    cargarimagen(txturl.Text);
                    cbocategoria.SelectedValue = articulo.Categoria.Id;
                    cbomarca.SelectedValue = articulo.Marca.Id;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void cargarimagen(string imagen)
        {
            try
            {
                pbxArticulo2.Load(imagen);
            }
            catch (Exception)
            {

                pbxArticulo2.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }
        private void btnimglocal_Click(object sender, EventArgs e)
        {
            imglocal = new OpenFileDialog();
            imglocal.Filter = "jpg|*.jpg;|png | *.png;";
            if (imglocal.ShowDialog() == DialogResult.OK)
            {
                txturl.Text = imglocal.FileName;
                cargarimagen(imglocal.FileName);
            }
        }
            private void btnaceptar_Click_1(object sender, EventArgs e)
        {
            Funcionalidad funcionalidad = new Funcionalidad();
            try
            {
                if (validarfiltro() == true)
                {
                    return;
                }
                if (ValidarArchivo() == true)
                {
                    DialogResult resultado = MessageBox.Show("Ya se encuentra esta imagen. ¿Desea sobreescribrila?", "Archivo ya Existente", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.Yes)
                    {

                        string rutaborrar = @"C:\winformapp.catalogoart";
                        string archivoValidar = imglocal.SafeFileName;
                        string RutaComple = rutaborrar + @"\" + archivoValidar;


                        File.Delete(RutaComple);
                      

                      File.Copy(imglocal.FileName, ConfigurationManager.AppSettings["Carpetaimgcat"] + imglocal.SafeFileName);
                        

                    }
                    else if (resultado == DialogResult.No)
                    {
                        return;
                    }
                }
                else if (imglocal != null && !(txturl.Text.ToUpper().Contains("HTTP")))
                {
                        File.Copy(imglocal.FileName, ConfigurationManager.AppSettings["Carpetaimgcat"] + imglocal.SafeFileName);
                }

               
                if (articulo == null)
                    articulo = new Articulo();
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtdescripcion.Text;
                articulo.Imagen = txturl.Text;
                articulo.Precio = decimal.Parse(txtprecio.Text);
                articulo.Marca = (Marca)cbomarca.SelectedItem;
                articulo.Categoria = (Categoria)cbocategoria.SelectedItem;

                if (articulo.Id == 0)
                {
                    funcionalidad.Agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                    Close();
                }
                else
                {
                    funcionalidad.Modificar(articulo);
                    MessageBox.Show("Modificado Correcamente");
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarfiltro()
        {
            if (txtNombre.Text == "")
            {
                lblvalidarcampos.Visible = true;
                return true;
            }

            if (txtdescripcion.Text == "")
            {
                lblvalidarcampos.Visible = true;
                return true;
            }
            if (txturl.Text == "")
            {
                lblvalidarcampos.Visible = true;
                return true;
            }
            if (cbocategoria.SelectedIndex < 0)
            {
                lblvalidarcampos.Visible = true;
                return true;
            }
            if (cbomarca.SelectedIndex < 0)
            {
                lblvalidarcampos.Visible = true;
                return true;
            }
            if (txtprecio.Text == "")
            {
                lblvalidarcampos.Visible = true;
                return true;
            }
            if (!Solonros(txtprecio.Text))
            {
                lblsolonros.Visible = true;
                return true;
            }

            return false;
        }

        public bool Solonros(string cadena)
        {
            foreach (char item in cadena)
            {
                if (char.IsNumber(item) || char.IsPunctuation(item))
                {
                    return true;
                }
            }
            return false;
        }
        private bool ValidarArchivo()
        {
            if (imglocal != null && !(txturl.Text.ToUpper().Contains("HTTP")))
            {
                try
                {
                    string ruta = @"C:\winformapp.catalogoart";
                    string archivoValidar = imglocal.SafeFileName;
                    string RutaComple = ruta + @"\" + archivoValidar;

                    if (File.Exists(RutaComple))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return false;
        }
    }
}