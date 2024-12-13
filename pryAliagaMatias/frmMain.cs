using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAliagaMatias
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
              clsPrincipal pr = new clsPrincipal();
              pr.ConectarBase();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
              frmProductos usuarios = new frmProductos();
              usuarios.ShowDialog();
              this.Close();
        }

        private void archivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
              frmVentas ventas = new frmVentas();
              ventas.ShowDialog();
              this.Close();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
              frmReportes reportes = new frmReportes();
              reportes.ShowDialog();
              this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
