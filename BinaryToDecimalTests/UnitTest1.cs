using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab1.BinaryToDecimal;

namespace BinaryToDecimalTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetResult_101_5returned()
        {
            //arrange
            double expected = 5;
            double example = 101;

            //act
            Lab1.BinaryToDecimal.BinaryToDecimalConvert convert = new BinaryToDecimalConvert();
            double actual = convert.GetResult(example);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GetResult_10101dot11_21dot75returned()
        {
            //arrange
            double expected = 21.75;
            double example = 10101.11;

            //act
            Lab1.BinaryToDecimal.BinaryToDecimalConvert convert = new BinaryToDecimalConvert();
            double actual = convert.GetResult(example);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GetResult_1015_NaNreturned()
        {
            //arrange
            double expected = double.NaN;
            double example = 1015;

            //act
            Lab1.BinaryToDecimal.BinaryToDecimalConvert convert = new BinaryToDecimalConvert();
            double actual = convert.GetResult(example);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GetResult_NaN_NaNreturned()
        {
            //arrange
            double expected = double.NaN;
            double example = double.NaN;

            //act
            Lab1.BinaryToDecimal.BinaryToDecimalConvert convert = new BinaryToDecimalConvert();
            double actual = convert.GetResult(example);

            //assert
            Assert.AreEqual(expected, actual);


        }

    }
}
