using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjectsLibrary
{
    public class Probe : SpaceObjects {
        int x, y, z;

        public override string Name
        {
            get { return "Probe"; }
        }
    }
}
