using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class Penguin : Bird , IMove
    {
        public Penguin(float weight) : base(weight) { } //constructor
        public void Move() //Implementing Interface method
        {
            Console.WriteLine("Penguin is moving!");
        }
        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " quack!");
        }
    }
}
