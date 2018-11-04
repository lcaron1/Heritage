using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeritageExo3
{
    abstract class Vehicule
    {
        string immatriculation;
        int anneeDeConstruction;
        string marque;
        string modele;

        public Vehicule(string immatriculation, int anneeDeConstruction, string marque, string modele)
        {
            this.immatriculation = immatriculation;
            this.anneeDeConstruction = anneeDeConstruction;
            this.marque = marque;
            this.modele = modele;
        }
        public string Immatriculation
        {
            get
            {
                return this.immatriculation;
            }
        }
        public int AnneeDeConstruction
        {
            get
            {
                return this.anneeDeConstruction;
            }
        }
        public string Marque
        {
            get
            {
                return this.marque;
            }
        }
        public string Modele
        {
            get
            {
                return this.modele;
            }
        }

        public abstract void Afficher();
    }
}
