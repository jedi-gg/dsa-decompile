using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ValidationMarker
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060A84", Offset="0x1060A84")]
		[FieldOffset(Offset="0x10")]
		private Type <MarkedType>k__BackingField;

		public Type MarkedType
		{
			[Address(RVA="0x2340224", Offset="0x2340224", VA="0x2340224")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074144", Offset="0x1074144")]
			get
			{
				return null;
			}
			[Address(RVA="0x234021C", Offset="0x234021C", VA="0x234021C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074154", Offset="0x1074154")]
			private set
			{
			}
		}

		[Address(RVA="0x2340170", Offset="0x2340170", VA="0x2340170")]
		public ValidationMarker(Type markedType)
		{
		}
	}
}