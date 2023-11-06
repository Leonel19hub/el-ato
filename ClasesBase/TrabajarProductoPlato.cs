using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarProductoPlato
    {
        public DataTable listarProductosPlato()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM ProductoPlato";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void agregarProductoPlato(int productoId, int platoId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "INSERT INTO ProductoPlato (ProductoId, PlatoId) VALUES (@ProductoId, @PlatoId)";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ProductoId", productoId);
                cmd.Parameters.AddWithValue("@PlatoId", platoId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void actualizarProductoPlato(int productoPlatoId, int productoId, int platoId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "UPDATE ProductoPlato SET ProductoId = @ProductoId, PlatoId = @PlatoId WHERE ProductoPlatoId = @ProductoPlatoId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ProductoPlatoId", productoPlatoId);
                cmd.Parameters.AddWithValue("@ProductoId", productoId);
                cmd.Parameters.AddWithValue("@PlatoId", platoId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void eliminarProductoPlato(int productoPlatoId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "DELETE FROM ProductoPlato WHERE ProductoPlatoId = @ProductoPlatoId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ProductoPlatoId", productoPlatoId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
