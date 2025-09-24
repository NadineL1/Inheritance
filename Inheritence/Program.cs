namespace Inheritence
{
    internal class Program
    {
        static void Main()
        {
            Animal animal1 = new();

            Cat cat1 = new();
            cat1.Hunt();
            
            Console.WriteLine($"Total animals in the zoo: {Animal.AnimalCount}");


            // foreach (Animal animal in animal) make a loop to handle each created object animal 
    
        }
    }
}
