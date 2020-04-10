using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class EmoteInventoryController : AFeatureController, IDispatchHandler<DEmoteInventorySelectedAction>, IDispatchHandler, IDispatchHandler<DEmoteInventoryModifyDeckAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10594D8", Offset="0x10594D8")]
	[FieldOffset(Offset="0x68")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x10594E8", Offset="0x10594E8")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10594F8", Offset="0x10594F8")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1059508", Offset="0x1059508")]
	[FieldOffset(Offset="0x80")]
	private InventoryService _inventoryService;

	[Attribute(Name="InjectAttribute", RVA="0x1059518", Offset="0x1059518")]
	[FieldOffset(Offset="0x88")]
	private TelemetryTranslator _telemetryTranslator;

	[FieldOffset(Offset="0x90")]
	private EmoteInventoryView _view;

	[FieldOffset(Offset="0x98")]
	private List<Gamedata.InventoryItem?> _allEmotes;

	[Address(RVA="0x1208020", Offset="0x1208020", VA="0x1208020")]
	public EmoteInventoryController()
	{
	}

	[Address(RVA="0x1208090", Offset="0x1208090", VA="0x1208090")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FF74", Offset="0x106FF74")]
	private int <PopulateView>b__6_0(Gamedata.InventoryItem? a, Gamedata.InventoryItem? b)
	{
		return new int();
	}

	[Address(RVA="0x12074BC", Offset="0x12074BC", VA="0x12074BC", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x1206E58", Offset="0x1206E58", VA="0x1206E58", Slot="13")]
	public void HandleDispatchAction(DEmoteInventorySelectedAction action)
	{
	}

	[Address(RVA="0x12070B8", Offset="0x12070B8", VA="0x12070B8", Slot="14")]
	public void HandleDispatchAction(DEmoteInventoryModifyDeckAction action)
	{
	}

	[Address(RVA="0x1206C6C", Offset="0x1206C6C", VA="0x1206C6C", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1207524", Offset="0x1207524", VA="0x1207524")]
	private void PopulateView()
	{
	}

	[Address(RVA="0x1206D70", Offset="0x1206D70", VA="0x1206D70", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1206DE0", Offset="0x1206DE0", VA="0x1206DE0", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C1BC", Offset="0x104C1BC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public EmoteInventoryController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x1206D68", Offset="0x1206D68", VA="0x1206D68")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1208208", Offset="0x1208208", VA="0x1208208")]
		internal void <Initialize>b__0(EmoteInventoryView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C1CC", Offset="0x104C1CC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public EmoteInventoryController <>4__this;

		[FieldOffset(Offset="0x18")]
		public DEmoteInventoryModifyDeckAction action;

		[Address(RVA="0x12074B4", Offset="0x12074B4", VA="0x12074B4")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x1208280", Offset="0x1208280", VA="0x1208280")]
		internal void <HandleDispatchAction>b__0(EquipEmoteResponse response)
		{
		}

		[Address(RVA="0x120866C", Offset="0x120866C", VA="0x120866C")]
		internal void <HandleDispatchAction>b__1(long errorCode)
		{
		}

		[Address(RVA="0x12086EC", Offset="0x12086EC", VA="0x12086EC")]
		internal void <HandleDispatchAction>b__2()
		{
		}
	}
}