using System;

namespace Problem_2.Animals
{
    public class Dog : Animal, ISoundProducible
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
            
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof-woof");
        }
    }
}
