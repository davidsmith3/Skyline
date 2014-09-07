using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyline.Domain {
    public class Processor {

        public List<Coordinate> GetSkyline(List<Building> buildings) {
            List<Coordinate> coordinates = new List<Coordinate>();
            var sortedBuildings = buildings.OrderBy(l => l.Left).ThenByDescending(h => h.Height);


            return coordinates;
        }
    }
}
