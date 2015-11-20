using System;
using System.Collections.Generic;

namespace Problem3.PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private double price;


        public Component(string name, double price, string details)
        {
            this.name = name;
            this.details = details;
            this.price = price;
        }
        public Component(string name, double price) : this (name, price,null)
        {
        }

        public string Name
        {
            get { return name; }
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
        public string Details
        {
            get { return details; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Details");
                }
                else
                {
                    this.details = value;
                }
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Price");
                }
                else
                {
                    this.price = value;
                }
            }
        }
    }


    class Computer
    {
        private string name;
        private List<Component> components = new List<Component>(); 
        private double price;
        private double PRICE;

        public Computer(string name, List<Component> components, double price)
        {
            this.name = name;
            this.Components = components;
            this.price = price;
            foreach (var c in Components)
            {
                PRICE += c.Price;
            }
        }
        public string Name
        {
            get { return name; }
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
        public List<Component> Components
        {
            get { return components; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid Input");
                }
                else
                {
                    this.components = value;
                }
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Price");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public void PrintInfo()
        {
            string info = "PC Info:\nName: " + Name + "\nPrice:" + Price;
            info += "\n\nComponents Details:\n";
            foreach (Component component in Components)
            {
                info += "\n" + component.Name + " -> " + String.Format("{0:C}", component.Price);
            }
            Console.WriteLine(info);
        }
    }


    class PC_Catalog
    {
        static void Main()
        {
            Component motherboard = new Component("Lenovo A456", 1200.00);
            Component processor = new Component("Intel i7", 1600);
            Component graphicsCard = new Component("AMD Radeon", 1400);
            Component RAM = new Component("64 GB ", 680.50);
            Component HDD = new Component("500 GB ", 700.55);
            Computer p1 = new Computer("Lenovo",new List<Component>(){motherboard,processor,graphicsCard,RAM,HDD}, 1299.99);
            p1.PrintInfo();

        }
    }
}
