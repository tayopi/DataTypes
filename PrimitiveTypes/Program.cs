using System;

namespace PrimitiveTypes
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Which example would you like to run:" );
			Console.WriteLine( "  1) Aliases" );
			Console.WriteLine( "  2) Size and Range" );
			string choice = Console.ReadLine();
			Console.WriteLine();

			switch ( choice )
			{
				case "1":
					Aliases.RunExample();
					break;
				case "2":
					SizeAndRange.RunExample();
					break;
				default:
					Console.WriteLine( "Invalid option" );
					break;
			}

			Console.Read();
		}
	}
}