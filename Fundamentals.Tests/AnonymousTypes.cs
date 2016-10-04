using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class AnonymousTypes
    {
        private void DoSomething<T>(T value)
        {
            Console.WriteLine(typeof(T));

        }

        [Test]
        public void Demo()
        {
            var person = new { FirstName = "Georgiana", LastName = "Stan" };
            DoSomething(person);
        }
    }
}
