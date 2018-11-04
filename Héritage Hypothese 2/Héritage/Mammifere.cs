using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Héritage
{
    class Mammifere
    {
        private string nom;
        private string lieuHabitation;
        private string monCrie;
        private bool jeSuisDomestique;

        public Mammifere(string nom ,string lieuHabitation, string monCrie ,bool jeSuisDomestique)
        {
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
        }
        public bool JeSuisDangereux
        {
            get {
                return this.jeSuisDomestique;
            }
        }
        public string Nom
        {
            get { return this.nom; }
        }

       public string LieuHabitation
        {
            get { return this.lieuHabitation; }
        }

       public bool JeSuisDomestique
       {
           get { return this.jeSuisDomestique; }
       }

       public string MonCrie
       {
           get { return this.monCrie; }
       }
    }

}
