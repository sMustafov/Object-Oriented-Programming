using System;

namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string Name { get; set; }

        DateTime StartDate { get; set; }

        string Details { get; set; }

        State State { get; set; }

        void CloseProject();
    }
}
