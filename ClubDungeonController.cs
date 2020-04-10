using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubDungeonController : AFeatureController, IDispatchHandler<DClubDungeonViewAction>, IDispatchHandler, IDispatchHandler<DClubDungeonNodeAction>, IDispatchHandler<DCampaignNodeDetailsViewAction>, IDispatchHandler<DRevSdkPlacementShownAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10568A8", Offset="0x10568A8")]
	[FieldOffset(Offset="0x68")]
	private ClubService _clubService;

	[Attribute(Name="InjectAttribute", RVA="0x10568B8", Offset="0x10568B8")]
	[FieldOffset(Offset="0x70")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x10568C8", Offset="0x10568C8")]
	[FieldOffset(Offset="0x78")]
	private MiniUnitDetailsController _miniUnitDetailsController;

	[Attribute(Name="InjectAttribute", RVA="0x10568D8", Offset="0x10568D8")]
	[FieldOffset(Offset="0x80")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x10568E8", Offset="0x10568E8")]
	[FieldOffset(Offset="0x88")]
	private LocalizationManager _locManager;

	[Attribute(Name="InjectAttribute", RVA="0x10568F8", Offset="0x10568F8")]
	[FieldOffset(Offset="0x90")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1056908", Offset="0x1056908")]
	[FieldOffset(Offset="0x98")]
	private ChatPreviewController _chatPreviewController;

	[Attribute(Name="InjectAttribute", RVA="0x1056918", Offset="0x1056918")]
	[FieldOffset(Offset="0xA0")]
	private HomeServiceUtility _homeServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1056928", Offset="0x1056928")]
	[FieldOffset(Offset="0xA8")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0xB0")]
	private ClubDungeonView _dungeonView;

	[FieldOffset(Offset="0xB8")]
	private CampaignNodeDetailsView _nodeDetailsView;

	[FieldOffset(Offset="0xC0")]
	private ClubDungeonContext _dungeonContext;

	[FieldOffset(Offset="0xC8")]
	private ulong? _selectedNodeId;

	[Address(RVA="0x11AAFC8", Offset="0x11AAFC8", VA="0x11AAFC8")]
	public ClubDungeonController()
	{
	}

	[Address(RVA="0x11AB02C", Offset="0x11AB02C", VA="0x11AB02C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F024", Offset="0x106F024")]
	private void <HandleDispatchAction>b__6_0(ClaimBonusClubDungeonAttemptResponse response)
	{
	}

	[Address(RVA="0x11AB898", Offset="0x11AB898", VA="0x11AB898")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F034", Offset="0x106F034")]
	private void <HandleDispatchAction>b__6_1(long failureCode)
	{
	}

	[Address(RVA="0x11AB93C", Offset="0x11AB93C", VA="0x11AB93C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F044", Offset="0x106F044")]
	private void <HandleDispatchAction>b__6_2()
	{
	}

	[Address(RVA="0x11AB9A0", Offset="0x11AB9A0", VA="0x11AB9A0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F054", Offset="0x106F054")]
	private void <ReloadDungeon>b__15_0()
	{
	}

	[Address(RVA="0x11AAEA4", Offset="0x11AAEA4", VA="0x11AAEA4")]
	private bool CanBattle()
	{
		return new bool();
	}

	[Address(RVA="0x11A9D24", Offset="0x11A9D24", VA="0x11A9D24")]
	private void ClaimBonusAttempt()
	{
	}

	[Address(RVA="0x11AA6E8", Offset="0x11AA6E8", VA="0x11AA6E8", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x11AA150", Offset="0x11AA150", VA="0x11AA150")]
	private void EnterSquadSelect()
	{
	}

	[Address(RVA="0x11A9AC0", Offset="0x11A9AC0", VA="0x11A9AC0", Slot="13")]
	public void HandleDispatchAction(DClubDungeonViewAction action)
	{
	}

	[Address(RVA="0x11A9E00", Offset="0x11A9E00", VA="0x11A9E00", Slot="14")]
	public void HandleDispatchAction(DClubDungeonNodeAction action)
	{
	}

	[Address(RVA="0x11AA144", Offset="0x11AA144", VA="0x11AA144", Slot="15")]
	public void HandleDispatchAction(DCampaignNodeDetailsViewAction action)
	{
	}

	[Address(RVA="0x11AA518", Offset="0x11AA518", VA="0x11AA518", Slot="16")]
	public void HandleDispatchAction(DRevSdkPlacementShownAction action)
	{
	}

	[Address(RVA="0x11A9258", Offset="0x11A9258", VA="0x11A9258", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x11AA798", Offset="0x11AA798", VA="0x11AA798")]
	private void LoadDungeonView(Action finished)
	{
	}

	[Address(RVA="0x11AA87C", Offset="0x11AA87C", VA="0x11AA87C")]
	private void LoadNodeDetailsView(Action finished)
	{
	}

	[Address(RVA="0x11A9960", Offset="0x11A9960", VA="0x11A9960")]
	private void ReloadDungeon()
	{
	}

	[Address(RVA="0x11AA960", Offset="0x11AA960", VA="0x11AA960")]
	private void RequestClub(Action finished)
	{
	}

	[Address(RVA="0x11AACBC", Offset="0x11AACBC", VA="0x11AACBC")]
	private void RequestDungeon(string dungeonId, Action finished)
	{
	}

	[Address(RVA="0x11AAB38", Offset="0x11AAB38", VA="0x11AAB38")]
	private void RequestDungeonStatus(Action finished)
	{
	}

	[Address(RVA="0x11A95EC", Offset="0x11A95EC", VA="0x11A95EC", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x11A96AC", Offset="0x11A96AC", VA="0x11A96AC", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x11AA070", Offset="0x11AA070", VA="0x11AA070")]
	private void ToggleNodeDetails(ClubDungeonNode node)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B89C", Offset="0x104B89C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[FieldOffset(Offset="0x20")]
		public Action <>9__2;

		[Address(RVA="0x11A95E4", Offset="0x11A95E4", VA="0x11A95E4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11AB9F4", Offset="0x11AB9F4", VA="0x11AB9F4")]
		internal void <Initialize>b__0(Action executed)
		{
		}

		[Address(RVA="0x11ABA44", Offset="0x11ABA44", VA="0x11ABA44")]
		internal void <Initialize>b__1()
		{
		}

		[Address(RVA="0x11ABF48", Offset="0x11ABF48", VA="0x11ABF48")]
		internal void <Initialize>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B8CC", Offset="0x104B8CC")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11AAB30", Offset="0x11AAB30", VA="0x11AAB30")]
		public <>c__DisplayClass10_0()
		{
		}

		[Address(RVA="0x11AC18C", Offset="0x11AC18C", VA="0x11AC18C")]
		internal void <RequestClub>b__0(ClubResponse response)
		{
		}

		[Address(RVA="0x11AC210", Offset="0x11AC210", VA="0x11AC210")]
		internal void <RequestClub>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B8DC", Offset="0x104B8DC")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11AACB4", Offset="0x11AACB4", VA="0x11AACB4")]
		public <>c__DisplayClass11_0()
		{
		}

		[Address(RVA="0x11AC2E0", Offset="0x11AC2E0", VA="0x11AC2E0")]
		internal void <RequestDungeonStatus>b__0(ClubDungeonStatusResponse response)
		{
		}

		[Address(RVA="0x11AC39C", Offset="0x11AC39C", VA="0x11AC39C")]
		internal void <RequestDungeonStatus>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B8EC", Offset="0x104B8EC")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11AAE9C", Offset="0x11AAE9C", VA="0x11AAE9C")]
		public <>c__DisplayClass12_0()
		{
		}

		[Address(RVA="0x11AC46C", Offset="0x11AC46C", VA="0x11AC46C")]
		internal void <RequestDungeon>b__0(ClubDungeonResponse response)
		{
		}

		[Address(RVA="0x11AC4F0", Offset="0x11AC4F0", VA="0x11AC4F0")]
		internal void <RequestDungeon>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B8AC", Offset="0x104B8AC")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11AA874", Offset="0x11AA874", VA="0x11AA874")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x11AC5C0", Offset="0x11AC5C0", VA="0x11AC5C0")]
		internal void <LoadDungeonView>b__0(ClubDungeonView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B8BC", Offset="0x104B8BC")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11AA958", Offset="0x11AA958", VA="0x11AA958")]
		public <>c__DisplayClass9_0()
		{
		}

		[Address(RVA="0x11AC618", Offset="0x11AC618", VA="0x11AC618")]
		internal void <LoadNodeDetailsView>b__0(CampaignNodeDetailsView view)
		{
		}
	}
}