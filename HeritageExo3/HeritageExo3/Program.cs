using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeritageExo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule[] tab = new Vehicule[4];
            tab[0] = new Voiture("333 ABC 06", 2000, "peugeot", "306", true, false);
            tab[1] = new Voiture("321 BBD 06", 2001, "renault", "clio", false, true);
            tab[2] = new Camion("1234 TZ 06", 1993, "DAF", "T43", true, 4);
            tab[3] = new Camion("765 ACE 06", 1999, "Mercedes", "C.L", false, 3);


            for (int i = 0; i < 4; i++)
            {
                tab[i].Afficher();
            }

            Console.ReadLine();
          
        }
    }
}
