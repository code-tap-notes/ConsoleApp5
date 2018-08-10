using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.DAL
{
    public class OffreAgenceVoyage
    { 
        
            public string Destination { get; set; }
            public double Prix { get; set; }
            public DateTime DateAller { get; set; }
            public DateTime DateRetour { get; set; }


            public OffreAgenceVoyage()
            {

            }
            public OffreAgenceVoyage(string _destination, double _prix, DateTime _datealler, DateTime _dateretour)
            {
                Destination = _destination;
                Prix = _prix;
                DateAller = _datealler;
                DateRetour = _dateretour;

            }
            public override string ToString()
            {
                return Destination + " " + Prix + " " + DateAller + " " + DateRetour;
            }

     }


}

