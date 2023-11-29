using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage.models
{
    public class Garage
    {
        private Dictionary<int, Voiture> _voitures = new Dictionary<int, Voiture>();

        public Voiture this[int index]
        {
            get
            {
                // Logique pour récupérer la voiture à l'index spécifié
                return _voitures[index];
            }
        }

        public void AjouterVoiture(int index, Voiture voiture)
        {
            _voitures.Add(index, voiture);
        }
    }
}
