using Il2CppDummyDll;
using Serverproto;
using System;
using System.Runtime.CompilerServices;

public static class EventExtensions
{
	[FieldOffset(Offset="0x0")]
	public const ulong DEFAULT_BUFFER_WINDOW_S = 2L;

	[Address(RVA="0x1214420", Offset="0x1214420", VA="0x1214420")]
	public static bool HasBegun(Event e, ulong bufferWindowS = 0L)
	{
		return new bool();
	}

	[Address(RVA="0x12144F0", Offset="0x12144F0", VA="0x12144F0")]
	public static bool HasBegun(InfoEvent e, ulong bufferWindowS = 0L)
	{
		return new bool();
	}

	[Address(RVA="0x12145C0", Offset="0x12145C0", VA="0x12145C0")]
	public static bool HasEnded(Event e, ulong bufferWindowS = 0L)
	{
		return new bool();
	}

	[Address(RVA="0x12146C0", Offset="0x12146C0", VA="0x12146C0")]
	public static bool HasEnded(InfoEvent e, ulong bufferWindowS = 0L)
	{
		return new bool();
	}

	[Address(RVA="0x1214818", Offset="0x1214818", VA="0x1214818")]
	public static bool HasExpired(EventStatus es, ulong bufferWindowS = 0L)
	{
		return new bool();
	}

	[Address(RVA="0x1214790", Offset="0x1214790", VA="0x1214790")]
	public static bool IsActive(Event e, ulong startBufferWindowS = 0L, ulong endBufferWindowS = 0L)
	{
		return new bool();
	}

	[Address(RVA="0x12147D4", Offset="0x12147D4", VA="0x12147D4")]
	public static bool IsActive(InfoEvent e, ulong startBufferWindowS = 0L, ulong endBufferWindowS = 0L)
	{
		return new bool();
	}
}