namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new();
            Console.WriteLine($"This animal has skintype: {animal1.SkinType} is color: {animal1.Color} and has {animal1.Food} as it's favourite food.");

            animal1.Eat();
            animal1.Speak();
            animal1.Move();

            Cat cat1 = new Cat();
            Console.WriteLine($"This animal has skintype: {cat1.SkinType} is color: {cat1.Color} and has {cat1.Food} as it's favourite food.");
            cat1.Eat();
            cat1.Speak();
            cat1.Move();

            BirdClass bird1 = new BirdClass();
            Console.WriteLine($"This animal has skintype: {bird1.SkinType} is color: {bird1.Color} and has {bird1.Food} as it's favourite food.");
            bird1.Eat();
            bird1.Speak();
            bird1.Move();

            Horse horse1 = new Horse();
            Console.WriteLine($"This animal has skintype: {horse1.SkinType} is color: {horse1.Color} and has {horse1.Food} as it's favourite food.");
            horse1.Eat();
            horse1.Speak();
            horse1.Move();

        }
    }
}
