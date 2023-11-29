using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme.models
{
    public class Moto : Vehicule
    {
        #region Méthodes

        public void Fairevrombir()
        {
            Console.WriteLine("Vrouum Vrouum !!!");
        }

        #endregion
    }
}
