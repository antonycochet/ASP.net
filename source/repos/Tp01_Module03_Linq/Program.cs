using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp01_Module03_Linq.Bo;

namespace Tp01_Module03_Linq
{
    class Program
    {

        static void Main(string[] args)
        {
            InitialiserDatas();

            var prenomsStartG = ListeAuteurs.Where(a => a.Nom.StartsWith("G")).Select(a => a.Prenom);
            Console.WriteLine("Voici la liste des prenoms des auteurs dont le nom commence par la lettre G \n");
            foreach (var prenom in prenomsStartG)
            {
                Console.WriteLine(prenom);
            }
            Console.WriteLine("-----------------------------------------------------------------------------");

            var authorMostBooks = ListeLivres.GroupBy(a => a.Auteur).OrderByDescending(b => b.Count()).FirstOrDefault().Key;
            Console.WriteLine("L'auteur qui a écrit le plus de livre est : \n");
            Console.WriteLine($"{authorMostBooks.Nom.ToUpper()} {authorMostBooks.Prenom}");
            Console.WriteLine("-----------------------------------------------------------------------------");

            var booksByAuthor = ListeLivres.GroupBy(a => a.Auteur);
            Console.WriteLine("Voici le nombre moyen de pages par livre par auteur \n");
            foreach (var item in booksByAuthor)
            {
                Console.WriteLine($"{item.Key.Nom.ToUpper()} {item.Key.Prenom} avec une moyenne de pages = {item.Average(b => b.NbPages)}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------");

            var booksMostPages = ListeLivres.OrderByDescending(a => a.NbPages).First();
            Console.WriteLine("Le titre du livre avec le plus de pages : \n");
            Console.WriteLine($"{booksMostPages.Titre} avec {booksMostPages.NbPages} pages.");
            Console.WriteLine("-----------------------------------------------------------------------------");

            var averageAuthorGains = ListeAuteurs.Average(a => a.Factures.Sum(b => b.Montant));
            Console.WriteLine("Voici combien les auteurs ont gagnés en moyenne \n");
            Console.WriteLine(averageAuthorGains);
            Console.WriteLine("-----------------------------------------------------------------------------");

            var booksByAuthor2 = ListeLivres.GroupBy(a => a.Auteur);
            foreach(var books in booksByAuthor2)
            {
                Console.WriteLine();
                Console.WriteLine($"Voici les livres de {books.Key.Nom.ToUpper()} {books.Key.Prenom} : \n");
                foreach (var book in books)
                {
                    Console.WriteLine(book.Titre);
                }
            }
            Console.WriteLine("-----------------------------------------------------------------------------");

            var booksByOrder = ListeLivres.Select(a => a.Titre).OrderBy(b => b).ToList();
            Console.WriteLine("Voici les titres des livres par ordre alphabétique \n");
            foreach(var title in booksByOrder)
            {
                Console.WriteLine(title);
            }
          
            Console.WriteLine("-----------------------------------------------------------------------------");
            var averagePages = ListeLivres.Average(a => a.NbPages);
            var booksAboveAveragePages = ListeLivres.Where(a => a.NbPages > averagePages);
            Console.WriteLine($"Les titres des livres supérieures à la moyenne en page : \n");
            foreach (var book in booksAboveAveragePages)
            {
                Console.WriteLine($"{book.Titre}");
            }

            Console.WriteLine("-----------------------------------------------------------------------------");

            var authorWithLessBook = ListeLivres.GroupBy(a => a.Auteur).OrderBy(b => b.Count()).FirstOrDefault().Key;
            Console.WriteLine($"L'auteur ayant écrit le moins de livres : \n");
            Console.WriteLine(authorWithLessBook.Nom);

            Console.ReadKey();
        }

        private static List<Auteur> ListeAuteurs = new List<Auteur>();
        private static List<Livre> ListeLivres = new List<Livre>();

        private static void InitialiserDatas()
        {
            ListeAuteurs.Add(new Auteur("GROUSSARD", "Thierry"));
            ListeAuteurs.Add(new Auteur("GABILLAUD", "Jérôme"));
            ListeAuteurs.Add(new Auteur("HUGON", "Jérôme"));
            ListeAuteurs.Add(new Auteur("ALESSANDRI", "Olivier"));
            ListeAuteurs.Add(new Auteur("de QUAJOUX", "Benoit"));
            ListeLivres.Add(new Livre(1, "C# 4", "Les fondamentaux du langage", ListeAuteurs.ElementAt(0), 533));
            ListeLivres.Add(new Livre(2, "VB.NET", "Les fondamentaux du langage", ListeAuteurs.ElementAt(0), 539));
            ListeLivres.Add(new Livre(3, "SQL Server 2008", "SQL, Transact SQL", ListeAuteurs.ElementAt(1), 311));
            ListeLivres.Add(new Livre(4, "ASP.NET 4.0 et C#", "Sous visual studio 2010", ListeAuteurs.ElementAt(3), 544));
            ListeLivres.Add(new Livre(5, "C# 4", "Développez des applications windows avec visual studio 2010", ListeAuteurs.ElementAt(2), 452));
            ListeLivres.Add(new Livre(6, "Java 7", "les fondamentaux du langage", ListeAuteurs.ElementAt(0), 416));
            ListeLivres.Add(new Livre(7, "SQL et Algèbre relationnelle", "Notions de base", ListeAuteurs.ElementAt(1), 216));
            ListeAuteurs.ElementAt(0).addFacture(new Facture(3500, ListeAuteurs.ElementAt(0)));
            ListeAuteurs.ElementAt(0).addFacture(new Facture(3200, ListeAuteurs.ElementAt(0)));
            ListeAuteurs.ElementAt(1).addFacture(new Facture(4000, ListeAuteurs.ElementAt(1)));
            ListeAuteurs.ElementAt(2).addFacture(new Facture(4200, ListeAuteurs.ElementAt(2)));
            ListeAuteurs.ElementAt(3).addFacture(new Facture(3700, ListeAuteurs.ElementAt(3)));
        }
    }
}
