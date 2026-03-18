using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class HuntingGround: SafariEnvironment<IHunt>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                if (animal is IHunt)
                {
                    string animalType = animal.GetType().Name;
                    //Console.WriteLine(animalType);
                    if (animal is IFly) //adding nested loop
                    {
                        Console.WriteLine(animalType + " is hunting in the skies above the hunting ground");
                    } else if (animal is ISwim)
                    {
                        Console.WriteLine(animalType + " is hunting in the waters of the hunting ground");
                    } else
                    {
                        Console.WriteLine(animalType + " is hunting on land in the hunting ground");
                    }


                }
            }

        }
    }
}
