using System;

namespace PrimitiveTypes
{
	static class SizeAndRange
	{
		public static void RunExample()
		{
			// Complete the output for the primitive types
			// Display the amount of memory (in bits) that the type uses
			// Display the valid range of values for the type

			Console.WriteLine( "byte" );
			Console.WriteLine( "  Size: {0}" );
			Console.WriteLine( "  Range: {0} to {1}" );
			Console.WriteLine();

			Console.WriteLine( "ulong" );
			Console.WriteLine( "  Size: {0}" );
			Console.WriteLine( "  Range: {0} to {1}" );
			Console.WriteLine();

			Console.WriteLine( "float" );
			Console.WriteLine( "  Size: {0}" );
			Console.WriteLine( "  Range: {0} to {1}" );
			Console.WriteLine();

			Console.WriteLine( "bool" );
			Console.WriteLine( "  Size: {0}" );
			Console.WriteLine();
		}
	}
}