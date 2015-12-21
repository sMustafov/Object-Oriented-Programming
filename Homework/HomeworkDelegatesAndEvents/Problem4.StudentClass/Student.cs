using System;

namespace Problem4.StudentClass
{
    public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs args);

    public class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name cannot be null");
                }
                PropertyChangedEventArgs args = new PropertyChangedEventArgs("Name", this.Name, value);
                this.PropertyChange(this, args);

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be negative");
                }
                PropertyChangedEventArgs args = new PropertyChangedEventArgs("Age", this.Age, value);
                this.PropertyChange(this, args);

                this.age = value;
            }
        }

        public void PropertyChange(object sender, PropertyChangedEventArgs args)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(sender, args);
            }
        }
    }
}