using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme.models
{
    public class Garage
    {
        private Dictionary<int, Vehicule> _voitures = new Dictionary<int, Vehicule>();

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
        }
    }
}
