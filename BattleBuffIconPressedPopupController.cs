using Glunies;
using Il2CppDummyDll;
using System;

public class BattleBuffIconPressedPopupController : APressedPopupController<BattleBuffIconPressedPopupView>, IDispatchHandler<DShowBattleBuffIconPressedPopupAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105479C", Offset="0x105479C")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[Address(RVA="0x1137D48", Offset="0x1137D48", VA="0x1137D48")]
	public BattleBuffIconPressedPopupController()
	{
	}

	[Address(RVA="0x1137AB4", Offset="0x1137AB4", VA="0x1137AB4", Slot="6")]
	public void HandleDispatchAction(DShowBattleBuffIconPressedPopupAction action)
	{
	}

	[Address(RVA="0x11379C4", Offset="0x11379C4", VA="0x11379C4", Slot="4")]
	public override void Initialize(Action completed)
	{
	}

	[Address(RVA="0x1137A44", Offset="0x1137A44", VA="0x1137A44", Slot="5")]
	public override void Shutdown()
	{
	}
}