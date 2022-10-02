using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment02;
using NUnit.Framework;

namespace Assignment02Tests
{
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        public void Valid_GetRectangleLength_NoInput_OutputDefaultValues()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expectedLength = 1;

            // Act
            int actualLength = rect.GetCurrentLength();

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void Valid_GetRectangleLength_InputLength20_OutputLength20()
        {
            // Arrange
            Rectangle rect = new Rectangle(20, 20);
            int expectedLength = 20;

            // Act
            int actualLength = rect.GetCurrentLength();

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        
    }
}
