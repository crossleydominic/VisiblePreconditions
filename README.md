VisiblePreconditions
====================

An experimental C# library that uses the type system to make method preconditions/postconditions visible in a method's signature.

Because the precondition/postcondition details are embedded directly in the arguments type it means that the information is automatically visible to Intellisense by consumers.

Allows a method signature to be declared like this

	public static class TestClass
    {
        public static void HasPreconditions(
            Precondition<string, NotNullOrWhitespace> str, 
            Precondition<List<int>, NotEmpty> list )
        {
			//No explicit checks required here

            DoSomethingWithString(str.Value);
            DoSomethingWithList(list.Value);
        }

        public static Postcondition<string, NotNullOrWhitespace> HasPostCondition(
			Precondition<List<char>, NotEmpty> list)
        {
            string str = string.Join("", list.Value);

            return str;
        }
    }

	public static class Consumer
	{
		public static void UseMethodsWithPreconditions()
		{
			//Passing a null/empty/whitespace string or an empty/null list will cause an exception
			//This passes precondition checks.
			TestClass.HasPreconitions("some string", new List<int>() { 1, 2, 3 });

			//someString is guaranteed to contain a non-empty/whitespace character
			String someString = TestClass.HasPostCondition(new List<char>() { 'a', 'b', 'c' });
		}
	}

The validation of the arguments preconditions/postconditions is deferred until the value is actually used. The conditions are checked when .Value is called or when the postcondition value is cast back into a raw value
