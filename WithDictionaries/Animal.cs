using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverMoreSwitch.WithDictionaries
{
    public class Animal
    {
        public AnimalType Type { get; set; }
        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine($"A {Name} is {AnimalMovementMap.GetMove[Type]}");
        }
    }
}
