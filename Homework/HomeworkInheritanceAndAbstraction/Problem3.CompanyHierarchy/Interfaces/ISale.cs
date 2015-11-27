using System;

namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface ISale
    {
        string Name { get; set; }

        DateTime Date { get; set; }

        double Price { get; set; }
    }
}
