using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;

public class PassportSeasonUpgradePreviewController : APopupController, IDispatchHandler<DPassportSeasonUpgradePreviewViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105B1D4", Offset="0x105B1D4")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105B1E4", Offset="0x105B1E4")]
	[FieldOffset(Offset="0x40")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x48")]
	private PassportSeasonUpgradePreviewController.Context _context;

	[Address(RVA="0x1409084", Offset="0x1409084", VA="0x1409084")]
	public PassportSeasonUpgradePreviewController()
	{
	}

	[Address(RVA="0x1408E3C", Offset="0x1408E3C", VA="0x1408E3C", Slot="14")]
	public void HandleDispatchAction(DPassportSeasonUpgradePreviewViewAction action)
	{
	}

	[Address(RVA="0x1408BC0", Offset="0x1408BC0", VA="0x1408BC0", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C5BC", Offset="0x104C5BC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PassportSeason? season;

		[FieldOffset(Offset="0x28")]
		public Action completed;

		[Address(RVA="0x1408E34", Offset="0x1408E34", VA="0x1408E34")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x140908C", Offset="0x140908C", VA="0x140908C")]
		internal void <Initialize>b__0(PassportSeasonUpgradePreviewView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public long? TelemetryRefId;

		[Address(RVA="0x1408770", Offset="0x1408770", VA="0x1408770")]
		public Context(long revSdkLogEventRefId)
		{
		}
	}
}