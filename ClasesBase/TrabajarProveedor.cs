using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarProveedor
    {
        public DataTable listarProveedores()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Proveedor";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void agregarProveedor(string nombre)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "INSERT INTO Proveedor (nombre) VALUES (@Nombre)";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void actualizarProveedor(int proveedorId, string nombre)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "UPDATE Proveedor SET nombre = @Nombre WHERE proveedorId = @ProveedorId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ProveedorId", proveedorId);
                cmd.Parameters.AddWithValue("@Nombre", nombre);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void eliminarProveedor(int proveedorId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "DELETE FROM Proveedor WHERE proveedorId = @ProveedorId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ProveedorId", proveedorId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
