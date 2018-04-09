using BookStore.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.ValueObject
{
    public class Subject
    {
        public string Name { get; private set; }

        protected Subject()
        {

        }

        public Subject(string name)
        {
            Guard.StringNullOrEmpity(name, "Name");
            this.Name = name;
        }
    }
}
