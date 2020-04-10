using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum BattleMessageType : sbyte
	{
		[FieldOffset(Offset="0x0")]
		PointAt,
		[FieldOffset(Offset="0x0")]
		SimpleMessage
	}
}