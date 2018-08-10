using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.DAL
{
    public sealed class Participant:Contact
    {
        
        public string NumeroParticipant { get; set; }
        public List<Contact> participant;
    }
}
