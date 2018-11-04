using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Héritage
{
    class Baleine:Cetace
    {
        public Baleine(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique, int dureeApnee, int profondeurPlongee)
            : base(nom, lieuHabitation, monCrie, jeSuisDomestique, dureeApnee, profondeurPlongee)
        {
        }
        public void Afficher()
        {
            Console.WriteLine("nom : {0}, lieu Habitation : {1}, son Crie : {2}, je Suis Domestique : {3}, dureeApnee : {4}, profondeurPlongee : {5}", this.nom, this.lieuHabitation, this.monCrie, this.jeSuisDomestique, this.dureeApnee, this.profondeurPlongee);
        }
    }
}
