using Evaluacion_PCE.Form.Class;
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
    /// Lógica de interacción para Actualizar.xaml
    /// </summary>
    public partial class Actualizar : Window
    {
        Equipo Equipo = new Class.Equipo();
        public Actualizar(Class.Equipo Equipo)
        {
            InitializeComponent();
            Equipo = Equipo;
            CargarDatosFormulario();
        }
        private void btnActualizarEquipo_Click(object sender, RoutedEventArgs e)
        {
            Class.Equipo EquipoTemporal = new();
            EquipoTemporal.Id = Convert.ToInt32(txtId.Text);
            EquipoTemporal.NombreEquipo = txtNombreEquipo.Text;
            EquipoTemporal.CantidadJugadores = Convert.ToInt32(txtCantidadJugadores.Text);

            EquipoTemporal.NombreDT = txtNombreDT.Text;
            EquipoTemporal.TipoEquipo = txtTipoEquipo.Text;
            EquipoTemporal.CapitanEquipo = txtCapitanEquipo.Text;
            EquipoTemporal.TieneSub21 = (chkTieneSub21.IsChecked.Value) ? false : true;

            int index = Class.EquipoCollection.EquipoList.IndexOf(this.Equipo);
            Class.EquipoCollection.EquipoList.RemoveAt(index);
            Class.EquipoCollection.EquipoList.Insert(index, EquipoTemporal);
            this.Close();
        }

        private void CargarDatosFormulario()
        {
            txtId.Text = this.Equipo.Id.ToString();
            txtNombreEquipo.Text = this.Equipo.NombreEquipo;
            txtCantidadJugadores.Text = this.Equipo.CantidadJugadores.ToString();
            txtNombreDT.Text = this.Equipo.NombreDT;
            txtTipoEquipo.Text = this.Equipo.TipoEquipo;
            txtCapitanEquipo.Text = this.Equipo.CapitanEquipo;
            chkTieneSub21.IsChecked = (this.Equipo.TieneSub21) ? true : false;
        }

        private static Regex s_regex = new Regex("[^0-9]+");

        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
    }
}
