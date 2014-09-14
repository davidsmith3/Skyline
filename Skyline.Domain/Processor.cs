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

            Dictionary<int, int> maxHeights = new Dictionary<int, int>();
            for (int x = 0; x <= maxX + 1; x++) {
                maxHeights.Add(x, 0);
            }

            foreach (var building in buildings) {
                for (int x = building.Left; x < building.Right; x++) {
                    if (building.Height > maxHeights[x]) {
                        maxHeights[x] = building.Height;
                    }
                }
            }

            int currY = 0;
            for (int x = 0; x <= maxX + 1; x++) {
                if (maxHeights[x] != currY) {
                    currY = maxHeights[x];
                    coordinates.Add(x);
                    coordinates.Add(currY);
                }                
            }
            return coordinates;

            /*int maxY = buildings.Max(y => y.Height);
            int maxX = buildings.Max(x => x.Right);
            bool[,] grid = new bool[maxX + 2, maxY + 2];
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
            bool goUp = true;

            while ((currX < maxX) || (currY > 0)) {
                coordinates.Add(currX);

                if (goUp) {
                    while (grid[currX, currY + 1]) currY++;
                } else {
                    while ((currY > 0) && (!grid[currX + 1, currY]) && (grid[currX, currY - 1])) currY--;
                }
                coordinates.Add(currY);

                currX++;
                if (currY == 0) {
                    while ((currX <= maxX) && (!grid[currX, currY])) currX++;
                } else {
                    while ((currX <= maxX) && (!grid[currX, currY + 1]) && (grid[currX + 1, currY])) currX++;
                } 
                goUp = grid[currX, currY + 1];
            }

            return coordinates; */
        }
    }
}
