using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class FriendsGiftCelebrationController : APopupController, IDispatchHandler<DFriendsGiftCelebrationViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1058630", Offset="0x1058630")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1058640", Offset="0x1058640")]
	[FieldOffset(Offset="0x40")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x1058650", Offset="0x1058650")]
	[FieldOffset(Offset="0x48")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x50")]
	private Player _player;

	[FieldOffset(Offset="0x58")]
	private FriendsGiftCelebrationView _view;

	[FieldOffset(Offset="0x60")]
	private FriendsGiftCelebrationController.Context _context;

	[Address(RVA="0x12CE928", Offset="0x12CE928", VA="0x12CE928")]
	public FriendsGiftCelebrationController()
	{
	}

	[Address(RVA="0x12CE748", Offset="0x12CE748", VA="0x12CE748")]
	private void FetchPlayerProfile(Action finished)
	{
	}

	[Address(RVA="0x12CE654", Offset="0x12CE654", VA="0x12CE654", Slot="14")]
	public void HandleDispatchAction(DFriendsGiftCelebrationViewAction action)
	{
	}

	[Address(RVA="0x12CE45C", Offset="0x12CE45C", VA="0x12CE45C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x12CE664", Offset="0x12CE664", VA="0x12CE664")]
	private void LoadView(Action finished)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BF4C", Offset="0x104BF4C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public FriendsGiftCelebrationController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x12CE64C", Offset="0x12CE64C", VA="0x12CE64C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x12CE930", Offset="0x12CE930", VA="0x12CE930")]
		internal void <Initialize>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BF5C", Offset="0x104BF5C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public FriendsGiftCelebrationController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x12CE740", Offset="0x12CE740", VA="0x12CE740")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x12CEC44", Offset="0x12CEC44", VA="0x12CEC44")]
		internal void <LoadView>b__0(FriendsGiftCelebrationView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BF6C", Offset="0x104BF6C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public FriendsGiftCelebrationController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x12CE920", Offset="0x12CE920", VA="0x12CE920")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x12CEC9C", Offset="0x12CEC9C", VA="0x12CEC9C")]
		internal void <FetchPlayerProfile>b__0(PlayerProfileResponse response)
		{
		}

		[Address(RVA="0x12CED10", Offset="0x12CED10", VA="0x12CED10")]
		internal void <FetchPlayerProfile>b__1(long errorCode)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly string PlayerId;

		[Address(RVA="0x12CEDAC", Offset="0x12CEDAC", VA="0x12CEDAC")]
		public Context(string playerId)
		{
		}
	}
}