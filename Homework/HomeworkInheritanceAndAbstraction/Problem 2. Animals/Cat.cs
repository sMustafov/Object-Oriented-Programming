using System;

namespace Problem_2.Animals
{
    public class Cat : Animal, ISoundProducible
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow...");
        }
    }
}
