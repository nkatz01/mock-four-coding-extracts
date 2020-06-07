using System;
using System.Reflection;

namespace QuestionFour
{
    class Program
    {
        static void Main(string[] args)
        {
           whatever wtevr = new whatever(1);
            Console.WriteLine(wtevr.GetType());
            Program program = (Program)Activator.CreateInstance(typeof(Program));
            Console.WriteLine(program.GetType());
           MethodInfo[] methodinfo = wtevr.GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.NonPublic );
            Console.WriteLine(String.Join<MethodInfo>(",", methodinfo));
           //ParameterInfo[] param = methodinfo[2].GetParameters();
           //var returnType = methodinfo[2].ReturnType;
           // Console.WriteLine(returnType);
           // var accessMod = methodinfo[2].Attributes;
           // Console.WriteLine(accessMod);

        }
    }


    public class whatever
    {
        public int N {get; set;}
        public whatever(int n)
        {
        N = n;
        }

        public string method1()
        {   
            return N + "";
        }
    }
}
