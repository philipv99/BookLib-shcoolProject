using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    public class BookRepo
    {
        private int nextId = 0;
        public List<Book>? books;

        public BookRepo()
        {
            books = new List<Book>();
        }

        public Book? Add(Book book)
        {
            book.Id = nextId;
            nextId++;
            books.Add(book);
            return book;
        }

        public Book? GetById(int id)
        {
            return books?.SingleOrDefault(B => B.Id == id);
        }
        public Book? Delete(int id)
        {
            if (books?.Count == 0) return null;
            Book? tempBook = books?.SingleOrDefault(B => B.Id == id);
            if (tempBook != null) { return null; }
            books.Remove(tempBook);
            return tempBook;
        }

        /// <summary>
        /// updates an instence determned by id with the object specified
        /// </summary>
        /// <param name="id">id of object in list, to be changed</param>
        /// <param name="book">new object to replace</param>
        /// <returns>the new Book</returns>
        public Book? Update(int id, Book book)
        {
            if (book == null || id > books?.Count() || id < 0 || books?.Count == 0) return null;
            var bookindex = books.IndexOf(books.SingleOrDefault(B => B.Id == id));
            books.Insert(bookindex, book);
            return book;
        }

        // lister:
        public List<Book>? GetBooks()
        {
            return books;
        }

        public List<Book>? SortByPrice()
        {
            List<Book> piceList = books.OrderBy(B => B.Price).ToList();
            return piceList;
        }

        public List<Book>? SortByName()
        {
            List<Book> nameList = books.OrderBy(B => B.Name).ToList();
            return nameList;
        }
    }
}
