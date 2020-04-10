using Il2CppDummyDll;
using Serverproto;
using System;

public class StoreUtility
{
	[Attribute(Name="InjectAttribute", RVA="0x105D238", Offset="0x105D238")]
	[FieldOffset(Offset="0x10")]
	private StoreDomainController _storeDc;

	[Attribute(Name="InjectAttribute", RVA="0x105D248", Offset="0x105D248")]
	[FieldOffset(Offset="0x18")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105D258", Offset="0x105D258")]
	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDc;

	[Address(RVA="0x13176E8", Offset="0x13176E8", VA="0x13176E8")]
	public StoreUtility()
	{
	}

	[Address(RVA="0x1316EF0", Offset="0x1316EF0", VA="0x1316EF0")]
	public int GetBadgeCountForTab(StoreTab tab)
	{
		return new int();
	}

	[Address(RVA="0x1316C5C", Offset="0x1316C5C", VA="0x1316C5C")]
	public int GetStoreBadgeCount()
	{
		return new int();
	}

	[Address(RVA="0x131716C", Offset="0x131716C", VA="0x131716C")]
	public bool ShouldBadgeStoreItem(StoreItem item)
	{
		return new bool();
	}
}