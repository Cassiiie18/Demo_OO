using Interface.models;
using Intrerface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrerface.models
{
    public class voitureElectrique : Vehicule, IVehiculeElectrique
    {
        public int CapaciteBatterie { get; set; } = 100;

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
    }
}
