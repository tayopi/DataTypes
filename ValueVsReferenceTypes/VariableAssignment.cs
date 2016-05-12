using System;

namespace ValueVsReferenceTypes
{
	static class VariableAssignment
	{
		public static void RunExample()
		{
			int intValue1 = 5;
			int intValue2 = intValue1;

			MyStruct structValue1 = new MyStruct
			{
				StructIntValue = 100,
				StructStringValue = "Struct Test"
			};
			MyStruct structValue2 = structValue1;

			MyClass classValue1 = new MyClass
			{
				ClassIntValue = 200,
				ClassStringValue = "Class Test"
			};
			MyClass classValue2 = classValue1;

			Console.WriteLine( "Values Before Changes" );
			Console.WriteLine( "=====================" );
			Console.WriteLine( "intValue1: {0}", intValue1 );
			Console.WriteLine( "intValue2: {0}", intValue2 );
			Console.WriteLine( "structValue1: {0}", structValue1 );
			Console.WriteLine( "structValue2: {0}", structValue2 );
			Console.WriteLine( "classValue1: {0}", classValue1 );
			Console.WriteLine( "classValue2: {0}", classValue2 );
			Console.WriteLine();
			Console.Read();

			intValue2 = 10;
			structValue2.StructIntValue = 101;
			structValue2.StructStringValue = "Struct Test 2";
			classValue2.ClassIntValue = 201;
			classValue2.ClassStringValue = "Class Test 2";

			Console.WriteLine( "Values After Changes" );
			Console.WriteLine( "====================" );
			Console.WriteLine( "intValue1: {0}", intValue1 );
			Console.WriteLine( "intValue2: {0}", intValue2 );
			Console.WriteLine( "structValue1: {0}", structValue1 );
			Console.WriteLine( "structValue2: {0}", structValue2 );
			Console.WriteLine( "classValue1: {0}", classValue1 );
			Console.WriteLine( "classValue2: {0}", classValue2 );
		}
	}
}