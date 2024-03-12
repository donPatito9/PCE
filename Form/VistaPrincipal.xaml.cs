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
    /// Lógica de interacción para VistaPrincipal.xaml
    /// </summary>
    public partial class VistaPrincipal : Window
    {
            public VistaPrincipal()
            {
                InitializeComponent();
                dgVistaPrincipal.ItemsSource = Class.EquipoCollection.EquipoList;
                dgVistaPrincipal.CanUserAddRows = false;
            }

            private void btnAgregar_Click(object sender, RoutedEventArgs e)
            {
                Guardar agregar = new();
                agregar.ShowDialog();
            }

            private void btnListar_Click(object sender, RoutedEventArgs e)
            {
                ObtenerTodos listar = new();
                listar.ShowDialog();
            }
            private void btnAcercaDe_Click(object sender, RoutedEventArgs e)
            {
                Informacion acerca = new();
                acerca.ShowDialog();
            }

            private void Window_Activated(object sender, EventArgs e)
            {
                dgVistaPrincipal.Items.Refresh();

            }


        }
    }
