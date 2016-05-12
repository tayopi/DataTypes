using System;

namespace CommonDataTypes
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Which exercise would you like to run:" );
			Console.WriteLine( "  1) Console exercises" );
			Console.WriteLine( "  2) String exercises" );
			Console.WriteLine( "  3) StringBuilder exercises" );
			Console.WriteLine( "  4) DateTime exercises" );
			Console.WriteLine( "  5) Environment exercises" );
			Console.WriteLine( "  6) Math exercises" );
			string choice = Console.ReadLine();
			Console.WriteLine();

			switch ( choice )
			{
				case "1":
					ConsoleExercises.RunExercises();
					break;
				case "2":
					StringExercises.RunExercises();
					break;
				case "3":
					StringBuilderExercises.RunExercise();
					break;
				case "4":
					DateTimeExercises.RunExercises();
					break;
				case "5":
					EnvironmentExercises.RunExercises();
					break;
				case "6":
					MathExercises.RunExercises();
					break;
				default:
					Console.WriteLine( "Invalid option" );
					break;
			}

			Console.Read();
		}
	}
}