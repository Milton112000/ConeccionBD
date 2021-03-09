using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using concexionDB.VISTA;

namespace concexionDB.VISTA
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void registraUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();

        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {

            
          
                 
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminitrador_Click(object sender, EventArgs e)
        {
            
        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loguin log = new loguin();
            log.Show();
        }
    }
}
