using System;

namespace BoVoyage.DAL
{
    public static class OutilsConsole
    {
       
        public static string SaisirChaineObligatoire(string message)
        {
            Console.WriteLine(message);
            var saisie = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(saisie))
            {
                AfficherMessageErreur("Champ requis. Recommence:");
                saisie = Console.ReadLine();
            }

            return saisie;
        }

        public static int? SaisirEntier(string message)
        {
            Console.WriteLine(message);
            string saisie = Console.ReadLine();

            int entier = 0;
            while (!string.IsNullOrEmpty(saisie)
                    && !int.TryParse(saisie, out entier))
            {
                AfficherMessageErreur("Saisie invalide. Recommence:");
                saisie = Console.ReadLine();
            }

            return string.IsNullOrEmpty(saisie)
                    ? (int?)null
                    : entier;
        }

       
        public static int SaisirEntierObligatoire(string message)
        {
            Console.WriteLine(message);
            string saisie = Console.ReadLine();

            int entier = 0;
            while (string.IsNullOrEmpty(saisie)
                    || !int.TryParse(saisie, out entier))
            {
                var messageErreur = string.IsNullOrEmpty(saisie)
                     ? "Champ obligatoire. Recommence:"
                     : "Saisie invalide. Recommence:";
                AfficherMessageErreur(messageErreur);
                saisie = Console.ReadLine();
            }

            return entier;
        }
        
        public static DateTime? SaisirDate(string message)
        {
            Console.WriteLine(message);
            string saisie = Console.ReadLine();

            DateTime date = default(DateTime);
            while (!string.IsNullOrEmpty(saisie)
                    && !DateTime.TryParse(saisie, out date))
            {
                AfficherMessageErreur("Saisie invalide. Recommence:");
                saisie = Console.ReadLine();
            }

            return string.IsNullOrEmpty(saisie)
                    ? (DateTime?)null
                    : date;
        }

        public static DateTime SaisirDateObligatoire(string message)
        {
            Console.WriteLine(message);
            string saisie = Console.ReadLine();

            DateTime date;
            while (string.IsNullOrEmpty(saisie)
                    || !DateTime.TryParse(saisie, out date))
            {
                var messageErreur = string.IsNullOrEmpty(saisie)
                     ? "Champ obligatoire. Recommence:"
                     : "Saisie invalide. Recommence:";
                AfficherMessageErreur(messageErreur);
                saisie = Console.ReadLine();
            }

            return date;
        }

        
        public static void AfficherMessageErreur(string message)
        {
            AfficherMessage(message, ConsoleColor.Red);
        }

        public static void AfficherMessage(
            string message,
            ConsoleColor couleur = ConsoleColor.Gray)
        {
            Console.ForegroundColor = couleur;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        
        public static void AfficherChamp(string texte, int longueurAffichage)
        {
            texte = (texte ?? string.Empty);

            // Si le texte est plus long que la longueur d'affichage,
            //  on le tronque
            texte = texte.Substring(0, Math.Min(texte.Length, longueurAffichage));
            Console.Write($"{texte.PadRight(longueurAffichage)} | ");
        }

        public static void AfficherRetourMenu()
        {
            Console.WriteLine();
            AfficherMessage(
                "\n > Appuie sur une touche pour revenir au menu...",
                ConsoleColor.White);
            Console.ReadKey();
        }
    }
}