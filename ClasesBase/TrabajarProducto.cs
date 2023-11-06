using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarProducto
    {
        public DataTable listarProductos() 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Producto";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return(dt);
        }

        public void agregarProducto(int categoriaId, string nombre, decimal precio, int stock, string unidadMedida)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "INSERT INTO Producto (CategoriaId, Nombre, Precio, Stock, UnidadMedida) " +
                               "VALUES (@CategoriaId, @Nombre, @Precio, @Stock, @UnidadMedida)";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@UnidadMedida", unidadMedida);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void actualizarProducto(int categoriaId, string nombre, decimal precio, int stock, string unidadMedida)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "UPDATE Producto " +
                               "SET CategoriaId = @CategoriaId, Nombre = @Nombre, Precio = @Precio, " +
                               "Stock = @Stock, UnidadMedida = @UnidadMedida " +
                               "WHERE ProductoId = @ProductoId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@UnidadMedida", unidadMedida);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void eliminarProducto(int productoId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "DELETE FROM Producto WHERE ProductoId = @ProductoId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ProductoId", productoId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
