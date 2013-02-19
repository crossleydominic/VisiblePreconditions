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
        private static class CatchScope
        {
            public static void Enter(Action action)
            {
                try
                {
                    action();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failure: " + e.Message);
                }
            }
        }

        private static void Main(string[] args)
        {
            //Success
            CatchScope.Enter(() =>
            {
                string joinedString = TargetClass.HasPostCondition(new List<char> {'a', 'b', 'c'});
                Console.WriteLine("Success");
            });

            //Success
            CatchScope.Enter(() =>
            {
                TargetClass.HasPreconditions("some string", new List<int> { 0 });
                Console.WriteLine("Success");
            });

            //Failure
            CatchScope.Enter(() =>
            {
                string joinedString = TargetClass.HasFailingPostCondition(new List<char> { 'a', 'b', 'c' });
            });

            //Failure
            CatchScope.Enter(() =>
            {
                TargetClass.HasPreconditions("Some string", new List<int>());
            });

            //Failure
            CatchScope.Enter(() =>
            {
                TargetClass.HasPreconditions(null, new List<int>());
            });
        }
    }

    public class TargetClass
    {
        public static void HasPreconditions(
            Precondition<string, NotNullOrWhitespace> str,
            Precondition<List<int>, NotEmpty> list)
        {
            //No explicit checks required here

            Console.WriteLine(str.Value);
            Console.WriteLine(list.Value);
        }

        public static Postcondition<string, NotNullOrWhitespace> HasPostCondition(
            Precondition<List<char>, NotEmpty> list)
        {
            return string.Join("", list.Value);
        }

        public static Postcondition<string, NotNullOrWhitespace> HasFailingPostCondition(
            Precondition<List<char>, NotEmpty> list)
        {
            return string.Empty;
        }
    }
}
