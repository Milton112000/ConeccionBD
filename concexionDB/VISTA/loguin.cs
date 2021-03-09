using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using concexionDB.DAO;
using concexionDB.DOMINIO;
using concexionDB.NEGOCIO;
using concexionDB.VISTA;

namespace concexionDB.VISTA
{
    public partial class loguin : Form
    {
        public int usuario;
        public loguin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsDAO DAO = new clsDAO();
            MENU m = new MENU();
            ClsLoguo log = new ClsLoguo();
            ClsLogueDominio d = new ClsLogueDominio();

            d.User = txtUser.Text;
            d.Pass = txtpaswork.Text;

            Boolean ac = log.accederLogue(d);

            if (ac == true)
            {

                Form1 form = new Form1();

                MessageBox.Show(" ACCESO CONCEDIDO "," " + txtUser);
                form.Show();
                this.Hide();

            }
            else {
                MessageBox.Show(" NO entraste");
            }
           
        }
    }
}
