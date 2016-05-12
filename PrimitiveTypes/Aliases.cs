using System;

namespace PrimitiveTypes
{
	static class Aliases
	{
		public static void RunExample()
		{
			byte byteTest = 1;
			sbyte sbyteTest = 1;
			int intTest = 1;
			uint uintTest = 1;
			short shortTest = 1;
			ushort ushortTest = 1;
			long longTest = 1;
			ulong ulongTest = 1;
			float floatTest = 1;
			double doubleTest = 1;
			decimal decimalTest = 1;
			char charTest = '1';
			bool boolTest = true;

			Console.WriteLine( "byte {0} a Byte", byteTest is Byte ? "is" : "is not" );
			Console.WriteLine( "sbyte {0} a SByte", sbyteTest is SByte ? "is" : "is not" );
			Console.WriteLine( "int {0} a Int32", intTest is Int32 ? "is" : "is not" );
			Console.WriteLine( "uint {0} a UInt32", uintTest is UInt32 ? "is" : "is not" );
			Console.WriteLine( "short {0} a Int16", shortTest is Int16 ? "is" : "is not" );
			Console.WriteLine( "ushort {0} a UInt16", ushortTest is UInt16 ? "is" : "is not" );
			Console.WriteLine( "long {0} a Int64", longTest is Int64 ? "is" : "is not" );
			Console.WriteLine( "ulong {0} a UInt64", ulongTest is UInt64 ? "is" : "is not" );
			Console.WriteLine( "float {0} a Single", floatTest is Single ? "is" : "is not" );
			Console.WriteLine( "double {0} a Double", doubleTest is Double ? "is" : "is not" );
			Console.WriteLine( "decimal {0} a Decimal", decimalTest is Decimal ? "is" : "is not" );
			Console.WriteLine( "char {0} a Char", charTest is Char ? "is" : "is not" );
			Console.WriteLine( "bool {0} a Boolean", boolTest is Boolean ? "is" : "is not" );

			Console.WriteLine( "int {0} a Int64", intTest is Int64 ? "is" : "is not" );
		}
	}
}