using System.Collections.Generic;
using ACM.BL;
using NUnit.Framework;

namespace ACM.UnitTests1
{
    [TestFixture]
    public class CustomerRepositoryTest
    {
        [Test]
        public void RetrieveValidate()
        {
            //Arrange
            Customer c1 = new Customer(1);
            CustomerRepository cr = new CustomerRepository();

            //Act
            Customer actual = cr.Retrieve(c1.CustomerId);
            //Assert
            Assert.AreEqual("fbaggins@hobbit.me", actual.EmailAddress);
            Assert.AreEqual("Frodo", actual.FirstName);
            Assert.AreEqual("Baggins", actual.LastName);
        }

        [Test]
        public void RetrieveExistingWithAddress()
        {
            //Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbit.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot Row",
                        City = "Hobbiton",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Carpenter",
                        StreetLine2 = "Row",
                        City = "Flint",
                        Country = "USA",
                        PostalCode = "1443"
                    }
                }
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}