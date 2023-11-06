using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPlato
    {
        public DataTable listarPlatos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Plato";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void agregarPlato(int platoCategoriaId, string nombre, decimal precio)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "INSERT INTO Plato (platoCategoriaId, nombre, precio) VALUES (@PlatoCategoriaId, @Nombre, @Precio)";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@PlatoCategoriaId", platoCategoriaId);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Precio", precio);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void actualizarPlato(int platoId, int platoCategoriaId, string nombre, decimal precio)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "UPDATE Plato SET platoCategoriaId = @PlatoCategoriaId, nombre = @Nombre, precio = @Precio WHERE platoId = @PlatoId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@PlatoId", platoId);
                cmd.Parameters.AddWithValue("@PlatoCategoriaId", platoCategoriaId);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Precio", precio);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void eliminarPlato(int platoId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.ñatoBdConnectionString))
            {
                string query = "DELETE FROM Plato WHERE platoId = @PlatoId";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@PlatoId", platoId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
