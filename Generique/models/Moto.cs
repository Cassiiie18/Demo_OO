using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generique.models
{
    public class Moto : Vehicule
    {
        #region Attributs + auto prop's

        public bool AntiChute { get; set; }

        #endregion

        #region Méthodes
        public override void Claxonner()
        {
            Console.WriteLine("La moto fait pouet pouet !");
        }

        public void Fairevrombir()
        {
            Console.WriteLine("Vrouum Vrouum !!!");
        }

        #endregion
    }
}
