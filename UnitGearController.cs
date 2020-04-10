using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class UnitGearController : AFeatureController, IDispatchHandler<DUnitGearViewAction>, IDispatchHandler, IDispatchHandler<DUnitGearUsedByAction>, IDispatchHandler<DUnitGearIngredientColumnAction>, IDispatchHandler<DUnitDetailsGearSlotAction>, IDispatchHandler<DUnitGearItemFindAction>, IDispatchHandler<DInstantBattleRewardsShownAction>, IDispatchHandler<DDirectBuyAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105F4D0", Offset="0x105F4D0")]
	[FieldOffset(Offset="0x68")]
	private InventoryService _inventoryService;

	[Attribute(Name="InjectAttribute", RVA="0x105F4E0", Offset="0x105F4E0")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105F4F0", Offset="0x105F4F0")]
	[FieldOffset(Offset="0x78")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105F500", Offset="0x105F500")]
	[FieldOffset(Offset="0x80")]
	private ItemFindControllerModule _itemFindModule;

	[Attribute(Name="InjectAttribute", RVA="0x105F510", Offset="0x105F510")]
	[FieldOffset(Offset="0x88")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105F520", Offset="0x105F520")]
	[FieldOffset(Offset="0x90")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105F530", Offset="0x105F530")]
	[FieldOffset(Offset="0x98")]
	private ClubServiceUtility _clubService;

	[FieldOffset(Offset="0xA0")]
	private UnitGearView _view;

	[FieldOffset(Offset="0xA8")]
	private UnitGearGameState.Context _context;

	[FieldOffset(Offset="0xB0")]
	private Serverproto.Unit _unit;

	[FieldOffset(Offset="0xB8")]
	private UnitGearTier? _unitGearTier;

	[FieldOffset(Offset="0xD0")]
	private UnitGearSlot? _unitGearSlot;

	[FieldOffset(Offset="0xE8")]
	private Gamedata.InventoryItem? _gearSlotItem;

	private bool UnitDataIsValid
	{
		[Address(RVA="0x11ECC98", Offset="0x11ECC98", VA="0x11ECC98")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11F0D9C", Offset="0x11F0D9C", VA="0x11F0D9C")]
	public UnitGearController()
	{
	}

	[Address(RVA="0x11F0EE4", Offset="0x11F0EE4", VA="0x11F0EE4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071044", Offset="0x1071044")]
	private void <BuyAndEquipGear>b__17_2()
	{
	}

	[Address(RVA="0x11F0F48", Offset="0x11F0F48", VA="0x11F0F48")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071054", Offset="0x1071054")]
	private void <CraftGear>b__19_0(CraftInventoryItemResponse response)
	{
	}

	[Address(RVA="0x11F13F8", Offset="0x11F13F8", VA="0x11F13F8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071064", Offset="0x1071064")]
	private void <CraftGear>b__19_2()
	{
	}

	[Address(RVA="0x11F0E80", Offset="0x11F0E80", VA="0x11F0E80")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071034", Offset="0x1071034")]
	private void <EquipGear>b__15_2()
	{
	}

	[Address(RVA="0x11F0DA4", Offset="0x11F0DA4", VA="0x11F0DA4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071024", Offset="0x1071024")]
	private void <Initialize>b__0_0(Action jobFinished)
	{
	}

	[Address(RVA="0x11EE01C", Offset="0x11EE01C", VA="0x11EE01C")]
	private void BuyAndEquipAllGear()
	{
	}

	[Address(RVA="0x11EDC84", Offset="0x11EDC84", VA="0x11EDC84")]
	private void BuyAndEquipGear()
	{
	}

	[Address(RVA="0x11EE4C4", Offset="0x11EE4C4", VA="0x11EE4C4")]
	private void CraftGear(ulong itemId)
	{
	}

	[Address(RVA="0x11EFA54", Offset="0x11EFA54", VA="0x11EFA54", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x11ED5C0", Offset="0x11ED5C0", VA="0x11ED5C0")]
	private void EquipAllGear()
	{
	}

	[Address(RVA="0x11ED1A8", Offset="0x11ED1A8", VA="0x11ED1A8")]
	private void EquipGear()
	{
	}

	[Address(RVA="0x11EFD34", Offset="0x11EFD34", VA="0x11EFD34")]
	private void FinishInitialization()
	{
	}

	[Address(RVA="0x11EDA58", Offset="0x11EDA58", VA="0x11EDA58")]
	private void GearTierUpUnit()
	{
	}

	[Address(RVA="0x11EF9D4", Offset="0x11EF9D4", VA="0x11EF9D4", Slot="9")]
	protected override void HandleBackButton(AView view)
	{
	}

	[Address(RVA="0x11ECFC4", Offset="0x11ECFC4", VA="0x11ECFC4", Slot="13")]
	public void HandleDispatchAction(DUnitGearViewAction action)
	{
	}

	[Address(RVA="0x11EE4B4", Offset="0x11EE4B4", VA="0x11EE4B4", Slot="15")]
	public void HandleDispatchAction(DUnitGearIngredientColumnAction action)
	{
	}

	[Address(RVA="0x11EE7B4", Offset="0x11EE7B4", VA="0x11EE7B4", Slot="14")]
	public void HandleDispatchAction(DUnitGearUsedByAction action)
	{
	}

	[Address(RVA="0x11EF53C", Offset="0x11EF53C", VA="0x11EF53C", Slot="16")]
	public void HandleDispatchAction(DUnitDetailsGearSlotAction action)
	{
	}

	[Address(RVA="0x11EF8FC", Offset="0x11EF8FC", VA="0x11EF8FC", Slot="17")]
	public void HandleDispatchAction(DUnitGearItemFindAction action)
	{
	}

	[Address(RVA="0x11EF938", Offset="0x11EF938", VA="0x11EF938", Slot="18")]
	public void HandleDispatchAction(DInstantBattleRewardsShownAction action)
	{
	}

	[Address(RVA="0x11EF994", Offset="0x11EF994", VA="0x11EF994", Slot="19")]
	public void HandleDispatchAction(DDirectBuyAction action)
	{
	}

	[Address(RVA="0x11EC86C", Offset="0x11EC86C", VA="0x11EC86C", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x11EFC50", Offset="0x11EFC50", VA="0x11EFC50")]
	private void LoadView(Action finished)
	{
	}

	[Address(RVA="0x11F0BBC", Offset="0x11F0BBC", VA="0x11F0BBC")]
	private void SendCrafGearTelemetry(CraftInventoryItemResponse response)
	{
	}

	[Address(RVA="0x11F09C8", Offset="0x11F09C8", VA="0x11F09C8")]
	private void SendEquipAllGearTelemetry(long numGearEquipped, InventoryDelta inventoryDelta, bool isBuyAndEquip)
	{
	}

	[Address(RVA="0x11F06E4", Offset="0x11F06E4", VA="0x11F06E4")]
	private void SendEquipGearTelemetry(InventoryDelta inventoryDelta, bool isBuyAndEquip)
	{
	}

	[Address(RVA="0x11F0CBC", Offset="0x11F0CBC", VA="0x11F0CBC")]
	private void SendTierUpTelemetry(GearTierUpRequest request)
	{
	}

	[Address(RVA="0x11ECD30", Offset="0x11ECD30", VA="0x11ECD30", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x11ECD70", Offset="0x11ECD70", VA="0x11ECD70", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x11ECA80", Offset="0x11ECA80", VA="0x11ECA80")]
	private void UpdateUnitData()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D0BC", Offset="0x104D0BC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[Address(RVA="0x11F0E78", Offset="0x11F0E78", VA="0x11F0E78")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11F145C", Offset="0x11F145C", VA="0x11F145C")]
		internal void <Initialize>b__1(UnitGearScene _)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D0CC", Offset="0x104D0CC")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitGearController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11EFD2C", Offset="0x11EFD2C", VA="0x11EFD2C")]
		public <>c__DisplayClass12_0()
		{
		}

		[Address(RVA="0x11F1470", Offset="0x11F1470", VA="0x11F1470")]
		internal void <LoadView>b__0(UnitGearView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D0DC", Offset="0x104D0DC")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset="0x10")]
		public Serverproto.Unit oldUnit;

		[FieldOffset(Offset="0x18")]
		public EquipGearRequest request;

		[FieldOffset(Offset="0x20")]
		public UnitGearController <>4__this;

		[Address(RVA="0x11F06B4", Offset="0x11F06B4", VA="0x11F06B4")]
		public <>c__DisplayClass15_0()
		{
		}

		[Address(RVA="0x11F15B0", Offset="0x11F15B0", VA="0x11F15B0")]
		internal void <EquipGear>b__0(EquipGearResponse response)
		{
		}

		[Address(RVA="0x11F1B8C", Offset="0x11F1B8C", VA="0x11F1B8C")]
		internal void <EquipGear>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D0EC", Offset="0x104D0EC")]
	private sealed class <>c__DisplayClass16_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitGearController <>4__this;

		[FieldOffset(Offset="0x18")]
		public long oldGearEquippedCount;

		[FieldOffset(Offset="0x20")]
		public Serverproto.Unit oldUnit;

		[FieldOffset(Offset="0x28")]
		public EquipAllGearRequest request;

		[Address(RVA="0x11F06BC", Offset="0x11F06BC", VA="0x11F06BC")]
		public <>c__DisplayClass16_0()
		{
		}

		[Address(RVA="0x11F1CA8", Offset="0x11F1CA8", VA="0x11F1CA8")]
		internal void <EquipAllGear>b__0(EquipAllGearResponse response)
		{
		}

		[Address(RVA="0x11F210C", Offset="0x11F210C", VA="0x11F210C")]
		internal void <EquipAllGear>b__1(long failureCode)
		{
		}

		[Address(RVA="0x11F21EC", Offset="0x11F21EC", VA="0x11F21EC")]
		internal void <EquipAllGear>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D0FC", Offset="0x104D0FC")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset="0x10")]
		public Serverproto.Unit oldUnit;

		[FieldOffset(Offset="0x18")]
		public BuyAndEquipGearRequest request;

		[FieldOffset(Offset="0x20")]
		public UnitGearController <>4__this;

		[Address(RVA="0x11F06C4", Offset="0x11F06C4", VA="0x11F06C4")]
		public <>c__DisplayClass17_0()
		{
		}

		[Address(RVA="0x11F2260", Offset="0x11F2260", VA="0x11F2260")]
		internal void <BuyAndEquipGear>b__0(BuyAndEquipGearResponse response)
		{
		}

		[Address(RVA="0x11F24BC", Offset="0x11F24BC", VA="0x11F24BC")]
		internal void <BuyAndEquipGear>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D10C", Offset="0x104D10C")]
	private sealed class <>c__DisplayClass18_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitGearController <>4__this;

		[FieldOffset(Offset="0x18")]
		public long oldGearEquippedCount;

		[FieldOffset(Offset="0x20")]
		public Serverproto.Unit oldUnit;

		[FieldOffset(Offset="0x28")]
		public BuyAndEquipAllGearRequest request;

		[Address(RVA="0x11F06CC", Offset="0x11F06CC", VA="0x11F06CC")]
		public <>c__DisplayClass18_0()
		{
		}

		[Address(RVA="0x11F25D8", Offset="0x11F25D8", VA="0x11F25D8")]
		internal void <BuyAndEquipAllGear>b__0(BuyAndEquipAllGearResponse response)
		{
		}

		[Address(RVA="0x11F2A3C", Offset="0x11F2A3C", VA="0x11F2A3C")]
		internal void <BuyAndEquipAllGear>b__1(long failureCode)
		{
		}

		[Address(RVA="0x11F2B1C", Offset="0x11F2B1C", VA="0x11F2B1C")]
		internal void <BuyAndEquipAllGear>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D11C", Offset="0x104D11C")]
	private sealed class <>c__DisplayClass19_0
	{
		[FieldOffset(Offset="0x10")]
		public CraftInventoryItemRequest request;

		[FieldOffset(Offset="0x18")]
		public UnitGearController <>4__this;

		[Address(RVA="0x11F06D4", Offset="0x11F06D4", VA="0x11F06D4")]
		public <>c__DisplayClass19_0()
		{
		}

		[Address(RVA="0x11F2B90", Offset="0x11F2B90", VA="0x11F2B90")]
		internal void <CraftGear>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D12C", Offset="0x104D12C")]
	private sealed class <>c__DisplayClass20_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitGearController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GearTierUpRequest request;

		[FieldOffset(Offset="0x20")]
		public Serverproto.Unit oldUnit;

		[Address(RVA="0x11F06DC", Offset="0x11F06DC", VA="0x11F06DC")]
		public <>c__DisplayClass20_0()
		{
		}

		[Address(RVA="0x11F2C6C", Offset="0x11F2C6C", VA="0x11F2C6C")]
		internal void <GearTierUpUnit>b__0(GearTierUpResponse response)
		{
		}

		[Address(RVA="0x11F34B8", Offset="0x11F34B8", VA="0x11F34B8")]
		internal void <GearTierUpUnit>b__1(long failureCode)
		{
		}

		[Address(RVA="0x11F35A4", Offset="0x11F35A4", VA="0x11F35A4")]
		internal void <GearTierUpUnit>b__2()
		{
		}
	}
}