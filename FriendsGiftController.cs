using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class FriendsGiftController : APopupController, IDispatchHandler<DFriendGiftListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x10585F0", Offset="0x10585F0")]
	[FieldOffset(Offset="0x38")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x1058600", Offset="0x1058600")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1058610", Offset="0x1058610")]
	[FieldOffset(Offset="0x48")]
	private ClubService _clubService;

	[FieldOffset(Offset="0x50")]
	private FriendsGiftView _view;

	[FieldOffset(Offset="0x58")]
	private List<FriendGiftListItemData> _friends;

	[FieldOffset(Offset="0x60")]
	private FriendsGiftController.Context _context;

	[FieldOffset(Offset="0x68")]
	private string _receiverId;

	[Address(RVA="0x12D006C", Offset="0x12D006C", VA="0x12D006C")]
	public FriendsGiftController()
	{
	}

	[Address(RVA="0x12D00DC", Offset="0x12D00DC", VA="0x12D00DC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FA24", Offset="0x106FA24")]
	private void <FriendGiftSelect>b__5_0(FriendGiftSelectResponse response)
	{
	}

	[Address(RVA="0x12D01EC", Offset="0x12D01EC", VA="0x12D01EC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FA34", Offset="0x106FA34")]
	private void <FriendGiftSelect>b__5_1(long errorCode)
	{
	}

	[Address(RVA="0x12D0268", Offset="0x12D0268", VA="0x12D0268")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FA44", Offset="0x106FA44")]
	private void <FriendGiftSelect>b__5_2()
	{
	}

	[Address(RVA="0x12CF664", Offset="0x12CF664", VA="0x12CF664")]
	private void FriendGiftSelect()
	{
	}

	[Address(RVA="0x12CF550", Offset="0x12CF550", VA="0x12CF550", Slot="14")]
	public void HandleDispatchAction(DFriendGiftListItemAction action)
	{
	}

	[Address(RVA="0x12CF358", Offset="0x12CF358", VA="0x12CF358", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x12CF8DC", Offset="0x12CF8DC", VA="0x12CF8DC")]
	private void LoadView(Action finished)
	{
	}

	[Address(RVA="0x12CFC60", Offset="0x12CFC60", VA="0x12CFC60")]
	private void RequestFriendsList(Action finished)
	{
	}

	[Address(RVA="0x12CF9B8", Offset="0x12CF9B8", VA="0x12CF9B8")]
	private void RequestList(Action finished)
	{
	}

	[Address(RVA="0x12CFDF4", Offset="0x12CFDF4", VA="0x12CFDF4")]
	private void SendFriendTelemetry()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BEFC", Offset="0x104BEFC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public FriendsGiftController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x12CF548", Offset="0x12CF548", VA="0x12CF548")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x12D02CC", Offset="0x12D02CC", VA="0x12D02CC")]
		internal void <Initialize>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BF0C", Offset="0x104BF0C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public FriendsGiftController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x15E8318", Offset="0x15E8318", VA="0x15E8318")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x15E8320", Offset="0x15E8320", VA="0x15E8320")]
		internal void <LoadView>b__0(FriendsGiftView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BF1C", Offset="0x104BF1C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public FriendsGiftController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x15E8378", Offset="0x15E8378", VA="0x15E8378")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x15E8380", Offset="0x15E8380", VA="0x15E8380")]
		internal void <RequestList>b__0(ClubResponse response)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BF2C", Offset="0x104BF2C")]
	private sealed class <>c__DisplayClass3_1
	{
		[FieldOffset(Offset="0x10")]
		public ClubRequest clubRequest;

		[FieldOffset(Offset="0x18")]
		public FriendsGiftController.<>c__DisplayClass3_0 CS$<>8__locals1;

		[Address(RVA="0x15E87A0", Offset="0x15E87A0", VA="0x15E87A0")]
		public <>c__DisplayClass3_1()
		{
		}

		[Address(RVA="0x15E87A8", Offset="0x15E87A8", VA="0x15E87A8")]
		internal void <RequestList>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BF3C", Offset="0x104BF3C")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public FriendsGiftController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x15E88A8", Offset="0x15E88A8", VA="0x15E88A8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x15E88B0", Offset="0x15E88B0", VA="0x15E88B0")]
		internal void <RequestFriendsList>b__0(FriendsListResponse response)
		{
		}

		[Address(RVA="0x15E8D88", Offset="0x15E8D88", VA="0x15E8D88")]
		internal void <RequestFriendsList>b__1(long errorCode)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly StoreItemData ItemData;

		[Address(RVA="0x15E8E5C", Offset="0x15E8E5C", VA="0x15E8E5C")]
		public Context(StoreItemData itemData)
		{
		}
	}
}