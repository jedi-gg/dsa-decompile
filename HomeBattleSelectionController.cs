using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class HomeBattleSelectionController : APopupController, IDispatchHandler<DHomeBattleSelectionViewAction>, IDispatchHandler, IDispatchHandler<DHomeBattleSelectResponse>
{
	[Attribute(Name="InjectAttribute", RVA="0x1058F38", Offset="0x1058F38")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1058F48", Offset="0x1058F48")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1058F58", Offset="0x1058F58")]
	[FieldOffset(Offset="0x48")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1058F68", Offset="0x1058F68")]
	[FieldOffset(Offset="0x50")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1058F78", Offset="0x1058F78")]
	[FieldOffset(Offset="0x58")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x60")]
	private HomeBattleSelectionView _view;

	[FieldOffset(Offset="0x68")]
	private HomeBattleSelectionController.Context _context;

	[Address(RVA="0x12E95B8", Offset="0x12E95B8", VA="0x12E95B8")]
	public HomeBattleSelectionController()
	{
	}

	[Address(RVA="0x12E8C00", Offset="0x12E8C00", VA="0x12E8C00")]
	private void EnterCampaign(ulong campaignId)
	{
	}

	[Address(RVA="0x12E95B0", Offset="0x12E95B0", VA="0x12E95B0", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x12E8880", Offset="0x12E8880", VA="0x12E8880", Slot="14")]
	public void HandleDispatchAction(DHomeBattleSelectionViewAction action)
	{
	}

	[Address(RVA="0x12E90E4", Offset="0x12E90E4", VA="0x12E90E4", Slot="15")]
	public void HandleDispatchAction(DHomeBattleSelectResponse response)
	{
	}

	[Address(RVA="0x12E86BC", Offset="0x12E86BC", VA="0x12E86BC", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x12E8808", Offset="0x12E8808", VA="0x12E8808", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C06C", Offset="0x104C06C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public HomeBattleSelectionController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x12E8800", Offset="0x12E8800", VA="0x12E8800")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x12E95C0", Offset="0x12E95C0", VA="0x12E95C0")]
		internal void <Initialize>b__0(HomeBattleSelectionView view)
		{
		}
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public HomePvpResponse HomePvpResponse;

		[FieldOffset(Offset="0x28")]
		public HomeBattleSelectResponse HomeBattleSelectResponse;

		[Address(RVA="0x12E9800", Offset="0x12E9800", VA="0x12E9800")]
		public Context()
		{
		}

		[Address(RVA="0x12E9828", Offset="0x12E9828", VA="0x12E9828")]
		public Context(HomePvpResponse homePvpResponse, HomeBattleSelectResponse homeBattleSelectResponse)
		{
		}
	}
}