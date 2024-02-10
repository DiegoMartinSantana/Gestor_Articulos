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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaProductos
{
    public partial class ArticuloDetalle : Form
    {

        private Articulo Detallar;
        public ArticuloDetalle()
        {
            InitializeComponent();
        }

        public ArticuloDetalle( Articulo detallar)
        {
            InitializeComponent();
            this.Detallar = detallar;
        }
        private void ArticuloDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                lblDnombre.Text = Detallar.Nombre;
                lblDdescripcion.Text = Detallar.Descripcion;
                lblDcategoria.Text = Detallar.Categoria.Descripcion;
                lblDMarca.Text = Detallar.Categoria.Descripcion;
                rtbUrl.Text = Detallar.Imagen;
                lblDprecio.Text = Detallar.Precio.ToString();
       
                cargarimagen(rtbUrl.Text);
                
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
                pbxdetalle.Load(imagen);
            }
            catch (Exception)
            {

                pbxdetalle.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void btnUrlcompleta_Click(object sender, EventArgs e)
        {
            rtbUrl.Visible = true;
        }
    }
}
