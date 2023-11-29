using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructeur.models
{
    public abstract class Vehicule
    {
        #region Attributs + auto prop's
        public string Marque { get; private set; } = string.Empty;
        public int Annee { get; private set; }
        #endregion

        #region Constructeur
        public Vehicule(string marque, int annee)
        {
            Marque = marque;
            Annee = annee;
        }

        #endregion

        #region Méthodes
        public virtual void AfficherDetail()
        {
            Console.WriteLine("--- Description ---");
            Console.WriteLine($"Marque   : {Marque}");
            Console.WriteLine($"Année    : {Annee}");

        }
        // prototype pour un membre abstract
        public abstract void Claxonner();
        #endregion
    }
}
