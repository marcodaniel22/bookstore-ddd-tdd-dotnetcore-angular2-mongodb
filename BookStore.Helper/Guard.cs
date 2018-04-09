using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Helper
{
    public class Guard
    {
        public static void StringNullOrEmpity(string value, string property)
        {
            if (String.IsNullOrEmpty(value))
                throw new Exception(String.Format("String property [0] can't be empity or null.", property));
        }

        public static void ByteArrayNullOrEmpity(byte[] byteArray, string property)
        {
            if (byteArray == null || (byteArray != null && byteArray.Length == 0))
                throw new Exception(String.Format("Byte array property [0] can't be empity or null.", property));
        }

        public static void ByteArrayMaxLength(byte[] byteArray, int maxLength, string property)
        {
            if (byteArray.Length > maxLength)
                throw new Exception(String.Format("Byte array property [0] can't be greater than [1].", property, maxLength));
        }

        public static void IntGreaterThanZero(int value, string property)
        {
            if(value <= 0)
                throw new Exception(String.Format("Int property [0] can't be smaller than 1.", property));
        }

        public static void YearMinOrGreaterThanToday(int value, string property)
        {
            if(value <= DateTime.MinValue.Year || value > DateTime.Now.Year)
                throw new Exception(String.Format("String property [0] can't be set with MinDate or greater dates than today.", property));
        }

        public static void DoubleNotNegative(double price, string property)
        {
            if (price < 0)
                throw new Exception(String.Format("Double property [0] can't be smaller than 0.00.", property));
        }
    }
}
