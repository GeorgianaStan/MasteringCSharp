using NUnit.Framework;
using System;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class DelegatesTest
    {
        [Test]
        public void SingleMethodInterface()
        {
            IInt32Action action = new Delegates();
            action.DoIt(10);
        }

        [Test]
        public void SingleDelegateFromMethod()
        {
            Delegates target = new Delegates("Jon");
            Int32Action action = new Int32Action(target.RandomRob);

            action.Invoke(5);
            action(6);
        }

        [Test]
        public void DelegatesFromStaticmethod()
        {
            Int32Action action = new Int32Action(Delegates.StaticRob);

            action.Invoke(7);
        }

        [Test]
        public void Multicast()
        {
            Int32Action action1 = new Int32Action(Delegates.StaticRob);
            Int32Action action2 = new Int32Action(Delegates.StaticRob2);

            //Int32Action action3 = action1 + action2;
            Int32Action action3 = (Int32Action)Delegate.Combine(action1, action2);
            action1 = null;
            action3(20);

            //Int32Action action4 = action3 - action1;
        }

        
    }
}
