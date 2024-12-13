namespace pryAliagaMatias
{
  partial class frmReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtTipoProd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtVentasPorMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTipoProd = new System.Windows.Forms.Button();
            this.btnVentasPorMes = new System.Windows.Forms.Button();
            this.lblVentasxMes = new System.Windows.Forms.Label();
            this.lblAlimMasVend = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtTipoProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtVentasPorMes)).BeginInit();
            this.SuspendLayout();
            // 
            // chtTipoProd
            // 
            chartArea3.Name = "ChartArea1";
            this.chtTipoProd.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtTipoProd.Legends.Add(legend3);
            this.chtTipoProd.Location = new System.Drawing.Point(136, 545);
            this.chtTipoProd.Margin = new System.Windows.Forms.Padding(4);
            this.chtTipoProd.Name = "chtTipoProd";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtTipoProd.Series.Add(series3);
            this.chtTipoProd.Size = new System.Drawing.Size(1110, 304);
            this.chtTipoProd.TabIndex = 0;
            // 
            // chtVentasPorMes
            // 
            chartArea4.Name = "ChartArea1";
            this.chtVentasPorMes.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtVentasPorMes.Legends.Add(legend4);
            this.chtVentasPorMes.Location = new System.Drawing.Point(136, 64);
            this.chtVentasPorMes.Margin = new System.Windows.Forms.Padding(4);
            this.chtVentasPorMes.Name = "chtVentasPorMes";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chtVentasPorMes.Series.Add(series4);
            this.chtVentasPorMes.Size = new System.Drawing.Size(1110, 361);
            this.chtVentasPorMes.TabIndex = 1;
            // 
            // btnTipoProd
            // 
            this.btnTipoProd.Location = new System.Drawing.Point(520, 503);
            this.btnTipoProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoProd.Name = "btnTipoProd";
            this.btnTipoProd.Size = new System.Drawing.Size(100, 28);
            this.btnTipoProd.TabIndex = 2;
            this.btnTipoProd.Text = "Consultar";
            this.btnTipoProd.UseVisualStyleBackColor = true;
            this.btnTipoProd.Click += new System.EventHandler(this.btnTipoProd_Click);
            // 
            // btnVentasPorMes
            // 
            this.btnVentasPorMes.Location = new System.Drawing.Point(524, 28);
            this.btnVentasPorMes.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentasPorMes.Name = "btnVentasPorMes";
            this.btnVentasPorMes.Size = new System.Drawing.Size(100, 28);
            this.btnVentasPorMes.TabIndex = 3;
            this.btnVentasPorMes.Text = "Consultar";
            this.btnVentasPorMes.UseVisualStyleBackColor = true;
            this.btnVentasPorMes.Click += new System.EventHandler(this.btnVentasPorMes_Click);
            // 
            // lblVentasxMes
            // 
            this.lblVentasxMes.AutoSize = true;
            this.lblVentasxMes.Location = new System.Drawing.Point(305, 34);
            this.lblVentasxMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentasxMes.Name = "lblVentasxMes";
            this.lblVentasxMes.Size = new System.Drawing.Size(101, 16);
            this.lblVentasxMes.TabIndex = 4;
            this.lblVentasxMes.Text = "Ventas por mes";
            this.lblVentasxMes.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAlimMasVend
            // 
            this.lblAlimMasVend.AutoSize = true;
            this.lblAlimMasVend.Location = new System.Drawing.Point(185, 509);
            this.lblAlimMasVend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlimMasVend.Name = "lblAlimMasVend";
            this.lblAlimMasVend.Size = new System.Drawing.Size(195, 16);
            this.lblAlimMasVend.TabIndex = 5;
            this.lblAlimMasVend.Text = "Los 10 alimentos más vendidos";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 873);
            this.Controls.Add(this.lblAlimMasVend);
            this.Controls.Add(this.lblVentasxMes);
            this.Controls.Add(this.btnVentasPorMes);
            this.Controls.Add(this.btnTipoProd);
            this.Controls.Add(this.chtVentasPorMes);
            this.Controls.Add(this.chtTipoProd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReportes";
            this.Text = "Consultar reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtTipoProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtVentasPorMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataVisualization.Charting.Chart chtTipoProd;
    private System.Windows.Forms.DataVisualization.Charting.Chart chtVentasPorMes;
    private System.Windows.Forms.Button btnTipoProd;
    private System.Windows.Forms.Button btnVentasPorMes;
    private System.Windows.Forms.Label lblVentasxMes;
    private System.Windows.Forms.Label lblAlimMasVend;
  }
}