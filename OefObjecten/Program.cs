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
            
        }
    }
}