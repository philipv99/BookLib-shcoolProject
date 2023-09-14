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
            Book harryBlobber = new Book("harry Blobber & the white man", 500);
            Assert.IsNotNull(harryBlobber);
            Assert.IsInstanceOfType(harryBlobber, typeof(Book));
        }

        [TestMethod()]
        public void ValidateNameToShort()
        {
            Book harryBlobber = new Book("HP", 500);
            Assert.ThrowsException<ArgumentException>(() => Book harryBlobber = new Book("HP", 500);)
        }
    }
}