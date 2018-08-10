using System.Collections.Generic;

namespace BoVoyage.DAL
{
    public interface IOutilsgesstion
    {
        IEnumerable<Contact> GetListe();

        void Enregistrer(Contact contact);

        void Supprimer(Contact contact);
    }
}