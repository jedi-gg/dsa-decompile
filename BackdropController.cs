using Glunies;
using Il2CppDummyDll;
using System;

public class BackdropController
{
	[Attribute(Name="InjectAttribute", RVA="0x1052760", Offset="0x1052760")]
	[FieldOffset(Offset="0x10")]
	private ViewController _viewController;

	[FieldOffset(Offset="0x18")]
	private BackdropView _view;

	[FieldOffset(Offset="0x20")]
	private bool _isShutdown;

	[Address(RVA="0x115EFA8", Offset="0x115EFA8", VA="0x115EFA8")]
	public BackdropController()
	{
	}

	[Address(RVA="0x115EB8C", Offset="0x115EB8C", VA="0x115EB8C")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x115EFA0", Offset="0x115EFA0", VA="0x115EFA0")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x115EF88", Offset="0x115EF88", VA="0x115EF88")]
	public void Show(bool show)
	{
	}

	[Address(RVA="0x115ECBC", Offset="0x115ECBC", VA="0x115ECBC")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x115ED0C", Offset="0x115ED0C", VA="0x115ED0C")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AEFC", Offset="0x104AEFC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public BackdropController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x115ECB4", Offset="0x115ECB4", VA="0x115ECB4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x115EFB0", Offset="0x115EFB0", VA="0x115EFB0")]
		internal void <Initialize>b__0(BackdropView view)
		{
		}
	}
}