using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class BattleInviteFriendPopupController : APopupController, IDispatchHandler<DBattleInviteFriendPopupViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x10549BC", Offset="0x10549BC")]
	[FieldOffset(Offset="0x38")]
	private PlayerService _playerService;

	[FieldOffset(Offset="0x40")]
	private BattleInviteFriendPopupView _view;

	[FieldOffset(Offset="0x48")]
	private List<PlayerProfileSimple> _friendProfiles;

	[Address(RVA="0x10FE200", Offset="0x10FE200", VA="0x10FE200")]
	public BattleInviteFriendPopupController()
	{
	}

	[Address(RVA="0x10FDEE0", Offset="0x10FDEE0", VA="0x10FDEE0", Slot="14")]
	public void HandleDispatchAction(DBattleInviteFriendPopupViewAction action)
	{
	}

	[Address(RVA="0x10FDCC8", Offset="0x10FDCC8", VA="0x10FDCC8", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x10FDF98", Offset="0x10FDF98", VA="0x10FDF98")]
	private void LoadView(Action finished)
	{
	}

	[Address(RVA="0x10FE07C", Offset="0x10FE07C", VA="0x10FE07C")]
	private void RequestFriendsList(Action finished)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B34C", Offset="0x104B34C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleInviteFriendPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public BattleInviteFriendPopupController.Context popupContext;

		[FieldOffset(Offset="0x20")]
		public Action completed;

		[Address(RVA="0x10FDED8", Offset="0x10FDED8", VA="0x10FDED8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x10FE208", Offset="0x10FE208", VA="0x10FE208")]
		internal void <Initialize>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B35C", Offset="0x104B35C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleInviteFriendPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x10FE074", Offset="0x10FE074", VA="0x10FE074")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x10FE7D8", Offset="0x10FE7D8", VA="0x10FE7D8")]
		internal void <LoadView>b__0(BattleInviteFriendPopupView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B36C", Offset="0x104B36C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleInviteFriendPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x10FE1F8", Offset="0x10FE1F8", VA="0x10FE1F8")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x10FE82C", Offset="0x10FE82C", VA="0x10FE82C")]
		internal void <RequestFriendsList>b__0(FriendsListResponse response)
		{
		}

		[Address(RVA="0x10FEB50", Offset="0x10FEB50", VA="0x10FEB50")]
		internal void <RequestFriendsList>b__1(long failureCode)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public Gamedata.InventoryItem? EntryCostItem;

		[FieldOffset(Offset="0x28")]
		public ulong EntryCost;

		[Address(RVA="0x10FEC20", Offset="0x10FEC20", VA="0x10FEC20")]
		public Context(Gamedata.InventoryItem? entryCostItem, ulong entryCost)
		{
		}
	}
}