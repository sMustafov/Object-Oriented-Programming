using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.HTMLDispatcher
{
    class ElementBuilder
    {
        private string name;
        private Dictionary<string, string> Attribute { get; set; }
        private string content;

        public ElementBuilder(string name)
        {
            this.Attribute = new Dictionary<string, string>();
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty space");
                }
                this.name = value;
            }
        }

        private string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

        public void AddAttribute(string attribute, string value)
        {
            if (string.IsNullOrEmpty(attribute.Trim()))
            {
                throw new ArgumentException("Atribute can't be null or empty.");
            }

            if (string.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentException("Value can't be null or empty.");
            }

            this.Attribute.Add(attribute, value);
        }

        public void AddContent(string content)
        {
            this.content = content;
        }

        public static string operator *(ElementBuilder element, int times)
        {
            if (times <= 0)
            {
                throw new ArgumentOutOfRangeException("Times should be bigger than zero");
            }
            StringBuilder newElement = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                newElement.Append(element + "\n");
            }
            return newElement.ToString();
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append("<" + this.Name + " ");
            foreach (var atribute in this.Attribute)
            {
                toString.Append(atribute.Key + "=" + "\"" + atribute.Value + "\"");
            }

            toString.Append(">");
            if (this.Content != null)
            {
                toString.Append(this.Content);
            }

            toString.Append("</" + this.Name + ">");

            return toString.ToString();
        }
    }
}
