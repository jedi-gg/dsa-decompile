using Il2CppDummyDll;
using System;

public struct DTowerViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DTowerViewAction.Type ActionType;

	[Address(RVA="0xEFFAFC", Offset="0xEFFAFC", VA="0xEFFAFC")]
	public DTowerViewAction(DTowerViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		ShowShipments,
		[FieldOffset(Offset="0x0")]
		RefreshTower,
		[FieldOffset(Offset="0x0")]
		AutoWinTower,
		[FieldOffset(Offset="0x0")]
		ClaimProgressionLoot,
		[FieldOffset(Offset="0x0")]
		NextTower
	}
}