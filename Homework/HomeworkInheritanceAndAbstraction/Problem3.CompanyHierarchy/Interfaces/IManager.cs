using System.Collections.Generic;

namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface IManager
    {
        ISet<Employee> Employees { get; set; }
         
        void AddEmployee(ISet<Employee> employees);

        string ToString();
    }
}
