﻿namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface IEmployee
    {
        double Salary { get; set; }

        Department Department { get; set; }

        string ToString();
    }
}
