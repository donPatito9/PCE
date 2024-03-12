using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Evaluacion_PCE.Form
{
    /// <summary>
    /// Lógica de interacción para ObtenerTodos.xaml
    /// </summary>
    public partial class ObtenerTodos : Window
    {
        public ObtenerTodos()
        {
            InitializeComponent();
            dgTodos.ItemsSource = Class.EquipoCollection.EquipoList;
            dgTodos.CanUserAddRows = false;
        }

        private void btnEliminarRegistro_Click(object sender, RoutedEventArgs e)
        {
            int index = dgTodos.SelectedIndex;
            Class.EquipoCollection.EquipoList.RemoveAt(index);
            dgTodos.Items.Refresh();
        }

        private void btnActualizarRegistro_Click(object sender, RoutedEventArgs e)
        {
            var EquipoSeleccionado = (Class.Equipo)dgTodos.SelectedItem;
            Actualizar actualizar = new(EquipoSeleccionado);
            actualizar.ShowDialog();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            dgTodos.Items.Refresh();
        }
    }
}

