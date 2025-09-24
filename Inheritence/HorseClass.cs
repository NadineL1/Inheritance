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
            Color = "Tan";
            Food = "hay";
            hasWings = false;
            SkinType = "Fur";
            Sound = "neighs";
            Pattern = "plain";
            Movement = "gallops";
        }
    }
}
