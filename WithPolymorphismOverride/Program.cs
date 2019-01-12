using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverMoreSwitch.WithPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal fish = new Fish()  { Name = "Fish"};
            Animal cat = new Cat()   { Name = "Cat"};
            Animal bird = new Bird()  { Name = "Bird"};

            fish.Move();
            cat.Move();
            bird.Move();

            Console.WriteLine("\n");

            Fish realFish = new Fish() { Name = "Fish" };
            Cat realCat = new Cat() { Name = "Cat" };
            Bird realBird = new Bird() { Name = "Bird" };
            ZooWorker zooWorker = new ZooWorker();
            Console.WriteLine($"Fish meals are: {zooWorker.FishMeals}");
            zooWorker.Feed(realFish);
            Console.WriteLine($"Fish meals are: {zooWorker.FishMeals}");

            Console.ReadLine();
        }
    }
}
