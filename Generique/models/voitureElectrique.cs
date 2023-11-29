using Generique.Interface;
using Generique.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generique.models
{
    public class voitureElectrique : Vehicule, IVehiculeElectrique
    {
        #region Attributs + auto prop's
        // Seuil pour la batterie faible (20 %)
        private const int SeuilBatterieFaible = 20;
        private int _CapaciteBatterie;
        // Evenement pour signaler la batterie faible
        public event EventHandler BatterieFaible;

        #endregion

        #region Prop's
        public int CapaciteBatterie
        {
            get { return _CapaciteBatterie; }
            set
            {
                _CapaciteBatterie = value;
                // Si la capacite de batterie est faible => je déclenche un événement
                if (_CapaciteBatterie < SeuilBatterieFaible)
                {
                    OnBatterieFaible();
                }
            }
        }
        #endregion

        #region Constructeurs

        #endregion

        #region Méthodes
        public override void Claxonner()
        {
            Console.WriteLine("La voiture életrique fait Bip Bip !");

        }

        public void Recharger()
        {
            _CapaciteBatterie = 100;
        }

        public void EffectuerTrajet()
        {
            if (CapaciteBatterie <= 0)
            {
                Console.WriteLine("Batterie a plat, veuillez recharger");
            }
            else
            {
                CapaciteBatterie -= 30;
            }
        }
        // méthode pour déclencher l'évenement de batterie faible
        protected virtual void OnBatterieFaible()
        {
            BatterieFaible?.Invoke(this, EventArgs.Empty);
            Console.WriteLine("LA batterie a passé le seuil de 20% ... Veuillez recharger !!!");

        }

        #endregion
    }
}
