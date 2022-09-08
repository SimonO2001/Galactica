using Galactica;

namespace Galactica
{

    public class lol
    {
        static void Main(string[] args)
        {
            Star star = new();
            //star.Pos = new() { PosX = 0, PosY = 0 };
            //Planet planet = new();
            

            Planet Mercury = new Planet("Mercury");
            Planet Venus = new Planet("Venus");
            Planet Earth = new Planet("Earth");
            Planet Mars = new Planet("Mars");

            Planet Jupiter = new Planet("Jupiter");
            Planet Saturn = new Planet("Saturn");
            Planet Uranus = new Planet("Uranus");
            Planet Neptune = new Planet("Neptune");

            Moon Luna = new Moon("Luna");
            Moon Titan = new Moon("Titan");
            Moon Phobos = new Moon("Phobos");
            Moon Europe = new Moon("Europe");

            Moon Deimos = new Moon("Deimos");
            Moon Ganymedes = new Moon("Ganymedes");
            Moon Io = new Moon("Io");
            Moon Mimas = new Moon("Mimas");

            Luna.Orbiting = Mercury;
            Titan.Orbiting = Venus;
            Phobos.Orbiting = Earth;
            Europe.Orbiting = Mars;
            Deimos.Orbiting = Jupiter;
            Ganymedes.Orbiting = Saturn;
            Io.Orbiting = Uranus;
            Mimas.Orbiting = Neptune;

            star.PlanetList.Add(Mercury);
            star.PlanetList.Add(Venus);
            star.PlanetList.Add(Earth);
            star.PlanetList.Add(Mars);
            star.PlanetList.Add(Jupiter);
            star.PlanetList.Add(Saturn);
            star.PlanetList.Add(Uranus);
            star.PlanetList.Add(Neptune);

            Mercury.MoonList.Add(Luna);
            Venus.MoonList.Add(Titan);
            Earth.MoonList.Add(Phobos);
            Mars.MoonList.Add(Europe);
            Jupiter.MoonList.Add(Deimos);
            Saturn.MoonList.Add(Ganymedes);
            Uranus.MoonList.Add(Io);
            Neptune.MoonList.Add(Mimas);

            foreach (Planet planet in star.PlanetList)
            {
                Console.WriteLine($"Name: {planet.name}\t\tType: {planet.PlanetType}\t\tDiameter: {planet.diameter}\n" +
                    $"Rotation: {planet.RotationPeriod}\t\tRevolution: {planet.RevolutionPeriod}\t\t Distance to sun: {planet.Distance(star.Pos.PosX, star.Pos.PosY)}");
                
                
                
                foreach (var Moon in planet.MoonList)
                {
                    Console.WriteLine($"Name: {Moon.Name}\t\tOrbiting planet: {Moon.Orbiting.Name}\t\t");
                }
            }

        }


    }


}

