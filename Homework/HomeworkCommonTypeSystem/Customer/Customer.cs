using System;
using System.Collections;
using System.Collections.Generic;

namespace Customer 
{
    public class Customer : ICloneable, IComparable<Customer>
    {
        public Customer(string firstName, string middleName, string lastName, string id, string permanentAddress, string mobilePhone,
            IList<Payment> payments, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Payments = payments;
            this.CustomerType = customerType;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string ID { get; set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public IList<Payment> Payments { get; set; }

        public CustomerType CustomerType { get; set; }

        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }

        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !(Customer.Equals(customer1, customer2));
        }

        public override bool Equals(object obj)
        {
            var item = obj as Customer;

            if (item == null)
            {
                return false;
            }

            return this.CustomerType.Equals(item.CustomerType);
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode();
        }

        public object Clone()
        {
            Customer clonedCustomer = new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.ID,
                this.PermanentAddress,
                this.MobilePhone,
                this.Payments,
                this.CustomerType);

            return clonedCustomer;
        }

        public int CompareTo(Customer otherCustomer)
        {
            string fullName = string.Format("{0} {1}", this.FirstName, this.MiddleName,this.LastName);
            string otherCustomerFullName = string.Format("{0} {1} {2}", otherCustomer.FirstName,otherCustomer.MiddleName,
                otherCustomer.LastName);

            if (fullName == otherCustomerFullName)
            {
                return this.ID.CompareTo(otherCustomer.ID);
            }

            return fullName.CompareTo(otherCustomerFullName);
        }

        public override string ToString()
        {
            return
                String.Format(
                    "First Name: {0}\nMiddle Name: {1}\nLast Name: {2}\nID: {3}\nPermanent Address: {4}\nMobile Phone: {5}\n" +
                    "Payments: {6}\nCustomer Type: {7}", this.FirstName, this.MiddleName, this.LastName, this.ID,
                    this.PermanentAddress, this.MobilePhone, this.Payments, this.CustomerType);
        }
    }
}