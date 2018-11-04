using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeritageExo3
{
    class Voiture:Vehicule
    {
        bool decapotable;
        bool climatisation;

        public Voiture(string immatriculation, int anneeDeConstruction, string marque, string modele, bool decapotable, bool climatisation)
            : base(immatriculation, anneeDeConstruction, marque, modele)
        {
            this.decapotable = decapotable;
            this.climatisation = climatisation;
        }
        public bool Decapotable
        {
            get
            {
                return this.decapotable;
            }
        }

        public bool Climatisation
        {
            get
            {
                return this.climatisation;
            }
        }
        public override void Afficher()
        {
            string resusltClimatisation;
            if (this.Climatisation == true)
            {
                resusltClimatisation = "Avec climatisation";
            }
            else
            {
                resusltClimatisation = "Sans climatisation";
            }

            string resultDecapotable;
            if (this.Decapotable == true)
            {
                resultDecapotable = "Decapotable";
            }
            else
            {
                resultDecapotable = "Non decapotable";
            }
            Console.WriteLine("Voiture : {0}, {1} \n Immatriculation: {2} \n Année de construction: {3} \n Marque: {4} \n Modèle {5} \n", resultDecapotable, resusltClimatisation, this.Immatriculation, this.AnneeDeConstruction, this.Marque, this.Modele);
        }
    }
}
