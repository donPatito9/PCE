using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica de interacción para Guardar.xaml
    /// </summary>
    public partial class Guardar : Window
    {
        public Guardar()
        {
            InitializeComponent();
        }
        private void btnAgregarEquipo_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nombreEquipo = txtNombreEquipo.Text;
            int cantidadJugadores = Convert.ToInt32(txtCantidadJugadores.Text);
            string NombreDT = txtNombreDT.Text;
            string TipoEquipo = txtTipoEquipo.Text;
            string CapitanEquipo = txtCapitanEquipo.Text;


            bool tieneSub21 = (chkTieneSub21.IsChecked.Value) ? true : false;

            Class.Equipo equipo = new Class.Equipo(id, nombreEquipo, cantidadJugadores, NombreDT, TipoEquipo, CapitanEquipo, tieneSub21);

            Class.EquipoCollection.EquipoList.Add(equipo);

            this.Close();
        }
        private static Regex s_regex = new Regex("[^0-9]+");

        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
    }
}


