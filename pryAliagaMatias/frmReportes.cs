using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryAliagaMatias
{
  public partial class frmReportes : Form
  {
    public frmReportes()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    clsPrincipal pr = new clsPrincipal();
    private void frmReportes_Load(object sender, EventArgs e)
    {
      
    }

    private void btnVentasPorMes_Click(object sender, EventArgs e)
    {
      pr.CargarVentasPorMes(chtVentasPorMes);
    }

    private void btnTipoProd_Click(object sender, EventArgs e)
    {
       pr.ObtenerDatosCategoria(chtTipoProd);
    }

    }
}
