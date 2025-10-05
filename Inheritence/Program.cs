namespace Inheritence
{
    internal class Program
    {
        static void Main()
        {
            Animal animal1 = new();
            animal1.MakeSound();

            BirdClass bird1 = new();
            bird1.MakeSound();
            bird1.Dance();

            Chicken chicken1 = new();
            chicken1.MakeSound();
            chicken1.LayEgg();
            chicken1.Peck();

            Flamingo flamingo = new();
            flamingo.MakeSound();
            flamingo.StandOnOneLeg();

            Owl owl1= new();
            owl1.MakeSound();
            owl1.Hunting();

            Cat cat1 = new();
            cat1.Hunt();
            cat1.ProCreate();
            cat1.MakeSound();

            Tiger tiger1 = new();
            tiger1.MakeSound();
            tiger1.Swim();

            Horse horse1 = new();
            horse1.MakeSound();
            horse1.Eat();

            Zebra zebra = new();
            zebra.ProCreate();
            zebra.MakeSound();

            Donkey donkey1 = new();
            donkey1.MakeSound();
            donkey1.Kick();

            
            Console.WriteLine($"Total animals in the zoo: {Animal.AnimalCount}");
    
        }
    }
}
