using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PvpLeaderboardPopupController : APopupController, IDispatchHandler<DPvpLeaderboardPopupViewAction>, IDispatchHandler, IDispatchHandler<DPlayerListItemClickedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105BC50", Offset="0x105BC50")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105BC60", Offset="0x105BC60")]
	[FieldOffset(Offset="0x40")]
	private LeaderboardService _leaderboardService;

	[Attribute(Name="InjectAttribute", RVA="0x105BC70", Offset="0x105BC70")]
	[FieldOffset(Offset="0x48")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x50")]
	private PvpLeaderboardPopupView _view;

	[FieldOffset(Offset="0x58")]
	private PlayerLeaderboardType _leaderboardType;

	[FieldOffset(Offset="0x0")]
	private static bool s_hasAutoScrolledThisSession;

	[Address(RVA="0x128570C", Offset="0x128570C", VA="0x128570C")]
	static PvpLeaderboardPopupController()
	{
	}

	[Address(RVA="0x1285704", Offset="0x1285704", VA="0x1285704")]
	public PvpLeaderboardPopupController()
	{
	}

	[Address(RVA="0x1285380", Offset="0x1285380", VA="0x1285380", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x1285130", Offset="0x1285130", VA="0x1285130")]
	private void GetLeaderboard(PlayerLeaderboardType leaderboardType)
	{
	}

	[Address(RVA="0x1285118", Offset="0x1285118", VA="0x1285118", Slot="14")]
	public void HandleDispatchAction(DPvpLeaderboardPopupViewAction action)
	{
	}

	[Address(RVA="0x1285414", Offset="0x1285414", VA="0x1285414", Slot="15")]
	public void HandleDispatchAction(DPlayerListItemClickedAction action)
	{
	}

	[Address(RVA="0x1284DD0", Offset="0x1284DD0", VA="0x1284DD0", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x1284F48", Offset="0x1284F48", VA="0x1284F48", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C83C", Offset="0x104C83C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PvpLeaderboardPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public PvpLeaderboardPopupController.Context popupContext;

		[FieldOffset(Offset="0x20")]
		public Action completed;

		[Address(RVA="0x1284F40", Offset="0x1284F40", VA="0x1284F40")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1285710", Offset="0x1285710", VA="0x1285710")]
		internal void <Initialize>b__0(PvpLeaderboardPopupView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C84C", Offset="0x104C84C")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset="0x10")]
		public PvpLeaderboardPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public PlayerLeaderboardType leaderboardType;

		[Address(RVA="0x12854B0", Offset="0x12854B0", VA="0x12854B0")]
		public <>c__DisplayClass5_0()
		{
		}

		[Address(RVA="0x1285AAC", Offset="0x1285AAC", VA="0x1285AAC")]
		internal void <GetLeaderboard>b__0(PlayerLeaderboardResponse response)
		{
		}

		[Address(RVA="0x1285F9C", Offset="0x1285F9C", VA="0x1285F9C")]
		internal void <GetLeaderboard>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1285FDC", Offset="0x1285FDC", VA="0x1285FDC")]
		internal void <GetLeaderboard>b__2()
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly PlayerLeaderboardType LeaderboardType;

		[Address(RVA="0x12853E8", Offset="0x12853E8", VA="0x12853E8")]
		public Context(PlayerLeaderboardType leaderboardType)
		{
		}
	}
}