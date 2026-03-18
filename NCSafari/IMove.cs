using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    [Obsolete("IMove is now obsolete, please use IFly / ISwim / IHunt", true)] // Using true as we want this to "throw an error if this interface is used"
    public interface IMove //Use obsolete when you plan to gradually migrate away from the obsolete feature.
    {
        void Move();
    }
    // If we want to declare all the interfaces in one file it's fine. In this case, we did one file(.cs) for each Interface. Best practice?!
    /*public interface IFly
    {
        void Fly();
    }*/
}
