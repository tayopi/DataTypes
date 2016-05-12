using System;

namespace ValueVsReferenceTypes
{
	struct MyStruct
	{
		public int StructIntValue;
		public string StructStringValue;

		public override string ToString()
		{
			return String.Format( "{0} - {1}", StructIntValue, StructStringValue );
		}
	}
}