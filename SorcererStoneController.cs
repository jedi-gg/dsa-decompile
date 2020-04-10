using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class SorcererStoneController : AFeatureController, IDispatchHandler<DSorcererStoneViewAction>, IDispatchHandler, IDispatchHandler<DSorcererStoneCraftedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105C5F0", Offset="0x105C5F0")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C600", Offset="0x105C600")]
	[FieldOffset(Offset="0x70")]
	private InventoryService _inventoryService;

	[Attribute(Name="InjectAttribute", RVA="0x105C610", Offset="0x105C610")]
	[FieldOffset(Offset="0x78")]
	private TelemetryTranslator _telemetryTranslator;

	[FieldOffset(Offset="0x80")]
	private SorcererStoneView _view;

	[FieldOffset(Offset="0x88")]
	private SorcererStoneGameState.Context _context;

	[FieldOffset(Offset="0x90")]
	private Unit _unit;

	[FieldOffset(Offset="0x98")]
	private List<ulong> _unitCycleList;

	[FieldOffset(Offset="0xA0")]
	private int _currentUnitCycleIndex;

	[Address(RVA="0x12392D0", Offset="0x12392D0", VA="0x12392D0")]
	public SorcererStoneController()
	{
	}

	[Address(RVA="0x1238288", Offset="0x1238288", VA="0x1238288", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x1237E84", Offset="0x1237E84", VA="0x1237E84")]
	private void CycleUnit(int indexChange)
	{
	}

	[Address(RVA="0x1237778", Offset="0x1237778", VA="0x1237778")]
	private void EquipStone(ulong stoneId)
	{
	}

	[Address(RVA="0x1237660", Offset="0x1237660", VA="0x1237660", Slot="13")]
	public void HandleDispatchAction(DSorcererStoneViewAction action)
	{
	}

	[Address(RVA="0x1237FA8", Offset="0x1237FA8", VA="0x1237FA8", Slot="14")]
	public void HandleDispatchAction(DSorcererStoneCraftedAction action)
	{
	}

	[Address(RVA="0x12371C0", Offset="0x12371C0", VA="0x12371C0", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1237C20", Offset="0x1237C20", VA="0x1237C20")]
	private void SwapStone(ulong stoneId)
	{
	}

	[Address(RVA="0x1237608", Offset="0x1237608", VA="0x1237608", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x12379DC", Offset="0x12379DC", VA="0x12379DC")]
	private void UnequipStone()
	{
	}

	[Address(RVA="0x12382E0", Offset="0x12382E0", VA="0x12382E0")]
	private void UpdateViewState()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C9EC", Offset="0x104C9EC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public SorcererStoneController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x1237600", Offset="0x1237600", VA="0x1237600")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x12392D8", Offset="0x12392D8", VA="0x12392D8")]
		internal void <Initialize>b__0(Action jobFinished)
		{
		}

		[Address(RVA="0x12393C4", Offset="0x12393C4", VA="0x12393C4")]
		internal void <Initialize>b__1(Action jobFinished)
		{
		}

		[Address(RVA="0x12394B8", Offset="0x12394B8", VA="0x12394B8")]
		internal void <Initialize>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C9FC", Offset="0x104C9FC")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[Address(RVA="0x12393BC", Offset="0x12393BC", VA="0x12393BC")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x12394F0", Offset="0x12394F0", VA="0x12394F0")]
		internal void <Initialize>b__3(SorcererStoneScene _)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CA0C", Offset="0x104CA0C")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public SorcererStoneController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[FieldOffset(Offset="0x20")]
		public Action <>9__5;

		[Address(RVA="0x12394B0", Offset="0x12394B0", VA="0x12394B0")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x1239504", Offset="0x1239504", VA="0x1239504")]
		internal void <Initialize>b__4(SorcererStoneView view)
		{
		}

		[Address(RVA="0x12396BC", Offset="0x12396BC", VA="0x12396BC")]
		internal void <Initialize>b__5()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CA1C", Offset="0x104CA1C")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset="0x10")]
		public EquipSorcererStoneRequest request;

		[FieldOffset(Offset="0x18")]
		public SorcererStoneController <>4__this;

		[FieldOffset(Offset="0x20")]
		public ulong stoneId;

		[Address(RVA="0x12392B8", Offset="0x12392B8", VA="0x12392B8")]
		public <>c__DisplayClass7_0()
		{
		}

		[Address(RVA="0x1239C5C", Offset="0x1239C5C", VA="0x1239C5C")]
		internal void <EquipStone>b__0(EquipSorcererStoneResponse response)
		{
		}

		[Address(RVA="0x123A038", Offset="0x123A038", VA="0x123A038")]
		internal void <EquipStone>b__1(long failureCode)
		{
		}

		[Address(RVA="0x123A180", Offset="0x123A180", VA="0x123A180")]
		internal void <EquipStone>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CA2C", Offset="0x104CA2C")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public UnequipSorcererStoneRequest request;

		[FieldOffset(Offset="0x18")]
		public SorcererStoneController <>4__this;

		[FieldOffset(Offset="0x20")]
		public ulong stoneId;

		[Address(RVA="0x12392C0", Offset="0x12392C0", VA="0x12392C0")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x123A1F4", Offset="0x123A1F4", VA="0x123A1F4")]
		internal void <UnequipStone>b__0(UnequipSorcererStoneResponse response)
		{
		}

		[Address(RVA="0x123A4F0", Offset="0x123A4F0", VA="0x123A4F0")]
		internal void <UnequipStone>b__1(long failureCode)
		{
		}

		[Address(RVA="0x123A5F8", Offset="0x123A5F8", VA="0x123A5F8")]
		internal void <UnequipStone>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CA3C", Offset="0x104CA3C")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset="0x10")]
		public SwapSorcererStoneRequest request;

		[FieldOffset(Offset="0x18")]
		public SorcererStoneController <>4__this;

		[FieldOffset(Offset="0x20")]
		public ulong stoneId;

		[Address(RVA="0x12392C8", Offset="0x12392C8", VA="0x12392C8")]
		public <>c__DisplayClass9_0()
		{
		}

		[Address(RVA="0x123A66C", Offset="0x123A66C", VA="0x123A66C")]
		internal void <SwapStone>b__0(SwapSorcererStoneResponse response)
		{
		}

		[Address(RVA="0x123A984", Offset="0x123A984", VA="0x123A984")]
		internal void <SwapStone>b__1(long failureCode)
		{
		}

		[Address(RVA="0x123AACC", Offset="0x123AACC", VA="0x123AACC")]
		internal void <SwapStone>b__2()
		{
		}
	}
}