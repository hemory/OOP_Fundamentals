using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository ar = new AddressRepository();

        public CustomerRepository()
        {
            ar = new AddressRepository();
        }
        
        //temp code
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbit.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = ar.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }


        public bool Save(Customer customer)
        {
            return true;
        }
    }
}