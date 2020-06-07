using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace QuestionNine
{
    class Program
    {

        static void Main(string[] args)
        {
            var mf = Memo(fib);
           Console.WriteLine( mf(10));
          //  Console.WriteLine(mf(10));
        }

       public static Func<int, int> fib = (int n) => (n <= 2 ) ? 1 : fib(n - 1) + fib(n - 2); 

        public static Func<int, int> Memo(Func<int, int> fib)
        {
            ConcurrentDictionary<int, int> dict = new ConcurrentDictionary<int, int>();
            return (arg) => dict.GetOrAdd(arg, value => fib(value)); 

        }

    }
}
