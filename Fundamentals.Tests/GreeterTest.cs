using NUnit.Framework;
using System;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class GreeterTest
    {
        [Test]
        public void SayHallow_ReturnsHelloWithRecipientNameAndSpeakerName()
        {
            Greeter greeter = new Greeter("Rob");
            string greeting = greeter.SayHello("Jon");
            Assert.AreEqual("Hello Jon from Rob", greeting);
            Console.WriteLine(greeting);
        }

        [Test]
        public void CanConstructGreeterWithNullSpeakerName()
        {
            new Greeter(null);
        }

        [Test]
        public void SayHallow_ReturnsHelloWithRecipientNameButNoSpeakerName()
        {
            Greeter greeter = new Greeter(null);
            string greeting = greeter.SayHello("Jon");
            Assert.AreEqual("Hello Jon", greeting);
        }

        [Test]
        public void SayHello_ThrowsExceptionWithNullRecipient()
        {
            Greeter greeter = new Greeter("Rob");
            Assert.Throws<ArgumentNullException>(() => greeter.SayHello(null));
        }

        [Test]
        public void SpeakerProperty_IsSetFromConstructor()
        {
            Greeter greeter = new Greeter("Rob");
            Assert.AreEqual("Rob", greeter.Speaker);
            Assert.AreNotEqual("rob", greeter.Speaker);
        }

    }
}
