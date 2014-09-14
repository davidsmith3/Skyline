using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyline.Domain {
    public class Processor {

        public List<int> GetSkyline(List<Building> buildings) {
            List<int> coordinates = new List<int>();
            if (buildings.Count == 0) return coordinates;
            int maxX = buildings.Max(x => x.Right);

            Dictionary<int, int> maxY = new Dictionary<int, int>();
            for (int x = 0; x <= maxX; x++) {
                maxY.Add(x, 0);
            }

            foreach (var building in buildings) {
                for (int x = building.Left; x < building.Right; x++) {
                    if (building.Height > maxY[x]) {
                        maxY[x] = building.Height;
                    }
                }
            }

            int currY = 0;
            for (int currX = 0; currX <= maxX; currX++) {
                if (maxY[currX] != currY) {
                    currY = maxY[currX];
                    coordinates.Add(currX);
                    coordinates.Add(currY);
                }                
            }
            return coordinates;
        }
    }
}
