using BookStore.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Test.ValueObject
{
    [TestClass]
    public class CoverImageTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CoverImage_New_NullImage()
        {
            new CoverImage(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CoverImage_New_EmpityImage()
        {
             new CoverImage(new byte[0]);
        }

        [TestMethod]
        public void CoverImage_New_ValidImage()
        {
            var image = new byte[256000];
            var coverImage = new CoverImage(image);
            Assert.AreEqual(image, coverImage.Image);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CoverImage_New_InvalidImage()
        {
            new CoverImage(new byte[300000]);
        }
    }
}
