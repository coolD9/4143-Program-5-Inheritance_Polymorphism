using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjectsLibrary
{
    public class Star : SpaceObjects {
        private int x, y, z;

        public Star() { }
        public Star(int Radius)
        {
            x = 0;
            y = 0;
            z = 0;

        }
        public override string Name
        {
            get { return "Star"; }
        }
    }
}
