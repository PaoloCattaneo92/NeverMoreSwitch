using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverMoreSwitch.WithPolymorphism
{
    public class ZooWorker
    {
        public int FishMeals { get; set; } = 10;
        public int CatMeals { get; set; } = 5;
        public int BirdMeals { get; set; } = 7;

        private void FeedingWhat(Animal animal)
        {
            Console.WriteLine($"Feeding a {animal.Name}");
        }

        public void Feed(Fish animal)
        {
            FeedingWhat(animal);
            FishMeals--;
        }

        public void Feed(Cat animal)
        {
            FeedingWhat(animal);
            CatMeals--;
        }

        public void Feed(Bird animal)
        {
            FeedingWhat(animal);
            BirdMeals--;
        }


    }
}
