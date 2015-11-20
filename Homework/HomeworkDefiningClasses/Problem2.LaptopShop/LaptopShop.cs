using System;

namespace Problem2.LaptopShop
{
    class Battery
    {
        private double life;

        public Battery(double life)
        {
            this.life = life;
        }
        public double Life
        {
            get { return life; }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Battery Life");
                }
                else
                {
                    this.life = value;
                }
            }
        }

        public override string ToString()
        {
            return life.ToString();
        }
    }


    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private byte ram;
        private string graphicsCard;
        private int hdd;
        private string screen;
        private string battery;
        private double price;
        private Battery batteryLife;

        public Laptop(string model,string manufacturer,string processor,byte ram,string graphicsCard, 
            int hdd, string screen,string battery, Battery batteryLife,double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.processor = processor;
            this.ram = ram;
            this.graphicsCard = graphicsCard;
            this.hdd = hdd;
            this.screen = screen;
            this.battery = battery;
            this.batteryLife = batteryLife;
            this.price = price;
        }

        public Laptop(string model, double price):this (model,null,null,0,null,0,null,null, null,price)
        {
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Model");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Manufacturer");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public string Processor
        {
            get { return processor; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Processor");
                }
                else
                {
                    this.processor = value;
                }
            }
        }

        public byte RAM
        {
            get { return ram; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid RAM");
                }
                else
                {
                    this.ram = value;
                }
            }
        }
        public string GraphicsCard
        {
            get { return graphicsCard; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Graphics Card");
                }
                else
                {
                    this.graphicsCard = value;
                }
            }
        }

        public string Screen
        {
            get { return screen; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Screen");
                }
                else
                {
                    this.screen = value;
                }
            }
        }

        public string Battery
        {
            get { return battery; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Battery");
                }
                else
                {
                    this.battery = value;
                }
            }
        }

        public int HDD
        {
            get { return hdd; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Model");
                }
                else
                {
                    this.hdd = value;
                }
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Price");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public override string ToString()
        {
            String info = "Laptop Description: " + "\n";
            info = info  + "Model: " + Model + "\n";
            if (Manufacturer != null)
            {
                info = info + "Manufacturer: " + Manufacturer + "\n";
            }
            if (Processor != null)
            {
                info = info + "Processor: " + Processor + "\n";
            }
            if (RAM != 0)
            {
                info = info + "RAM: " + RAM + "GB \n";
            }
            if (GraphicsCard != null)
            {
                info = info + "Graphics Card: " + GraphicsCard + "\n";
            }
            if (HDD != 0)
            {
                info = info + "HDD: " + HDD + "GB SSD\n";
            }
            if (Screen != null)
            {
                info = info + "Screen: " + Screen + "\n";
            }
            if (Battery != null)
            {
                info = info + "Battery: " + Battery + "\n";
            }
            if (batteryLife != null)
            {
                info = info + "Battery Life: " + batteryLife.ToString() + " hours \n";
            }
            String p = String.Format("Price {0:0.00} lv", Price);
            info = info + p + "\n";
            return info;
        }
    }


    class LaptopShop
    {
        static void Main(string[] args)
        {
            Laptop l1 = new Laptop("HP 250 G",699);
            Console.WriteLine(l1.ToString());
            Battery life = new Battery(4.5);
            Laptop l2 = new Laptop("Lenovo Yoga 2 Pro", "Lenovo",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                8, "Intel HD Graphics 4400", 128, "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                "Li-Ion, 4-cells, 2550 mAh", life, 2259);
            Console.WriteLine(l2.ToString());
        }
    }
}
