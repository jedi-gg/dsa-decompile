using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class FriendsController : AFeatureController, IDispatchHandler<DFriendsViewAction>, IDispatchHandler, IDispatchHandler<DPlayerListItemClickedAction>, IDispatchHandler<DFriendListItemAction>, IDispatchHandler<DPlayerListItemUtilityAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1058530", Offset="0x1058530")]
	[FieldOffset(Offset="0x68")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x1058540", Offset="0x1058540")]
	[FieldOffset(Offset="0x70")]
	private INativeMessageSharing _messageSharing;

	[Attribute(Name="InjectAttribute", RVA="0x1058550", Offset="0x1058550")]
	[FieldOffset(Offset="0x78")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1058560", Offset="0x1058560")]
	[FieldOffset(Offset="0x80")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x1058570", Offset="0x1058570")]
	[FieldOffset(Offset="0x88")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1058580", Offset="0x1058580")]
	[FieldOffset(Offset="0x90")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1058590", Offset="0x1058590")]
	[FieldOffset(Offset="0x98")]
	private ClubDomainController _clubDc;

	[Attribute(Name="InjectAttribute", RVA="0x10585A0", Offset="0x10585A0")]
	[FieldOffset(Offset="0xA0")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0xA8")]
	private FriendsView _view;

	[FieldOffset(Offset="0xB0")]
	private List<FriendsListItemData> _friends;

	[Address(RVA="0x12CD218", Offset="0x12CD218", VA="0x12CD218")]
	public FriendsController()
	{
	}

	[Address(RVA="0x12CD288", Offset="0x12CD288", VA="0x12CD288")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F9E4", Offset="0x106F9E4")]
	private void <InitAsync>b__8_0(Action complete)
	{
	}

	[Address(RVA="0x12CD36C", Offset="0x12CD36C", VA="0x12CD36C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F9F4", Offset="0x106F9F4")]
	private void <RequestFriendInviteUrl>b__10_0(FriendsListInviteURLResponse response)
	{
	}

	[Address(RVA="0x12CD50C", Offset="0x12CD50C", VA="0x12CD50C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FA04", Offset="0x106FA04")]
	private void <RequestFriendInviteUrl>b__10_1(long failure)
	{
	}

	[Address(RVA="0x12CC7A4", Offset="0x12CC7A4", VA="0x12CC7A4")]
	private void AcceptFriendInviteLink(SocialGameState.FriendsDeepLinkContext context, Action finished)
	{
	}

	[Address(RVA="0x12CCD5C", Offset="0x12CCD5C", VA="0x12CCD5C")]
	private int CompareFriends(FriendsListItemData friendA, FriendsListItemData friendB)
	{
		return new int();
	}

	[Address(RVA="0x12CC47C", Offset="0x12CC47C", VA="0x12CC47C", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x12CB86C", Offset="0x12CB86C", VA="0x12CB86C", Slot="13")]
	public void HandleDispatchAction(DFriendsViewAction action)
	{
	}

	[Address(RVA="0x12CBA10", Offset="0x12CBA10", VA="0x12CBA10", Slot="14")]
	public void HandleDispatchAction(DPlayerListItemClickedAction action)
	{
	}

	[Address(RVA="0x12CBEF8", Offset="0x12CBEF8", VA="0x12CBEF8", Slot="15")]
	public void HandleDispatchAction(DFriendListItemAction action)
	{
	}

	[Address(RVA="0x12CC340", Offset="0x12CC340", VA="0x12CC340", Slot="16")]
	public void HandleDispatchAction(DPlayerListItemUtilityAction action)
	{
	}

	[Address(RVA="0x12CC4D8", Offset="0x12CC4D8", VA="0x12CC4D8")]
	private void InitAsync(Action finished)
	{
	}

	[Address(RVA="0x12CB4F0", Offset="0x12CB4F0", VA="0x12CB4F0", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x12CC040", Offset="0x12CC040", VA="0x12CC040")]
	private void ModifyFriendsList(string friendId, FriendsListModifyAction modifyAction)
	{
	}

	[Address(RVA="0x12CB878", Offset="0x12CB878", VA="0x12CB878")]
	private void RequestFriendInviteUrl()
	{
	}

	[Address(RVA="0x12CC5FC", Offset="0x12CC5FC", VA="0x12CC5FC")]
	private void RequestFriendsList(Action finished)
	{
	}

	[Address(RVA="0x12CCDF8", Offset="0x12CCDF8", VA="0x12CCDF8")]
	private void SendFriendTelemetry(string friendId, FriendsListModifyAction action)
	{
	}

	[Address(RVA="0x12CB794", Offset="0x12CB794", VA="0x12CB794", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x12CB800", Offset="0x12CB800", VA="0x12CB800", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x12CC9C0", Offset="0x12CC9C0", VA="0x12CC9C0")]
	private void UpdateFriendsList(FriendsListModifyRequest request)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BE9C", Offset="0x104BE9C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public FriendsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public SocialGameState.FriendsDeepLinkContext friendContext;

		[FieldOffset(Offset="0x20")]
		public GameStateTransitionContext context;

		[Address(RVA="0x12CB78C", Offset="0x12CB78C", VA="0x12CB78C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x12CD5B0", Offset="0x12CD5B0", VA="0x12CD5B0")]
		internal void <Initialize>b__0(Action finished)
		{
		}

		[Address(RVA="0x12CD5F0", Offset="0x12CD5F0", VA="0x12CD5F0")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BEDC", Offset="0x104BEDC")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public FriendsController <>4__this;

		[FieldOffset(Offset="0x20")]
		public SocialGameState.FriendsDeepLinkContext context;

		[Address(RVA="0x12CC9B0", Offset="0x12CC9B0", VA="0x12CC9B0")]
		public <>c__DisplayClass11_0()
		{
		}

		[Address(RVA="0x12CD7DC", Offset="0x12CD7DC", VA="0x12CD7DC")]
		internal void <AcceptFriendInviteLink>b__0(FriendsListModifyResponse response)
		{
		}

		[Address(RVA="0x12CD7F0", Offset="0x12CD7F0", VA="0x12CD7F0")]
		internal void <AcceptFriendInviteLink>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BEEC", Offset="0x104BEEC")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset="0x10")]
		public FriendsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public string friendId;

		[FieldOffset(Offset="0x20")]
		public FriendsListModifyAction modifyAction;

		[FieldOffset(Offset="0x28")]
		public FriendsListModifyRequest request;

		[Address(RVA="0x12CC9B8", Offset="0x12CC9B8", VA="0x12CC9B8")]
		public <>c__DisplayClass12_0()
		{
		}

		[Address(RVA="0x12CDB20", Offset="0x12CDB20", VA="0x12CDB20")]
		internal void <ModifyFriendsList>b__0(FriendsListModifyResponse response)
		{
		}

		[Address(RVA="0x12CDE10", Offset="0x12CDE10", VA="0x12CDE10")]
		internal void <ModifyFriendsList>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BEAC", Offset="0x104BEAC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public FriendsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Friend friend;

		[Address(RVA="0x12CBEF0", Offset="0x12CBEF0", VA="0x12CBEF0")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x12CDF48", Offset="0x12CDF48", VA="0x12CDF48")]
		internal void <HandleDispatchAction>b__0()
		{
		}

		[Address(RVA="0x12CE038", Offset="0x12CE038", VA="0x12CE038")]
		internal void <HandleDispatchAction>b__1()
		{
		}

		[Address(RVA="0x12CDE84", Offset="0x12CDE84", VA="0x12CDE84")]
		internal void <HandleDispatchAction>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BEBC", Offset="0x104BEBC")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public Action complete;

		[FieldOffset(Offset="0x18")]
		public FriendsController <>4__this;

		[Address(RVA="0x12CD364", Offset="0x12CD364", VA="0x12CD364")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x12CE0A0", Offset="0x12CE0A0", VA="0x12CE0A0")]
		internal void <InitAsync>b__1(FriendsView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BECC", Offset="0x104BECC")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset="0x10")]
		public FriendsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x12CC79C", Offset="0x12CC79C", VA="0x12CC79C")]
		public <>c__DisplayClass9_0()
		{
		}

		[Address(RVA="0x12CE0F8", Offset="0x12CE0F8", VA="0x12CE0F8")]
		internal void <RequestFriendsList>b__0(FriendsListResponse response)
		{
		}

		[Address(RVA="0x12CE448", Offset="0x12CE448", VA="0x12CE448")]
		internal void <RequestFriendsList>b__1(long failureCode)
		{
		}
	}
}