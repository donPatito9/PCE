using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_PCE.Form.Class
{
    public class Equipo
    {

        public int Id { get; set; }
        public string NombreEquipo { get; set; } = null!;
        public int CantidadJugadores { get; set; }
        public string NombreDT { get; set; } = null!;
        public string TipoEquipo { get; set; } = null!;
        public string CapitanEquipo { get; set; } = null!;
        public bool TieneSub21 { get; set; }

        public Equipo(int id, string nombreEquipo, int cantidadJugadores, string nombreDT, string tipoEquipo, string capitanEquipo, bool tieneSub21)
        {
            Id = id;
            NombreEquipo = nombreEquipo;
            CantidadJugadores = cantidadJugadores;
            NombreDT = nombreDT;
            TipoEquipo = tipoEquipo;
            CapitanEquipo = capitanEquipo;
            TieneSub21 = tieneSub21;
        }

        public Equipo()
        {

        }
    }
}



