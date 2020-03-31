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

namespace Clase2.VISTA
{
    public partial class frmROLES : Form
    {
        public frmROLES()
        {
            InitializeComponent();
        }

        private void frmROLES_Load(object sender, EventArgs e)
        {
            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1()) {

                var Jointablas = from tbusua in bd.tb_usuarios
                                 from rolesusuarios in bd.roles_usuario
                                 where tbusua.Id == rolesusuarios.id_Rol_usuario

                                 select new
                                 {
                                     Id = tbusua.Id,
                                     Email = tbusua.Email,
                                     Tipo_rol = rolesusuarios.tipo_rol
                                 };

                dtVistaRoles.DataSource = Jointablas.ToList();


            }
        }
    }
}
