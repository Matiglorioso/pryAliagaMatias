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
  public partial class frmVentas : Form
  {
    public frmVentas()
    {
      InitializeComponent();
    }
      clsPrincipal pr = new clsPrincipal();
    private void frmActividades_Load(object sender, EventArgs e)
    {
      pr.CargarVentas(tvwVentas, dtpFechaD, dtpFechaH);
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
      pr.CargarVentas(tvwVentas, dtpFechaD, dtpFechaH);
    }
  }
}
