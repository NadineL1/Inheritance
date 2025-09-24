using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Horse : Animal
    {
        public Horse()
        {
            Color = "tan";
            Food = "hay";
            hasWings = false;
            SkinType = "fur";
            Sound = "neighs";
            Pattern = "plain";
            Movement = "gallops";
        }
    }
}
