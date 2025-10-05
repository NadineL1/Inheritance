namespace Inheritence
{
    internal class Program
    {
        static void Main()
        {
            Animal animal1 = new();
            animal1.MakeSound();
            animal1.ProCreate();
            animal1.Eat();
            Cat cat1 = new();
            cat1.Hunt();
            cat1.ProCreate();
            cat1.MakeSound();

            Zebra zebra = new();
            zebra.ProCreate();
            zebra.MakeSound();

            Console.WriteLine($"Total animals in the zoo: {Animal.AnimalCount}");
    
        }
    }
}
