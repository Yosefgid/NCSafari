using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class Penguin : Bird , IHunt, ISwim
    {
        public Penguin(float weight) : base(weight) { } //constructor
        public void Hunt() //Implementing Interface method
        {
            Console.WriteLine("Penguin is hunting!");
        }
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming!");
        }
        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " quack!");
        }
    }
}
