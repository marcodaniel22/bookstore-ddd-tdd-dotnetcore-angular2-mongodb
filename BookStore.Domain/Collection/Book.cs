using BookStore.Domain.ValueObject;
using BookStore.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Collection
{
    public class Book : MongoDbBase
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Edition { get; private set; }
        public string Publisher { get; private set; }
        public double Price { get; private set; }
        public int YearPublication { get; private set; }
        public List<Subject> Subjects { get; private set; }
        public CoverImage Cover { get; private set; }

        protected Book()
        {

        }

        public Book(string title, string author, int edition, string publisher, int yearPublication, double price, string id = "")
        {
            SetTitle(title);
            SetAuthor(author);
            SetEdition(edition);
            SetPublisher(publisher);
            SetYearPublication(yearPublication);
            SetPrice(price);
            SetControlId(id);
        }

        private void SetTitle(string title)
        {
            Guard.StringNullOrEmpity(title, "Title");
            this.Title = title;
        }

        private void SetAuthor(string author)
        {
            Guard.StringNullOrEmpity(author, "Author");
            this.Author = author;
        }

        private void SetEdition(int edition)
        {
            Guard.IntGreaterThanZero(edition, "Edition");
            this.Edition = edition;
        }

        private void SetPublisher(string publisher)
        {
            Guard.StringNullOrEmpity(publisher, "Publisher");
            this.Publisher = publisher;
        }

        private void SetYearPublication(int yearPublication)
        {
            Guard.YearMinOrGreaterThanToday(yearPublication, "YearPublication");
            this.YearPublication = yearPublication;
        }

        public void SetPrice(double price)
        {
            Guard.DoubleNotNegative(price, "Price");
            this.Price = price;
        }

        private void SetControlId(string id)
        {
            this.controlId = id;
        }
    }
}
