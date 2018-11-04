using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Héritage
{
    class Mammifere
    {
        protected string nom;
        protected string lieuHabitation;
        protected string monCrie;
        protected bool jeSuisDomestique;

        public Mammifere(string nom ,string lieuHabitation, string monCrie ,bool jeSuisDomestique)
        {
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
        }

    }

}
