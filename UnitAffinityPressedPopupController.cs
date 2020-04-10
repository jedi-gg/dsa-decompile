using Glunies;
using Il2CppDummyDll;
using System;

public class UnitAffinityPressedPopupController : APressedPopupController<UnitAffinityPressedPopupView>, IDispatchHandler<DShowUnitAffinityPressedPopupAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105F1C8", Offset="0x105F1C8")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[Address(RVA="0x11DED44", Offset="0x11DED44", VA="0x11DED44")]
	public UnitAffinityPressedPopupController()
	{
	}

	[Address(RVA="0x11DECA0", Offset="0x11DECA0", VA="0x11DECA0", Slot="6")]
	public void HandleDispatchAction(DShowUnitAffinityPressedPopupAction action)
	{
	}

	[Address(RVA="0x11DEBB0", Offset="0x11DEBB0", VA="0x11DEBB0", Slot="4")]
	public override void Initialize(Action completed)
	{
	}

	[Address(RVA="0x11DEC30", Offset="0x11DEC30", VA="0x11DEC30", Slot="5")]
	public override void Shutdown()
	{
	}
}