using ACM.BL;
using NUnit.Framework;

namespace ACM.UnitTests1
{
    [TestFixture]
    public class CustomerTest
    {
        [Test]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Hemory";
            customer.LastName = "Phifer";
            
            //Act
            string fullName = customer.FullName;
            
            //Assert
            Assert.AreEqual("Phifer, Hemory", fullName);
        }
        
        [Test]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Phifer";
            
            //Act
            string fullName = customer.FullName;
            
            //Assert
            Assert.AreEqual("Phifer", fullName);
        }
        
        [Test]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Hemory";
            
            //Act
            string fullName = customer.FullName;
            
            //Assert
            Assert.AreEqual("Hemory", fullName);
        }

        [Test]
        public void StaticTest()
        {
            //Arrange
            Customer c1 = new Customer();
            Customer.InstanceCount += 1;
            
            Customer c2 = new Customer();
            Customer.InstanceCount += 1;
            
            Customer c3 = new Customer();
            Customer.InstanceCount += 1;
            
            //Act

            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }


        [Test]
        public void ValidateValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "john@yahoo.com";
            
            //Act
            bool actual = customer.Validate();

            //Assert
            Assert.AreEqual(true, actual);
        }
        
        [Test]
        public void ValidateLastNameFalse()
        {
            //Arrange
            Customer customer = new Customer();
            customer.EmailAddress = "john@yahoo.com";
            
            //Act
            bool actual = customer.Validate();

            //Assert
            Assert.AreEqual(false, actual);
        }
        
        [Test]
        public void ValidateEmailFalse()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            
            //Act
            bool actual = customer.Validate();

            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}