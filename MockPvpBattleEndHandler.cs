using BattleLib;
using Il2CppDummyDll;
using Serverproto;
using System;

public class MockPvpBattleEndHandler : IBattleEndHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105A7A4", Offset="0x105A7A4")]
	[FieldOffset(Offset="0x10")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x105A7B4", Offset="0x105A7B4")]
	[FieldOffset(Offset="0x18")]
	private BattleHandler _battleHandler;

	[Address(RVA="0x12F42BC", Offset="0x12F42BC", VA="0x12F42BC")]
	public MockPvpBattleEndHandler()
	{
	}

	[Address(RVA="0x12F4104", Offset="0x12F4104", VA="0x12F4104")]
	private void EndBattle(bool win, BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason, bool delayExit)
	{
	}

	[Address(RVA="0x12F4074", Offset="0x12F4074", VA="0x12F4074", Slot="4")]
	public void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded)
	{
	}

	[Address(RVA="0x12F42AC", Offset="0x12F42AC", VA="0x12F42AC", Slot="5")]
	public void HandleBattleQuit()
	{
	}
}