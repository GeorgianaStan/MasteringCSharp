using NUnit.Framework;
using System;
using System.Net;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class ExtensionsTest
    {
        [Test]
        public void MiniLinq()
        {
            string[] names = { "Holly", "Rob", "Jon", "Tom", "William" };
            //var query = names.Where(x => !x.EndsWith("m"))
            //                  .Select(x => new
            //                  {
            //                    UpperName = x.ToUpper(),
            //                    NameLength = x.Length
            //                  } );

            var query = MasteringEnumerable.Select(
                            MasteringEnumerable.Where(
                                names,
                                x => !x.EndsWith("m")),
                            x => new
                            {
                                UpperName = x.ToUpper(),
                                NameLength = x.Length
                            });
            foreach (var result in query)
            {
                Console.WriteLine(result);
            }
        }

        [Test]
        public void InvokeReverse()
        {
            string reversed = "hello".Reverse();
            string reversed2 = Extensions.Reverse("hello");
            Assert.AreEqual("olleh", reversed);
        }

        [Test]
        public void ReadFully()
        {
            var request = WebRequest.Create("http://www.google.com");
            using (var response = request.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    byte[] data = responseStream.ReadFully();
                    Console.WriteLine(data.Length);
                }
            }
        }
    }
}
