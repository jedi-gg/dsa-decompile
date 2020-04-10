using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class KothLeaderboardController : APopupController, IDispatchHandler<DPlayerListItemClickedAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	private static bool s_hasAutoScrolledThisSession;

	[Attribute(Name="InjectAttribute", RVA="0x105A388", Offset="0x105A388")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105A398", Offset="0x105A398")]
	[FieldOffset(Offset="0x40")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105A3A8", Offset="0x105A3A8")]
	[FieldOffset(Offset="0x48")]
	private LeaderboardService _leaderboardService;

	[FieldOffset(Offset="0x50")]
	private KothLeaderboardView _view;

	[Address(RVA="0x11CD6DC", Offset="0x11CD6DC", VA="0x11CD6DC")]
	static KothLeaderboardController()
	{
	}

	[Address(RVA="0x11CD6D4", Offset="0x11CD6D4", VA="0x11CD6D4")]
	public KothLeaderboardController()
	{
	}

	[Address(RVA="0x11CD6E0", Offset="0x11CD6E0", VA="0x11CD6E0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070104", Offset="0x1070104")]
	private void <GetLeaderboard>b__3_0(PlayerLeaderboardResponse response)
	{
	}

	[Address(RVA="0x11CDB88", Offset="0x11CDB88", VA="0x11CDB88")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070114", Offset="0x1070114")]
	private void <GetLeaderboard>b__3_1(long errorCode)
	{
	}

	[Address(RVA="0x11CDBB8", Offset="0x11CDBB8", VA="0x11CDBB8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070124", Offset="0x1070124")]
	private void <GetLeaderboard>b__3_2()
	{
	}

	[Address(RVA="0x11CD414", Offset="0x11CD414", VA="0x11CD414")]
	private void GetLeaderboard()
	{
	}

	[Address(RVA="0x11CD33C", Offset="0x11CD33C", VA="0x11CD33C", Slot="14")]
	public void HandleDispatchAction(DPlayerListItemClickedAction action)
	{
	}

	[Address(RVA="0x11CD058", Offset="0x11CD058", VA="0x11CD058", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x11CD16C", Offset="0x11CD16C", VA="0x11CD16C", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C31C", Offset="0x104C31C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public KothLeaderboardController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x11CD164", Offset="0x11CD164", VA="0x11CD164")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11CDBCC", Offset="0x11CDBCC", VA="0x11CDBCC")]
		internal void <Initialize>b__0(KothLeaderboardView view)
		{
		}
	}
}