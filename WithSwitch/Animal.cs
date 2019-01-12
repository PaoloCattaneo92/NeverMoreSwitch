using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverMoreSwitch.WithSwitch
{
    public class Animal
    {
        public AnimalType Type { get; set; }
        public string Name { get; set; }

        public void Move()
        {
            switch (Type)
            {
                case AnimalType.FISH:
                    Console.WriteLine($"A {Name} is swimming");
                    break;
                case AnimalType.CAT:
                    Console.WriteLine($"A {Name} is walking");
                    break;
                case AnimalType.BIRD:
                    Console.WriteLine($"A {Name} is flying");
                    break;
            }
        }
    }
}
