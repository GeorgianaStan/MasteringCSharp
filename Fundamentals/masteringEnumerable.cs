using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public static class MasteringEnumerable
    {
        public static IEnumerable<TResult> Select<TSource, TResult>
            (this IEnumerable<TSource> source,
                Func<TSource, TResult> selector)
        {
            foreach(TSource item in source)
            {
                yield return selector(item);
            }
        }

        public static IEnumerable<TSource> Where<TSource>
            (this IEnumerable<TSource> source,
                Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
