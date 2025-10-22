using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjectsLibrary
{
    public class Martian : SpaceObjects
    {
        private int x, y, z;

        public Martian(double height, int arms, int x, int y, int z)
        : base(x, y, z) {
            Height = height;
            Arms = arms;
        }

        public void move(int dx, int dy, int dz) {
            
        }


        public int Arms { get; set; }
        public double Height { get; set; }

        public override string Name
        {
            get { return "Martian"; }
        }
    }
}

