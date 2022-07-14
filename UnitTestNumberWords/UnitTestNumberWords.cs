using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Excercise01;

namespace UnitTestNumberWords
{
    [TestClass]
    public class UnitTestNumberWords
    {
        Excerise01 excercise01 = new Excerise01();

        /// <summary>
        /// Test million number to words
        /// </summary>
        [TestMethod]
        public void Million()
        {
            string number = excercise01.IntegerToWords(Convert.ToUInt64(1200000));

            Console.WriteLine("Number in words is \n{0}", number);
        }

        /// <summary>
        /// Test billion number to words
        /// </summary>
        [TestMethod]
        public void Billion()
        {
            string number = excercise01.IntegerToWords(Convert.ToUInt64(1600000000));

            Console.WriteLine("Number in words is \n{0}", number);
        }

        /// <summary>
        /// Test trillion number to words
        /// </summary>
        [TestMethod]
        public void Trillion()
        {
            string number = excercise01.IntegerToWords(Convert.ToUInt64(13000000000000));

            Console.WriteLine("Number in words is \n{0}", number);
        }

        /// <summary>
        /// Test quintillion number to words
        /// </summary>
        [TestMethod]
        public void quintillion()
        {
            string number = excercise01.IntegerToWords(Convert.ToUInt64(1845600203201100000));

            Console.WriteLine("Number in words is \n{0}", number);
           
        }
    }
}
