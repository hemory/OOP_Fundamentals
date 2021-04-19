using System.Collections.Generic;
using ACM.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAddress { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        public override string ToString()
        {
            return FullName;
        }

        public Customer() : this(0) //constructor chaining
        {
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }


        //Methods
        public override bool Validate()
        {
            bool isValid = !string.IsNullOrWhiteSpace(LastName);

            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }

        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
    }
}