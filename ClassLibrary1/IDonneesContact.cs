using System.Collections.Generic;

namespace BoVoyage.DAL
{
    public interface IDonneesContact
    {
        IEnumerable<Contact> GetListe();

        void Enregistrer(Contact contact);

        void Supprimer(Contact contact);
    }
}
