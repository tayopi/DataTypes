using System;

namespace ValueVsReferenceTypes
{
	class MyClass
	{
		public int ClassIntValue;
		public string ClassStringValue;

		public override string ToString()
		{
			return String.Format( "{0} - {1}", ClassIntValue, ClassStringValue );
		}
	}
}