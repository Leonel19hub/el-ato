using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarMetodoPago
    {
        public DataTable listarMetodosPago()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM MetodoPago";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void agregarMetodoPago(string descripcion)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "INSERT INTO MetodoPago (descripcion) VALUES (@Descripcion)";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void actualizarMetodoPago(int metodoPagoId, string descripcion)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "UPDATE MetodoPago SET descripcion = @Descripcion WHERE metodoPagoId = @MetodoPagoId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@MetodoPagoId", metodoPagoId);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void eliminarMetodoPago(int metodoPagoId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "DELETE FROM MetodoPago WHERE metodoPagoId = @MetodoPagoId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@MetodoPagoId", metodoPagoId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
