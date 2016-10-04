using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fundamentals.Tests
{
    internal static class Extension
    {
        internal static int DoubleLength(this string text)
        {
            return text.Length * 2;
        }
    }
    [TestFixture]
    public class LinqTest
    {
        [Test]
        public void Scratchpad()
        {
            List<string> names = new List<string>
            {
                "Rob, Friend",
                "Holly, Family",
                "This isn't a name",
                "Malcom, Colleague",
                "Tom, Family"
            };

            Regex pattern = new Regex("([^,]*),(.*)");

            var query = from line in names
                        where line.Length < 15
                        select line;

            var query1 = names.Where(line => line.Length < 15);

            foreach(var line in query1)
            {
                Console.WriteLine(line);
            }

            //linq and lambda expression
            //var query = names.Select(line => new { line, match = pattern.Match(line) })
            //                    .Where(z => z.match.Success)
            //                    .Select(z => new
            //                    {
            //                        Name = z.match.Groups[1].Value,
            //                        Relationship = z.match.Groups[2].Value
            //                    })
            //                    .GroupBy(association => association.Relationship,
            //                                association => association.Name);




            //linq
            //var query = from line in names
            //            let match = pattern.Match(line)
            //            where match.Success
            //            select new
            //            {
            //                Name = match.Groups[1].Value,
            //                Relationship = match.Groups[2].Value
            //            } into association
            //            group association.Name by association.Relationship;
            //            ;

            //foreach (var group in query)
            //{
            //    Console.WriteLine("Relationship: {0}", group.Key);
            //    foreach (var name in group)
            //    {
            //        Console.WriteLine(" {0}", name);
            //    }
            //}

            ////anmonymous type and type inference
            //var person = new { Name = "Georgiana", Age = 29 };

            ////lambda expression         delegate
            //Func<string, bool> isLong = x => x.Length > 5;

            ////extension methods
            //int doubleLength = "foo".DoubleLength();
        }

        //public void Print(string x)
        //{
        //    Console.WriteLine(x);
        //}
        }
}
