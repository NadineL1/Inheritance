namespace Inheritence
{
    internal class Program
    {
        static void Main()
        {
            Animal animal1 = new();
            Console.WriteLine($"This animal has skintype: {animal1.SkinType} is color: {animal1.Color} and has {animal1.Food} as it's favourite food.");

            animal1.Eat();
            animal1.MakeSound();
            animal1.Move();

            Cat cat1 = new();
            Console.WriteLine($"This animal has skintype: {cat1.SkinType} is color: {cat1.Color} and has {cat1.Food} as it's favourite food.");
            cat1.Eat();
            cat1.MakeSound();
            cat1.Move();

            BirdClass bird1 = new();
            Console.WriteLine($"This animal has skintype: {bird1.SkinType} is color: {bird1.Color} and has {bird1.Food} as it's favourite food.");
            bird1.Eat();
            bird1.MakeSound();
            bird1.Move();
            bird1.LayEgg();

            Chicken chicken1 = new();
            chicken1.Peck();
            
            Flamingo flamingo = new();
            flamingo.StandOnOneLeg();



            Horse horse1 = new();
            Console.WriteLine($"This animal has skintype: {horse1.SkinType} is color: {horse1.Color} and has {horse1.Food} as it's favourite food.");
            horse1.Eat();
            horse1.MakeSound();
            horse1.Move();

            Flamingo flamingo1 = new();
            Console.WriteLine($"This animal has skintype: {flamingo1.SkinType} is color: {flamingo1.Color} and has {flamingo1.Food} as it's favourite food.");
            flamingo1.Eat();
            flamingo1.MakeSound();
            flamingo1.Move();

            // Created a new animal object pig 
            /*Animal pig = new();
            pig.Color = "pink";
            pig.Food = "corn";
            pig.Sound = "oinks";
            Console.WriteLine($"This animal has skintype: {pig.SkinType} is color: {pig.Color} and has {pig.Food} as it's favourite food.");
            pig.Eat();
            pig.MakeSound();*/
            Zebra zebra1 = new();
            zebra1.Eat();

            Console.WriteLine($"Total animals in the zoo: {Animal.AnimalCount}");


            // foreach (Animal animal in animal) make a loop to handle each created object animal 
    
        }
    }
}
