using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPlatoOrden
    {
        public DataTable listarPlatosOrden()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM PlatoOrden";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void agregarPlatoOrden(int platoId, int ordenId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "INSERT INTO PlatoOrden (platoId, ordenId) VALUES (@PlatoId, @OrdenId)";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@PlatoId", platoId);
                cmd.Parameters.AddWithValue("@OrdenId", ordenId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void actualizarPlatoOrden(int platoOrdenId, int platoId, int ordenId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "UPDATE PlatoOrden SET platoId = @PlatoId, ordenId = @OrdenId WHERE platoOrdenId = @PlatoOrdenId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@PlatoOrdenId", platoOrdenId);
                cmd.Parameters.AddWithValue("@PlatoId", platoId);
                cmd.Parameters.AddWithValue("@OrdenId", ordenId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void eliminarPlatoOrden(int platoOrdenId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "DELETE FROM PlatoOrden WHERE platoOrdenId = @PlatoOrdenId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@PlatoOrdenId", platoOrdenId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
