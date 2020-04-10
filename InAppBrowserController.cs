using Glunies;
using Il2CppDummyDll;
using System;

public class InAppBrowserController : AFeatureController, IDispatchHandler<DInAppBrowserAction>, IDispatchHandler, IDispatchHandler<DViewShownAction>, IDispatchHandler<DViewHiddenAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10590E8", Offset="0x10590E8")]
	[FieldOffset(Offset="0x68")]
	private SystemDialogManager _systemDialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x10590F8", Offset="0x10590F8")]
	[FieldOffset(Offset="0x70")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x78")]
	private InAppBrowserPlaceholderView _view;

	[FieldOffset(Offset="0x80")]
	private InAppBrowserGameState.TransitionContext _browserContext;

	[Address(RVA="0x117D750", Offset="0x117D750", VA="0x117D750")]
	public InAppBrowserController()
	{
	}

	[Address(RVA="0x117D9C0", Offset="0x117D9C0", VA="0x117D9C0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FE54", Offset="0x106FE54")]
	private void <HandleDispatchAction>g__ErrorAcknowledged|1_0()
	{
	}

	[Address(RVA="0x117D758", Offset="0x117D758", VA="0x117D758")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FE44", Offset="0x106FE44")]
	private void <Initialize>b__0_0(InAppBrowserPlaceholderView view)
	{
	}

	[Address(RVA="0x117D3FC", Offset="0x117D3FC", VA="0x117D3FC", Slot="13")]
	public void HandleDispatchAction(DInAppBrowserAction action)
	{
	}

	[Address(RVA="0x117D504", Offset="0x117D504", VA="0x117D504", Slot="14")]
	public void HandleDispatchAction(DViewShownAction action)
	{
	}

	[Address(RVA="0x117D6A4", Offset="0x117D6A4", VA="0x117D6A4", Slot="15")]
	public void HandleDispatchAction(DViewHiddenAction action)
	{
	}

	[Address(RVA="0x117D310", Offset="0x117D310", VA="0x117D310", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}
}