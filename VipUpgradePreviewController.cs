using Glunies;
using Il2CppDummyDll;
using System;

public class VipUpgradePreviewController : APopupController, IDispatchHandler<DVipUpgradePreviewViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105FB40", Offset="0x105FB40")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105FB50", Offset="0x105FB50")]
	[FieldOffset(Offset="0x40")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x48")]
	private VipUpgradePreviewController.Context _context;

	public override bool ShouldBeRestoredFromHistory
	{
		[Address(RVA="0x15A4020", Offset="0x15A4020", VA="0x15A4020", Slot="7")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x15A4530", Offset="0x15A4530", VA="0x15A4530")]
	public VipUpgradePreviewController()
	{
	}

	[Address(RVA="0x15A43B8", Offset="0x15A43B8", VA="0x15A43B8", Slot="13")]
	protected override void ControllerClosing()
	{
	}

	[Address(RVA="0x15A44B4", Offset="0x15A44B4", VA="0x15A44B4")]
	private string ConvertSourceToString()
	{
		return null;
	}

	[Address(RVA="0x15A43B0", Offset="0x15A43B0", VA="0x15A43B0", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x15A41B8", Offset="0x15A41B8", VA="0x15A41B8", Slot="14")]
	public void HandleDispatchAction(DVipUpgradePreviewViewAction action)
	{
	}

	[Address(RVA="0x15A4028", Offset="0x15A4028", VA="0x15A4028", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x15A42B8", Offset="0x15A42B8", VA="0x15A42B8")]
	private void SendBuyClickTelemetry()
	{
	}

	[Address(RVA="0x15A43BC", Offset="0x15A43BC", VA="0x15A43BC")]
	private void SendCloseWindowTelemetry()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D22C", Offset="0x104D22C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[Address(RVA="0x15A41B0", Offset="0x15A41B0", VA="0x15A41B0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x15A4538", Offset="0x15A4538", VA="0x15A4538")]
		internal void <Initialize>b__0(VipUpgradePreviewView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public VipUpgradePreviewController.Source TriggerSource;

		[Address(RVA="0x15A4568", Offset="0x15A4568", VA="0x15A4568")]
		public Context(VipUpgradePreviewController.Source triggerSource)
		{
		}
	}

	public enum Source
	{
		[FieldOffset(Offset="0x0")]
		Invalid,
		[FieldOffset(Offset="0x0")]
		PveEnergy,
		[FieldOffset(Offset="0x0")]
		GrandEnergy,
		[FieldOffset(Offset="0x0")]
		HardAttempts,
		[FieldOffset(Offset="0x0")]
		ClubDungeon,
		[FieldOffset(Offset="0x0")]
		DailyEvents,
		[FieldOffset(Offset="0x0")]
		Tower,
		[FieldOffset(Offset="0x0")]
		Shipments,
		[FieldOffset(Offset="0x0")]
		DailyLogin,
		[FieldOffset(Offset="0x0")]
		Store,
		[FieldOffset(Offset="0x0")]
		Home,
		[FieldOffset(Offset="0x0")]
		PvpLobby,
		[FieldOffset(Offset="0x0")]
		InventoryItemDetails,
		[FieldOffset(Offset="0x0")]
		DailyActivity,
		[FieldOffset(Offset="0x0")]
		SavedSquads
	}
}