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

        [Test]

        public void ValidRectangle_GetCurrentWidth_NoInput_OutputDefaultValues()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expectedwidth = 1;

            // Act
            int actualwidth = rect.GetCurrentWidth();

            // Assert
            Assert.AreEqual(expectedwidth, actualwidth);
        }

        [Test]
        public void ValidRectangle_GetCurrentWidth_InputWidth30_OutputWidth30()
        {
            // Arrange
            Rectangle rect = new Rectangle(30, 30);
            int expectedWidth = 30;

            // Act
            int actualWidth = rect.GetCurrentWidth();

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void ValidRectangle_GetCurrentWidth_InputWidth60_OutputWidth60()
        {
            // Arrange
            Rectangle rect = new Rectangle(60, 60);
            int expectedWidth = 60;

            // Act
            int actualWidth = rect.GetCurrentWidth();

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void ValidRectangle_SetNewWidth_DefaultObject_Input55_OutputWidth55()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expectedWidth = 55;

            // Act
            rect.SetNewWidth(55);
            int actualWidth = rect.GetCurrentWidth();

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void ValidRectangle_SetNewWidth_ParameterizedObject_Input45_OutputLength45()
        {
            // Arrange
            Rectangle rect = new Rectangle(30, 45);
            int expectedWidth = 45;

            // Act
            rect.SetNewWidth(45);
            int actualWidth = rect.GetCurrentWidth();

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void ValidRectangle_SetNewWidth_ParameterizedObject_Input70_OutputWidth70()
        {
            // Arrange
            Rectangle rect = new Rectangle(30, 70);
            int expectedWidth = 70;

            // Act
            rect.SetNewWidth(70);
            int actualWidth = rect.GetCurrentWidth();

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);
        }


        [Test]
        public void ValidRectangle_GetPerimeter_DefaultObject()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expectedPerimeter = 4;

            // Act
            int actualPerimeter = rect.GetPerimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void ValidRectangle_GetPerimeter_ParameterizedObject_InputLength20Width20_Output80()
        {
            // Arrange
            Rectangle rect = new Rectangle(20, 20);
            int expectedPerimeter = 80;

            // Act
            int actualPerimeter = rect.GetPerimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void ValidRectangle_GetPerimeter_ParameterizedObject_InputLength20Width50_Output140()
        {
            // Arrange
            Rectangle rect = new Rectangle(20, 50);
            int expectedPerimeter = 140;

            // Act
            int actualPerimeter = rect.GetPerimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }
}
