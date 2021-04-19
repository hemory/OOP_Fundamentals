using ACM.BL;
using NUnit.Framework;

namespace ACM.UnitTests1
{
    [TestFixture]
    public class OrderRepositoryTests
    {
        [Test]
        public void RetrieveValidate()
        {
            //Arrange
            Order o1 = new Order(1);
            OrderRepository or = new OrderRepository();

            //Act
            Order actual = or.Retrieve(o1.OrderId);
            //Assert
            Assert.AreEqual("04/14/2021 17:07:25",actual.OrderDate.ToString());
            
        }
    }
    
}