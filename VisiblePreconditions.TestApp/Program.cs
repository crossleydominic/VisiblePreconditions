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
                TargetClass.SinglePrecondition("some string");

                TargetClass.SinglePrecondition(null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class TargetClass
    {
        public static void SinglePrecondition(Precondition<string, NotNull> str)
        {
            Console.WriteLine(str.Value);
        }
    }
}
