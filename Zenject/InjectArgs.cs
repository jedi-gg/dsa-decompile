using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class InjectArgs
	{
		[FieldOffset(Offset="0x10")]
		public List<TypeValuePair> ExtraArgs;

		[FieldOffset(Offset="0x18")]
		public InjectContext Context;

		[FieldOffset(Offset="0x20")]
		public object ConcreteIdentifier;

		[Address(RVA="0x1839AA4", Offset="0x1839AA4", VA="0x1839AA4")]
		public InjectArgs()
		{
		}
	}
}