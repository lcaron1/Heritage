using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Héritage
{
    class Cetace:Mammifere
    {
        protected int dureeApnee;
        protected int profondeurPlongee;

        public Cetace(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique, int dureeApnee, int profondeurPlongee)
            : base(nom, lieuHabitation, monCrie, jeSuisDomestique)
        {
            this.dureeApnee = dureeApnee;
            this.profondeurPlongee = profondeurPlongee;
        }

        public int DureeApnee
        {
            get { return dureeApnee; }
        }

        public int ProfondeurPlongee
        {
            get { return profondeurPlongee; }
        }
    }
}
