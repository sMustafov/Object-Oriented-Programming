using System;
using System.Collections;

namespace StringDisperser
{
    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        private string[] elements;

        public StringDisperser(params string[] elemetns)
        {
            this.Elements = elemetns;
        }

        public string[] Elements
        {
            get
            {
                string[] elementsCopy = new string[this.elements.Length];
                Array.Copy(this.elements, elementsCopy, this.elements.Length);
                return elementsCopy;
            }
            private set { this.elements = value; }
        }

        public static bool operator ==(StringDisperser stringDisperser1, StringDisperser stringDisperser2)
        {
            return StringDisperser.Equals(stringDisperser1, stringDisperser2);
        }

        public static bool operator !=(StringDisperser stringDisperser1, StringDisperser stringDisperser2)
        {
            return !(StringDisperser.Equals(stringDisperser1, stringDisperser2));
        }

        public override bool Equals(object obj)
        {
            var item = obj as StringDisperser;

            if (item == null)
            {
                return false;
            }

            return this.Elements.Equals(item.Elements);
        }

        public override int GetHashCode()
        {
            return Elements.GetHashCode();
        }

        public object Clone()
        {
            string[] elementsCopy = new string[this.Elements.Length];
            Array.Copy(this.Elements, elementsCopy, this.Elements.Length);
            return new StringDisperser(elementsCopy);
        }

        public int CompareTo(StringDisperser otherStringDisperser)
        {
            return this.ToString().CompareTo(otherStringDisperser.ToString());
        }

        public IEnumerator GetEnumerator()
        {
            string disperserAsString = this.ToString();

            for (var i = 0; i < disperserAsString.Length; i++)
            {
                yield return disperserAsString[i];
            }
        }

        public override string ToString()
        {
            return string.Join(" ", this.Elements);
        }
    }
}