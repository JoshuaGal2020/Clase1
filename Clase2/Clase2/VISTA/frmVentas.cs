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
        private int n = 0;
        public frmVentas()
        {
            InitializeComponent();
        }
       
        private void frmVentas_Load(object sender, EventArgs e)
        {
            retornarid();
            CargarCombo();
            
           
        }

        void retornarid() 
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {

                var tb_V = db.tb_venta;
                txtIDNumercion.Text = "1";
                foreach (var iterardatostbventas in tb_V)
                {
                    int idVenta = iterardatostbventas.idVenta;
                    int suma = idVenta + 1;
                    txtIDNumercion.Text = suma.ToString();
                    
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

            double toto = 0;
            foreach (DataGridViewRow row in dtgProductos.Rows)
            {
                toto += Convert.ToDouble(row.Cells["TOTAL"].Value);
            }
            txtTot.Text = Convert.ToString(toto);

            
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
                txtCantidad.Text = "1";
                
                txtCantidad.Select();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
           
            if (n != -1)
            {
                dtgProductos.Rows.RemoveAt(n);
            }

            double toto = 0;
            foreach (DataGridViewRow row in dtgProductos.Rows)
            {
                toto += Convert.ToDouble(row.Cells["TOTAL"].Value);
            }
            txtTot.Text = Convert.ToString(toto);


        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           n = e.RowIndex;

            if (n!=-1)
            {
                label11.Text = (string)dtgProductos.Rows[n].Cells[1].Value;
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1()) 
            {
                tb_venta tb_v = new tb_venta();
                String combo = cmbTipoD.SelectedValue.ToString();
                String comboCliente = cmbCliente.SelectedValue.ToString();
                tb_v.idDocumento = Convert.ToInt32(combo);
                tb_v.iDCliente = Convert.ToInt32(comboCliente);
                tb_v.iDUsuario = 1;
                tb_v.totalVenta = Convert.ToDecimal(txtTot.Text);
                tb_v.fecha = Convert.ToDateTime(dtpFecha.Text);

                bd.tb_venta.Add(tb_v);
                bd.SaveChanges();


                detalleVenta det = new detalleVenta();

                for (int i=0;i<dtgProductos.Rows.Count;i++) 
                {
                    String idProducto = dtgProductos.Rows[i].Cells[0].Value.ToString();
                    int idProductoConvertidos = Convert.ToInt32(idProducto);

                    String cantidad = dtgProductos.Rows[i].Cells[3].Value.ToString();
                    int cantidadConvertidos = Convert.ToInt32(cantidad);

                    String precio = dtgProductos.Rows[i].Cells[2].Value.ToString();
                    Decimal precioConvertidos = Convert.ToDecimal(precio);

                    String total = dtgProductos.Rows[i].Cells[4].Value.ToString();
                    Decimal totalConvertidos = Convert.ToDecimal(total);

                    det.idVenta = Convert.ToInt32(txtIDNumercion.Text);
                    det.idProducto = idProductoConvertidos;
                    det.cantidad = cantidadConvertidos;
                    det.precio = precioConvertidos;
                    det.total = totalConvertidos;

                    bd.detalleVenta.Add(det);
                    bd.SaveChanges();
                }
            }
            retornarid();
            dtgProductos.Rows.Clear();
            txtTot.Text = "";

        }

        private void txtCodigoBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCodigoBusqueda.Text == "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button1.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                using (sistema_ventasEntities1 bd = new sistema_ventasEntities1())
                {
                    tb_producto pro = new tb_producto();

                    int buscar = int.Parse(txtCodigoBusqueda.Text);
                    pro = bd.tb_producto.Where(idBusqueda => idBusqueda.idProducto == buscar).First();
                    txtIdProducto.Text = Convert.ToString(pro.idProducto);
                    txtNombreProducto.Text = Convert.ToString(pro.nombreProducto);
                    txtPrecioProd.Text = Convert.ToString(pro.precioProducto);
                    txtCantidad.Focus();
                    txtCodigoBusqueda.Text = "";

                }
            }
            
        }
        int intentos = 1;
        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (intentos == 2)
                {
                    btnAgregar.PerformClick();
                    
                    txtIdProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtPrecioProd.Text = "";
                    txtTotal.Text = "";
                    intentos = 0;
                    txtCantidad.Text = "1";
                    txtCodigoBusqueda.Focus();
                }
                intentos += 1;
            }
        }
    }
}
