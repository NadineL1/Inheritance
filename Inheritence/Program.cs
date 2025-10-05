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

            Human human1 = new("Andreas", 30);
            human1.MakeSound();
            human1.HumanInfo();

            Console.WriteLine($"Total animals in the zoo: {Animal.AnimalCount}");
    
        }
    }
}
