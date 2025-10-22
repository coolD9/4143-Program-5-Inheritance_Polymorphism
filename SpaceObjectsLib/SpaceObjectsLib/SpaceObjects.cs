namespace SpaceObjectsLib
{
    public abstract class SpaceObject
    {
        public required string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }


        public abstract string GetInfo();
    }
    public abstract class Being : SpaceObject
    {
        public int Arms { get; set; }

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
    }

    public class Star : SpaceObject
    {
        private int Radius, Temp;
        private string Classification;

        public Star(string name, int radius, int temp, double x, double y, double z)
        {
            this.Name = name;
            this.Radius = radius;
            this.Temp = temp;
            this.X = x;
            this.Y = y;
            this.Z = z;

            DetermineClassification();
        }

        private void DetermineClassification()
        {
            if (this.Radius < 300000 && this.Temp < 4000)
                this.Classification = "Red Dwarf";
            else if (this.Radius < 700000 && this.Temp < 6000)
                this.Classification = "Main Sequence (Sun-like)";
            else if (this.Radius < 1000000 && this.Temp >= 6000 && this.Temp < 10000)
                this.Classification = "Blue-White Main Sequence";
            else if (this.Radius >= 1000000 && this.Temp < 5000000)
                this.Classification = "Giant";
            else if (this.Radius >= 5000000)
                this.Classification = "Supergiant";
            else
                this.Classification = "Unknown Type";
        }

        public override string GetInfo() => $"Star {Name}, radius of {Radius}, Location: {X}, {Y}, {Z}";
    }

    public class Planet : SpaceObject
    {
        private int Radius;
        private int Moons;

        public Planet(string name, int radius, int moons, double x, double y, double z)
        {
            this.Name = name;
            this.Moons = moons;
            this.Radius = radius;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        private string Rotation()
        {
            return "The planet spins on its axis.";
        }

        public override string GetInfo() => $"Planet {Name}, radius of {Radius}, {Moons} moons, Location: {X}, {Y}, {Z}";
    }

    public class SpaceShip : SpaceObject
    {
        private int Payload, Speed;

        public SpaceShip(string name, int payload, int speed, double x, double y, double z)
        {
            this.Name = name;
            this.Payload = payload;
            this.Speed = speed;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public void AddPayload()
        {
            int additionalPayload = this.Payload / 10;

            this.Payload += additionalPayload;
        }

        public double StarTravel(int destX, int destY, int destZ)
        {
            double distance = Math.Sqrt(Math.Pow(destX - X, 2) + Math.Pow(destY - Y, 2) + Math.Pow(destZ - Z, 2));

            return (distance * 3.262) / this.Speed;
        }
        public override string GetInfo() => $"Spaceship {Name}, payload of {Payload} tons, speed of {Speed} ly/hr, Location: {X}, {Y}, {Z}";
    }

    public class Probe : SpaceObject
    {
        private int Samples;

        public Probe(string name, int samples, double x, double y, double z)
        {
            this.Name = name;
            this.Samples = samples;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public void TakeSample()
        {
            this.Samples++;
        }

        public override string GetInfo() => $"Probe {Name}, number of samples: {Samples}, Location: {X}, {Y}, {Z}";
    }

    public class Earthling : Being
    {
        private int Height;
        public Earthling(string name, int height, double x, double y, double z)
        {
            this.Name = name;
            this.Height = height;
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Arms = 2;
        }

        public override string GetInfo() => $"Earthling {Name}, {Arms} arms, {Height} feet tall, Location: {X}, {Y}, {Z}";
    }

    public class Alien : Being
    {
        private int Height;

        public Alien(string name, int arms, int height, double x, double y, double z)
        {
            this.Name = name;
            this.Arms = arms;
            this.Height = height;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string GetInfo() => $"Alien {Name}, {Arms} arms, {Height} feet tall, Location: {X}, {Y}, {Z}";
    }
}
