using Il2CppDummyDll;
using System;
using System.Diagnostics;

namespace Zenject
{
	[DebuggerStepThrough]
	public class TypeValuePair
	{
		[FieldOffset(Offset="0x10")]
		public System.Type Type;

		[FieldOffset(Offset="0x18")]
		public object Value;

		[Address(RVA="0x233F790", Offset="0x233F790", VA="0x233F790")]
		public TypeValuePair(System.Type type, object value)
		{
		}
	}
}