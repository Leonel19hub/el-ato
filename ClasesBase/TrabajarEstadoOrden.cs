using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarEstadoOrden
    {
        public DataTable listarEstadosOrden()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM EstadoOrden";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void agregarEstadoOrden(string descripcion)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "INSERT INTO EstadoOrden (descripcion) VALUES (@Descripcion)";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void actualizarEstadoOrden(int estadoOrdenId, string descripcion)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "UPDATE EstadoOrden SET descripcion = @Descripcion WHERE estadoOrdenId = @EstadoOrdenId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@EstadoOrdenId", estadoOrdenId);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void eliminarEstadoOrden(int estadoOrdenId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "DELETE FROM EstadoOrden WHERE estadoOrdenId = @EstadoOrdenId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@EstadoOrdenId", estadoOrdenId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
