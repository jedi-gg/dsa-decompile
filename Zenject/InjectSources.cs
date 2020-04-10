using Il2CppDummyDll;
using System;

namespace Zenject
{
	public enum InjectSources
	{
		[FieldOffset(Offset="0x0")]
		Any,
		[FieldOffset(Offset="0x0")]
		Local,
		[FieldOffset(Offset="0x0")]
		Parent,
		[FieldOffset(Offset="0x0")]
		AnyParent
	}
}