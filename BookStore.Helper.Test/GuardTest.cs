using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Helper.Test
{
    [TestClass]
    public class GuardTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_StringNullOrEmpity_StringNullError()
        {
            Guard.StringNullOrEmpity(null, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_StringNullOrEmpity_StringEmpityError()
        {
            Guard.StringNullOrEmpity("", "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ByteArrayNullOrEmpity_ByteArrayNullError()
        {
            Guard.ByteArrayNullOrEmpity(null, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ByteArrayNullOrEmpity_ByteArrayEmpityError()
        {
            Guard.ByteArrayNullOrEmpity(new byte[0], "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ByteArrayMaxLength_InvalidLength()
        {
            Guard.ByteArrayMaxLength(new byte[1000], 100, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_IntGreaterThanZero_IntZero()
        {
            Guard.IntGreaterThanZero(0, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_IntGreaterThanZero_NegativeInt()
        {
            Guard.IntGreaterThanZero(-100, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_DateTimeMinOrGreaterThanToday_GreaterThanToday()
        {
            Guard.YearMinOrGreaterThanToday(-1, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_DateTimeMinOrGreaterThanToday_MinDateTime()
        {
            Guard.YearMinOrGreaterThanToday(3000, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_DoubleNotNegative_NegativeDouble()
        {
            Guard.DoubleNotNegative(-100.00, "Test");
        }
    }
}
