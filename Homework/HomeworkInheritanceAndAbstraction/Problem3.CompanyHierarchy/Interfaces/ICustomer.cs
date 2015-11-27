namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface ICustomer
    {
        double PurchasesAmount { get; set; }

        void AddPurchasePrice(double purchasePrice);

        string ToString();
    }
}
