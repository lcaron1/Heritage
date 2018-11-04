using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Héritage
{
    class Chat:Felin
    {
        public Chat(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique, int nombrePattes)
            : base(nom, lieuHabitation, monCrie, jeSuisDomestique,nombrePattes)
        {

        }
        public void Afficher()
        {
            Console.WriteLine("nom : {0}, lieu Habitation : {1},  son Crie : {2}, jeSuisDomestique : {3}, nombrePattes : {4}", this.Nom, this.LieuHabitation, this.MonCrie, this.JeSuisDomestique, this.NombrePattes);
        }
    }
}
