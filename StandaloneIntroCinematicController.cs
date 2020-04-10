using Glunies;
using Il2CppDummyDll;
using System;

public class StandaloneIntroCinematicController : AFeatureController, IDispatchHandler<DTitleViewAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x68")]
	private TitleView _view;

	[Address(RVA="0x1227480", Offset="0x1227480", VA="0x1227480")]
	public StandaloneIntroCinematicController()
	{
	}

	[Address(RVA="0x12273F8", Offset="0x12273F8", VA="0x12273F8", Slot="13")]
	public void HandleDispatchAction(DTitleViewAction action)
	{
	}

	[Address(RVA="0x1227264", Offset="0x1227264", VA="0x1227264", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x12273B4", Offset="0x12273B4", VA="0x12273B4", Slot="7")]
	public override void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CC6C", Offset="0x104CC6C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public StandaloneIntroCinematicController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x12273AC", Offset="0x12273AC", VA="0x12273AC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1227488", Offset="0x1227488", VA="0x1227488")]
		internal void <Initialize>b__0(TitleView view)
		{
		}
	}
}