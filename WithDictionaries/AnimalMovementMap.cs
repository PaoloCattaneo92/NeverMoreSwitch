using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverMoreSwitch.WithDictionaries
{
    public static class AnimalMovementMap
    {
        public static Dictionary<AnimalType, string> GetMove = new Dictionary<AnimalType, string>()
        {
            { AnimalType.FISH, "swimming"},
            { AnimalType.CAT, "walking"},
            { AnimalType.BIRD, "flying"}
        };
    }
}
