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

        public void Move()
        {
            Random rand = new Random();

            if (this.X == 0 || this.Y == 0 || this.Z == 0)
            {
                X += rand.Next(0, 2);
                Y += rand.Next(0, 2);
                Z += rand.Next(0, 2);
            }
            else
            {
                X += rand.Next(-1, 2);
                Y += rand.Next(-1, 2);
                Z += rand.Next(-1, 2);
            }
        }


        public int Arms { get; set; }
        public double Height { get; set; }

        public override string Name
        {
            get { return "Martian"; }
        }
    }
}


