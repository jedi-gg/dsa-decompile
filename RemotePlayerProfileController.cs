using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class RemotePlayerProfileController : APlayerProfileController
{
	[Attribute(Name="InjectAttribute", RVA="0x105B9B0", Offset="0x105B9B0")]
	[FieldOffset(Offset="0x90")]
	private PlayerServiceUtility _playerServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105B9C0", Offset="0x105B9C0")]
	[FieldOffset(Offset="0x98")]
	private Unit.Factory _unitFactory;

	[Attribute(Name="InjectAttribute", RVA="0x105B9D0", Offset="0x105B9D0")]
	[FieldOffset(Offset="0xA0")]
	private Spell.Factory _spellFactory;

	[FieldOffset(Offset="0xA8")]
	private string _playerId;

	[FieldOffset(Offset="0xB0")]
	private List<Friend> _friends;

	[Address(RVA="0x2C2F4F0", Offset="0x2C2F4F0", VA="0x2C2F4F0")]
	public RemotePlayerProfileController()
	{
	}

	[Address(RVA="0x2C2F560", Offset="0x2C2F560", VA="0x2C2F560")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070674", Offset="0x1070674")]
	private void <HandleDispatchAction>b__1_0()
	{
	}

	[Address(RVA="0x2C2F594", Offset="0x2C2F594", VA="0x2C2F594")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070684", Offset="0x1070684")]
	private bool <InitializeView>b__3_0(Friend f)
	{
		return new bool();
	}

	[Address(RVA="0x2C2F5EC", Offset="0x2C2F5EC", VA="0x2C2F5EC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070694", Offset="0x1070694")]
	private void <RequestFriendsList>b__5_0(FriendsListResponse response)
	{
	}

	[Address(RVA="0x2C2EF60", Offset="0x2C2EF60", VA="0x2C2EF60", Slot="14")]
	public override void HandleDispatchAction(DPlayerProfileAction action)
	{
	}

	[Address(RVA="0x2C2EEC0", Offset="0x2C2EEC0", VA="0x2C2EEC0", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x2C2F32C", Offset="0x2C2F32C", VA="0x2C2F32C", Slot="17")]
	protected override void InitializeAsync(Action finished)
	{
	}

	[Address(RVA="0x2C2F238", Offset="0x2C2F238", VA="0x2C2F238", Slot="16")]
	protected override void InitializeView()
	{
	}

	[Address(RVA="0x2C2F098", Offset="0x2C2F098", VA="0x2C2F098", Slot="15")]
	protected override void LoadProfileInfo(Action<Player, List<PlayerStat>> success, Action<long> failure)
	{
	}

	[Address(RVA="0x2C2F330", Offset="0x2C2F330", VA="0x2C2F330")]
	private void RequestFriendsList(Action finished)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C79C", Offset="0x104C79C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static RemotePlayerProfileController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<long> <>9__5_1;

		[Address(RVA="0x2C2F678", Offset="0x2C2F678", VA="0x2C2F678")]
		static <>c()
		{
		}

		[Address(RVA="0x2C2F6DC", Offset="0x2C2F6DC", VA="0x2C2F6DC")]
		public <>c()
		{
		}

		[Address(RVA="0x2C2F6E4", Offset="0x2C2F6E4", VA="0x2C2F6E4")]
		internal void <RequestFriendsList>b__5_1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C78C", Offset="0x104C78C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public RemotePlayerProfileController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action<Player, List<PlayerStat>> success;

		[Address(RVA="0x2C2F230", Offset="0x2C2F230", VA="0x2C2F230")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x2C2F6E8", Offset="0x2C2F6E8", VA="0x2C2F6E8")]
		internal void <LoadProfileInfo>b__0(PlayerProfileResponse response)
		{
		}
	}
}