using Glunies;
using Il2CppDummyDll;
using System;

public class PassportSeasonPreviewController : AFeatureController, IDispatchHandler<DPassportSeasonPreviewViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105B1A4", Offset="0x105B1A4")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105B1B4", Offset="0x105B1B4")]
	[FieldOffset(Offset="0x70")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x78")]
	private PassportSeasonPreviewView _view;

	[Address(RVA="0x1405F88", Offset="0x1405F88", VA="0x1405F88")]
	public PassportSeasonPreviewController()
	{
	}

	[Address(RVA="0x1405F2C", Offset="0x1405F2C", VA="0x1405F2C", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x1405DF0", Offset="0x1405DF0", VA="0x1405DF0", Slot="13")]
	public void HandleDispatchAction(DPassportSeasonPreviewViewAction action)
	{
	}

	[Address(RVA="0x1405C94", Offset="0x1405C94", VA="0x1405C94", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1405D98", Offset="0x1405D98", VA="0x1405D98", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C5AC", Offset="0x104C5AC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PassportSeasonPreviewController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x1405D90", Offset="0x1405D90", VA="0x1405D90")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1405F90", Offset="0x1405F90", VA="0x1405F90")]
		internal void <Initialize>b__0(PassportSeasonPreviewView view)
		{
		}
	}
}