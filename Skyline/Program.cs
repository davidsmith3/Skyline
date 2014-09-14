using Skyline.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Skyline {
    class Program {
        static void Main(string[] args) {
            List<Building> buildings = new List<Building>();
            int bldgs = 100000;
            Random r = new Random();
            for (int i = 0; i < bldgs; i++) {
                int left = r.Next(0, bldgs - 1);
                int height = r.Next(0, bldgs);
                int right = r.Next(left, bldgs);
                buildings.Add(new Building(left, height, right));
            }
            Console.WriteLine("Buildings generated:  {0}", bldgs);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Processor p = new Processor();
            List<int> result = p.GetSkyline(buildings);
            sw.Stop();
            Console.WriteLine("Skyline evaluated:  {0}", sw.Elapsed);
            Console.ReadLine();
        }
    }
}
