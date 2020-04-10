using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class TowerSelectController : AFeatureController, IDispatchHandler<DTowerSelectListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105D970", Offset="0x105D970")]
	[FieldOffset(Offset="0x68")]
	private TowerService _towerService;

	[Attribute(Name="InjectAttribute", RVA="0x105D980", Offset="0x105D980")]
	[FieldOffset(Offset="0x70")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105D990", Offset="0x105D990")]
	[FieldOffset(Offset="0x78")]
	private ContextualMessageController _contextualMessageController;

	[FieldOffset(Offset="0x80")]
	private List<TowerMap> _towerMaps;

	[FieldOffset(Offset="0x88")]
	private IList<TowerStatus> _statuses;

	[FieldOffset(Offset="0x90")]
	private TowerSelectView _view;

	[Address(RVA="0x1438668", Offset="0x1438668", VA="0x1438668")]
	public TowerSelectController()
	{
	}

	[Address(RVA="0x1437BB4", Offset="0x1437BB4", VA="0x1437BB4")]
	private void FinishInitialization(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x14377E4", Offset="0x14377E4", VA="0x14377E4", Slot="13")]
	public void HandleDispatchAction(DTowerSelectListItemAction action)
	{
	}

	[Address(RVA="0x14375F8", Offset="0x14375F8", VA="0x14375F8", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x143827C", Offset="0x143827C", VA="0x143827C")]
	private void LoadView(Action finished)
	{
	}

	[Address(RVA="0x14384E4", Offset="0x14384E4", VA="0x14384E4")]
	private void RequestStatuses(Action finished)
	{
	}

	[Address(RVA="0x1438360", Offset="0x1438360", VA="0x1438360")]
	private void RequestTowers(Action finished)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CEEC", Offset="0x104CEEC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public TowerSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x14377DC", Offset="0x14377DC", VA="0x14377DC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x14386D8", Offset="0x14386D8", VA="0x14386D8")]
		internal void <Initialize>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CEFC", Offset="0x104CEFC")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public TowerSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1438358", Offset="0x1438358", VA="0x1438358")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x1438708", Offset="0x1438708", VA="0x1438708")]
		internal void <LoadView>b__0(TowerSelectView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CF0C", Offset="0x104CF0C")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public TowerSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x14384DC", Offset="0x14384DC", VA="0x14384DC")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x1438760", Offset="0x1438760", VA="0x1438760")]
		internal void <RequestTowers>b__0(TowerResponse response)
		{
		}

		[Address(RVA="0x1438CC4", Offset="0x1438CC4", VA="0x1438CC4")]
		internal void <RequestTowers>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CF1C", Offset="0x104CF1C")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset="0x10")]
		public TowerSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1438660", Offset="0x1438660", VA="0x1438660")]
		public <>c__DisplayClass5_0()
		{
		}

		[Address(RVA="0x1438D94", Offset="0x1438D94", VA="0x1438D94")]
		internal void <RequestStatuses>b__0(TowerStatusResponse response)
		{
		}

		[Address(RVA="0x1438E08", Offset="0x1438E08", VA="0x1438E08")]
		internal void <RequestStatuses>b__1(long failureCode)
		{
		}
	}
}