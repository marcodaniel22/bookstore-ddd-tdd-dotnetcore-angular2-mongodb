using BookStore.Domain.Collection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Test.Entities
{
    [TestClass]
    public class BookTest
    {
        private string Title { get; set; }
        private string Author { get; set; }
        private int Edition { get; set; }
        private string Publisher { get; set; }
        private int YearPublication { get; set; }
        private double Price { get; set; }

        public BookTest()
        {
            this.Title = "TestBook";
            this.Author = "Marco Daniel";
            this.Edition = 1;
            this.Publisher = "HBSIS";
            this.YearPublication = 2018;
            this.Price = 20.00;
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Book_New_Required_NotEmpityTitle()
        {
            new Book("", Author, Edition, Publisher, YearPublication, Price);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Book_New_Required_NotNullTitle()
        {
            new Book(null, Author, Edition, Publisher, YearPublication, Price);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Book_New_Required_NotEmpityAuthor()
        {
            new Book(Title, "", Edition, Publisher, YearPublication, Price);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Book_New_Required_NotNullAuthor()
        {
            new Book(Title, null, Edition, Publisher, YearPublication, Price);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Book_New_Required_ValidEdition()
        {
            new Book(Title, Author, 0, Publisher, YearPublication, Price);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Book_New_Required_NotEmpityPublisher()
        {
            new Book(Title, Author, Edition, "", YearPublication, Price);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Book_New_Required_NotNullPublisher()
        {
            new Book(Title, Author, Edition, null, YearPublication, Price);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Book_New_Required_NotMinValueYearPublication()
        {
            new Book(Title, Author, Edition, Publisher, -1000, Price);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Book_New_Required_NotGreaterDateThanTodayYearPublication()
        {
            new Book(Title, Author, Edition, Publisher, 3000, Price);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Book_New_Required_NotNegativePrice()
        {
            new Book(Title, Author, Edition, Publisher, YearPublication, -100.00);
        }

        [TestMethod]
        public void Book_New_ValidBook()
        {
            var book = new Book(Title, Author, Edition, Publisher, YearPublication, Price);
            Assert.AreEqual(Title, book.Title);
            Assert.AreEqual(Author, book.Author);
            Assert.AreEqual(Edition, book.Edition);
            Assert.AreEqual(Publisher, book.Publisher);
            Assert.AreEqual(YearPublication, book.YearPublication);
            Assert.AreEqual(Price, book.Price);
        }
    }
}
