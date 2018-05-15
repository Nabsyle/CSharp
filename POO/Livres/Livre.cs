using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Livre
    {
        public string Titre;
        public string Auteur;
        public string ISBN;
        public int AnParution;
        public int Tirage;
        public int CoutProduction;
        public int PrixVente;
        public int NombrePages;
        public int Poids;
        public int StockEncours;

        public void AugmenterTirage()
        {
            this.Tirage++;
            this.StockEncours++;
            Console.WriteLine("Le nombre d'exemplaires est {0} ", Tirage);
        }

        public void CalculerMarge()
        {
            //Todo
        }
        public void MettreAuPilon()
        {
            StockEncours--;
            Console.WriteLine("Stock en cours: {0}", StockEncours);
        }

    }
}