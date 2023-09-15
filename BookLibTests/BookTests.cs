using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib.Tests
{
    [TestClass()]
    public class BookTests
    {
        [TestMethod()]
        public void ValidateNameTest()
        {
            Book harryBlobber = new Book("hive", 500);
            Assert.IsNotNull(harryBlobber);
            Assert.IsInstanceOfType(harryBlobber, typeof(Book));
        }

        [TestMethod()]
        public void ValidateNameToShort()
        {
            Book harryBlobber = new Book("HPv", 500);
            Assert.ThrowsException<ArgumentException>(() => harryBlobber.ValidateName());
        }

        [TestMethod()]
        public void ValidatePrice()
        {
            Book harryBlobber = new Book("HP", 500);
            Assert.IsInstanceOfType(harryBlobber, typeof(Book));
            Assert.IsInstanceOfType(harryBlobber.Price, typeof(int));
            harryBlobber.ValidatePrice();
        }

        [TestMethod()]
        public void ValidatePriceIsZero()
        {
            Book harryBlobber = new Book("HP", 0);
            Assert.IsInstanceOfType(harryBlobber, typeof(Book));
            Assert.IsInstanceOfType(harryBlobber.Price, typeof(int));
            harryBlobber.ValidatePrice();
        }
        [TestMethod()]
        public void ValidatePriceOneUnderMax()
        {
            Book harryBlobber = new Book("HP", 1199);
            Assert.IsInstanceOfType(harryBlobber, typeof(Book));
            Assert.IsInstanceOfType(harryBlobber.Price, typeof(int));
            harryBlobber.ValidatePrice();
        }

        [TestMethod()]
        public void ValidatePriceUnderZero()
        {
            Book harryBlobber = new Book("HP", -5);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => harryBlobber.ValidatePrice());
        }

        [TestMethod()]
        public void ValidatePriceOverIs1200()
        {
            Book harryBlobber = new Book("HP", 1200);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => harryBlobber.ValidatePrice());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Book harryBlobber = new Book("gump", 890);
            var expected = $"the book: gump. cost: 890";
            Assert.AreEqual(expected, harryBlobber.ToString());

        }
    }
}