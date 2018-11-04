using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Héritage
{
    class Lion:Felin
    {
        public Lion(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique, int nombrePattes)
            : base(nom, lieuHabitation, monCrie, jeSuisDomestique,nombrePattes)
        {

        }
        public void Afficher()
        {
            Console.WriteLine("nom : {0}, lieu Habitation : {1}, son Crie : {2}, jeSuisDomestique : {3}, nombrePattes : {4}", this.nom, this.lieuHabitation, this.monCrie, this.jeSuisDomestique, this.nombrePattes);
        }
    }
}
