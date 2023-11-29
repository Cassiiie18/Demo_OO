using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Constructeur.models
{
    public class Moto : Vehicule
    {
        #region Attrivuts + auto prop's

        public int NombreRoue { get;private set; }

        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur pour mon objet moto
        /// </summary>
        /// <param name="marque">Marque de la moto</param>
        /// <param name="annee">Année de la moto</param>
        /// <param name="nombreRoue">Nombre de roue (2 par default)</param>
        public Moto(string marque, int annee, int nombreRoue = 2): base(marque, annee)
        {
            // marque et annee implémentés dans le constructeur parent
            NombreRoue = nombreRoue;
        }

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

        public override void AfficherDetail()
        {
            base.AfficherDetail();
            Console.WriteLine($"Nombre Roues : {NombreRoue}");
        }

        #endregion
    }
}
