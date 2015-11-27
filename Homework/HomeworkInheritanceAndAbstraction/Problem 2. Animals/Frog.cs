using System;

namespace Problem_2.Animals
{
    public class Frog : Animal,ISoundProducible
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Croak-Croak");
        }
    }
}
