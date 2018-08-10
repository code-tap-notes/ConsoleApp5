using System.Collections.Generic;
using BoVoyage.DAL;

namespace BoVoyage.Business
{
    public interface IServiceContact
    {
        IEnumerable<Contact> ChercherContacts(string texte);

        void CreerContact(Contact contact);

        IEnumerable<Contact> GetContacts();

        void SupprimerContact(Contact contact);
    }
}