namespace Galactica
{
    internal class Star : SpaceObject
    {
        public Star()
        {
            Pos = new();
            Name = "Sun";
            Pos.PosX = 0;
            Pos.PosY = 0;

        }

        private int temperature;

        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

         


        public List<Planet> PlanetList { get; set; } = new();

        
    }

        


    
}
