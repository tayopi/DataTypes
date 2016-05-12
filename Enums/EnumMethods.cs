using System;
using System.Linq;

namespace Enums
{
	static class EnumMethods
	{
		public static void RunExample()
		{
			// Enum.GetNames
			Console.WriteLine( "The names in Direction are:" );
			foreach ( string name in Enum.GetNames( typeof( Direction ) ) )
			{
				Console.WriteLine( "   {0}", name );
			}
			Console.WriteLine();
			Console.ReadLine();

			// Enum.GetValues
			Console.WriteLine( "The values in Direction are:" );
			Enum.GetValues( typeof( Direction ) ).Cast<int>().ToList().ForEach( val => Console.WriteLine( "   {0}", val ) );
			Console.WriteLine();
			Console.ReadLine();

			// Enum.IsDefined
			Console.WriteLine( "Check if values are in the enum" );
			Console.WriteLine( "   5 {0} in the enum", CheckInEnum( 5 ) );
			Console.WriteLine( "   45 {0} in the enum", CheckInEnum( 45 ) );
			Console.WriteLine( "   North {0} in the enum", CheckInEnum( "North" ) );
			Console.WriteLine( "   NorthNorthEast {0} in the enum", CheckInEnum( "NorthNorthEast" ) );
			Console.WriteLine();
			Console.ReadLine();

			// Enum.Parse
			Direction value;
			try
			{
				Console.WriteLine( "Parse West" );
				value = (Direction)Enum.Parse( typeof( Direction ), "West" );
				Console.WriteLine( "   Parse Succeeded: {0}", value );
			}
			catch
			{
				Console.WriteLine( "   Parse failed" );
			}
			try
			{
				Console.WriteLine( "Parse 180" );
				value = (Direction)Enum.Parse( typeof( Direction ), "180" );
				Console.WriteLine( "   Parse Succeeded: {0}", value );
			}
			catch
			{
				Console.WriteLine( "   Parse failed" );
			}
			try
			{
				Console.WriteLine( "Parse Sur" );
				value = (Direction)Enum.Parse( typeof( Direction ), "Sur" );
				Console.WriteLine( "   Parse Succeeded: {0}", value );
			}
			catch
			{
				Console.WriteLine( "   Parse failed" );
			}
			Console.ReadLine();

			// Enum.TryParse
			Console.WriteLine( "TryParse West" );
			if (Enum.TryParse<Direction>("West", out value))
			{ 
				Console.WriteLine( "   TryParse Succeeded: {0}", value );
			}
			else
			{
				Console.WriteLine( "   Parse failed" );
			}
			Console.WriteLine( "TryParse 180" );
			if ( Enum.TryParse<Direction>( "180", out value ) )
			{
				Console.WriteLine( "   TryParse Succeeded: {0}", value );
			}
			else
			{
				Console.WriteLine( "TryParse failed" );
			}
			Console.WriteLine( "TryParse Sur" );
			if ( Enum.TryParse<Direction>( "Sur", out value ) )
			{
				Console.WriteLine( "   TryParse Succeeded: {0}", value );
			}
			else
			{
				Console.WriteLine( "   TryParse failed" );
			}
		}

		static string CheckInEnum(object value)
		{
			if ( Enum.IsDefined( typeof( Direction ), value ) )
			{
				return "is";
			}
			else
			{
				return "is not";
			}
		}
	}
}