using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeritageExo3
{
    class Camion:Vehicule
    {
        bool semiRemorque;
        int essieux;

        public Camion(string immatriculation, int anneeDeConstruction, string marque, string modele, bool semiRemorque, int essieux)
            : base(immatriculation, anneeDeConstruction, marque, modele)
        {
            this.semiRemorque = semiRemorque;
            this.essieux = essieux;
        }

        public bool SemiRemorque
        {
            get
            {
                return this.semiRemorque;
            }
        }

        public int Essieux
        {
            get
            {
                return this.essieux;
            }
        }
        public override void Afficher()
        {
            string resultSemiRemorque;
            if (this.SemiRemorque == true)
            {
                resultSemiRemorque = "Semi Remorque";
            }
            else
            {
                resultSemiRemorque = "Sans SemiRemorque";
            }
            Console.WriteLine("camion : {0} avec {1} essieux \n Immatriculation: {2} \n Année de construction: {3} \n Marque: {4} \n Modèle {5} \n", resultSemiRemorque, this.Essieux, this.Immatriculation, this.AnneeDeConstruction, this.Marque, this.Modele);
        }
    }
}
