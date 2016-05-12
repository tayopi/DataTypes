using System;

namespace Enums
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Which example would you like to run:" );
			Console.WriteLine( "  0) Colors" );
			Console.WriteLine( "  1) Headings" );
			Console.WriteLine( "  2) EnumMethods" );

			MenuChoice choice;
			if ( !Enum.TryParse<MenuChoice>( Console.ReadLine(), out choice ) )
			{
				Console.WriteLine( "Invalid option" );
			}
			else
			{
				Console.WriteLine();

				switch ( choice )
				{
					case MenuChoice.Colors:
						Colors.RunExample();
						break;
					case MenuChoice.Headings:
						Headings.RunExample();
						break;
					case MenuChoice.EnumMethods:
						EnumMethods.RunExample();
						break;
					default:
						Console.WriteLine( "Invalid option" );
						break;
				}
			}

			Console.Read();
		}
	}

	enum MenuChoice
	{
		Colors, // Value defaults to 0
		Headings, // Value defaults to 1
		EnumMethods // Value defaults to 2
	}
}