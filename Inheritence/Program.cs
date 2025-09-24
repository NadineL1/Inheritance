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

            

        }
    }
}
