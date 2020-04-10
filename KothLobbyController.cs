using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class KothLobbyController : AFeatureController, IDispatchHandler<DKothLobbyViewAction>, IDispatchHandler, IDispatchHandler<DKothLobbyOpponentAction>, IDispatchHandler<DClubSupportRequestButtonAction>, IDispatchHandler<DRevSdkPlacementShownAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105A3C8", Offset="0x105A3C8")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105A3D8", Offset="0x105A3D8")]
	[FieldOffset(Offset="0x70")]
	private Procrastinator _procrastinator;

	[Attribute(Name="InjectAttribute", RVA="0x105A3E8", Offset="0x105A3E8")]
	[FieldOffset(Offset="0x78")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105A3F8", Offset="0x105A3F8")]
	[FieldOffset(Offset="0x80")]
	private Unit.Factory _unitFactory;

	[Attribute(Name="InjectAttribute", RVA="0x105A408", Offset="0x105A408")]
	[FieldOffset(Offset="0x88")]
	private Spell.Factory _spellFactory;

	[Attribute(Name="InjectAttribute", RVA="0x105A418", Offset="0x105A418")]
	[FieldOffset(Offset="0x90")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105A428", Offset="0x105A428")]
	[FieldOffset(Offset="0x98")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x105A438", Offset="0x105A438")]
	[FieldOffset(Offset="0xA0")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105A448", Offset="0x105A448")]
	[FieldOffset(Offset="0xA8")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x105A458", Offset="0x105A458")]
	[FieldOffset(Offset="0xB0")]
	private HudController _hudController;

	[Attribute(Name="InjectAttribute", RVA="0x105A468", Offset="0x105A468")]
	[FieldOffset(Offset="0xB8")]
	private ClubUtil _clubUtil;

	[Attribute(Name="InjectAttribute", RVA="0x105A478", Offset="0x105A478")]
	[FieldOffset(Offset="0xC0")]
	private ClubServiceUtility _clubServiceUtility;

	[FieldOffset(Offset="0xC8")]
	private KothLobbyResponse _lobbyData;

	[FieldOffset(Offset="0xD0")]
	private KothLobbyView _view;

	[FieldOffset(Offset="0xD8")]
	private int _telemetryOpponentUpdateVal;

	[FieldOffset(Offset="0xE0")]
	private DateTime _nextPayoutTime;

	[FieldOffset(Offset="0xE8")]
	private bool _isExpired;

	[Address(RVA="0x11D1718", Offset="0x11D1718", VA="0x11D1718")]
	public KothLobbyController()
	{
	}

	[Address(RVA="0x11D178C", Offset="0x11D178C", VA="0x11D178C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070144", Offset="0x1070144")]
	private void <RefreshCooldown>b__12_0()
	{
	}

	[Address(RVA="0x11D1720", Offset="0x11D1720", VA="0x11D1720")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070134", Offset="0x1070134")]
	private void <RefreshViewData>b__10_0()
	{
	}

	[Address(RVA="0x11D1794", Offset="0x11D1794", VA="0x11D1794")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070154", Offset="0x1070154")]
	private void <SendClearCooldownRequest>b__13_0(KothClearCooldownResponse resp)
	{
	}

	[Address(RVA="0x11D1960", Offset="0x11D1960", VA="0x11D1960")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070164", Offset="0x1070164")]
	private void <SendClearCooldownRequest>b__13_1(long errorCode)
	{
	}

	[Address(RVA="0x11D1AA0", Offset="0x11D1AA0", VA="0x11D1AA0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070174", Offset="0x1070174")]
	private void <SendClearCooldownRequest>b__13_2()
	{
	}

	[Address(RVA="0x11CE854", Offset="0x11CE854", VA="0x11CE854")]
	private void ExpireLobby()
	{
	}

	[Address(RVA="0x11CF134", Offset="0x11CF134", VA="0x11CF134")]
	private string GetRankString()
	{
		return null;
	}

	[Address(RVA="0x11CEC10", Offset="0x11CEC10", VA="0x11CEC10", Slot="13")]
	public void HandleDispatchAction(DKothLobbyViewAction action)
	{
	}

	[Address(RVA="0x11CF578", Offset="0x11CF578", VA="0x11CF578", Slot="14")]
	public void HandleDispatchAction(DKothLobbyOpponentAction action)
	{
	}

	[Address(RVA="0x11CFABC", Offset="0x11CFABC", VA="0x11CFABC", Slot="15")]
	public void HandleDispatchAction(DClubSupportRequestButtonAction action)
	{
	}

	[Address(RVA="0x11CFE4C", Offset="0x11CFE4C", VA="0x11CFE4C", Slot="16")]
	public void HandleDispatchAction(DRevSdkPlacementShownAction action)
	{
	}

	[Address(RVA="0x11CE438", Offset="0x11CE438", VA="0x11CE438", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x11CF2E0", Offset="0x11CF2E0", VA="0x11CF2E0")]
	private void RefreshCooldown()
	{
	}

	[Address(RVA="0x11CF49C", Offset="0x11CF49C", VA="0x11CF49C")]
	private void RefreshCooldownForAd()
	{
	}

	[Address(RVA="0x11CFC1C", Offset="0x11CFC1C", VA="0x11CFC1C")]
	private void RefreshKothAttempts(ClubSupportRequest supportRequest)
	{
	}

	[Address(RVA="0x11CF1DC", Offset="0x11CF1DC", VA="0x11CF1DC")]
	private void RefreshViewData()
	{
	}

	[Address(RVA="0x11D16BC", Offset="0x11D16BC", VA="0x11D16BC")]
	private void ReloadGameState()
	{
	}

	[Address(RVA="0x11D00C8", Offset="0x11D00C8", VA="0x11D00C8")]
	private void RequestLobbyData(Action finished)
	{
	}

	[Address(RVA="0x11D024C", Offset="0x11D024C", VA="0x11D024C")]
	private void RequestView(Action finished)
	{
	}

	[Address(RVA="0x11CFEF4", Offset="0x11CFEF4", VA="0x11CFEF4")]
	private void SendClearCooldownRequest(RevSdkRewardType adType)
	{
	}

	[Address(RVA="0x11D0330", Offset="0x11D0330", VA="0x11D0330")]
	private void SetViewData()
	{
	}

	[Address(RVA="0x11CE6E0", Offset="0x11CE6E0", VA="0x11CE6E0", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x11CE74C", Offset="0x11CE74C", VA="0x11CE74C", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x11CF634", Offset="0x11CF634", VA="0x11CF634")]
	private void TryEnterBattle(ulong opponentRank)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C32C", Offset="0x104C32C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public KothLobbyController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[FieldOffset(Offset="0x20")]
		public Action<KothRankRewardPreviewResponse> <>9__3;

		[FieldOffset(Offset="0x28")]
		public Action<long> <>9__4;

		[Address(RVA="0x11CE6D8", Offset="0x11CE6D8", VA="0x11CE6D8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11D1B04", Offset="0x11D1B04", VA="0x11D1B04")]
		internal void <Initialize>b__0(Action done)
		{
		}

		[Address(RVA="0x11D1B50", Offset="0x11D1B50", VA="0x11D1B50")]
		internal void <Initialize>b__1()
		{
		}

		[Address(RVA="0x11D1F24", Offset="0x11D1F24", VA="0x11D1F24")]
		internal void <Initialize>b__3(KothRankRewardPreviewResponse response)
		{
		}

		[Address(RVA="0x11D21E8", Offset="0x11D21E8", VA="0x11D21E8")]
		internal void <Initialize>b__4(long failureCode)
		{
		}

		[Address(RVA="0x11D1D50", Offset="0x11D1D50", VA="0x11D1D50")]
		internal void <Initialize>g__HandleInitDone|2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C35C", Offset="0x104C35C")]
	private sealed class <>c__DisplayClass18_0
	{
		[FieldOffset(Offset="0x10")]
		public KothLobbyController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubSupportRequest supportRequest;

		[Address(RVA="0x11D1710", Offset="0x11D1710", VA="0x11D1710")]
		public <>c__DisplayClass18_0()
		{
		}

		[Address(RVA="0x11D2268", Offset="0x11D2268", VA="0x11D2268")]
		internal void <RefreshKothAttempts>b__0(RefreshKothAttemptsResponse response)
		{
		}

		[Address(RVA="0x11D2370", Offset="0x11D2370", VA="0x11D2370")]
		internal void <RefreshKothAttempts>b__1(long errorCode)
		{
		}

		[Address(RVA="0x11D23F0", Offset="0x11D23F0", VA="0x11D23F0")]
		internal void <RefreshKothAttempts>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C33C", Offset="0x104C33C")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset="0x10")]
		public KothLobbyController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11D0244", Offset="0x11D0244", VA="0x11D0244")]
		public <>c__DisplayClass7_0()
		{
		}

		[Address(RVA="0x11D2464", Offset="0x11D2464", VA="0x11D2464")]
		internal void <RequestLobbyData>b__0(KothLobbyResponse resp)
		{
		}

		[Address(RVA="0x11D2F44", Offset="0x11D2F44", VA="0x11D2F44")]
		internal void <RequestLobbyData>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C34C", Offset="0x104C34C")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset="0x10")]
		public KothLobbyController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11D0328", Offset="0x11D0328", VA="0x11D0328")]
		public <>c__DisplayClass9_0()
		{
		}

		[Address(RVA="0x11D2FE0", Offset="0x11D2FE0", VA="0x11D2FE0")]
		internal void <RequestView>b__0(KothLobbyView view)
		{
		}
	}
}