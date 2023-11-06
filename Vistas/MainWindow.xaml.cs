using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClasesBase;
using System.Data;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Crear una instancia de TrabajarProducto
        TrabajarProducto trabajarProducto = new TrabajarProducto();

        public MainWindow()
        {
            InitializeComponent();

            

            // Obtener los datos de la consulta
            DataTable dt = trabajarProducto.listarProductos();

            // Asignar los datos al control de cuadrícula de datos (DataGrid)
            if (dt != null)
            {
                dataGrid.ItemsSource = dt.DefaultView; // dataGrid es el nombre del control de cuadrícula de datos en tu MainWindow.xaml
            }

            CargarDatos();
        }

        private void CargarDatos()
        {
            DataTable dt = trabajarProducto.listarProductos();
            if (dt != null)
            {
                dataGrid.ItemsSource = dt.DefaultView;
            }
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int categoriaId = Convert.ToInt32(txtCategoriaId.Text);
                string nombre = txtNombre.Text;
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                string unidadMedida = txtUnidadMedida.Text;

                trabajarProducto.agregarProducto(categoriaId, nombre, precio, stock, unidadMedida);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int categoriaId = Convert.ToInt32(txtCategoriaId.Text);
                string nombre = txtNombre.Text;
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                string unidadMedida = txtUnidadMedida.Text;

                trabajarProducto.actualizarProducto(categoriaId, nombre, precio, stock, unidadMedida);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //int productoId = Convert.ToInt32(txtProductoId.Text);
                //trabajarProducto.eliminarProducto(productoId);
                //CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
