using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class UnitDetailsController : AFeatureController, IDispatchHandler<DUnitDetailsViewAction>, IDispatchHandler, IDispatchHandler<DUnitDetailsGearSlotAction>, IDispatchHandler<DUnitDetailsAbilityListItemAction>, IDispatchHandler<DUnitTrainSuccessAction>, IDispatchHandler<DPopupControllerAction>, IDispatchHandler<DUnitSkinAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105F278", Offset="0x105F278")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105F288", Offset="0x105F288")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105F298", Offset="0x105F298")]
	[FieldOffset(Offset="0x78")]
	private InventoryService _inventoryService;

	[Attribute(Name="InjectAttribute", RVA="0x105F2A8", Offset="0x105F2A8")]
	[FieldOffset(Offset="0x80")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105F2B8", Offset="0x105F2B8")]
	[FieldOffset(Offset="0x88")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105F2C8", Offset="0x105F2C8")]
	[FieldOffset(Offset="0x90")]
	private UnitAffinityPressedPopupController _unitAffinityPressedPopupController;

	[FieldOffset(Offset="0x98")]
	private List<ulong> _unitCycleList;

	[FieldOffset(Offset="0xA0")]
	private int _currentUnitCycleIndex;

	[FieldOffset(Offset="0xA8")]
	private UnitDetailsView _detailsView;

	[FieldOffset(Offset="0xB0")]
	private Unit _unit;

	[FieldOffset(Offset="0xB8")]
	private ulong _unitDefinitionId;

	[FieldOffset(Offset="0xC0")]
	private string _unitPlayerId;

	[Address(RVA="0x11E2C88", Offset="0x11E2C88", VA="0x11E2C88")]
	public UnitDetailsController()
	{
	}

	[Address(RVA="0x11E19D4", Offset="0x11E19D4", VA="0x11E19D4", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x11E03C0", Offset="0x11E03C0", VA="0x11E03C0")]
	private void CycleUnit(int indexChange)
	{
	}

	[Address(RVA="0x11E04D0", Offset="0x11E04D0", VA="0x11E04D0")]
	private void EquipAllGear()
	{
	}

	[Address(RVA="0x11E284C", Offset="0x11E284C", VA="0x11E284C")]
	private void EquipUnitSkin(ulong skinItemId)
	{
	}

	[Address(RVA="0x11E169C", Offset="0x11E169C", VA="0x11E169C")]
	private void EquipUnitSkinIndex(int skinDefIndex)
	{
	}

	[Address(RVA="0x11E1B94", Offset="0x11E1B94", VA="0x11E1B94")]
	private void FeatureInitializeReady(UnitDetailsGameState.Context unitDetailsContext)
	{
	}

	[Address(RVA="0x11E1850", Offset="0x11E1850", VA="0x11E1850")]
	private void FindUnitSkinItem(int skinDefIndex)
	{
	}

	[Address(RVA="0x11E01B8", Offset="0x11E01B8", VA="0x11E01B8")]
	private void GearTierUpUnit()
	{
	}

	[Address(RVA="0x11DF998", Offset="0x11DF998", VA="0x11DF998", Slot="13")]
	public void HandleDispatchAction(DUnitDetailsViewAction action)
	{
	}

	[Address(RVA="0x11E0958", Offset="0x11E0958", VA="0x11E0958", Slot="14")]
	public void HandleDispatchAction(DUnitDetailsGearSlotAction action)
	{
	}

	[Address(RVA="0x11E0B0C", Offset="0x11E0B0C", VA="0x11E0B0C", Slot="15")]
	public void HandleDispatchAction(DUnitDetailsAbilityListItemAction action)
	{
	}

	[Address(RVA="0x11E0D90", Offset="0x11E0D90", VA="0x11E0D90", Slot="16")]
	public void HandleDispatchAction(DUnitTrainSuccessAction action)
	{
	}

	[Address(RVA="0x11E1310", Offset="0x11E1310", VA="0x11E1310", Slot="17")]
	public void HandleDispatchAction(DPopupControllerAction action)
	{
	}

	[Address(RVA="0x11E166C", Offset="0x11E166C", VA="0x11E166C", Slot="18")]
	public void HandleDispatchAction(DUnitSkinAction action)
	{
	}

	[Address(RVA="0x11DF674", Offset="0x11DF674", VA="0x11DF674", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x11E1AB0", Offset="0x11E1AB0", VA="0x11E1AB0")]
	private void LoadView(Action finished)
	{
	}

	[Address(RVA="0x11DFD98", Offset="0x11DFD98", VA="0x11DFD98")]
	private void PromoteUnit(DUnitDetailsViewAction.Type actionType)
	{
	}

	[Address(RVA="0x11DFFB0", Offset="0x11DFFB0", VA="0x11DFFB0")]
	private void RequestTrainUnit()
	{
	}

	[Address(RVA="0x11E2AC8", Offset="0x11E2AC8", VA="0x11E2AC8")]
	private void SendEquipAllGearTelemetry(long numGearEquipped, InventoryDelta inventoryDelta)
	{
	}

	[Address(RVA="0x11E24EC", Offset="0x11E24EC", VA="0x11E24EC")]
	private void SendPromoteTelemetry(PromoteUnitRequest request, PromoteUnitResponse response)
	{
	}

	[Address(RVA="0x11E2270", Offset="0x11E2270", VA="0x11E2270")]
	private void SendUnlockTelemetry(PromoteUnitRequest request, PromoteUnitResponse response)
	{
	}

	[Address(RVA="0x11DF8D0", Offset="0x11DF8D0", VA="0x11DF8D0", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x11DF908", Offset="0x11DF908", VA="0x11DF908", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x11E1848", Offset="0x11E1848", VA="0x11E1848")]
	private void UnequipUnitSkin()
	{
	}

	[Address(RVA="0x11E0DCC", Offset="0x11E0DCC", VA="0x11E0DCC")]
	private void UpdateUnit(ulong unitId)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CFCC", Offset="0x104CFCC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitDetailsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public UnitDetailsGameState.Context unitDetailsContext;

		[Address(RVA="0x11DF8C8", Offset="0x11DF8C8", VA="0x11DF8C8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11E2C90", Offset="0x11E2C90", VA="0x11E2C90")]
		internal void <Initialize>b__0(Action jobFinished)
		{
		}

		[Address(RVA="0x11E2D7C", Offset="0x11E2D7C", VA="0x11E2D7C")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CFDC", Offset="0x104CFDC")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[Address(RVA="0x11E2D74", Offset="0x11E2D74", VA="0x11E2D74")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x11E2DAC", Offset="0x11E2DAC", VA="0x11E2DAC")]
		internal void <Initialize>b__2(UnitDetailsScene _)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CFEC", Offset="0x104CFEC")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitDetailsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11E1B8C", Offset="0x11E1B8C", VA="0x11E1B8C")]
		public <>c__DisplayClass10_0()
		{
		}

		[Address(RVA="0x11E2DC0", Offset="0x11E2DC0", VA="0x11E2DC0")]
		internal void <LoadView>b__0(UnitDetailsView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CFFC", Offset="0x104CFFC")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset="0x10")]
		public DUnitDetailsViewAction.Type actionType;

		[FieldOffset(Offset="0x18")]
		public UnitDetailsController <>4__this;

		[FieldOffset(Offset="0x20")]
		public PromoteUnitRequest request;

		[FieldOffset(Offset="0x28")]
		public Action <>9__2;

		[Address(RVA="0x11E2260", Offset="0x11E2260", VA="0x11E2260")]
		public <>c__DisplayClass13_0()
		{
		}

		[Address(RVA="0x11E2EF0", Offset="0x11E2EF0", VA="0x11E2EF0")]
		internal void <PromoteUnit>b__0(PromoteUnitResponse response)
		{
		}

		[Address(RVA="0x11E3364", Offset="0x11E3364", VA="0x11E3364")]
		internal void <PromoteUnit>b__1(long failureCode)
		{
		}

		[Address(RVA="0x11E32F4", Offset="0x11E32F4", VA="0x11E32F4")]
		internal void <PromoteUnit>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D00C", Offset="0x104D00C")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitDetailsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Unit oldUnit;

		[Address(RVA="0x11E2268", Offset="0x11E2268", VA="0x11E2268")]
		public <>c__DisplayClass15_0()
		{
		}

		[Address(RVA="0x11E346C", Offset="0x11E346C", VA="0x11E346C")]
		internal void <GearTierUpUnit>b__0(GearTierUpResponse response)
		{
		}

		[Address(RVA="0x11E3664", Offset="0x11E3664", VA="0x11E3664")]
		internal void <GearTierUpUnit>b__1(long failureCode)
		{
		}

		[Address(RVA="0x11E3734", Offset="0x11E3734", VA="0x11E3734")]
		internal void <GearTierUpUnit>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D01C", Offset="0x104D01C")]
	private sealed class <>c__DisplayClass21_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitDetailsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ulong skinItemId;

		[Address(RVA="0x11E2AB8", Offset="0x11E2AB8", VA="0x11E2AB8")]
		public <>c__DisplayClass21_0()
		{
		}

		[Address(RVA="0x11E37A8", Offset="0x11E37A8", VA="0x11E37A8")]
		internal void <EquipUnitSkin>b__0(EquipUnitSkinResponse response)
		{
		}

		[Address(RVA="0x11E399C", Offset="0x11E399C", VA="0x11E399C")]
		internal void <EquipUnitSkin>b__1(long errorCode)
		{
		}

		[Address(RVA="0x11E3AAC", Offset="0x11E3AAC", VA="0x11E3AAC")]
		internal void <EquipUnitSkin>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D02C", Offset="0x104D02C")]
	private sealed class <>c__DisplayClass23_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitDetailsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public long oldGearEquippedCount;

		[FieldOffset(Offset="0x20")]
		public Unit oldUnit;

		[FieldOffset(Offset="0x28")]
		public EquipAllGearRequest request;

		[Address(RVA="0x11E2AC0", Offset="0x11E2AC0", VA="0x11E2AC0")]
		public <>c__DisplayClass23_0()
		{
		}

		[Address(RVA="0x11E3B20", Offset="0x11E3B20", VA="0x11E3B20")]
		internal void <EquipAllGear>b__0(EquipAllGearResponse response)
		{
		}

		[Address(RVA="0x11E3E5C", Offset="0x11E3E5C", VA="0x11E3E5C")]
		internal void <EquipAllGear>b__1(long failureCode)
		{
		}

		[Address(RVA="0x11E3F3C", Offset="0x11E3F3C", VA="0x11E3F3C")]
		internal void <EquipAllGear>b__2()
		{
		}
	}
}