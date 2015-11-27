using System.Collections.Generic;

namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface IDeveloper
    {
        ISet<Project> Projects { get; set; }

        void AddProjects(ISet<Project> projects);

        string ToString();
    }
}
