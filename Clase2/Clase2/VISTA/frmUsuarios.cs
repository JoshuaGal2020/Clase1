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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        tb_usuarios user = new tb_usuarios();
        void cargardatos() {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {

                var tb_usuarios = db.tb_usuarios;

                foreach (var iterardatosTbUsuarios in tb_usuarios)
                {

                    dtvUsuarios.Rows.Add(iterardatosTbUsuarios.Id, iterardatosTbUsuarios.Email, iterardatosTbUsuarios.Contrasena);

                }


                //dtvUsuarios.DataSource = db.tb_usuarios.ToList();
            }

        }
        void limpiardatos() {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dtvUsuarios.Rows.Clear();
            cargardatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1()) {
                

                user.Email = txtUsuario.Text;
                user.Contrasena = txtContrasena.Text;

                db.tb_usuarios.Add(user);
                db.SaveChanges();
            }
            limpiardatos();
            dtvUsuarios.Rows.Clear();
            cargardatos();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            using (sistema_ventasEntities1 db = new sistema_ventasEntities1()) {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();

                user = db.tb_usuarios.Find(int.Parse(Id));
                db.tb_usuarios.Remove(user);
                db.SaveChanges();
            }
            limpiardatos();
            dtvUsuarios.Rows.Clear();
            cargardatos();
            
        }

        private void dtvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Email = dtvUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Contra = dtvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtUsuario.Text = Email;
            txtContrasena.Text = Contra;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1()) {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
                int idc = int.Parse(Id);
                user = db.tb_usuarios.Where(verificarID => verificarID.Id == idc).First();
                user.Email = txtUsuario.Text;
                user.Contrasena = txtContrasena.Text;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();                
            }
            limpiardatos();
            dtvUsuarios.Rows.Clear();
            cargardatos();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
    }
}
