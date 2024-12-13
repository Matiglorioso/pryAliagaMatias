using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryAliagaMatias
{
    internal class clsPrincipal
    {
        string rutaArchivo = @"C:\Users\USUARIO\Downloads\Aliaga.accdb";
        public void ConectarBase()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
            OleDbConnection conn = new OleDbConnection(connectionString);

            try
            {
                conn.Open();
                MessageBox.Show("Conexión exitosa a la base de datos.");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void CargarCategorias(TreeView treeview)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

            string query = "SELECT * FROM CategoriaAlimentos";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string categoriaNombre = reader["Nombre"].ToString();
                        int categoriaId = Convert.ToInt32(reader["Id"]);

                        TreeNode categoriaNode = new TreeNode(categoriaNombre);
                        categoriaNode.Tag = categoriaId;

                        CargarProductos(categoriaId, categoriaNode);
                        treeview.Nodes.Add(categoriaNode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las categorías: " + ex.Message);
                }
            }
        }

        private void CargarProductos(int categoriaId, TreeNode categoriaNode)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

            string query = "SELECT Nombre FROM Productos WHERE TipoAlimento = (SELECT Nombre FROM CategoriaAlimentos WHERE Id = ?)";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", categoriaId);

                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string productoNombre = reader["Nombre"].ToString();
                        TreeNode productoNode = new TreeNode(productoNombre);

                        categoriaNode.Nodes.Add(productoNode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos: " + ex.Message);
                }
            }
        }

        public void CargarVentas(TreeView treeview, DateTimePicker fechadesde, DateTimePicker fechashasta)
        {
            DateTime fechaInicio = fechadesde.Value.Date;
            DateTime fechaFin = fechashasta.Value.Date;

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

            string query = "SELECT DISTINCT FechaVenta FROM Ventas WHERE FechaVenta BETWEEN ? AND ? ORDER BY FechaVenta";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    cmd.Parameters.AddWithValue("?", fechaInicio);
                    cmd.Parameters.AddWithValue("?", fechaFin);

                    OleDbDataReader reader = cmd.ExecuteReader();


                    treeview.Nodes.Clear();

                    while (reader.Read())
                    {
                        DateTime fechaVenta = Convert.ToDateTime(reader["FechaVenta"]);
                        TreeNode fechaNode = new TreeNode(fechaVenta.ToString("d"));
                        fechaNode.Tag = fechaVenta; 

                       
                        CargarProductosVendidos(fechaVenta, fechaNode, rutaArchivo);

                   
                        treeview.Nodes.Add(fechaNode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las ventas: " + ex.Message);
                }
            }
        }
        private void CargarProductosVendidos(DateTime fechaVenta, TreeNode fechaNode, string rutaArchivo)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

            string query = "SELECT Producto, SUM(Cantidad) AS TotalCantidad FROM Ventas WHERE FechaVenta = ? GROUP BY Producto";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", fechaVenta);

                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string productoNombre = reader["Producto"].ToString();
                        int cantidadVendida = Convert.ToInt32(reader["TotalCantidad"]);

                        TreeNode productoNode = new TreeNode($"{productoNombre}");
                        productoNode.Tag = productoNombre;

                       
                        CargarCantidadProducto(fechaVenta, productoNombre, productoNode, rutaArchivo, cantidadVendida);

                        
                        fechaNode.Nodes.Add(productoNode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos vendidos: " + ex.Message);
                }
            }
        }

        private void CargarCantidadProducto(DateTime fechaVenta, string productoNombre, TreeNode productoNode, string rutaArchivo, int cantidadVendida)
        {
            TreeNode cantidadNode = new TreeNode($"Cantidad: {cantidadVendida}");
            productoNode.Nodes.Add(cantidadNode);
        }
        public void CargarVentasPorMes(Chart cht)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                            SELECT Format(FechaVenta, 'yyyy-mm') AS Mes, SUM(Cantidad) AS TotalVentas 
                            FROM Ventas 
                            GROUP BY Format(FechaVenta, 'yyyy-mm') 
                            ORDER BY Format(FechaVenta, 'yyyy-mm');";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        cht.Series.Clear();
                        var series = cht.Series.Add("Ventas por mes");
                        series.ChartType = SeriesChartType.Bar;

                        series.IsXValueIndexed = false;

                        cht.ChartAreas[0].AxisX.Interval = 1;

                        var meses = new Dictionary<string, string>
                {
                    { "01", "ENE" },
                    { "02", "FEB" },
                    { "03", "MAR" },
                    { "04", "ABR" },
                    { "05", "MAY" },
                    { "06", "JUN" },
                    { "07", "JUL" },
                    { "08", "AGO" },
                    { "09", "SEPT" },
                    { "10", "OCT" },
                    { "11", "NOV" },
                    { "12", "DIC" }
                };

                        while (reader.Read())
                        {
                            string mes = reader["Mes"].ToString();
                            string mesNumero = mes.Substring(5, 2);
                            string mesNombre = meses[mesNumero];

                            int totalVentas = Convert.ToInt32(reader["TotalVentas"]);
                            series.Points.AddXY(mesNombre, totalVentas);
                        }
                    }
                }
                catch (OleDbException oleDbEx)
                {
                    MessageBox.Show("Error de base de datos al cargar las ventas por mes: " + oleDbEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las ventas por mes: " + ex.Message);
                }
            }
        }


        public void ObtenerDatosCategoria(Chart cht)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT CategoriaAlimentos.Nombre AS Categoria, 
                               SUM(Ventas.Cantidad) AS TotalCantidad
                        FROM (Ventas
                              INNER JOIN Productos ON Ventas.Id = Productos.Id)
                        INNER JOIN CategoriaAlimentos ON Productos.TipoAlimento = CategoriaAlimentos.Nombre
                        GROUP BY CategoriaAlimentos.Nombre";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                      
                        cht.Series.Clear();

                       
                        Series series = new Series("Ventas por Categoría")
                        {
                            ChartType = SeriesChartType.Pie,   
                            IsValueShownAsLabel = false, 
                            IsXValueIndexed = false,                            
                            IsVisibleInLegend = true,           
                            BorderWidth = 2,                   
                        };
                        cht.Series.Add(series);


                        while (reader.Read())
                        {
                            string categoria = reader["Categoria"].ToString();
                            int totalCantidad = Convert.ToInt32(reader["TotalCantidad"]);
                            series.Points.AddXY(categoria, totalCantidad);
                                                
                            series.Points[series.Points.Count - 1].LegendText = $"{categoria} - {totalCantidad}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos de ventas por categoría: " + ex.Message);
                }
            }
        }

    }
}

