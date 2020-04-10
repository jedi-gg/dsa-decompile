using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubWarController : AFeatureController, IDispatchHandler<DClubWarViewAction>, IDispatchHandler, IDispatchHandler<DClubWarViewNodeAction>, IDispatchHandler<DClubWarMemberRegisterAction>, IDispatchHandler<DClubWarRefreshedAction>, IDispatchHandler<DClubWarTeamHudWidgetAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1056CC8", Offset="0x1056CC8")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1056CD8", Offset="0x1056CD8")]
	[FieldOffset(Offset="0x70")]
	private ClubService _clubService;

	[Attribute(Name="InjectAttribute", RVA="0x1056CE8", Offset="0x1056CE8")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1056CF8", Offset="0x1056CF8")]
	[FieldOffset(Offset="0x80")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x1056D08", Offset="0x1056D08")]
	[FieldOffset(Offset="0x88")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1056D18", Offset="0x1056D18")]
	[FieldOffset(Offset="0x90")]
	private ClubWarDomainController _clubWarDc;

	[Attribute(Name="InjectAttribute", RVA="0x1056D28", Offset="0x1056D28")]
	[FieldOffset(Offset="0x98")]
	private ChatPreviewController _chatPreviewController;

	[Attribute(Name="InjectAttribute", RVA="0x1056D38", Offset="0x1056D38")]
	[FieldOffset(Offset="0xA0")]
	private HudController _hudController;

	[Attribute(Name="InjectAttribute", RVA="0x1056D48", Offset="0x1056D48")]
	[FieldOffset(Offset="0xA8")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x1056D58", Offset="0x1056D58")]
	[FieldOffset(Offset="0xB0")]
	private AccountPrefs _accountPrefs;

	[FieldOffset(Offset="0xB8")]
	private ClubWarView _view;

	[FieldOffset(Offset="0xC0")]
	private ClubWarScene _scene;

	[FieldOffset(Offset="0xC8")]
	private Club _club;

	[FieldOffset(Offset="0xD0")]
	private float _warRefreshCooldownS;

	[FieldOffset(Offset="0xD4")]
	private bool _isExpired;

	[FieldOffset(Offset="0xD8")]
	private DateTime _phaseEndTime;

	[Address(RVA="0x126B8A8", Offset="0x126B8A8", VA="0x126B8A8")]
	public ClubWarController()
	{
	}

	[Address(RVA="0x126BD80", Offset="0x126BD80", VA="0x126BD80")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F174", Offset="0x106F174")]
	private void <ExpireClubWar>b__14_0()
	{
	}

	[Address(RVA="0x126BDD4", Offset="0x126BDD4", VA="0x126BDD4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F184", Offset="0x106F184")]
	private void <ExpireClubWar>b__14_1()
	{
	}

	[Address(RVA="0x126B8B8", Offset="0x126B8B8", VA="0x126B8B8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F134", Offset="0x106F134")]
	private void <TickUpdate>b__2_0(bool success)
	{
	}

	[Address(RVA="0x126B928", Offset="0x126B928", VA="0x126B928")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F144", Offset="0x106F144")]
	private void <UnregisterMember>b__12_0()
	{
	}

	[Address(RVA="0x126BB38", Offset="0x126BB38", VA="0x126BB38")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F154", Offset="0x106F154")]
	private void <UnregisterMember>b__12_1(ClubWarUnregisterMemberResponse response)
	{
	}

	[Address(RVA="0x126BD1C", Offset="0x126BD1C", VA="0x126BD1C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F164", Offset="0x106F164")]
	private void <UnregisterMember>b__12_3()
	{
	}

	[Address(RVA="0x126B670", Offset="0x126B670", VA="0x126B670", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x126AA94", Offset="0x126AA94", VA="0x126AA94")]
	private void ExpireClubWar()
	{
	}

	[Address(RVA="0x126AC0C", Offset="0x126AC0C", VA="0x126AC0C", Slot="13")]
	public void HandleDispatchAction(DClubWarViewAction action)
	{
	}

	[Address(RVA="0x126B0D0", Offset="0x126B0D0", VA="0x126B0D0", Slot="14")]
	public void HandleDispatchAction(DClubWarViewNodeAction action)
	{
	}

	[Address(RVA="0x126B330", Offset="0x126B330", VA="0x126B330", Slot="15")]
	public void HandleDispatchAction(DClubWarMemberRegisterAction action)
	{
	}

	[Address(RVA="0x126B5C8", Offset="0x126B5C8", VA="0x126B5C8", Slot="16")]
	public void HandleDispatchAction(DClubWarRefreshedAction action)
	{
	}

	[Address(RVA="0x126B5EC", Offset="0x126B5EC", VA="0x126B5EC", Slot="17")]
	public void HandleDispatchAction(DClubWarTeamHudWidgetAction action)
	{
	}

	[Address(RVA="0x126A534", Offset="0x126A534", VA="0x126A534", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x126B33C", Offset="0x126B33C", VA="0x126B33C")]
	private void RegisterMember(bool autoRegister)
	{
	}

	[Address(RVA="0x126B6D8", Offset="0x126B6D8", VA="0x126B6D8")]
	private void RequestClub(Action finished)
	{
	}

	[Address(RVA="0x126A6A8", Offset="0x126A6A8", VA="0x126A6A8")]
	private void RequestWar(Action<bool> finished)
	{
	}

	[Address(RVA="0x126B0E0", Offset="0x126B0E0", VA="0x126B0E0")]
	private void ShowNodeDetail(string nodeId)
	{
	}

	[Address(RVA="0x126A824", Offset="0x126A824", VA="0x126A824", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x126A8C8", Offset="0x126A8C8", VA="0x126A8C8", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x126AFD0", Offset="0x126AFD0", VA="0x126AFD0")]
	private void UnregisterMember()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BA0C", Offset="0x104BA0C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static ClubWarController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<long> <>9__11_1;

		[FieldOffset(Offset="0x10")]
		public static Action<long> <>9__12_2;

		[Address(RVA="0x126BE28", Offset="0x126BE28", VA="0x126BE28")]
		static <>c()
		{
		}

		[Address(RVA="0x126BE8C", Offset="0x126BE8C", VA="0x126BE8C")]
		public <>c()
		{
		}

		[Address(RVA="0x126BE94", Offset="0x126BE94", VA="0x126BE94")]
		internal void <RegisterMember>b__11_1(long failureCode)
		{
		}

		[Address(RVA="0x126BF50", Offset="0x126BF50", VA="0x126BF50")]
		internal void <UnregisterMember>b__12_2(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B9AC", Offset="0x104B9AC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[FieldOffset(Offset="0x20")]
		public AnonymousJob.Work <>9__1;

		[FieldOffset(Offset="0x28")]
		public AnonymousJob.Work <>9__2;

		[FieldOffset(Offset="0x30")]
		public AnonymousJob.Work <>9__3;

		[FieldOffset(Offset="0x38")]
		public Action <>9__4;

		[Address(RVA="0x126A6A0", Offset="0x126A6A0", VA="0x126A6A0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x126C00C", Offset="0x126C00C", VA="0x126C00C")]
		internal void <Initialize>b__0(bool success)
		{
		}

		[Address(RVA="0x126C334", Offset="0x126C334", VA="0x126C334")]
		internal void <Initialize>b__1(Action executed)
		{
		}

		[Address(RVA="0x126C4A4", Offset="0x126C4A4", VA="0x126C4A4")]
		internal void <Initialize>b__2(Action executed)
		{
		}

		[Address(RVA="0x126C590", Offset="0x126C590", VA="0x126C590")]
		internal void <Initialize>b__3(Action finished)
		{
		}

		[Address(RVA="0x126C5E0", Offset="0x126C5E0", VA="0x126C5E0")]
		internal void <Initialize>b__4()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B9BC", Offset="0x104B9BC")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public ClubWarController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x126C49C", Offset="0x126C49C", VA="0x126C49C")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x126C8C0", Offset="0x126C8C0", VA="0x126C8C0")]
		internal void <Initialize>b__5(ClubWarScene scene)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B9CC", Offset="0x104B9CC")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public ClubWarController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x14CA3BC", Offset="0x14CA3BC", VA="0x14CA3BC")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x14CA3C4", Offset="0x14CA3C4", VA="0x14CA3C4")]
		internal void <Initialize>b__6(ClubWarView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B9EC", Offset="0x104B9EC")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x14CA42C", Offset="0x14CA42C", VA="0x14CA42C")]
		public <>c__DisplayClass10_0()
		{
		}

		[Address(RVA="0x14CA434", Offset="0x14CA434", VA="0x14CA434")]
		internal void <RequestClub>b__0(ClubResponse response)
		{
		}

		[Address(RVA="0x14CA4A8", Offset="0x14CA4A8", VA="0x14CA4A8")]
		internal void <RequestClub>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B9FC", Offset="0x104B9FC")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarController <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool autoRegister;

		[Address(RVA="0x14CA578", Offset="0x14CA578", VA="0x14CA578")]
		public <>c__DisplayClass11_0()
		{
		}

		[Address(RVA="0x14CA580", Offset="0x14CA580", VA="0x14CA580")]
		internal void <RegisterMember>b__0(ClubWarRegisterMemberResponse response)
		{
		}

		[Address(RVA="0x14CB2BC", Offset="0x14CB2BC", VA="0x14CB2BC")]
		internal void <RegisterMember>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B9DC", Offset="0x104B9DC")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action<bool> finished;

		[Address(RVA="0x14CB330", Offset="0x14CB330", VA="0x14CB330")]
		public <>c__DisplayClass9_0()
		{
		}

		[Address(RVA="0x14CB338", Offset="0x14CB338", VA="0x14CB338")]
		internal void <RequestWar>b__0(ClubWarResponse resp)
		{
		}

		[Address(RVA="0x14CBA68", Offset="0x14CBA68", VA="0x14CBA68")]
		internal void <RequestWar>b__1(long errCode)
		{
		}
	}
}