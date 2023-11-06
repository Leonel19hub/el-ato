using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPlatoCategoria
    {
        public DataTable listarPlatoCategorias()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM PlatoCategoria";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void agregarPlatoCategoria(string descripcion)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "INSERT INTO PlatoCategoria (descripcion) VALUES (@Descripcion)";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void actualizarPlatoCategoria(int platoCategoriaId, string descripcion)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "UPDATE PlatoCategoria SET descripcion = @Descripcion WHERE platoCategoriaId = @PlatoCategoriaId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@PlatoCategoriaId", platoCategoriaId);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void eliminarPlatoCategoria(int platoCategoriaId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "DELETE FROM PlatoCategoria WHERE platoCategoriaId = @PlatoCategoriaId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@PlatoCategoriaId", platoCategoriaId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
