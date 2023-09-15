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
    public class BookRepoTests
    {
        [TestMethod()]
        public void BookRepoTest()
        {
            Book book1 = new Book("Abook", 200);
            Book book2 = new Book("Bbook2", 400);
            Book book3 = new Book("Cbook", 100);
            Book book4 = new Book("Zbook", 50);
            BookRepo repo = new BookRepo();
            repo.Add(book1);
            repo.Add(book2);
            repo.Add(book3);
            repo.Add(book4);
            Assert.AreEqual(repo.books.Count(), 4);
            Assert.AreEqual(repo.books[1].Id, 1);
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Book book1 = new Book("Abook", 200);
            Book book2 = new Book("Bbook2", 400);
            Book book3 = new Book("Cbook", 100);
            Book book4 = new Book("Zbook", 50);
            BookRepo repo = new BookRepo();
            repo.Add(book1);
            repo.Add(book2);
            repo.Add(book3);
            repo.Add(book4);

            var getBook = repo.GetById(2);
            Assert.AreEqual(getBook.Name, book3.Name);
        }

        [TestMethod()]
        public void GetByIdOutOfScope()
        {
            Book book1 = new Book("Abook", 200);
            Book book2 = new Book("Bbook2", 400);
            Book book3 = new Book("Cbook", 100);
            Book book4 = new Book("Zbook", 50);
            BookRepo repo = new BookRepo();
            repo.Add(book1);
            repo.Add(book2);
            repo.Add(book3);
            repo.Add(book4);

            Assert.IsNull(repo.GetById(10));
        }

        [TestMethod()]
        public void GetByIdOutOfScopeNegative()
        {
            Book book1 = new Book("Abook", 200);
            Book book2 = new Book("Bbook2", 400);
            Book book3 = new Book("Cbook", 100);
            Book book4 = new Book("Zbook", 50);
            BookRepo repo = new BookRepo();
            repo.Add(book1);
            repo.Add(book2);
            repo.Add(book3);
            repo.Add(book4);

            Assert.IsNull(repo.GetById(-4));
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetBooksTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SortByPriceTest()
        {
            Book book1 = new Book("Bbook", 200);
            Book book2 = new Book("Abook", 400);
            Book book3 = new Book("Dbook", 100);
            Book book4 = new Book("Cbook", 50);
            BookRepo repo = new BookRepo();
            repo.Add(book1);
            repo.Add(book2);
            repo.Add(book3);
            repo.Add(book4);

            List<Book> newList = repo.SortByPrice();

            Assert.IsNotNull(newList);
            Assert.AreEqual(50, newList[0].Price);
            Assert.AreEqual(400, newList[3].Price);
        }

        [TestMethod()]
        public void SortByNameTest()
        {
            Book book1 = new Book("Bbook", 200);
            Book book2 = new Book("Abook", 400);
            Book book3 = new Book("Dbook", 100);
            Book book4 = new Book("Cbook", 50);
            BookRepo repo = new BookRepo();
            repo.Add(book1);
            repo.Add(book2);
            repo.Add(book3);
            repo.Add(book4);

            List<Book> newList = repo.SortByName();

            Assert.IsNotNull(newList);
            Assert.AreEqual("Abook", newList[0].Name);
            Assert.AreEqual("Dbook", newList[3].Name);
        }
    }
}