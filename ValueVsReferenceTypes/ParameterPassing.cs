using System;

namespace ValueVsReferenceTypes
{
	static class ParameterPassing
	{
		public static void RunExample()
		{
			int intValue = 5;
			MyStruct structValue = new MyStruct
			{
				StructIntValue = 100,
				StructStringValue = "Struct Test"
			};
			MyClass classValue = new MyClass
			{
				ClassIntValue = 200,
				ClassStringValue = "Class Test"
			};

			Console.WriteLine( "Values Before Method" );
			Console.WriteLine( "====================" );
			Console.WriteLine( "intValue: {0}", intValue );
			Console.WriteLine( "structValue: {0}", structValue );
			Console.WriteLine( "classValue: {0}", classValue );
			Console.WriteLine();
			Console.Read();

			ChangeValues( intValue, structValue, classValue );
			Console.Read();

			Console.WriteLine( "Values After Method" );
			Console.WriteLine( "===================" );
			Console.WriteLine( "intValue: {0}", intValue );
			Console.WriteLine( "structValue: {0}", structValue );
			Console.WriteLine( "classValue: {0}", classValue );
		}

		static void ChangeValues( int intValue, MyStruct structValue, MyClass classValue )
		{
			intValue = 10;
			structValue.StructIntValue = 101;
			structValue.StructStringValue = "Struct Test 2";
			classValue.ClassIntValue = 201;
			classValue.ClassStringValue = "Class Test 2";

			Console.WriteLine( "Values In Method" );
			Console.WriteLine( "================" );
			Console.WriteLine( "intValue: {0}", intValue );
			Console.WriteLine( "structValue: {0}", structValue );
			Console.WriteLine( "classValue: {0}", classValue );
			Console.WriteLine();
		}
	}
}