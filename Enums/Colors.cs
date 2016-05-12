using System;

namespace Enums
{
	static class Colors
	{
		public static void RunExample()
		{
			Console.WriteLine( "This is the default color" );
			Console.ForegroundColor = (ConsoleColor)11;
			Console.WriteLine( "I don't know what color this will be" );
			Console.ForegroundColor = (ConsoleColor)14;
			Console.WriteLine( "I don't know what color this will be, either" );

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine( "I know this will be green.  It's value is: {0}", (int)ConsoleColor.Green );
		}
	}
}