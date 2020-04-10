using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum UnitType : sbyte
	{
		[FieldOffset(Offset="0x0")]
		Standard,
		[FieldOffset(Offset="0x0")]
		SpawnedAdd,
		[FieldOffset(Offset="0x0")]
		Boss,
		[FieldOffset(Offset="0x0")]
		Building,
		[FieldOffset(Offset="0x0")]
		Clone
	}
}