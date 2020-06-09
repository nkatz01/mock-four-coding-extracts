using System;
using System.Linq;

namespace QuestionEight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new BigInt(7).Factor().OutputBigInteger());
        }
    }

    public class BigInt
    {
        private int[] digits; // stores BigInt as an array of Int
        private bool error; // if overflow or underflow occurred, then true else false


        public BigInt Factor() => new BigInt(Enumerable.Range(2, digits.Length ).Where(i => digits.Length % i == 0).First());
 
        public BigInt(int x = 0) // This class deals only with integers >= 0
        {
            digits = new int[x];
        }

        public BigInt(BigInt x) : this(x.digits.Length)
        {
            // ...
        }

        public BigInt(int[] arr) : this(arr.Length)
        {
            // ...
        }

        //Return a String representation of a BigInteger
        public string OutputBigInteger()
        {
            return digits.Length +"";
        }

        //// Add x to this, put return new value
        //public BigInt AddBigIntegers(BigInt x)
        //{
        //    // ... 
        //}

        //// Subtract x from this, return new value
        //public BigInt SubtractBigIntegers(BigInt x)
        //{
        //    // ...
        //}

        //// Multiply this by x, return new value
        //public BigInt MultiplyBigIntegers(BigInt x)
        //{
        //    // ...
        //}

        //// Divide this by x, return new value
        //public BigInt DivideBigIntegers(BigInt x)
        //{
        //    // ...
        //}

        //// return the remainder of this when divided by val (this is unchanged)
        //public BigInt ModulusBigIntegers(BigInt x)
        //{
        //    // ...
        //}

        //// true when this == x
        //public bool IsEqualTo(BigInt x)
        //{
        //    // ...
        //}

        //// true when this < x
        //public bool IsLessThan(BigInt x)
        //{
        //    // ...
        //}
    }
}
