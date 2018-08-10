using System;
using System.Linq;
using System.Collections.Generic;
using BoVoyage.Business;
using BoVoyage.DAL;

namespace BoVoyage
{
    class Program
    {
        static List<OffreAgenceVoyage> offreA = new List<OffreAgenceVoyage>();
        static List<OffreBoVoyage> offreB = new List<OffreBoVoyage>();
        Destination destination = new Destination();
        
        static void ListeOffres()
        {
            OutilsConsole.AfficherChamp("DESTINATION", 10);
            OutilsConsole.AfficherChamp("DATE DEBUT", 10);
            OutilsConsole.AfficherChamp("DATE RETOUR", 20);   
            Console.WriteLine();
            Console.WriteLine(new string('-', 75));
            Console.Clear();
            Console.WriteLine("Liste des offres\n");
            OffreAgenceVoyage voyage1 = new OffreAgenceVoyage("Barcelone", 123, new DateTime(2018, 08, 20, 08, 45, 00), new DateTime(2018, 08, 26, 08, 15, 00));
            OffreAgenceVoyage voyage2 = new OffreAgenceVoyage("Vienne", 123, new DateTime(2018, 08, 20, 08, 45, 00), new DateTime(2018, 08, 26, 08, 15, 00));
            OffreAgenceVoyage voyage3 = new OffreAgenceVoyage("Bangkok", 123, new DateTime(2018, 08, 20, 08, 45, 00), new DateTime(2018, 08, 26, 08, 15, 00));
            OffreAgenceVoyage voyage4 = new OffreAgenceVoyage("Rio", 123, new DateTime(2018, 08, 20, 08, 45, 00), new DateTime(2018, 08, 26, 08, 15, 00));

            offreA.Add(voyage1);
            offreA.Add(voyage2);
            offreA.Add(voyage3);
            offreA.Add(voyage4);
  
            for (int i = 0; i < offreA.Count; i++)
            {
                Console.WriteLine($"({i})-{ offreA[i]} ");
            }
            Console.WriteLine("\nSelectionnez le numero de l'offre à ajouter");
            var index = int.Parse(Console.ReadLine());

            //offreA[index] =
            //offreA.RemoveAt(index);

            Console.ReadKey();

        }

        static IServiceContact service = new ServiceContact();

        static void Main(string[] args)
        {
            Console.WriteLine("1.Gestion Client");
            Console.WriteLine("2.Gestion Des Voyage");
            Console.WriteLine("3.Quiter");
            string saisie = Console.ReadLine();
            if (saisie == "1")
            {
                bool continuer = true;
                while (continuer)
                {
                    var choix = AfficherMenu1();
                    switch (choix)
                    {
                        case "1":
                            ListerContacts();
                            break;
                        case "2":
                            AjouterContact();
                            break;
                        case "3":
                            TrierContacts();
                            break;
                        case "4":
                            EcrireFichier();
                            break;
                        case "q":
                        case "Q":
                            continuer = false;
                            break;
                        default:
                            Console.WriteLine("Choix invalide, l'application va fermer...");
                            continuer = false;
                            break;
                    }
                }
            }
            Console.WriteLine("1.Gestion Client");
            Console.WriteLine("2.Gestion Des Voyage");
            Console.WriteLine("3.Quiter");
            if (saisie == "2")
            {
                bool continuer = true;
                while (continuer)
                {
                    var choix = AfficherMenu1();
                    switch (choix)
                    {
                        case "1":
                         // SuiviPayerDossier();
                            break;
                        case "2":
                           // ListerReservation();
                            break;
                        case "3":
                            ListeOffres;
                            break;
                        case "4":
                          //  SupprimerOffre();
                            break;
                        case "Q":
                            continuer = false;
                            break;
                        default:
                            Console.WriteLine("Choix invalide, l'application va fermer...");
                            continuer = false;
                            break;
                    }
                }
            }
        }

        static string AfficherMenu1()
        {
            Console.Clear();
            Console.WriteLine("MENU GESTION CLIENT\n");
            Console.WriteLine("1. Liste des client");
            Console.WriteLine("2. Ajout d’un client");
            Console.WriteLine("3. Trier contact par tranche d'age");
            Console.WriteLine("4. Entregistrer contact");
            Console.WriteLine("Q. Quitter");
            return Console.ReadLine();
        }
        static string AfficherMenu2()
        {
            Console.Clear();
            Console.WriteLine("MENU Gestion Des Voyage\n");
            Console.WriteLine("1. Suivi Dossier");
            Console.WriteLine("2. CreerDosier");
            Console.WriteLine("3. Liste des Offre");
            Console.WriteLine("4. Supprimer des Offre");
            Console.WriteLine("5. Calculer Assurance");
            Console.WriteLine("Q. Quitter");
            Console.Write("\nVotre choix: ");
            return Console.ReadLine();
        }

        static void ListerContacts()
        {
            Console.Clear();
            Console.WriteLine("LISTE DES CONTACTS\n");

            AfficherListeContacts(service.GetContacts());

            OutilsConsole.AfficherRetourMenu();
        }

