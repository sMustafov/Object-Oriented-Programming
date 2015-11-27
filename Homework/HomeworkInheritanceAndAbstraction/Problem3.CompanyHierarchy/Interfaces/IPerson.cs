namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface IPerson
    {
        string ID { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string ToString();
    }
}
