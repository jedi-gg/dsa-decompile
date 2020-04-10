using Il2CppDummyDll;
using System;

public class TimeSync
{
	[FieldOffset(Offset="0x10")]
	private DateTime _syncTimeUtc;

	[FieldOffset(Offset="0x18")]
	private float _syncedTimestamp;

	public DateTime RealTimeUtc
	{
		[Address(RVA="0x1326BEC", Offset="0x1326BEC", VA="0x1326BEC")]
		get
		{
			return new DateTime();
		}
	}

	[Address(RVA="0x1326CCC", Offset="0x1326CCC", VA="0x1326CCC")]
	public TimeSync(ulong syncTime)
	{
	}
}