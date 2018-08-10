using System;
using System.Collections.Generic;
using System.Linq;

namespace BoVoyage.DAL
{
    public class Contact
    {public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string Addresse { get; set; }


        public override string ToString()
        {
            return Nom + " " + Prenom;
        }

        public static IEnumerable<Contact> TrierParPrenom(IEnumerable<Contact> contacts)
        {
            return contacts.OrderBy(x => x.Prenom);
        }

        public static IEnumerable<Contact> TrierParNom(IEnumerable<Contact> contacts)
        {
            return contacts.OrderBy(x => x.Nom);
        }
    }
}