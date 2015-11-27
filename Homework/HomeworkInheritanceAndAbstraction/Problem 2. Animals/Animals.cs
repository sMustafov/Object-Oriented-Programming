using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2.Animals
{
    class Animals
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog("Sharo",3,"Male"),
                new Dog("Misho",2,"Male"),
                new Dog("Pesho",5,"Male"),
                new Frog("Croki",6,"Female"),
                new Frog("Skoklio",5,"Male"),
                new Frog("Gosho",3,"Male"),
                new Cat("Petq",7,"Female"),
                new Cat("Maria",8,"Female"),
                new Cat("Alex",13,"Female"),
                new Tomcat("Tomi",2),
                new Tomcat("Roki",3),
                new Tomcat("Silvester",1),
                new Kitten("Kitty",4),
                new Kitten("Twitty",1),
                new Kitten("Mily", 2)
            };
            foreach (var kind in animals.GroupBy(x => x.GetType()))
            {
                double averageAge = kind.Select(x => x.Age).Average();
                Console.WriteLine("Animal - {0} : AverageAge: {1:0.00}", kind.Key.Name, averageAge);
            }
        }
    }
}
