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
using Clase2.VISTA.formulariosdebusqueda;

namespace Clase2.VISTA
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }
       
        private void frmVentas_Load(object sender, EventArgs e)
        {
            CargarCombo();
            retornarid();
        }

        void retornarid() 
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {

                var tb_V = db.tb_venta;

                foreach (var iterardatostbventas in tb_V)
                {
                    txtIDNumercion.Text = iterardatostbventas.idVenta.ToString();
                   // dtvUsuarios.Rows.Add(iterardatosTbUsuarios.Email, iterardatosTbUsuarios.Contrasena);

                }
            }
        }
        void CargarCombo() 
        {

            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1()) {

                var clientes = bd.tb_cliente.ToList();

                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "nombreCliente";
                cmbCliente.ValueMember = "iDCliente";


                var doc = bd.tb_documento.ToList();

                cmbTipoD.DataSource = doc;
                cmbTipoD.DisplayMember = "nombreDocumento";
                cmbTipoD.ValueMember = "iDDocumento";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBusqueda busqueda = new frmBusqueda();
            busqueda.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                calculo();
                
            }
            catch (Exception ex)
            {

            }


            dtgProductos.Rows.Add(txtIdProducto.Text,txtNombreProducto.Text,txtPrecioProd.Text,txtCantidad.Text,txtTotal.Text);

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            calculo();
        }
        void calculo() 
        {
            try
            {
                Double precioprod;
                Double cantidad;
                Double total;

                precioprod = Double.Parse(txtPrecioProd.Text);
                cantidad = Convert.ToDouble(txtCantidad.Text);

                total = precioprod * cantidad;

                txtTotal.Text = total.ToString();

                
                

            }
            catch (Exception ex)
            {
                txtCantidad.Text = "0";
                MessageBox.Show("NO SE PUEDE OPERAR CANTIDADES MENORES A 0");
                txtCantidad.Select();
            }
        }
        
    }
}
