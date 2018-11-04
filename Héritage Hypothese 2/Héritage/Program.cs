using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Héritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion1 = new Lion("thibo", "igloo", "craww", true, 4);
            Baleine baleine1 = new Baleine("marco", "ocean", "plouff", false, 200, 50);
            Chat chat1 = new Chat("Oggi", "maison", "miaou", true, 4);
            lion1.Afficher();
            baleine1.Afficher();
            chat1.Afficher();

            List<Mammifere> listeAnimaux = new List<Mammifere>();
            listeAnimaux.Add(lion1);
            listeAnimaux.Add(baleine1);
            listeAnimaux.Add(chat1);

            Console.WriteLine("Voulez vous un animal domestique (true ou false)");
            bool resultat = Convert.ToBoolean(Console.ReadLine());
            
            if (resultat == true)
            {
                Console.WriteLine("Chat");
            }
            else
            {
                Console.WriteLine("Lion, Baleine");
            }



            Console.ReadLine();
            }
        }
    }
}
