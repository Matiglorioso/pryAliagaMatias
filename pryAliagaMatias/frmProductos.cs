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
  public partial class frmProductos : Form
  {
    public frmProductos()
    {
      InitializeComponent();
    }

    private void frmUsuarios_Load(object sender, EventArgs e)
    {
      clsPrincipal principal = new clsPrincipal();
      principal.CargarCategorias(tvwUsuarios);
    }

  }
}
