using Constructeur.models;
using Constructeur.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructeur.models
{
    public class voitureElectrique : Vehicule, IVehiculeElectrique
    {
        #region Attributs + auto prop's
        public int CapaciteBatterie { get; set; } = 100;
        #endregion

        #region Constructeur
        public voitureElectrique(string marque, int annee) : base(marque, annee)
        {
            // éléments implémentés au niveau du parent
        }
        #endregion

        #region Méthodes

        public override void Claxonner()
        {
            Console.WriteLine("La voiture életrique fait Bip Bip !");

        }

        public void Recharger()
        {
            CapaciteBatterie = 100;
        }

        public void EffectuerTrajet()
        {
            if (CapaciteBatterie <= 0)
            {
                Console.WriteLine("Batterie a plat, veuillez recharger");
            }
            else
            {
                CapaciteBatterie -= 20;
            }
        }

        #endregion
    }
}
