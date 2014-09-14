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
            buildings.Add(new Building(2, 6, 7));
            buildings.Add(new Building(3, 13, 9));
            buildings.Add(new Building(12, 7, 16));
            buildings.Add(new Building(14, 3, 25));
            buildings.Add(new Building(19, 18, 22));
            buildings.Add(new Building(23, 13, 29));
            buildings.Add(new Building(24, 4, 28));

            Processor p = new Processor();
            List<int> result = p.GetSkyline(buildings);
            Console.ReadLine();
        }
    }
}
