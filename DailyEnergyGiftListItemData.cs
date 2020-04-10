using Il2CppDummyDll;
using System;

public class DailyEnergyGiftListItemData
{
	[FieldOffset(Offset="0x10")]
	public ulong EnergyItemId;

	[FieldOffset(Offset="0x18")]
	public string NameKey;

	[FieldOffset(Offset="0x20")]
	public string DescKey;

	[FieldOffset(Offset="0x28")]
	public ulong GiftAmount;

	[FieldOffset(Offset="0x30")]
	public DateTime StartTimeUtc;

	[FieldOffset(Offset="0x38")]
	public DateTime ExpireTimeUtc;

	public bool ReadyToBeClaimed
	{
		[Address(RVA="0x12AC478", Offset="0x12AC478", VA="0x12AC478")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x12AC598", Offset="0x12AC598", VA="0x12AC598")]
	public DailyEnergyGiftListItemData()
	{
	}
}