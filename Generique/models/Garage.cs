using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generique.models
{
    public class Garage<T>
        where T : Vehicule
    {
        #region Attributs + auto prop's
        private List<T> _Vehicule;

        private static int _NombreVehicules;

        #endregion

        #region Prop's
        public static int NombreVehicules
        {
            get { return _NombreVehicules; }
        }

        public Vehicule this[int index]
        {
            get
            {
                // Logique pour récupérer la voiture à l'index spécifié
                return _Vehicule[index];
            }
        }
        #endregion

        #region Constructeurs

        public Garage()
        {
            _Vehicule = new List<T>();
        }

        #endregion

        #region Méthodes
        public void AjouterVehicule(T vehicule)
        {
            _Vehicule.Add(vehicule);
        }

        public void AfficherDetailVehicule()
        {
            foreach (var vehicule in _Vehicule)
            {
                vehicule.AfficherDetail();
            }
        }
        #endregion
    }
}
