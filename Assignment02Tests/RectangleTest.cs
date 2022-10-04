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
        public void ValidRectangle_GetCurrentLength_NoInput_OutputDefaultValues()
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
        public void ValidRectangle_GetCurrentLength_InputLength20_OutputLength20()
        {
            // Arrange
            Rectangle rect = new Rectangle(20, 20);
            int expectedLength = 20;

            // Act
            int actualLength = rect.GetCurrentLength();

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void ValidRectangle_GetCurrentLength_InputLength50_OutputLength50()
        {
            // Arrange
            Rectangle rect = new Rectangle(20, 50);
            int expectedLength = 50;

            // Act
            int actualLength = rect.GetCurrentLength();

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void ValidRectangle_SetNewLength_DefaultObject_Input40_OutputLength40()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expectedLength = 40;

            // Act
            rect.SetNewLength(40);
            int actualLength = rect.GetCurrentLength();

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void ValidRectangle_SetNewLength_ParameterizedObject_Input40_OutputLength40()
        {
            // Arrange
            Rectangle rect = new Rectangle(20, 50);
            int expectedLength = 40;

            // Act
            rect.SetNewLength(40);
            int actualLength = rect.GetCurrentLength();

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void ValidRectangle_SetNewLength_ParameterizedObject_Input5_OutputLength5()
        {
            // Arrange
            Rectangle rect = new Rectangle(20, 50);
            int expectedLength = 5;

            // Act
            rect.SetNewLength(5);
            int actualLength = rect.GetCurrentLength();

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }
    }
}
