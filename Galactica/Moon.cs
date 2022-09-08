namespace Galactica
{
    internal sealed class Moon : Planet
    {
        private Planet orbiting;

        public Planet Orbiting
        {
            get { return orbiting; }
            set { orbiting = value; }
        }

        public void Distance(double x1, double y1, double x2, double y2)
        {
            

            double finalDistance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y2, 2)));

            Console.WriteLine(finalDistance);

        }
        public Moon(string name)
        {
            Random rand = new();
            Position pos = new();

            this.name = name;
            revolutionPeriod = rand.Next(1, 69);
            rotationPeriod = rand.Next(3, 69);
            diameter = rand.Next(300000, 6900000);
            StarType = (StarType)rand.Next(0, 4);
            pos.PosX = rand.Next(69, 420000);
            pos.PosY = rand.Next(69, 420000);


        }
    }
}
