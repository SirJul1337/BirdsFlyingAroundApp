using BirdsFlyingAroundApp;
using BirdsFlyingAroundApp.Interface;
using System.Reflection.Emit;

public class Program
{
    public static void Main()
    {
        List<Bird> birds = new List<Bird> {new BlackBird(),new Ostrich(),new Pinguin(), new CanaryBird() };
        Random rnd = new Random();
        foreach (var bird in birds)
        {
            Console.WriteLine(bird.Draw());
            Console.WriteLine(bird.SetLocation(rnd.NextDouble(), rnd.NextDouble())); 
            if(bird is IFly fb)
            {
                Console.WriteLine(fb.SetAltitude(rnd.NextDouble())); 
            }
            if(bird is ISwim sb)
            {
                sb.Swim();
            }
            if(bird is IRun rb)
            {
                rb.Run();
            }
            Console.WriteLine();

        }
    }
}