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



        public override string Name {
            get { return "Earthling";  }
        }
    }
}

