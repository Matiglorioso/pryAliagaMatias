namespace pryAliagaMatias
{
  partial class frmVentas
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
            this.tvwVentas = new System.Windows.Forms.TreeView();
            this.dtpFechaD = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaH = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.grpConsultaVenta = new System.Windows.Forms.GroupBox();
            this.grpConsultaVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwVentas
            // 
            this.tvwVentas.Location = new System.Drawing.Point(23, 104);
            this.tvwVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvwVentas.Name = "tvwVentas";
            this.tvwVentas.Size = new System.Drawing.Size(610, 411);
            this.tvwVentas.TabIndex = 0;
            // 
            // dtpFechaD
            // 
            this.dtpFechaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaD.Location = new System.Drawing.Point(112, 27);
            this.dtpFechaD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaD.Name = "dtpFechaD";
            this.dtpFechaD.Size = new System.Drawing.Size(103, 22);
            this.dtpFechaD.TabIndex = 1;
            // 
            // dtpFechaH
            // 
            this.dtpFechaH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaH.Location = new System.Drawing.Point(336, 27);
            this.dtpFechaH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaH.Name = "dtpFechaH";
            this.dtpFechaH.Size = new System.Drawing.Size(107, 22);
            this.dtpFechaH.TabIndex = 2;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(17, 31);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(87, 16);
            this.lblFechaDesde.TabIndex = 3;
            this.lblFechaDesde.Text = "Fecha desde";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(240, 31);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(81, 16);
            this.lblFechaHasta.TabIndex = 4;
            this.lblFechaHasta.Text = "Fecha hasta";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(485, 25);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // grpConsultaVenta
            // 
            this.grpConsultaVenta.Controls.Add(this.btnFiltrar);
            this.grpConsultaVenta.Controls.Add(this.dtpFechaD);
            this.grpConsultaVenta.Controls.Add(this.lblFechaHasta);
            this.grpConsultaVenta.Controls.Add(this.dtpFechaH);
            this.grpConsultaVenta.Controls.Add(this.lblFechaDesde);
            this.grpConsultaVenta.Location = new System.Drawing.Point(23, 3);
            this.grpConsultaVenta.Name = "grpConsultaVenta";
            this.grpConsultaVenta.Size = new System.Drawing.Size(610, 72);
            this.grpConsultaVenta.TabIndex = 6;
            this.grpConsultaVenta.TabStop = false;
            this.grpConsultaVenta.Text = "Filtrar venta";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 590);
            this.Controls.Add(this.tvwVentas);
            this.Controls.Add(this.grpConsultaVenta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVentas";
            this.Text = "Consultar ventas";
            this.Load += new System.EventHandler(this.frmActividades_Load);
            this.grpConsultaVenta.ResumeLayout(false);
            this.grpConsultaVenta.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TreeView tvwVentas;
    private System.Windows.Forms.DateTimePicker dtpFechaD;
    private System.Windows.Forms.DateTimePicker dtpFechaH;
    private System.Windows.Forms.Label lblFechaDesde;
    private System.Windows.Forms.Label lblFechaHasta;
    private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox grpConsultaVenta;
    }
}
