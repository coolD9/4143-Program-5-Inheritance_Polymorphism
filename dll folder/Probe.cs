using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjectsLibrary
{
    public class Probe : SpaceObjects {
        private int x, y, z;

        public double Payload { get; set; }
        public int Samples { get; set; }

        public override string Name
        {
            get { return "Probe"; }
        }

        public override string ToString()
        {
            return $"{Name} at ({X}, {Y}, {Z}), Payload: {Payload}, Samples: {Samples}";
        }
    }
}

