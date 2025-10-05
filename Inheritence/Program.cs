namespace Inheritence
{
    internal class Program
    {
        static void Main()
        {
            Animal animal1 = new();
            Animal animal2 = new();
            Animal animal3 = new();

            Cat cat1 = new();
            cat1.Hunt();
            cat1.ProCreate();

            Zebra zebra = new();
            zebra.ProCreate();

            Console.WriteLine($"Total animals in the zoo: {Animal.AnimalCount}");
    
        }
    }
}
