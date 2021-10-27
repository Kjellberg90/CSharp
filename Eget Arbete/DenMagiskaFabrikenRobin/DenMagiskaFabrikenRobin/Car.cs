using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabrikenRobin
{
    class Car : Product
    {
        public List<Material> ritningCar = new List<Material>() { new Metal(), new Metal() };
        public Car() { ritning = ritningCar; }
    }
}