        static void AfficherListeContacts(IEnumerable<Contact> listeContacts)
        {
            OutilsConsole.AfficherChamp("NOM", 10);
            OutilsConsole.AfficherChamp("PRENOM", 10);
            OutilsConsole.AfficherChamp("EMAIL", 20);
            OutilsConsole.AfficherChamp("TELEPHONE", 10);
            OutilsConsole.AfficherChamp("DATE NAISSANCE", 10);
            Console.WriteLine();
            Console.WriteLine(new string('-', 75));

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var contact in listeContacts)
            {
                OutilsConsole.AfficherChamp(contact.Nom, 10);
                OutilsConsole.AfficherChamp(contact.Prenom, 10);
                OutilsConsole.AfficherChamp(contact.Email, 20);
                OutilsConsole.AfficherChamp(contact.Telephone, 10);
                OutilsConsole.AfficherChamp(contact.DateNaissance?.ToShortDateString(), 10);
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        static void TrierContacts()
        {
            OutilsConsole.AfficherMessage(
                "Saisir 1: Pour trache d'age plus 65 ans ou 2: pour trache d'age moin 18 ans ",
                ConsoleColor.Yellow);
            var saisie = Console.ReadLine();
            byte tri;
            while (!byte.TryParse(saisie, out tri)
                || (tri < 1 || tri > 2))
            {
                OutilsConsole.AfficherMessageErreur("Choix inconnu. Recommence.");
                saisie = Console.ReadLine();
            }
            //public delegate (DateTime.Today-Contact.DateDeNaisance).Day>65) Predicate<T>  
            var tableau = new Dictionary<int, Func<IEnumerable<Contact>, IEnumerable<Contact>>>
            {
                [1] = Contact.TrierParNom,
                [2] = Contact.TrierParPrenom
            };

            IEnumerable<Contact> contactsTries = tableau[tri](service.GetContacts());

            AfficherListeContacts(contactsTries);

            OutilsConsole.AfficherRetourMenu();
        }

        static void AjouterContact()
        {
            Console.Clear();
            Console.WriteLine("AJOUT D'UN CONTACT\n");

            var contact = new Contact();
            contact.Nom = OutilsConsole.SaisirChaineObligatoire("Nom:");
            contact.Prenom = OutilsConsole.SaisirChaineObligatoire("Prénom:");

            Console.WriteLine("Email:");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Téléphone:");
            contact.Telephone = Console.ReadLine();

            contact.DateNaissance = OutilsConsole.SaisirDate("Date de naissance:");

            service.CreerContact(contact);

            OutilsConsole.AfficherMessage("Contact ajouté !", ConsoleColor.Green);

            OutilsConsole.AfficherRetourMenu();
        }

        static void SupprimerContact()
        {
            Console.Clear();
            Console.WriteLine("SUPPRESSION D'UN CONTACT\n");

            Console.Write("{0,-6} | ", "NUMERO");
            Console.Write("{0,-10} | ", "NOM");
            Console.Write("{0,-10} | ", "PRENOM");
            Console.WriteLine();
            Console.WriteLine(new string('-', 35));

            var listeContacts = service.GetContacts();

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (var i = 0; i < listeContacts.Count(); i++)
            {
                var contact = listeContacts.ElementAt(i);
                Console.Write("{0,-6} | ", i);
                Console.Write("{0,-10} | ", contact.Nom);
                Console.Write("{0,-10} | ", contact.Prenom);
                Console.WriteLine();
            }
            Console.ResetColor();

            Console.Write("Entre le numéro du contact à supprimer: ");
            var index = int.Parse(Console.ReadLine());

            if (index < listeContacts.Count())
            {
                var contact = listeContacts.ElementAt(index);
                service.SupprimerContact(contact);
                OutilsConsole.AfficherMessage("Contact supprimé !", ConsoleColor.Green);
            }
            else
            {
                OutilsConsole.AfficherMessageErreur("Numéro invalide !");
            }

            OutilsConsole.AfficherRetourMenu();
        }

        static void SupprimerOffre()
        {
            Console.Clear();
            Console.WriteLine("SUPPRESSION D'UN OFFRE\n");

            Console.Write("{0,-6} | ", " ");
            Console.Write("{0,-10} | ", "");
            Console.Write("{0,-10} | ", " ");
            Console.WriteLine();
            Console.WriteLine(new string('-', 35));

            var listeContacts = service.GetContacts();

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (var i = 0; i < listeContacts.Count(); i++)
            {
                var contact = listeContacts.ElementAt(i);
                Console.Write("{0,-6} | ", i);
                Console.Write("{0,-10} | ", contact.Nom);
                Console.Write("{0,-10} | ", contact.Prenom);
                Console.WriteLine();
            }
            Console.ResetColor();

            Console.Write("Entre le numéro du contact à supprimer: ");
            var index = int.Parse(Console.ReadLine());

            if (index < listeContacts.Count())
            {
                var contact = listeContacts.ElementAt(index);
                service.SupprimerContact(contact);
                OutilsConsole.AfficherMessage("Contact supprimé !", ConsoleColor.Green);
            }
            else
            {
                OutilsConsole.AfficherMessageErreur("Numéro invalide !");
            }

            OutilsConsole.AfficherRetourMenu();
        }
    }
}
