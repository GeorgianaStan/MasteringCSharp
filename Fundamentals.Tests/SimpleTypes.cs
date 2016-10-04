using NUnit.Framework;
using System;
using System.Numerics;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class SimpleTypes
    {
        [Test]
        public void DisplayValues()
        {
            /*
             * int = System.Int32
             * uint = System.UInt32
             * 
             * long = System.Int64
             * ulong = System.Uint64
             * 
             * byte = System.Byte (8 bits)
             * sbyte = System.SByte (8 bits)
             * 
             * short = System.Int16
             * ushort = System.UInt16
             */
            //BigInteger bigInt = new BigInteger();

            /*
             * float = System.Single (32 bits)
             * double = System.Double (64 bits)
             * decimal = System.Decimal (128 bits)
             */

            decimal x = 0.1m;
            //Console.WriteLine(DoubleConverter.ToExactString(x));
            x += 0.000001m;
            x += 0.000001m;
            x += 0.000001m;
            x += 0.000001m;
            x += 0.000001m;
            Assert.AreEqual(0.100005m, x);
            //Console.WriteLine(x == y);
            //Console.WriteLine(DoubleConverter.ToExactString(x));
            //Assert.AreEqual(0.100001, x);
            Complex c1= new Complex(0, 1);
            Console.WriteLine(c1 * c1);
        }
    }
}
