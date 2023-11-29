using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructeur.models
{
    public class Voiture : Vehicule
    {
        #region Attributs + auto prop's
        // définition des attributs qui compose le modèle voiture
        public string Modele { get; set; } = string.Empty;
        public int CapaciteCoffre { get; set; }

        private string _Couleur = string.Empty;

        #endregion

        #region Constructeur

        /// <summary>
        /// Constructeur sans l'application de la couleur
        /// </summary>
        /// <param name="marque"></param>
        /// <param name="annee"></param>
        /// <param name="modele"></param>
        /// <param name="capaciteCoffre"></param>
        public Voiture(string marque, int annee, string modele, int capaciteCoffre): base(marque, annee)
        {
            Modele = modele;
            CapaciteCoffre = capaciteCoffre;
        }
        /// <summary>
        /// Constructeur avec l'application de la couleur
        /// </summary>
        /// <param name="marque"></param>
        /// <param name="annee"></param>
        /// <param name="modele"></param>
        /// <param name="capaciteCoffre"></param>
        /// <param name="couleur"></param>
        public Voiture(string marque, int annee, string modele, int capaciteCoffre, string couleur) : this(marque, annee, modele, capaciteCoffre)
        {
            _Couleur = couleur;
        }

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

        public override void AfficherDetail()
        {
            base.AfficherDetail();
            Console.WriteLine($"Modèle   : {Modele}");
            Console.WriteLine($"Coffre L : {CapaciteCoffre}");
            if (_Couleur != string.Empty)
            {
                Console.WriteLine($"Couleur  : {_Couleur}");
            }
            else
            {
                Console.WriteLine($"Couleur  :   //   ");

            }
        }

        public void AfficherVitesse()
        {
            Console.WriteLine("Vitesse : 200 km/h");
        }

        public override void Claxonner()
        {
            Console.WriteLine("La voiture fait Bip Bip !");
        }
        #endregion
    }
}