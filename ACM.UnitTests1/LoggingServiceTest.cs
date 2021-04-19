using System.Collections.Generic;
using ACM.BL;
using ACM.Common;
using NUnit.Framework;

namespace ACM.UnitTests1
{
    [TestFixture]
    public class LoggingServiceTest
    {
        [Test]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins.hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden rake with Steel Head",
                CurrentPrice = 6m
            };
            changedItems.Add(product);

            //Act
           var actual = LoggingService.WriteToFile(changedItems);

            //Assert
            Assert.AreEqual("Baggins, Frodo Rake", actual);
            
        }
    }
}