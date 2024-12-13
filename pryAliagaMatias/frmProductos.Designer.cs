namespace pryAliagaMatias
{
  partial class frmProductos
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tvwUsuarios = new System.Windows.Forms.TreeView();
            this.lblTipoProd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvwUsuarios
            // 
            this.tvwUsuarios.Location = new System.Drawing.Point(35, 49);
            this.tvwUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvwUsuarios.Name = "tvwUsuarios";
            this.tvwUsuarios.Size = new System.Drawing.Size(472, 522);
            this.tvwUsuarios.TabIndex = 0;
            // 
            // lblTipoProd
            // 
            this.lblTipoProd.AutoSize = true;
            this.lblTipoProd.Location = new System.Drawing.Point(41, 19);
            this.lblTipoProd.Name = "lblTipoProd";
            this.lblTipoProd.Size = new System.Drawing.Size(127, 16);
            this.lblTipoProd.TabIndex = 1;
            this.lblTipoProd.Text = "Tipos de productos:";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 628);
            this.Controls.Add(this.lblTipoProd);
            this.Controls.Add(this.tvwUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProductos";
            this.Text = "Consultar productos";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView tvwUsuarios;
        private System.Windows.Forms.Label lblTipoProd;
    }
}