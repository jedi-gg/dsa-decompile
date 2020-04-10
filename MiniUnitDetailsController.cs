using Glunies;
using Il2CppDummyDll;
using System;

public class MiniUnitDetailsController : APressedPopupController<MiniUnitDetailsView>, IDispatchHandler<DMiniUnitDetailsShowEnemyPreview>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105A774", Offset="0x105A774")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[Address(RVA="0x12F3DEC", Offset="0x12F3DEC", VA="0x12F3DEC")]
	public MiniUnitDetailsController()
	{
	}

	[Address(RVA="0x12F3598", Offset="0x12F3598", VA="0x12F3598", Slot="6")]
	public void HandleDispatchAction(DMiniUnitDetailsShowEnemyPreview action)
	{
	}

	[Address(RVA="0x12F34A8", Offset="0x12F34A8", VA="0x12F34A8", Slot="4")]
	public override void Initialize(Action completed)
	{
	}

	[Address(RVA="0x12F3528", Offset="0x12F3528", VA="0x12F3528", Slot="5")]
	public override void Shutdown()
	{
	}
}