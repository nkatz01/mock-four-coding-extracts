using System;
using System.Linq;
namespace QuestionOne
{
    class Program
    {
        public static Func<int, bool> isEven = (i) => i % 2 == 0;
        public static Func<int[], int> howManyEvens = (l) => l.Count(i => i % 2 == 0);
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,3,4,5,6,7,8,9,10 };
            Console.WriteLine(howManyEvens(arr));
            Console.WriteLine(howManyEvensRec(arr,0));
            //  Console.WriteLine(howManyEvensFiltEq(arr, isEven));
            Console.WriteLine(arr.Where(i => isEven(i)).Count());
            Console.WriteLine(arr.Where(i => i % 2 == 0).Select(i => i ).Count()); 

        }


        public static int howManyEvensRec(int[] array, int n) =>
            array.Length == 0 ? n  : howManyEvensRec(array.Skip(1).ToArray(), array[0] % 2 == 0 ? 1  +n : 0 + n);

        public static int howManyEvensFiltEq(int[] array, Func<int, bool> pred) => array.Where(i => pred(i)).Count();

     }
}
