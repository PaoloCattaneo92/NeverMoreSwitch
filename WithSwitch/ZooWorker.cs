using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverMoreSwitch.WithSwitch
{
    public class ZooWorker
    {
        public int FishMeals { get; set; } = 10;
        public int CatMeals { get; set; } = 5;
        public int BirdMeals { get; set; } = 7;

        public void Feed(Animal animal)
        {
            Console.WriteLine($"Feeding a {animal.Name}");
            switch (animal.Type)
            {
                case AnimalType.FISH:
                    FishMeals--;
                    break;
                case AnimalType.CAT:
                    CatMeals--;
                    break;
                case AnimalType.BIRD:
                    BirdMeals--;
                    break;
            }
        }
    }
}
