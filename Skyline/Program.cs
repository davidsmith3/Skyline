using Skyline.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyline {
    class Program {
        static void Main(string[] args) {
            List<Building> buildings = new List<Building>();
            buildings.Add(new Building(1, 11, 5));

            Processor p = new Processor();
            List<int> result = p.GetSkyline(buildings);
        }
    }
}
