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

            int maxY = buildings.Max(y => y.Height);
            int maxX = buildings.Max(x => x.Right);
            bool[,] grid = new bool[maxX + 1, maxY + 2];
            foreach (var building in buildings) {
                for (int x = building.Left; x <= building.Right; x++) {
                    for (int y = 0; y <= building.Height; y++) {
                        grid[x, y] = true;
                    }
                }
            }

            int currX = 0;
            int currY = 0;
            while ((currX <= maxX) && (!grid[currX, currY])) currX++;

            while ((currX < maxX) || (currY > 0)) {
                coordinates.Add(currX);

                if (grid[currX, currY + 1]) { //go up
                    while (grid[currX, currY + 1]) currY++;
                } else { // go down
                    while ((currY > 0) && (grid[currX, currY - 1])) currY--;
                }
                coordinates.Add(currY);

                //go right
                while ((currX < maxX) && (grid[currX + 1, currY])) currX++;
            }

            return coordinates;
        }
    }
}
