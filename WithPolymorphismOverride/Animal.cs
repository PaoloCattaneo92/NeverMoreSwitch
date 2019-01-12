using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverMoreSwitch.WithPolymorphism
{
    //WARNING: put several classes in a single file is another bad habit
    //It's done here just to get the concept in a sight
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Move();
    }

    public class Fish : Animal
    {
        public override void Move()
        {
            Console.WriteLine($"A {Name} is swimming");
        }
    }

    public class Cat : Animal
    {
        public override void Move()
        {
            Console.WriteLine($"A {Name} is walking");
        }
    }

    public class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine($"A {Name} is flying");
        }
    }
}
