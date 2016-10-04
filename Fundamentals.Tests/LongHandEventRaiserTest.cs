using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class LonghandEventRaiserTest
    {
        private void ReportToConsole(object sender, EventArgs e)
        {
            Console.WriteLine("ReportToConsole was canceled");
        }

        [Test]
        public void RaiseEvents()
        {
            ClickHandler handler = ReportToConsole;

            var raiser = new LonghandEventRaiser();
            raiser.OnClick();

            raiser.Click += handler;

            raiser.OnClick();

            raiser.Click += handler;
            raiser.OnClick();

            raiser.Click -= handler;
            raiser.Click -= handler;
            raiser.OnClick();
        }
    }
}
