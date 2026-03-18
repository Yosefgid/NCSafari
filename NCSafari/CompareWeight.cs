using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class CompareWeight: IComparer<Animal>
    {
        public bool Descending = false;
        public CompareWeight(bool descending) { this.Descending = descending; }




    }
}
