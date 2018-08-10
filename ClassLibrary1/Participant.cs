using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeBoVoyage.Donne
{
    public sealed class Participant:Contact
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NumeroParticipant { get; set; }
        public List<Contact> participant;
    }
}
