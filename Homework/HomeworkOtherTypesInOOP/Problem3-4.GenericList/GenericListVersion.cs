using System;

namespace Problem3_4.GenericList
{
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Interface |
        AttributeTargets.Enum |
        AttributeTargets.Method)]

    class GenericListVersion : Attribute
    {
        private int minor;
        private int major;

        public GenericListVersion(int major, int minor)
        {
            this.Minor = minor;
            this.Major = major;
        }

        public int Minor
        {
            get { return minor; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The minor cannot be negative");
                }
                this.minor = value;
            }
        }

        public int Major
        {
            get { return this.major; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The major cannot be negative");
                }
                this.major = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Version {0}.{1}", Major, Minor.ToString("X2"));
        }
    }
}
