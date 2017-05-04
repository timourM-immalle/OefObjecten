using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefObjecten
{
    public class Persoon
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public Persoon()
        {

        }

        public Persoon(string naam, int lt)
        {
            Naam = naam;
            Leeftijd = lt;
        }
    }

    public class Artikel
    {
        public string Naam { get; set; }
        public double EP { get; set; }
        public int Aantal { get; set; }

        public Artikel()
        {

        }

        public Artikel(string artikelnaam, double eenheidsprijs, int aantal)
        {
            Naam = artikelnaam;
            EP = eenheidsprijs;
            Aantal = aantal;
        }

        public double Totaalprijs
        {
            get
            {
                return EP * Aantal;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Persoon> personen = new List<Persoon>();

            //1e manier
            Persoon p1 = new Persoon { Naam = "Joske", Leeftijd = 13 };
            personen.Add(p1);

            //2e manier
            Persoon p2 = new Persoon();
            p2.Naam = "Jantje";
            p2.Leeftijd = 14;
            personen.Add(p2);

            //3e manier
            Persoon p3 = new Persoon("Mieke", 15);
            personen.Add(p3);

            foreach (Persoon p in personen)
            {
                Console.WriteLine(p.Naam + " is " + p.Leeftijd + " jaar oud.");
            }
            //////////////////////////////////////////////
            List<Artikel> artikels = new List<Artikel>();
            artikels.Add(new Artikel("tafel", 399.00, 1));
            artikels.Add(new Artikel("stoel", 79.00, 4));

            foreach (Artikel a in artikels)
            {
                Console.WriteLine(String.Format("{0} kost {1:c}/stuk. Men koopt  er {2} van aan en dus kost het in totaal {3:c}.", a.Naam, a.EP, a.Aantal, a.Totaalprijs));
            }
        }
    }
}