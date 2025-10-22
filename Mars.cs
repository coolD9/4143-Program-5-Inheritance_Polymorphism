using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjectsLibrary
{
    public class Mars : SpaceObjects {
        private int x, y, z;
        private int radius;

        public Mars() { }

        public Mars (int xValue, int yValue, int zValue, int radiusValue) {
            Radius = radiusValue;
        }

        public int Radius
        {
            get { return radius;  }

            set { if (value >= 0)
                    radius = value; }

        }

        public override string Name
        {
            get { return "Mars"; }
        }

    }
}
