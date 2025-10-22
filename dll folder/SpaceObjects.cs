using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjectsLibrary
{
    public abstract class SpaceObjects {
        private int x, y, z;
        // public virtual double ht() { return 0; }
        // public virtual int radius() { return 0; }
            
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public void Move(int dx, int dy, int dz)
        {
            X += dx;
            Y += dy;
            Z += dz;
        }
        
        public abstract string Name { get; }

        
    }
}



