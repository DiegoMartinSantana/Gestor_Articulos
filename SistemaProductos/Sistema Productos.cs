using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Producto;
using Gestor4;

namespace SistemaProductos
{
    public partial class FormularioArticulos : Form
    {
        private List<Articulo> ListaArticulos;
        public FormularioArticulos()
        {
            InitializeComponent();
        }

        private void FormularioArticulos_Load(object sender, EventArgs e)
        {
            Cargar();
            cbocampo.Items.Add("Nombre");
            cbocampo.Items.Add("Descripcion");
            cbocampo.Items.Add("Categoria");
            cbocampo.Items.Add("Marca");
            cbocampo.Items.Add("Precio");

        }
        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvArticulos.CurrentRow != null)
            {
                Articulo select = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
                cargarimagen(select.Imagen);
            }
        }
        public void Cargar()
        {
            
            Funcionalidad gestion = new Funcionalidad();
            try
            {
                ListaArticulos = gestion.Listar();
                DgvArticulos.DataSource = ListaArticulos;
                ocultarcolumnas();
             cargarimagen(ListaArticulos[0].Imagen);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void cargarimagen (string imagen)
        {
            try
            {
                pbxarticulo.Load(imagen);
            }
            catch (Exception )
            {
                pbxarticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            Agregar_Articulo Agregar = new Agregar_Articulo();
            Agregar.ShowDialog();
        }
        private void ocultarcolumnas()
        {
            DgvArticulos.Columns["Imagen"].Visible = false;
            DgvArticulos.Columns["Id"].Visible = false;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if (validarbotones())
            {
                Cargar();
                return;
            }
            seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            Agregar_Articulo Modificar = new Agregar_Articulo(seleccionado);
            Modificar.ShowDialog();
            Cargar();
        }

        private void btnverdetalle_Click(object sender, EventArgs e)
        {
            Articulo Detallar;
            if (validarbotones())
            {
                Cargar();
                return;
            }
            Detallar = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            ArticuloDetalle Detalleart = new ArticuloDetalle(Detallar);
            Detalleart.ShowDialog();
        }

        private void txtBusquedarapida_TextChanged(object sender, EventArgs e)
        {
            List <Articulo> Listafiltrar;
            string filtrar = txtBusquedarapida.Text;
            if (filtrar.Length >= 3 )
            {
                Listafiltrar = ListaArticulos.FindAll(Item => Item.Nombre.ToUpper().Contains(filtrar.ToUpper()) ||Item.Descripcion.ToUpper().Contains(filtrar.ToUpper()) || Item.Marca.Descripcion.ToUpper().Contains(filtrar.ToUpper()) || Item.Categoria.Descripcion.ToUpper().Contains(filtrar.ToUpper()));
            }
            else
            {
                Listafiltrar = ListaArticulos;
            }
            DgvArticulos.DataSource = null;
            DgvArticulos.DataSource = Listafiltrar;
            ocultarcolumnas();
        }
        private void cbocampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cbocampo.SelectedItem.ToString();
            if (campo == "Precio")
            { cbocriterio.Items.Clear();
                cbocriterio.Items.Add("Menor a");
                cbocriterio.Items.Add("Igual a");
                cbocriterio.Items.Add("Mayor a");
            }
            else
            {
                cbocriterio.Items.Clear();
                cbocriterio.Items.Add("Inicia con");
                cbocriterio.Items.Add("Contiene");
                cbocriterio.Items.Add("Termina con");

            }
        }
        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            Funcionalidad filtro = new Funcionalidad();
            try
            {
                if (validarfiltro())
                {
                    return;
                }
                string campo = cbocampo.SelectedItem.ToString();
                string criterio = cbocriterio.SelectedItem.ToString();
                string contenido = txtBusquedaAvanzada.Text;
                DgvArticulos.DataSource = filtro.BusquedaAvanzada(campo, criterio, contenido);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }   
        }
        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            Funcionalidad eliminando = new Funcionalidad();
            Articulo seleccionado;

            try
            {
                if (validarbotones()) { 
                    Cargar();
                return;
               }
                DialogResult respuesta = MessageBox.Show("Confirme Eliminacion, porfavor ", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
                    eliminando.Eliminar(seleccionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarfiltro()
        {
            if(cbocampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione campos a Filtrar");
                return true;
            }

            if (cbocriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione criterios a Filtrar");
                return true;
            }
            if (cbocampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtBusquedaAvanzada.Text))
                {
                    MessageBox.Show("Porfavor cargue filtro numerico");
                    return true;
                }
                if (Solonros(txtBusquedaAvanzada.Text))
                {
                    MessageBox.Show("Ingrese solo Numeros para este Campo");
                    return true;
                }
            }
           

            return false;
        }

        private bool Solonros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber (caracter)))
                {
                    return true;
                }
            }
            return false;
        }
        private bool validarbotones()
        {
            if (!(DgvArticulos.CurrentRow == null))
            {
                lblavisodgv.Visible = false;
                return false;
            }

            lblavisodgv.Visible = true;
            return true;
        }
    }
}

 
