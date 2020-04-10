using Glunies;
using Il2CppDummyDll;
using System;

public class ScrimController : IDispatchHandler<DShowScrimAction>, IDispatchHandler, IDispatchHandler<DHideScrimsAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105C1C0", Offset="0x105C1C0")]
	[FieldOffset(Offset="0x10")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x105C1D0", Offset="0x105C1D0")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x20")]
	private LoadingScrimView _loadingScrimView;

	[FieldOffset(Offset="0x28")]
	private BackdropScrimView _backdropScrimView;

	[FieldOffset(Offset="0x30")]
	private bool _isShutdown;

	[Address(RVA="0x2C3FD30", Offset="0x2C3FD30", VA="0x2C3FD30")]
	public ScrimController()
	{
	}

	[Address(RVA="0x2C3FB34", Offset="0x2C3FB34", VA="0x2C3FB34", Slot="4")]
	public void HandleDispatchAction(DShowScrimAction action)
	{
	}

	[Address(RVA="0x2C3FC50", Offset="0x2C3FC50", VA="0x2C3FC50", Slot="5")]
	public void HandleDispatchAction(DHideScrimsAction action)
	{
	}

	[Address(RVA="0x2C3F914", Offset="0x2C3F914", VA="0x2C3F914")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x2C3FD28", Offset="0x2C3FD28", VA="0x2C3FD28")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x2C3FA98", Offset="0x2C3FA98", VA="0x2C3FA98")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C90C", Offset="0x104C90C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ScrimController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x2C3FA90", Offset="0x2C3FA90", VA="0x2C3FA90")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x2C3FD38", Offset="0x2C3FD38", VA="0x2C3FD38")]
		internal void <Initialize>b__0(Action executed)
		{
		}

		[Address(RVA="0x2C3FE7C", Offset="0x2C3FE7C", VA="0x2C3FE7C")]
		internal void <Initialize>b__1(Action executed)
		{
		}

		[Address(RVA="0x2C3FFC0", Offset="0x2C3FFC0", VA="0x2C3FFC0")]
		internal void <Initialize>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C91C", Offset="0x104C91C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public ScrimController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x2C3FE74", Offset="0x2C3FE74", VA="0x2C3FE74")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x2C40028", Offset="0x2C40028", VA="0x2C40028")]
		internal void <Initialize>b__3(BackdropScrimView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C92C", Offset="0x104C92C")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public ScrimController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x2C3FFB8", Offset="0x2C3FFB8", VA="0x2C3FFB8")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x2C40090", Offset="0x2C40090", VA="0x2C40090")]
		internal void <Initialize>b__4(LoadingScrimView view)
		{
		}
	}
}