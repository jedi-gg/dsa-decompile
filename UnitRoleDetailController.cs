using Glunies;
using Il2CppDummyDll;
using System;

public class UnitRoleDetailController : APressedPopupController<UnitRoleDetailView>, IDispatchHandler<DUnitRoleDetailAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105F780", Offset="0x105F780")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x105F790", Offset="0x105F790")]
	[FieldOffset(Offset="0x30")]
	private GamedataDomainController _gamedataDC;

	[Address(RVA="0x150CAC4", Offset="0x150CAC4", VA="0x150CAC4")]
	public UnitRoleDetailController()
	{
	}

	[Address(RVA="0x150C66C", Offset="0x150C66C", VA="0x150C66C", Slot="6")]
	public void HandleDispatchAction(DUnitRoleDetailAction action)
	{
	}

	[Address(RVA="0x150C57C", Offset="0x150C57C", VA="0x150C57C", Slot="4")]
	public override void Initialize(Action completed)
	{
	}

	[Address(RVA="0x150C5FC", Offset="0x150C5FC", VA="0x150C5FC", Slot="5")]
	public override void Shutdown()
	{
	}
}