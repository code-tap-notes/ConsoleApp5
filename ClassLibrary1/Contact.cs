using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeBoVoyage.Donne
{
    public class Contact
    {
        public string Civilite{ set; get; }
        public string Nom { set; get; }
        public string Prenom { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string Telephone { set; get; }
        public DateTime DateDeNaissance { set; get; }
    }
}
