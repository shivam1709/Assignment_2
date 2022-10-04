using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assignment_2;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Assignment_2.Tests
{
    [TestFixture]

    public class RectangleTest
    {

        [Test]
        public void validRectangleLength_5()
        {
            
            int length = 5;
            int width = 10;
            Rectangle rectangle = new Rectangle(length , width);
            int expected = 5;
            int actual = rectangle.GetCurrentLength(); 
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void validRectangleLength_10()
        {

            int length = 10;
            int width = 10;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = 10;
            int actual =  rectangle.GetCurrentLength();
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void validRectangleLength_15()
        {

            int length = 15;
            int width = 15;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = 15;
            int actual = rectangle.GetCurrentLength();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void isValidSetNewLength_5()
        {

            int length = 5;
            Rectangle rectangle = new Rectangle();
            int expected = 5;
            int actual = rectangle.SetNewLength(length);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void isValidSetNewLength_10()
        {

            int length = 10;
            Rectangle rectangle = new Rectangle();
            int expected = 10;
            int actual = rectangle.SetNewLength(length);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void isValidSetNewLength_15()
        {

            int length = 15;
            Rectangle rectangle = new Rectangle();
            int expected = 15;
            int actual = rectangle.SetNewLength(length);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void validRectangleWidth_5()
        {

            int length = 5;
            int width = 5;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = 5;
            int actual = rectangle.GetCurrentWidth();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void validRectangleWidth_10()
        {

            int length = 5;
            int width = 10;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = 10;
            int actual = rectangle.GetCurrentWidth();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void validRectangleWidth_15()
        {

            int length = 5;
            int width = 15;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = 15;
            int actual = rectangle.GetCurrentWidth();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void isValidSetNewWidth_5()
        {

            int width = 5;
            Rectangle rectangle = new Rectangle();
            int expected = 5;
            int actual = rectangle.SetNewWidth(width);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void isValidSetNewWidth_10()
        {

            int width = 10;
            Rectangle rectangle = new Rectangle();
            int expected = 10;
            int actual = rectangle.SetNewWidth(width);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void isValidSetNewWidth_15()
        {

            int width = 15;
            Rectangle rectangle = new Rectangle();
            int expected = 15;
            int actual = rectangle.SetNewWidth(width);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getValidPerimeter_5()
        {
            int length = 5;
            int width = 5;
            Rectangle rectangle = new Rectangle(length , width);
            int expected = (length + width) * 2;
            int actual = rectangle.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getValidPerimeter_10()
        {
            int length = 10;
            int width = 10;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = (length + width) * 2;
            int actual = rectangle.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getValidPerimeter_15()
        {
            int length = 15;
            int width = 15;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = (length + width) * 2;
            int actual = rectangle.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getValidArea_5()
        {
            int length = 5;
            int width = 5;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = length * width;
            int actual = rectangle.GetArea();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getValidArea_10()
        {
            int length = 10;
            int width = 10;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = length * width;
            int actual = rectangle.GetArea();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getValidArea_15()
        {
            int length = 15;
            int width = 15;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = length * width;
            int actual = rectangle.GetArea();
            Assert.AreEqual(expected, actual);
        }
    } 
}
