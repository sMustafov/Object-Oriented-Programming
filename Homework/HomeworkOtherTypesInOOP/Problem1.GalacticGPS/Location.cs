using System;

namespace Problem1.GalacticGPS
{
    public struct Location
    {
        public Planet Planet { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}", Latitude, Longitude, Planet);
        }
    }
}