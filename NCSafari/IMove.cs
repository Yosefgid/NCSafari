using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public interface IMove
    {
        void Move();
    }
    // If we want to declare all the interfaces in one file it's fine. In this case, we did one file(.cs) for each Interface. Best practice?!
    /*public interface IFly
    {
        void Fly();
    }*/
}
