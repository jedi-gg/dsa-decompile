using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubWarNodePopupController : APopupController, IDispatchHandler<DClubWarNodePopupViewAction>, IDispatchHandler, IDispatchHandler<DClubWarSquadListItemAction>, IDispatchHandler<DClubWarNodeDirtyAction>, IDispatchHandler<DClubWarRefreshing>
{
	[Attribute(Name="InjectAttribute", RVA="0x10572E8", Offset="0x10572E8")]
	[FieldOffset(Offset="0x38")]
	private ClubService _clubService;

	[Attribute(Name="InjectAttribute", RVA="0x10572F8", Offset="0x10572F8")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1057308", Offset="0x1057308")]
	[FieldOffset(Offset="0x48")]
	private ClubWarDomainController _clubWarDc;

	[Attribute(Name="InjectAttribute", RVA="0x1057318", Offset="0x1057318")]
	[FieldOffset(Offset="0x50")]
	private Serverproto.Unit.Factory _unitFactory;

	[Attribute(Name="InjectAttribute", RVA="0x1057328", Offset="0x1057328")]
	[FieldOffset(Offset="0x58")]
	private Serverproto.Spell.Factory _spellFactory;

	[Attribute(Name="InjectAttribute", RVA="0x1057338", Offset="0x1057338")]
	[FieldOffset(Offset="0x60")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x1057348", Offset="0x1057348")]
	[FieldOffset(Offset="0x68")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1057358", Offset="0x1057358")]
	[FieldOffset(Offset="0x70")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x1057368", Offset="0x1057368")]
	[FieldOffset(Offset="0x78")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x80")]
	private ClubWarNodePopupView _view;

	[FieldOffset(Offset="0x88")]
	private ClubWarNodePopupController.Context _context;

	[FieldOffset(Offset="0x90")]
	private ClubWarNodeDetailResponse _nodeDetail;

	[FieldOffset(Offset="0x98")]
	private List<ClubWarNode?> _cycleNodes;

	[FieldOffset(Offset="0xA0")]
	private bool _isRefreshing;

	[Address(RVA="0x14D4874", Offset="0x14D4874", VA="0x14D4874")]
	public ClubWarNodePopupController()
	{
	}

	[Address(RVA="0x14D2C48", Offset="0x14D2C48", VA="0x14D2C48")]
	private void AssignSquadToNode()
	{
	}

	[Address(RVA="0x14D1F54", Offset="0x14D1F54", VA="0x14D1F54")]
	private void Capture()
	{
	}

	[Address(RVA="0x14D19FC", Offset="0x14D19FC", VA="0x14D19FC")]
	private void CycleNodeDetail(int offset)
	{
	}

	[Address(RVA="0x14D2564", Offset="0x14D2564", VA="0x14D2564")]
	private void EnterBattle(string defenseId)
	{
	}

	[Address(RVA="0x14D3218", Offset="0x14D3218", VA="0x14D3218")]
	private void FetchNodeDetail(Action<bool> finished)
	{
	}

	[Address(RVA="0x14D19B0", Offset="0x14D19B0", VA="0x14D19B0", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x14D19B8", Offset="0x14D19B8", VA="0x14D19B8", Slot="14")]
	public void HandleDispatchAction(DClubWarNodePopupViewAction action)
	{
	}

	[Address(RVA="0x14D232C", Offset="0x14D232C", VA="0x14D232C", Slot="15")]
	public void HandleDispatchAction(DClubWarSquadListItemAction action)
	{
	}

	[Address(RVA="0x14D3164", Offset="0x14D3164", VA="0x14D3164", Slot="16")]
	public void HandleDispatchAction(DClubWarNodeDirtyAction action)
	{
	}

	[Address(RVA="0x14D3210", Offset="0x14D3210", VA="0x14D3210", Slot="17")]
	public void HandleDispatchAction(DClubWarRefreshing action)
	{
	}

	[Address(RVA="0x14D1298", Offset="0x14D1298", VA="0x14D1298", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x14D2E4C", Offset="0x14D2E4C", VA="0x14D2E4C")]
	private void MakeRebuildDefenseSquad()
	{
	}

	[Address(RVA="0x14D3450", Offset="0x14D3450", VA="0x14D3450")]
	private void PopulateView()
	{
	}

	[Address(RVA="0x14D21F8", Offset="0x14D21F8", VA="0x14D21F8")]
	private void RefreshNodeDetails(bool showScrim)
	{
	}

	[Address(RVA="0x14D3F14", Offset="0x14D3F14", VA="0x14D3F14")]
	private void SendSquadTelemetry(long referenceId, ClubWarSquad squad)
	{
	}

	[Address(RVA="0x14D1CE0", Offset="0x14D1CE0", VA="0x14D1CE0")]
	private void SetTarget()
	{
	}

	[Address(RVA="0x14D17A4", Offset="0x14D17A4", VA="0x14D17A4", Slot="9")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x14D1818", Offset="0x14D1818", VA="0x14D1818", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x14D237C", Offset="0x14D237C", VA="0x14D237C")]
	private void UnassignSquadFromNode(string squadId)
	{
	}

	[Address(RVA="0x14D1588", Offset="0x14D1588", VA="0x14D1588")]
	private void UpdateCycleNodeList()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BA8C", Offset="0x104BA8C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarNodePopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x14D1580", Offset="0x14D1580", VA="0x14D1580")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x14D48E4", Offset="0x14D48E4", VA="0x14D48E4")]
		internal void <Initialize>b__0(Action jobComplete)
		{
		}

		[Address(RVA="0x14D49B0", Offset="0x14D49B0", VA="0x14D49B0")]
		internal void <Initialize>b__1(Action jobComplete)
		{
		}

		[Address(RVA="0x14D4AA4", Offset="0x14D4AA4", VA="0x14D4AA4")]
		internal void <Initialize>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BA9C", Offset="0x104BA9C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action jobComplete;

		[Address(RVA="0x14D49A8", Offset="0x14D49A8", VA="0x14D49A8")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x14D4BEC", Offset="0x14D4BEC", VA="0x14D4BEC")]
		internal void <Initialize>b__3(bool _)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BAAC", Offset="0x104BAAC")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action jobComplete;

		[FieldOffset(Offset="0x18")]
		public ClubWarNodePopupController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x14D4A9C", Offset="0x14D4A9C", VA="0x14D4A9C")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x14D4C00", Offset="0x14D4C00", VA="0x14D4C00")]
		internal void <Initialize>b__4(ClubWarNodePopupView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BACC", Offset="0x104BACC")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarNodePopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubWarNode? lastNode;

		[Address(RVA="0x14D3E94", Offset="0x14D3E94", VA="0x14D3E94")]
		public <>c__DisplayClass10_0()
		{
		}

		[Address(RVA="0x14D4C68", Offset="0x14D4C68", VA="0x14D4C68")]
		internal void <CycleNodeDetail>b__0(bool success)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BADC", Offset="0x104BADC")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarNodePopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public string squadId;

		[Address(RVA="0x14D3EF4", Offset="0x14D3EF4", VA="0x14D3EF4")]
		public <>c__DisplayClass13_0()
		{
		}

		[Address(RVA="0x14D4D44", Offset="0x14D4D44", VA="0x14D4D44")]
		internal void <UnassignSquadFromNode>b__0(ClubWarUnsetDefenseResponse resp)
		{
		}

		[Address(RVA="0x14D53AC", Offset="0x14D53AC", VA="0x14D53AC")]
		internal void <UnassignSquadFromNode>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BAEC", Offset="0x104BAEC")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarNodePopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public string nodeId;

		[Address(RVA="0x14D3EFC", Offset="0x14D3EFC", VA="0x14D3EFC")]
		public <>c__DisplayClass14_0()
		{
		}

		[Address(RVA="0x14D55E0", Offset="0x14D55E0", VA="0x14D55E0")]
		internal void <SetTarget>b__0(ClubWarSetNodeTargetResponse resp)
		{
		}

		[Address(RVA="0x14D5838", Offset="0x14D5838", VA="0x14D5838")]
		internal void <SetTarget>b__1(long errorCode)
		{
		}

		[Address(RVA="0x14D58B8", Offset="0x14D58B8", VA="0x14D58B8")]
		internal void <SetTarget>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BAFC", Offset="0x104BAFC")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarNodePopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public string nodeId;

		[Address(RVA="0x14D3F04", Offset="0x14D3F04", VA="0x14D3F04")]
		public <>c__DisplayClass15_0()
		{
		}

		[Address(RVA="0x14D592C", Offset="0x14D592C", VA="0x14D592C")]
		internal void <Capture>b__0(ClubWarCaptureUndefendedNodeResponse resp)
		{
		}

		[Address(RVA="0x14D5B48", Offset="0x14D5B48", VA="0x14D5B48")]
		internal void <Capture>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BB0C", Offset="0x104BB0C")]
	private sealed class <>c__DisplayClass16_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarNodePopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public string nodeId;

		[Address(RVA="0x14D3F0C", Offset="0x14D3F0C", VA="0x14D3F0C")]
		public <>c__DisplayClass16_0()
		{
		}

		[Address(RVA="0x14D5C1C", Offset="0x14D5C1C", VA="0x14D5C1C")]
		internal void <MakeRebuildDefenseSquad>b__0(ClubWarClubDefensesResponse response)
		{
		}

		[Address(RVA="0x14D5E44", Offset="0x14D5E44", VA="0x14D5E44")]
		internal void <MakeRebuildDefenseSquad>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BB1C", Offset="0x104BB1C")]
	private sealed class <>c__DisplayClass19_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarNodePopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool showScrim;

		[Address(RVA="0x14D486C", Offset="0x14D486C", VA="0x14D486C")]
		public <>c__DisplayClass19_0()
		{
		}

		[Address(RVA="0x14D5F40", Offset="0x14D5F40", VA="0x14D5F40")]
		internal void <RefreshNodeDetails>b__0(bool success)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BABC", Offset="0x104BABC")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarNodePopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubWarNodeDetailRequest request;

		[FieldOffset(Offset="0x20")]
		public Action<bool> finished;

		[Address(RVA="0x14D3448", Offset="0x14D3448", VA="0x14D3448")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x14D5FFC", Offset="0x14D5FFC", VA="0x14D5FFC")]
		internal void <FetchNodeDetail>b__0(ClubWarNodeDetailResponse response)
		{
		}

		[Address(RVA="0x14D6534", Offset="0x14D6534", VA="0x14D6534")]
		internal void <FetchNodeDetail>b__1(long errorCode)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarNode? Node;

		[Address(RVA="0x14D6614", Offset="0x14D6614", VA="0x14D6614")]
		public Context()
		{
		}
	}
}