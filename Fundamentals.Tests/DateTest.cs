using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class DateTest
    {
        [Test]
        public void TypeSpanUsage()
        {
            TimeSpan fiveSeconds = TimeSpan.FromSeconds(5);
            TimeSpan halfAMinute = TimeSpan.FromMinutes(.5);
            Assert.AreEqual(TimeSpan.FromMilliseconds(35000), fiveSeconds + halfAMinute);

            //Sytem.DateTime (.NET 1.0)
        }
        [Test]
        public void DateTimeUsage()
        {
            //System.TimeSpan (.NET 1.0)

            DateTime jonsTime = new DateTime(2016, 8, 19, 14, 16, 0, DateTimeKind.Local);
            DateTime robsTime = new DateTime(2016, 4, 1, 10, 24, 0, DateTimeKind.Local);
            DateTime utcTime = new DateTime(2016, 8, 19, 11, 16, 0, DateTimeKind.Utc);

            Assert.AreEqual(utcTime, jonsTime.ToUniversalTime());
            //System.DateTimeOffset (.NET 2.0 SP1 / .NET 3.5)
            //System.TimeZoneInfo (.NET 3.5)
        }

    }
}

