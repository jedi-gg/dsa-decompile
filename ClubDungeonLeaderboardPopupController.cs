using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubDungeonLeaderboardPopupController : APopupController, IDispatchHandler<DClubDungeonLeaderboardPopupViewAction>, IDispatchHandler, IDispatchHandler<DPlayerListItemClickedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1056B38", Offset="0x1056B38")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1056B48", Offset="0x1056B48")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1056B58", Offset="0x1056B58")]
	[FieldOffset(Offset="0x48")]
	private LeaderboardService _leaderboardService;

	[FieldOffset(Offset="0x50")]
	private ITransitionContext _context;

	[FieldOffset(Offset="0x58")]
	private ClubDungeonLeaderboardPopupView _view;

	[Address(RVA="0x11AFE60", Offset="0x11AFE60", VA="0x11AFE60")]
	public ClubDungeonLeaderboardPopupController()
	{
	}

	[Address(RVA="0x11AFE68", Offset="0x11AFE68", VA="0x11AFE68")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F0D4", Offset="0x106F0D4")]
	private void <GetClubLeaderboard>b__3_0(ClubLeaderboardResponse response)
	{
	}

	[Address(RVA="0x11B02E4", Offset="0x11B02E4", VA="0x11B02E4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F0E4", Offset="0x106F0E4")]
	private void <GetClubLeaderboard>b__3_1(long errorCode)
	{
	}

	[Address(RVA="0x11B03C0", Offset="0x11B03C0", VA="0x11B03C0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F0F4", Offset="0x106F0F4")]
	private void <GetClubLeaderboard>b__3_2()
	{
	}

	[Address(RVA="0x11B03F0", Offset="0x11B03F0", VA="0x11B03F0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F104", Offset="0x106F104")]
	private void <GetClubMembersLeaderboard>b__4_0(ClubMemberLeaderboardResponse response)
	{
	}

	[Address(RVA="0x11B07CC", Offset="0x11B07CC", VA="0x11B07CC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F114", Offset="0x106F114")]
	private void <GetClubMembersLeaderboard>b__4_1(long errorCode)
	{
	}

	[Address(RVA="0x11B08A8", Offset="0x11B08A8", VA="0x11B08A8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F124", Offset="0x106F124")]
	private void <GetClubMembersLeaderboard>b__4_2()
	{
	}

	[Address(RVA="0x11AF8F4", Offset="0x11AF8F4", VA="0x11AF8F4")]
	private void GetClubLeaderboard()
	{
	}

	[Address(RVA="0x11AFAB8", Offset="0x11AFAB8", VA="0x11AFAB8")]
	private void GetClubMembersLeaderboard()
	{
	}

	[Address(RVA="0x11AF82C", Offset="0x11AF82C", VA="0x11AF82C", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x11AF834", Offset="0x11AF834", VA="0x11AF834", Slot="14")]
	public void HandleDispatchAction(DClubDungeonLeaderboardPopupViewAction action)
	{
	}

	[Address(RVA="0x11AFDC4", Offset="0x11AFDC4", VA="0x11AFDC4", Slot="15")]
	public void HandleDispatchAction(DPlayerListItemClickedAction action)
	{
	}

	[Address(RVA="0x11AF688", Offset="0x11AF688", VA="0x11AF688", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B96C", Offset="0x104B96C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonLeaderboardPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x11AF81C", Offset="0x11AF81C", VA="0x11AF81C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11B08D8", Offset="0x11B08D8", VA="0x11B08D8")]
		internal void <Initialize>b__0(ClubDungeonLeaderboardPopupView view)
		{
		}
	}

	public class AllClubsContext : ITransitionContext
	{
		public ClubLeaderboardType LeaderboardType
		{
			[Address(RVA="0x11B0A78", Offset="0x11B0A78", VA="0x11B0A78")]
			get
			{
				return new ClubLeaderboardType();
			}
		}

		[Address(RVA="0x11AF824", Offset="0x11AF824", VA="0x11AF824")]
		public AllClubsContext()
		{
		}
	}

	public class MyClubContext : ITransitionContext
	{
		public ClubMemberLeaderboardType LeaderboardType
		{
			[Address(RVA="0x11B0A80", Offset="0x11B0A80", VA="0x11B0A80")]
			get
			{
				return new ClubMemberLeaderboardType();
			}
		}

		[Address(RVA="0x11AFAB0", Offset="0x11AFAB0", VA="0x11AFAB0")]
		public MyClubContext()
		{
		}
	}
}