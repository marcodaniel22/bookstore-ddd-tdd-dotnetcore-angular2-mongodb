using BookStore.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Test.ValueObject
{
    [TestClass]
    public class SubjectTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Subject_New_EmpityName()
        {
            new Subject("");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Subject_New_NullName()
        {
            new Subject(null);
        }

        [TestMethod]
        public void Subject_New_Valid()
        {
            var name = "TestSubject";
            var subject = new Subject(name);
            Assert.AreEqual(name, subject.Name);
        }
    }
}
