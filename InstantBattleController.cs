using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class InstantBattleController : APopupController, IDispatchHandler<DInstantBattleViewAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	private const uint DEFAULT_MAX_BATTLES = 100;

	[Attribute(Name="InjectAttribute", RVA="0x10593B8", Offset="0x10593B8")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x10593C8", Offset="0x10593C8")]
	[FieldOffset(Offset="0x40")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x10593D8", Offset="0x10593D8")]
	[FieldOffset(Offset="0x48")]
	private CampaignUtility _campaignUtility;

	[Attribute(Name="InjectAttribute", RVA="0x10593E8", Offset="0x10593E8")]
	[FieldOffset(Offset="0x50")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x10593F8", Offset="0x10593F8")]
	[FieldOffset(Offset="0x58")]
	private RevSdkController _revSdk;

	[FieldOffset(Offset="0x60")]
	private ITransitionContext _context;

	[FieldOffset(Offset="0x68")]
	private Gamedata.BattleNode? _battleNode;

	[Address(RVA="0x1186E1C", Offset="0x1186E1C", VA="0x1186E1C")]
	public InstantBattleController()
	{
	}

	[Address(RVA="0x11862EC", Offset="0x11862EC", VA="0x11862EC", Slot="14")]
	public void HandleDispatchAction(DInstantBattleViewAction action)
	{
	}

	[Address(RVA="0x1185F20", Offset="0x1185F20", VA="0x1185F20", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x1186C1C", Offset="0x1186C1C", VA="0x1186C1C")]
	private void SendInstantBattleEventTelemetry(InstantBattleEventRequest request, InstantBattleEventResponse response)
	{
	}

	[Address(RVA="0x11868F4", Offset="0x11868F4", VA="0x11868F4")]
	private void SendInstantBattleTelemetry(InstantBattleRequest request, InstantBattleResponse response)
	{
	}

	[Address(RVA="0x11863D0", Offset="0x11863D0", VA="0x11863D0")]
	private void SimCampaignBattle(ulong numBattles)
	{
	}

	[Address(RVA="0x1186654", Offset="0x1186654", VA="0x1186654")]
	private void SimEventBattle(ulong numBattles)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C15C", Offset="0x104C15C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public Gamedata.InventoryItem? battleEntryCostItem;

		[FieldOffset(Offset="0x28")]
		public uint entryCostCount;

		[FieldOffset(Offset="0x2C")]
		public uint maxBattles;

		[FieldOffset(Offset="0x30")]
		public Action completed;

		[Address(RVA="0x1368350", Offset="0x1368350", VA="0x1368350")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1368358", Offset="0x1368358", VA="0x1368358")]
		internal void <Initialize>b__0(InstantBattleView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C16C", Offset="0x104C16C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public InstantBattleController <>4__this;

		[FieldOffset(Offset="0x18")]
		public InstantBattleRequest request;

		[FieldOffset(Offset="0x20")]
		public InstantBattleController.CampaignContext campaignContext;

		[Address(RVA="0x1368810", Offset="0x1368810", VA="0x1368810")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1368818", Offset="0x1368818", VA="0x1368818")]
		internal void <SimCampaignBattle>b__0(InstantBattleResponse response)
		{
		}

		[Address(RVA="0x1368A50", Offset="0x1368A50", VA="0x1368A50")]
		internal void <SimCampaignBattle>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C17C", Offset="0x104C17C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public InstantBattleController <>4__this;

		[FieldOffset(Offset="0x18")]
		public InstantBattleEventRequest request;

		[FieldOffset(Offset="0x20")]
		public InstantBattleController.EventContext eventContext;

		[Address(RVA="0x1368B08", Offset="0x1368B08", VA="0x1368B08")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x1368B10", Offset="0x1368B10", VA="0x1368B10")]
		internal void <SimEventBattle>b__0(InstantBattleEventResponse response)
		{
		}

		[Address(RVA="0x1368CB0", Offset="0x1368CB0", VA="0x1368CB0")]
		internal void <SimEventBattle>b__1(long failureCode)
		{
		}

		[Address(RVA="0x1368DF0", Offset="0x1368DF0", VA="0x1368DF0")]
		internal void <SimEventBattle>b__2()
		{
		}
	}

	public class CampaignContext : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly CampaignIdentifier CampaignIdentifier;

		[Address(RVA="0x1368E64", Offset="0x1368E64", VA="0x1368E64")]
		public CampaignContext(CampaignIdentifier campaignIdentifier)
		{
		}
	}

	public class EventContext : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly EventIdentifier EventIdentifier;

		[FieldOffset(Offset="0x18")]
		public readonly ulong EntryCostItemId;

		[FieldOffset(Offset="0x20")]
		public readonly uint EntryCostCount;

		[FieldOffset(Offset="0x28")]
		public readonly ulong MaxBattles;

		[Address(RVA="0x1368E90", Offset="0x1368E90", VA="0x1368E90")]
		public EventContext(EventIdentifier eventIdentifier, ulong entryCostItemId, uint entryCostCount, ulong maxBattles)
		{
		}
	}
}