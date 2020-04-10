using Il2CppDummyDll;
using System;

namespace Glunies.Sequencer
{
	[Attribute(Name="AttributeUsageAttribute", RVA="0x1049AE8", Offset="0x1049AE8")]
	public class SequencerBoundFieldAttribute : Attribute
	{
		[FieldOffset(Offset="0x10")]
		public BindingValueType ValueType;

		[Address(RVA="0x153498C", Offset="0x153498C", VA="0x153498C")]
		public SequencerBoundFieldAttribute(BindingValueType valueType)
		{
		}
	}
}