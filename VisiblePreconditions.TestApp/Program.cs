using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisiblePreconditions.Framework;
using VisiblePreconditions.Validators;

namespace VisiblePreconditions.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TargetClass.SinglePrecondition("some string", new List<int> { 0 });

                TargetClass.SinglePrecondition("Some string", new List<int>());

                TargetClass.SinglePrecondition(null, new List<int>());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class TargetClass
    {
        public static void SinglePrecondition(Precondition<string, NotNullOrWhitespace> str, Precondition<List<int>, NotEmpty> list )
        {
            Console.WriteLine(str.Value);
            Console.WriteLine(list.Value.Count);
        }
    }
}
