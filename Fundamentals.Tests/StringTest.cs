using NUnit.Framework;
using System;
using System.Text;
using System.Windows.Forms;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class StringTest
    {
        [Test]
        public void Length()
        {
            string x = "hello";
            Assert.AreEqual(5, x.Length);
        }

        //[Test]
        //public void NullTermination()
        //{
        //    MessageBox.Show("Hello\0word");
        //}

        [Test]
        public void GoodConcatenation()
        {
            string simple = new string('x', 10);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                builder.Append("x");
            }
            string good = builder.ToString();
            builder.Append("this won't appear in good");
            Assert.AreEqual(simple, good);
            Console.WriteLine(simple);
        }

        [Test]
        public void StringFormat()
        {
            decimal price = 10.50m;
            string result = string.Format("price={0:c}", price);
            Assert.AreEqual("price=10,50 lei", result);
        }

    }
}
