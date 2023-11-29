using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.models
{
    public class Moto : Vehicule
    {
        public override void Claxonner()
        {
            Console.WriteLine("La moto fait pouet pouet !");
        }
        #region Méthodes

        public void Fairevrombir()
        {
            Console.WriteLine("Vrouum Vrouum !!!");
        }

        #endregion
    }
}
