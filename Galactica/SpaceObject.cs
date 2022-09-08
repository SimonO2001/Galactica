namespace Galactica
{
    internal abstract class SpaceObject
    {



        public int iD;

        public int Id
        {
            get { return iD; }
            set { iD = value; }
        }

        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual Position? Pos { get; set; }

        public class Position
        { 
            public int PosX { get; set; }
            public int PosY { get; set; }

        }

        

        public override string ToString()
        {
            if (Pos != null)
                return ($"{Pos.PosX},{Pos.PosY}");
            else return String.Empty;
        }

      

    }

    public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }
    public enum PlanetType { Terrestial, Giant, Dwarf, GasGiant }

    
      

        

    
}
