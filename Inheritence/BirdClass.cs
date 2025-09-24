using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class BirdClass : Animal
    {
        public BirdClass()
        {
            Color = "yellow";
            Food = "seeds";
            hasWings = true;
            SkinType = "feathers";
            Sound = "chirps";
            Pattern = "varied";
            Movement = "flies";
        }

        public void LayEgg()
        {
            Console.WriteLine("The bird has laid an egg!");
        }

    }
    internal class Chicken : BirdClass
    {
        public Chicken()
        {
            Color = "white";
            Food = "grains";
            Movement = "walks and flaps its wings";
        }
        public void Peck()
        {
            Console.WriteLine("The chicken pecks the ground.");
        }
    }
    internal class Flamingo : BirdClass
    {
        public Flamingo()
        {
            Color = "pink";
            Food = "crustasceans";          
        }
        public void StandOnOneLeg()
        {
            Console.WriteLine("The flamingo is standing on one leg.");
        }

    }
}
