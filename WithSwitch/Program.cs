using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverMoreSwitch.WithSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal fish = new Animal()  { Name = "Fish", Type = AnimalType.FISH };
            Animal cat = new Animal()   { Name = "Cat", Type = AnimalType.CAT };
            Animal bird = new Animal()  { Name = "Bird", Type = AnimalType.BIRD };

            fish.Move();
            cat.Move();
            bird.Move();

            Console.WriteLine("\n");

            ZooWorker zooWorker = new ZooWorker();
            Console.WriteLine($"Fish meals are: {zooWorker.FishMeals}");
            zooWorker.Feed(fish);
            Console.WriteLine($"Fish meals are: {zooWorker.FishMeals}");

            Console.ReadLine();
        }
    }
}
