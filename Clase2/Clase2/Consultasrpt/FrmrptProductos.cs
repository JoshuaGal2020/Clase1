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
using Clase2.Reportes;

namespace Clase2.Consultasrpt
{
    public partial class FrmrptProductos : Form
    {
        public FrmrptProductos()
        {
            InitializeComponent();
        }

        private void FrmrptProductos_Load(object sender, EventArgs e)
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                rptProductos rptpr = new rptProductos();
                rptpr.SetDataSource(db.tb_producto.ToList());
                crproductos.ReportSource = rptpr;
            }
        }
    }
}
