using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructeur.Interface
{
    public interface IVehiculeElectrique
    {
        int CapaciteBatterie { get; set; }
        void Recharger();
    }
}
