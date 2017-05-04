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
        }
    }
}