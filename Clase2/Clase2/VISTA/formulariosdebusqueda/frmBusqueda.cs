using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase2.Model;

namespace Clase2.VISTA.formulariosdebusqueda
{
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            cargar();
        }

        void cargar() 
        {
            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1())
            {

                var Jointablas = from tbprod in bd.tb_producto                               

                                 select new
                                 {
                                     Id = tbprod.idProducto,
                                     Nombre = tbprod.nombreProducto,
                                     Precio = tbprod.precioProducto
                                 };

             dtgProductos.DataSource = Jointablas.ToList();


            }
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgProductos.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgProductos.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtgProductos.CurrentRow.Cells[2].Value.ToString();


            frmMenu.Ven.txtIdProducto.Text = Id;
            frmMenu.Ven.txtNombreProducto.Text = Nombre;
            frmMenu.Ven.txtPrecioProd.Text = Precio;

            frmMenu.Ven.txtCantidad.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1()) 
            {
                String Nombre = txtBusqueda.Text;

                var Buscarprod = from tbprod in bd.tb_producto
                                 
                                 where tbprod.nombreProducto == Nombre

                                 select new
                                 {
                                     Id = tbprod.idProducto,
                                     Nombre = tbprod.nombreProducto,
                                     Precio = tbprod.precioProducto
                                 };

                dtgProductos.DataSource = Buscarprod.ToList();
            }
        }
    }
}
