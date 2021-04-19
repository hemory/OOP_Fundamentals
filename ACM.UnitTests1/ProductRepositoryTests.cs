using ACM.BL;
using Microsoft.VisualBasic.CompilerServices;
using NUnit.Framework;

namespace ACM.UnitTests1
{
    [TestFixture]
    public class ProductRepositoryTests
    {
        [Test]
        public void RetrieveValidate()
        {
            //Arrange
            Product f1 = new Product(1);
            ProductRepository pr = new ProductRepository();

            //Act
            Product actual = pr.Retrieve(f1.ProductId);
            //Assert
            Assert.AreEqual("ring", actual.ProductName);
            Assert.AreEqual("enchanted power", actual.ProductDescription);
            Assert.AreEqual(100, actual.CurrentPrice);
        }

        
        [Test]
        public void SaveTestHasPrice()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = 5.00m,
                ProductDescription = "MiniYellow Flowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updateProduct);

            //Assert
            Assert.AreEqual(true,actual);
        }
        

        [Test]
        public void SaveTestMissingPrice()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "MiniYellow Flowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updateProduct);

            //Assert
            Assert.AreEqual(false,actual);
        }
    }
}

