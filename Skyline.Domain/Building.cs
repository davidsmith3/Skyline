using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyline {
    public class Building {
        public int Left { get; private set; }
        public int Height { get; private set; }
        public int Right { get; private set; }

        public Building(int left, int height, int right) {
            this.Left = left;
            this.Height = height;
            this.Right = right;
        }
    }
}
