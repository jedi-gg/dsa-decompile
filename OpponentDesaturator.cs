using BattleLib;
using Glunies;
using Il2CppDummyDll;
using System;

public class OpponentDesaturator : IDispatchHandler<DBattleUnitsControllerAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x10543F0", Offset="0x10543F0")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1054400", Offset="0x1054400")]
	[FieldOffset(Offset="0x18")]
	private ABattle _battle;

	[Address(RVA="0x12FF9D4", Offset="0x12FF9D4", VA="0x12FF9D4")]
	public OpponentDesaturator()
	{
	}

	[Address(RVA="0x12FF9D0", Offset="0x12FF9D0", VA="0x12FF9D0", Slot="4")]
	public void HandleDispatchAction(DBattleUnitsControllerAction action)
	{
	}

	[Address(RVA="0x12FF960", Offset="0x12FF960", VA="0x12FF960")]
	public void Initialize()
	{
	}

	[Address(RVA="0x12FF998", Offset="0x12FF998", VA="0x12FF998")]
	public void Shutdown()
	{
	}
}