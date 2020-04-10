using Glunies;
using Il2CppDummyDll;
using System;

public abstract class APressedPopupController<T>
where T : APressedPopupView, new()
{
	[Attribute(Name="InjectAttribute", RVA="0x105BB60", Offset="0x105BB60")]
	[FieldOffset(Offset="0x0")]
	private ViewController _viewController;

	[FieldOffset(Offset="0x0")]
	protected APressedPopupView _view;

	[FieldOffset(Offset="0x0")]
	private bool _isShutdown;

	[Address(RVA="0x211EF38", Offset="0x211EF38", VA="0x211EF38")]
	protected APressedPopupController()
	{
	}

	[Address(RVA="0x211ED00", Offset="0x211ED00", VA="0x211ED00", Slot="4")]
	public virtual void Initialize(Action completed)
	{
	}

	[Address(RVA="0x211EF30", Offset="0x211EF30", VA="0x211EF30")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x211EE6C", Offset="0x211EE6C", VA="0x211EE6C", Slot="5")]
	public virtual void Shutdown()
	{
	}

	[Address(RVA="0x211EEBC", Offset="0x211EEBC", VA="0x211EEBC")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C7DC", Offset="0x104C7DC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x0")]
		public APressedPopupController<T> <>4__this;

		[FieldOffset(Offset="0x0")]
		public Action completed;

		[Address(RVA="0x211EC7C", Offset="0x211EC7C", VA="0x211EC7C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x211ECA8", Offset="0x211ECA8", VA="0x211ECA8")]
		internal void <Initialize>b__0(T view)
		{
		}
	}
}