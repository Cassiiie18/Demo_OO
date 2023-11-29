using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surcharge_operateur.models
{
    public class Voiture
    {
        #region Attributs + auto prop's
        // définition des attributs qui compose le modèle voiture
        public string Marque { get; set; } = string.Empty;
        public string Modele { get; set; } = string.Empty;
        public int CapaciteCoffre { get; set; }
        public int Annee { get; set; }

        private string _Couleur = string.Empty;

        #endregion

        #region Prop's
        // création des props pour le controle de mes attributs depuis l'extérieur de ma classe
        public string Couleur
        {
            get { return _Couleur; }            // lecture
            private set { _Couleur = value; }   // écriture
        }
        #endregion

        #region Méthodes
        // Surcharge de l'opérateur +
        public static double operator +(Voiture voiture1, Voiture voiture2)
        {
            // Addition des capacités du coffre
            return voiture1.CapaciteCoffre + voiture2.CapaciteCoffre;
        }

        public static double operator +(Voiture voiture1, int capaciteCoffre)
        {
            // Addition des capacités du coffre
            return voiture1.CapaciteCoffre + capaciteCoffre;
        }

        // création de comportements lié a ma voiture
        /// <summary>
        /// Permet de définir une couleur sur la voiture 
        /// </summary>
        /// <param name="couleur">encodage de la couleur en chaine de caractère</param>
        public void DefinirCouleur(string couleur)
        {
            _Couleur = couleur;
        }

        public void Description()
        {
            Console.WriteLine($" Marque     : {Marque}");
            if (_Couleur == string.Empty)
            {
                Console.WriteLine($" Couleur : Couleur non définie...");
            }
            else
            {
                Console.WriteLine($" Couleur : {_Couleur}");
            }
        }

        #endregion
    }
}