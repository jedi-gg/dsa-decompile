using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum ContextualMessageType : sbyte
	{
		[FieldOffset(Offset="0x0")]
		PointAt,
		[FieldOffset(Offset="0x0")]
		SimpleMessage,
		[FieldOffset(Offset="0x0")]
		DialogOneButton,
		[FieldOffset(Offset="0x0")]
		DialogTwoButton
	}
}