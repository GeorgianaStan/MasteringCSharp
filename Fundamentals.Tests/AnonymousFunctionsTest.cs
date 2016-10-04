using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Fundamentals.Tests
{
    public delegate void Int32Action(int value);
    public delegate void GenericAction<T>(T value);

   [TestFixture]
    public class AnonymousFunctionsTest
    {
        public void MethodTakingString(string value)
        {
            Console.WriteLine(value);
        }

        [Test]
        public void MethodGroupConversion()
        {
            GenericAction<string> action = MethodTakingString;
            action("Hi Georgiana!");
            Console.WriteLine(Math.Sqrt(2));
        }

        private double SquareRoot(int x)
        {
            return Math.Sqrt(x);
        }

        [Test]
        public void ListConversion()
        {
            List<int> original = new List<int> { 1, 2, 3 };
            List<double> squareRoots = original.ConvertAll(SquareRoot);
            foreach(double value in squareRoots)
            {
                Console.WriteLine(value);
            }
        }

        [Test]
        public void AnonymousMethods()
        {
            List<int> original = new List<int> { 1, 2, 3 };
            List<double> squareRoots = original.ConvertAll(delegate (int x)
            {
                return Math.Sqrt(x);
            });
            foreach (double value in squareRoots)
            {
                Console.WriteLine(value);
            }
        }

        [Test]
        public void ClosureAnonymousMethods()
        {
            int calls = 0;
            double power = 0.5; //square root
            Converter<int, double> converter = delegate(int x)
            {
                calls++;
                return Math.Pow(x,power);
            };

            List<int> original = new List<int> { 1, 2, 3 };
            List<double> squareRoots = original.ConvertAll(converter);
            foreach (double value in squareRoots)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("Total calls: {0}", calls);
            power = 2;
            List<double> squares = original.ConvertAll(converter);
            foreach (double value in squares)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("Total calls: {0}", calls);
        }

        [Test]
        public void ClosureLambda()
        {
            double power = 0.5; //square root
            Converter<int, double> converter = x => Math.Pow(x, power);
            Console.WriteLine(converter);

            List<int> original = new List<int> { 1, 2, 3 };
            List<double> squareRoots = original.ConvertAll(converter);
            foreach (double value in squareRoots)
            {
                Console.WriteLine(value);
            }
            
            power = 2;
            List<double> squares = original.ConvertAll(converter);
            foreach (double value in squares)
            {
                Console.WriteLine(value);
            } 
        }

        [Test]
        public void DangerWillRobinson()
        {
            List<string> words = new List<string>() { "Danger", "Will", "Robinson"};
            List<Action> actions = new List<Action>();

            for(int i = 0; i < words.Count; i++)
            {
                string word = words[i];
                actions.Add(() => Console.WriteLine("{0} : {1}" , i, word));
            }

            foreach (Action action in actions)
            {
                action();
            }
        }

        [Test]
        public void ExpressionTrees()
        {
            Expression<Converter<int, double>> converter = x => Math.Pow(x, 0.5);
            Console.WriteLine(converter);

            Converter<int, double> compiled = converter.Compile();
            Console.WriteLine(compiled(5));
        }

        [Test]
        public void IngnoreParameter()
        {
            Converter<int, double> converter = delegate { return 5.5; };
            Console.WriteLine(converter(10));
        }
    }
}
