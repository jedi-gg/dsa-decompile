using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class UnitTrainingController : APopupController, IDispatchHandler<DUnitTrainingViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105F8B0", Offset="0x105F8B0")]
	[FieldOffset(Offset="0x38")]
	private InventoryService _inventoryService;

	[Attribute(Name="InjectAttribute", RVA="0x105F8C0", Offset="0x105F8C0")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105F8D0", Offset="0x105F8D0")]
	[FieldOffset(Offset="0x48")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x50")]
	private UnitTrainingController.Context _context;

	[FieldOffset(Offset="0x58")]
	private UnitTrainingView _view;

	public override bool ShouldBeRestoredFromHistory
	{
		[Address(RVA="0x1515AA4", Offset="0x1515AA4", VA="0x1515AA4", Slot="7")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x15162B0", Offset="0x15162B0", VA="0x15162B0")]
	public UnitTrainingController()
	{
	}

	[Address(RVA="0x1515C04", Offset="0x1515C04", VA="0x1515C04", Slot="14")]
	public void HandleDispatchAction(DUnitTrainingViewAction action)
	{
	}

	[Address(RVA="0x1515AAC", Offset="0x1515AAC", VA="0x1515AAC", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x1515F4C", Offset="0x1515F4C", VA="0x1515F4C")]
	private void SendTrainTelemetry(TrainUnitRequest request, TrainUnitResponse response, long numLevels)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D1AC", Offset="0x104D1AC")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitTrainingController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x1515BFC", Offset="0x1515BFC", VA="0x1515BFC")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x15162B8", Offset="0x15162B8", VA="0x15162B8")]
		internal void <Initialize>b__0(UnitTrainingView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D1BC", Offset="0x104D1BC")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitTrainingController <>4__this;

		[FieldOffset(Offset="0x18")]
		public TrainUnitRequest request;

		[FieldOffset(Offset="0x20")]
		public long numLevels;

		[Address(RVA="0x1515F44", Offset="0x1515F44", VA="0x1515F44")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x1516BFC", Offset="0x1516BFC", VA="0x1516BFC")]
		internal void <HandleDispatchAction>b__0(TrainUnitResponse response)
		{
		}

		[Address(RVA="0x1516FF4", Offset="0x1516FF4", VA="0x1516FF4")]
		internal void <HandleDispatchAction>b__1(long failureCode)
		{
		}

		[Address(RVA="0x15170D4", Offset="0x15170D4", VA="0x15170D4")]
		internal void <HandleDispatchAction>b__2()
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly ulong UnitId;

		[Address(RVA="0x1517148", Offset="0x1517148", VA="0x1517148")]
		public Context(ulong unitId)
		{
		}
	}
}