using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjectsLibrary
{
    public class Earthling : SpaceObjects {
        private int x, y, z;
        private int arms = 2;
        public Earthling() { }
        // public Earthling()

        



        public override string Name {
            get { return "Earthling";  }
        }
    }
}
