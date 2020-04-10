using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class AlertTextController : IAssetDependentLifecycleObject, IDispatchHandler<DAlertTextAnimationCompletedAction>, IDispatchHandler, IDispatchHandler<DAlertTextHideAction>, IDispatchHandler<DAlertTextAction>, IDispatchHandler<DAlertTextSequenceAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1052550", Offset="0x1052550")]
	[FieldOffset(Offset="0x10")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1052560", Offset="0x1052560")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x20")]
	private AlertTextView _view;

	[FieldOffset(Offset="0x28")]
	private List<string> _sequenceText;

	[FieldOffset(Offset="0x30")]
	private DAlertTextViewConfig _sequenceConfig;

	[FieldOffset(Offset="0x38")]
	private bool _isShutdown;

	[Address(RVA="0x11599AC", Offset="0x11599AC", VA="0x11599AC")]
	public AlertTextController()
	{
	}

	[Address(RVA="0x1159240", Offset="0x1159240", VA="0x1159240", Slot="8")]
	public void HandleDispatchAction(DAlertTextAnimationCompletedAction action)
	{
	}

	[Address(RVA="0x11596A0", Offset="0x11596A0", VA="0x11596A0", Slot="9")]
	public void HandleDispatchAction(DAlertTextHideAction action)
	{
	}

	[Address(RVA="0x1159734", Offset="0x1159734", VA="0x1159734", Slot="10")]
	public void HandleDispatchAction(DAlertTextAction action)
	{
	}

	[Address(RVA="0x115983C", Offset="0x115983C", VA="0x115983C", Slot="11")]
	public void HandleDispatchAction(DAlertTextSequenceAction action)
	{
	}

	[Address(RVA="0x1159094", Offset="0x1159094", VA="0x1159094", Slot="4")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x11599A4", Offset="0x11599A4", VA="0x11599A4")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x1159098", Offset="0x1159098", VA="0x1159098", Slot="6")]
	public void LoadAssets(Action finished)
	{
	}

	[Address(RVA="0x11591CC", Offset="0x11591CC", VA="0x11591CC", Slot="7")]
	public void ReleaseAssets()
	{
	}

	[Address(RVA="0x11591C0", Offset="0x11591C0", VA="0x11591C0", Slot="5")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AE5C", Offset="0x104AE5C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public AlertTextController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1159238", Offset="0x1159238", VA="0x1159238")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1159A20", Offset="0x1159A20", VA="0x1159A20")]
		internal void <LoadAssets>b__0(AlertTextView view)
		{
		}
	}
}