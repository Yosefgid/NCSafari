using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    internal class Goose : Bird, IFly, ISwim
    {
        public Goose(float weight) : base(weight) { }
        public void Hunt() //Implementing Interface method
        {
            Console.WriteLine("Goose is hunting!");
        }
        public void Swim() //Implementing Interface method
        {
            Console.WriteLine("Goose is swimming!");
        }
        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " goose noises!");
        }
    }
}
