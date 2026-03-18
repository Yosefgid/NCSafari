using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class Bat : Mammal, IHunt, IFly
    {
        public Bat(float weight) : base(weight) { }
        public void Hunt() //Implementing Interface method
        {
            Console.WriteLine("Bat is hunting!");
        }
        public void Fly() //Implementing Interface method
        {
            Console.WriteLine("Bat is flying!");
        }
        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " screetch!");
        }
    }
}
