using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarProductoCategoria
    {
        public DataTable listarProductoCategoria()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM ProductoCategoria";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return (dt);
        }

        public void agregarProductoCategoria(string descripcion)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "INSERT INTO ProductoCategoria (descripcion) VALUES (@descripcion)";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void actualizarProductoCategoria(int categoriaId, string descripcion)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "UPDATE ProductoCategoria SET descripcion = @Descripcion WHERE categoriaId = @CategoriaId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void eliminarProductoCategoria(int categoriaId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "DELETE FROM ProductoCategoria WHERE categoriaId = @CategoriaId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
