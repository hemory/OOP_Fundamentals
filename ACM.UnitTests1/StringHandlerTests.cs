using ACM.Common;
using NUnit.Framework;

namespace ACM.UnitTests1
{
    [TestFixture]
    public class StringHandlerTests
    {
        [Test]
        public void InsertSpaceIsValid()
        {
            //Arrange
            var actual = "The House";
            //Act
            actual = actual.InsertSpaces();
            
            //Assert
            Assert.AreEqual("The House", actual);
        }
        
        [Test]
        public void InsertSpaceWithExitingSpaces()
        {
            //Arrange
            var actual = "The House";
            //Act
            actual = actual.InsertSpaces();
            
            //Assert
            Assert.AreEqual("The House", actual);
        }
    }
}