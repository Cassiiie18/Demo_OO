using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexeur.models
{
    public class Voiture
    {
        #region Attributs + auto prop's
        // définition des attributs qui compose le modèle voiture
        public string Marque { get; set; } = string.Empty;
        public string Modele { get; set; } = string.Empty;
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