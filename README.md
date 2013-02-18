VisiblePreconditions
====================

An experimental C# library that uses the type system to make method preconditions visible in the method signature.

Because the precondition details are embedded directly in the arguments type it means that the information is automatically visible to Intellisense by consumers.

Allows a method signature to be declared like this

	public static void SinglePrecondition(
		Precondition<string, NotNullOrWhitespace> str, 
		Precondition<List<int>, NotEmpty> list )
	{
		DoSomethingWithValues(str.Value);
	}

The validation of the arguments preconditions is deferred until the argument is actually used. The preconditions are checked when .Value is called.
