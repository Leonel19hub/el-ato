using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarOden
    {
        public DataTable listarOrdenes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Orden";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void agregarOrden(int estadoOrdenId, int mesa, DateTime fechaHora)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "INSERT INTO Orden (estadoOrdenId, mesa, fechaHora) VALUES (@EstadoOrdenId, @Mesa, @FechaHora)";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@EstadoOrdenId", estadoOrdenId);
                cmd.Parameters.AddWithValue("@Mesa", mesa);
                cmd.Parameters.AddWithValue("@FechaHora", fechaHora);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void actualizarOrden(int ordenId, int estadoOrdenId, int mesa, DateTime fechaHora)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "UPDATE Orden SET estadoOrdenId = @EstadoOrdenId, mesa = @Mesa, fechaHora = @FechaHora WHERE ordenId = @OrdenId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@OrdenId", ordenId);
                cmd.Parameters.AddWithValue("@EstadoOrdenId", estadoOrdenId);
                cmd.Parameters.AddWithValue("@Mesa", mesa);
                cmd.Parameters.AddWithValue("@FechaHora", fechaHora);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void eliminarOrden(int ordenId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "DELETE FROM Orden WHERE ordenId = @OrdenId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@OrdenId", ordenId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
