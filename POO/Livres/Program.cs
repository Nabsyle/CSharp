using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Livre monLivre = new Livre();
            monLivre.Titre = "Apprendre C# en s'amusant";
            monLivre.Auteur = "Claude C.";
            monLivre.ISBN = "978-1-4717-4645-1";
            monLivre.AnParution = 2014;
            monLivre.Tirage = 20;
            monLivre.CoutProduction = 7;
            monLivre.PrixVente = 15;
            monLivre.NombrePages = 177;
            monLivre.Poids = 320;
            monLivre.StockEncours = 10;

            Console.WriteLine("Tirage du livre \"{0}\" en {1} exemplaires", monLivre.Titre, monLivre.Tirage);

            Console.WriteLine("Stock en cours du livre \"{0}\" : {1} ", monLivre.Titre, monLivre.StockEncours);
            monLivre.AugmenterTirage();
            Console.WriteLine("Nouveau stock en cours du livre \"{0}\" : {1} ", monLivre.Titre, monLivre.StockEncours);
            Console.ReadKey();
        }
    }
}