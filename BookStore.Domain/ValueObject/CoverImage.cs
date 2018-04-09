using BookStore.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.ValueObject
{
    public class CoverImage
    {
        public const int MaxBytesSize = 256000;
        public byte[] Image { get; private set; }

        protected CoverImage()
        {

        }

        public CoverImage(byte[] image)
        {
            Guard.ByteArrayNullOrEmpity(image, "Image");
            Guard.ByteArrayMaxLength(image, MaxBytesSize, "Image");
            this.Image = image;
        }
    }
}
