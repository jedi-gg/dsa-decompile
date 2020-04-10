using Il2CppDummyDll;
using System;

public static class AutoBattle
{
	[FieldOffset(Offset="0x0")]
	public static float[] s_timeScale;

	[Address(RVA="0x115E700", Offset="0x115E700", VA="0x115E700")]
	static AutoBattle()
	{
	}

	public enum Speed
	{
		[FieldOffset(Offset="0x0")]
		Low,
		[FieldOffset(Offset="0x0")]
		Medium,
		[FieldOffset(Offset="0x0")]
		High,
		[FieldOffset(Offset="0x0")]
		Insane,
		[FieldOffset(Offset="0x0")]
		NUM_SPEEDS
	}
}