using System;

namespace Problem1.Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }

        public Person(string name, int age) : this (name,age,null)
        {
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Name");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 && value > 100)
                {
                    throw new ArgumentOutOfRangeException("Invalid Age");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value == "" || value == null && value.Contains("@"))
                {
                    throw new ArgumentException("Invalid Email");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public override string ToString()
        {
            string info = "Name: " + Name + "\n" + "Age: " + Age;
            if (!String.IsNullOrEmpty(Email))
            {
                info = info + "\n" + "Email: " + Email;
            }
            return info;
        }
    }


    class Persons
    {
        static void Main()
        {
            Person p1 = new Person("Gosho", 35);
            Console.WriteLine(p1.ToString());
            Person p2 = new Person("Pesho", 42, "peshoto@gmail.com");
            Console.WriteLine(p2.ToString());
        }
    }
}
