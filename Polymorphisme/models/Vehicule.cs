using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme.models
{
    public class Vehicule
    {
        #region Attributs + auto prop's
        public string Marque { get; set; } = string.Empty;
        public int Annee { get; set; }
        #endregion

        #region Méthodes
        public virtual void AfficherDetail()
        {
            Console.WriteLine("--- Description ---");
            Console.WriteLine($"Marque   : {Marque}");
            Console.WriteLine($"Année    : {Annee}");

        }


        #endregion
    }
}
