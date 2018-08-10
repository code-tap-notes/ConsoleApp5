using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeBoVoyage.Donne
{
    public class Reservation
    {
        public string NumeroDossier { get; set; }
        public string NombreParticipant {get; set;}
        public double CalculMontant { get; set; }
        public string EtatReservation { get; set; }
    }

}
