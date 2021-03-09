using concexionDB.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concexionDB
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            Carga();
            clear();
        }


        void clear() {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtPaswork.Clear();
        }
        
        void Carga() {
            dtgListaUsuario.Rows.Clear();
            using (EjemploDBEntities1 db = new EjemploDBEntities1())

            {
                var lista = db.Registrar.ToList();
                foreach (var iteracion in lista)
                {
                    dtgListaUsuario.Rows.Add(iteracion.Id,iteracion.Nombre,iteracion.Apellidos,iteracion.Telefono,iteracion.Recidencia,iteracion.paswork);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (EjemploDBEntities1 db = new EjemploDBEntities1() ) 
            
            {
                Registrar r = new Registrar();
                r.Nombre = txtNombre.Text;
                r.Apellidos = txtApellido.Text;
                r.Recidencia = txtDireccion.Text;
                r.Telefono =txtTelefono.Text;
                r.paswork = txtPaswork.Text;

                db.Registrar.Add(r);
                db.SaveChanges();
                
                Carga();
                clear();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (EjemploDBEntities1 db = new EjemploDBEntities1())
            { Registrar r = new Registrar();
                int eliminar = Convert.ToInt32(txtId.Text);
                r = db.Registrar.Find(eliminar);
                db.Registrar.Remove(r);
                db.SaveChanges();
                Carga();
                clear();

             }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            using (EjemploDBEntities1 db = new EjemploDBEntities1())
            {
                
                int update = Convert.ToInt32(txtId.Text);
                Registrar res = db.Registrar.Where(x => x.Id == 2).Select(x => x).FirstOrDefault();
                res.Nombre = txtNombre.Text;
                res.Apellidos = txtApellido.Text;
                res.Telefono = (txtTelefono.Text);
                res.Recidencia = txtDireccion.Text;
                res.paswork = txtPaswork.Text;
                db.SaveChanges();
                
            }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            Carga();
            clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dtgListaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dtgListaUsuario.CurrentRow.Cells[0].Value.ToString();
            String nombre = dtgListaUsuario.CurrentRow.Cells[1].Value.ToString();
            String apellido = dtgListaUsuario.CurrentRow.Cells[2].Value.ToString();
            String telefono = dtgListaUsuario.CurrentRow.Cells[3].Value.ToString();
            String direccion = dtgListaUsuario.CurrentRow.Cells[4].Value.ToString();
            String pas= dtgListaUsuario.CurrentRow.Cells[5].Value.ToString();
            txtId.Text = id;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtTelefono.Text = telefono;
            txtDireccion.Text = direccion;
            txtPaswork.Text = pas;



        }
    }
}
