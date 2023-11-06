using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPagoOrden
    {
        public DataTable listarPagosOrden()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM PagoOrden";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void agregarPagoOrden(int metodoPagoId, int ordenId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "INSERT INTO PagoOrden (metodoPagoId, ordenId) VALUES (@MetodoPagoId, @OrdenId)";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@MetodoPagoId", metodoPagoId);
                cmd.Parameters.AddWithValue("@OrdenId", ordenId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void actualizarPagoOrden(int pagoOrdenId, int metodoPagoId, int ordenId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "UPDATE PagoOrden SET metodoPagoId = @MetodoPagoId, ordenId = @OrdenId WHERE pagoOrdenId = @PagoOrdenId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@PagoOrdenId", pagoOrdenId);
                cmd.Parameters.AddWithValue("@MetodoPagoId", metodoPagoId);
                cmd.Parameters.AddWithValue("@OrdenId", ordenId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void eliminarPagoOrden(int pagoOrdenId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "DELETE FROM PagoOrden WHERE pagoOrdenId = @PagoOrdenId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@PagoOrdenId", pagoOrdenId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
