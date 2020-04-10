using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class InstantBattleRewardsController : APopupController, IDispatchHandler<DInstantBattleRewardsViewAction>, IDispatchHandler, IDispatchHandler<DPopupControllerAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1059408", Offset="0x1059408")]
	[FieldOffset(Offset="0x38")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x1059418", Offset="0x1059418")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1059428", Offset="0x1059428")]
	[FieldOffset(Offset="0x48")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x1059438", Offset="0x1059438")]
	[FieldOffset(Offset="0x50")]
	private CampaignUtility _campaignUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1059448", Offset="0x1059448")]
	[FieldOffset(Offset="0x58")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1059458", Offset="0x1059458")]
	[FieldOffset(Offset="0x60")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x1059468", Offset="0x1059468")]
	[FieldOffset(Offset="0x68")]
	private RevSdkController _revSdk;

	[FieldOffset(Offset="0x70")]
	private InstantBattleRewardsController.AContext _context;

	[FieldOffset(Offset="0x78")]
	private InstantBattleRewardsView _view;

	[Address(RVA="0x1369D18", Offset="0x1369D18", VA="0x1369D18")]
	public InstantBattleRewardsController()
	{
	}

	[Address(RVA="0x1369D20", Offset="0x1369D20", VA="0x1369D20")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FF44", Offset="0x106FF44")]
	private void <HandleDispatchAction>b__1_1(long failureCode)
	{
	}

	[Address(RVA="0x13694C0", Offset="0x13694C0", VA="0x13694C0", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x13690C0", Offset="0x13690C0", VA="0x13690C0", Slot="14")]
	public void HandleDispatchAction(DInstantBattleRewardsViewAction action)
	{
	}

	[Address(RVA="0x136936C", Offset="0x136936C", VA="0x136936C", Slot="15")]
	public void HandleDispatchAction(DPopupControllerAction action)
	{
	}

	[Address(RVA="0x1368EE0", Offset="0x1368EE0", VA="0x1368EE0", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x13699F0", Offset="0x13699F0", VA="0x13699F0")]
	private void SendInstantBattleTelemetry(InstantBattleRequest request, InstantBattleResponse response)
	{
	}

	[Address(RVA="0x13694C8", Offset="0x13694C8", VA="0x13694C8")]
	private void ShowViewData()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C18C", Offset="0x104C18C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public InstantBattleRewardsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x13690B8", Offset="0x13690B8", VA="0x13690B8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1369D84", Offset="0x1369D84", VA="0x1369D84")]
		internal void <Initialize>b__0(InstantBattleRewardsView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C19C", Offset="0x104C19C")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset="0x10")]
		public InstantBattleRequest request;

		[FieldOffset(Offset="0x18")]
		public InstantBattleRewardsController <>4__this;

		[Address(RVA="0x1369364", Offset="0x1369364", VA="0x1369364")]
		public <>c__DisplayClass1_0()
		{
		}

		[Address(RVA="0x1369DF0", Offset="0x1369DF0", VA="0x1369DF0")]
		internal void <HandleDispatchAction>b__0(InstantBattleResponse response)
		{
		}
	}

	public abstract class AContext : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public InventoryDelta InventoryDelta;

		[Address(RVA="0x1369EE8", Offset="0x1369EE8", VA="0x1369EE8")]
		public AContext(InventoryDelta inventoryDelta)
		{
		}
	}

	public class CampaignContext : InstantBattleRewardsController.AContext
	{
		[FieldOffset(Offset="0x18")]
		public readonly CampaignIdentifier CampaignIdentifier;

		[FieldOffset(Offset="0x20")]
		public readonly Gamedata.BattleNode? BattleNode;

		[Address(RVA="0x1368A04", Offset="0x1368A04", VA="0x1368A04")]
		public CampaignContext(InventoryDelta inventoryDelta, Gamedata.BattleNode? battleNode, CampaignIdentifier campaignIdentifier)
		{
		}
	}

	public class EventContext : InstantBattleRewardsController.AContext
	{
		[Address(RVA="0x1368C84", Offset="0x1368C84", VA="0x1368C84")]
		public EventContext(InventoryDelta inventoryDelta)
		{
		}
	}

	public class TowerAutoWinContext : InstantBattleRewardsController.AContext
	{
		[Address(RVA="0x1369F14", Offset="0x1369F14", VA="0x1369F14")]
		public TowerAutoWinContext(InventoryDelta inventoryDelta)
		{
		}
	}
}