using System;

namespace ValueVsReferenceTypes
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Which example would you like to run:" );
			Console.WriteLine( "  1) Parameter passing" );
			Console.WriteLine( "  2) Variable assignment" );
			string choice = Console.ReadLine();
			Console.WriteLine();

			switch(choice)
			{
				case "1":
					ParameterPassing.RunExample();
					break;
				case "2":
					VariableAssignment.RunExample();
					break;
				default:
					Console.WriteLine( "Invalid option" );
					break;
			}

			Console.Read();
		}
	}
}