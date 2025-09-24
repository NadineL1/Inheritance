using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Cat : Animal
    {
        // constructor for catclass
        public Cat()
        {
            Color = "black";
            Food = "fish";
            hasWings = false;
            SkinType = "fur";
            Sound = "meows";
            Pattern = "plain";
            Movement = "climbs";
        }

    }
}
