using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Héritage
{
    class Felin:Mammifere
    {
        protected int nombrePattes;

        public Felin(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique, int nombrePattes)
            : base(nom, lieuHabitation, monCrie, jeSuisDomestique)
        {
            this.nombrePattes = nombrePattes;
        }

    }
}
