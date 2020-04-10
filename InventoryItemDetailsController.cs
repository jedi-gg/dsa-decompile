using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;

public class InventoryItemDetailsController : APopupController, IDispatchHandler<DInventoryItemDetailsViewAction>, IDispatchHandler, IDispatchHandler<DUnitGearUsedByAction>, IDispatchHandler<DClubItemRequestedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10598D4", Offset="0x10598D4")]
	[FieldOffset(Offset="0x38")]
	private ClubServiceUtility _clubService;

	[Attribute(Name="InjectAttribute", RVA="0x10598E4", Offset="0x10598E4")]
	[FieldOffset(Offset="0x40")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x10598F4", Offset="0x10598F4")]
	[FieldOffset(Offset="0x48")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1059904", Offset="0x1059904")]
	[FieldOffset(Offset="0x50")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x58")]
	private InventoryItemDetailsController.Context _context;

	[FieldOffset(Offset="0x60")]
	private InventoryItemDetailsView _view;

	[FieldOffset(Offset="0x68")]
	private InventoryItem _item;

	[Address(RVA="0x136EC80", Offset="0x136EC80", VA="0x136EC80")]
	public InventoryItemDetailsController()
	{
	}

	[Address(RVA="0x136E3B0", Offset="0x136E3B0", VA="0x136E3B0", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x136E3B8", Offset="0x136E3B8", VA="0x136E3B8", Slot="14")]
	public void HandleDispatchAction(DInventoryItemDetailsViewAction action)
	{
	}

	[Address(RVA="0x136E834", Offset="0x136E834", VA="0x136E834", Slot="15")]
	public void HandleDispatchAction(DUnitGearUsedByAction action)
	{
	}

	[Address(RVA="0x136E974", Offset="0x136E974", VA="0x136E974", Slot="16")]
	public void HandleDispatchAction(DClubItemRequestedAction action)
	{
	}

	[Address(RVA="0x136DEE8", Offset="0x136DEE8", VA="0x136DEE8", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x136E2B4", Offset="0x136E2B4", VA="0x136E2B4", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C23C", Offset="0x104C23C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public InventoryItemDetailsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x136E2AC", Offset="0x136E2AC", VA="0x136E2AC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x136EC88", Offset="0x136EC88", VA="0x136EC88")]
		internal void <Initialize>b__0(InventoryItemDetailsView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly ulong ItemId;

		[FieldOffset(Offset="0x18")]
		public readonly bool AllowNavigateAway;

		[FieldOffset(Offset="0x20")]
		public readonly ulong IgnoreUnitUsedById;

		[FieldOffset(Offset="0x28")]
		public readonly InventoryItemDetailsController.Context.UnitGearUsedByAction UnitGearUsedByActionType;

		[FieldOffset(Offset="0x2C")]
		public readonly bool IsVipExclusive;

		[Address(RVA="0x136A224", Offset="0x136A224", VA="0x136A224")]
		public Context(ulong itemId, bool allowNavigateAway = true, ulong ignoreUnitUsedById = 0L, InventoryItemDetailsController.Context.UnitGearUsedByAction unitGearUsedByActionType = 0, bool isVipExclusive = false)
		{
		}

		public enum UnitGearUsedByAction
		{
			[FieldOffset(Offset="0x0")]
			UnitDetails,
			[FieldOffset(Offset="0x0")]
			Close
		}
	}
}