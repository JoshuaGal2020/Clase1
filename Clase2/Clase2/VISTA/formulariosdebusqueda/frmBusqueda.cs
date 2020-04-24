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
            filtro();
        }
        void filtro()
        {
            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1())
            {
                String Nombre = txtBusqueda.Text;

                var Buscarprod = from tbprod in bd.tb_producto

                                 where tbprod.nombreProducto.Contains(Nombre)

                                 select new
                                 {
                                     Id = tbprod.idProducto,
                                     Nombre = tbprod.nombreProducto,
                                     Precio = tbprod.precioProducto
                                 };

                dtgProductos.DataSource = Buscarprod.ToList();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void dtgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            envioTelmex();
        }
        void envioTelmex() 
        {
            String Id = dtgProductos.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgProductos.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtgProductos.CurrentRow.Cells[2].Value.ToString();


            frmMenu.Ven.txtIdProducto.Text = Id;
            frmMenu.Ven.txtNombreProducto.Text = Nombre;
            frmMenu.Ven.txtPrecioProd.Text = Precio;

            frmMenu.Ven.txtCantidad.Focus();
            this.Close();
        }

        private void dtgProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                envioTelmex();
            }
        }
    }
}
