using Glunies;
using Il2CppDummyDll;
using System;

public class UnitStatsDescriptionController : APressedPopupController<UnitStatsDescriptionView>, IDispatchHandler<DUnitStatListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105F890", Offset="0x105F890")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[Address(RVA="0x1513BA8", Offset="0x1513BA8", VA="0x1513BA8")]
	public UnitStatsDescriptionController()
	{
	}

	[Address(RVA="0x1513A30", Offset="0x1513A30", VA="0x1513A30", Slot="6")]
	public void HandleDispatchAction(DUnitStatListItemAction action)
	{
	}

	[Address(RVA="0x1513940", Offset="0x1513940", VA="0x1513940", Slot="4")]
	public override void Initialize(Action completed)
	{
	}

	[Address(RVA="0x15139C0", Offset="0x15139C0", VA="0x15139C0", Slot="5")]
	public override void Shutdown()
	{
	}
}