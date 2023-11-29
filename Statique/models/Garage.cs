using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statique.models
{
    public class Garage
    {
        private Dictionary<int, Vehicule> _voitures = new Dictionary<int, Vehicule>();

        private static int _NombreVehicules;

        public static int NombreVehicules
        {
            get {  return _NombreVehicules;}
        }

        public Vehicule this[int index]
        {
            get
            {
                // Logique pour récupérer la voiture à l'index spécifié
                return _voitures[index];
            }
        }

        public void AjouterVoiture(int index, Vehicule voiture)
        {
            _voitures.Add(index, voiture);
            _NombreVehicules++;
        }
    }
}
