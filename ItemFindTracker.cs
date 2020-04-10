using Glunies;
using Il2CppDummyDll;
using System;

public class ItemFindTracker : IDispatchHandler<DCacheItemFindIdAction>, IDispatchHandler, IDispatchHandler<DClearItemFindIdAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105A19C", Offset="0x105A19C")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x105A1AC", Offset="0x105A1AC")]
	[FieldOffset(Offset="0x18")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0x20")]
	private ulong _itemId;

	[FieldOffset(Offset="0x28")]
	private long _goalCount;

	public long GoalCount
	{
		[Address(RVA="0x11C6D0C", Offset="0x11C6D0C", VA="0x11C6D0C")]
		get
		{
			return new long();
		}
	}

	public ulong ItemId
	{
		[Address(RVA="0x11C6D04", Offset="0x11C6D04", VA="0x11C6D04")]
		get
		{
			return new ulong();
		}
	}

	[Address(RVA="0x11C6E4C", Offset="0x11C6E4C", VA="0x11C6E4C")]
	public ItemFindTracker()
	{
	}

	[Address(RVA="0x11C6D84", Offset="0x11C6D84", VA="0x11C6D84", Slot="4")]
	public void HandleDispatchAction(DCacheItemFindIdAction action)
	{
	}

	[Address(RVA="0x11C6E44", Offset="0x11C6E44", VA="0x11C6E44", Slot="5")]
	public void HandleDispatchAction(DClearItemFindIdAction action)
	{
	}

	[Address(RVA="0x11C6D14", Offset="0x11C6D14", VA="0x11C6D14")]
	public void Initialize()
	{
	}

	[Address(RVA="0x11C6D4C", Offset="0x11C6D4C", VA="0x11C6D4C")]
	public void Shutdown()
	{
	}
}