using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  BoVoyage.DAL
{
   
    public class OffreBoVoyage:OffreAgenceVoyage
    {
        public int NombrePlaceLibre { get; set; }
        public List<OffreAgenceVoyage> offres { get; set; }
    }
}
