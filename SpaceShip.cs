using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjectsLibrary
{
    public class SpaceShip : SpaceObjects {
        private int x, y, z;
        public SpaceShip() { }

        public override string Name
        {
            get { return "SpaceShip"; }
        }
    }
}
