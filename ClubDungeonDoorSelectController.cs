using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using Zenject;

public class ClubDungeonDoorSelectController : AFeatureController, IDispatchHandler<DClubDungeonDoorSelected>, IDispatchHandler, IDispatchHandler<DClubDungeonDoorSelectViewAction>, IDispatchHandler<DViewSequencerEndAction>
{
	[FieldOffset(Offset="0x0")]
	private const int MIN_NUM_DOOR_TRYS = 3;

	[Attribute(Name="InjectAttribute", RVA="0x1056AA8", Offset="0x1056AA8")]
	[FieldOffset(Offset="0x68")]
	private ClubService _clubService;

	[Attribute(Name="InjectAttribute", RVA="0x1056AB8", Offset="0x1056AB8")]
	[FieldOffset(Offset="0x70")]
	private ViewSequencerController _sequencerController;

	[Attribute(Name="InjectAttribute", RVA="0x1056AC8", Offset="0x1056AC8")]
	[FieldOffset(Offset="0x78")]
	private LocalizationManager _locManager;

	[Attribute(Name="InjectAttribute", RVA="0x1056AD8", Offset="0x1056AD8")]
	[FieldOffset(Offset="0x80")]
	private DiContainer _diContainer;

	[FieldOffset(Offset="0x88")]
	private ClubDungeonDoorSelectView _doorSelectView;

	[FieldOffset(Offset="0x90")]
	private List<ulong> _failedDoors;

	[FieldOffset(Offset="0x98")]
	private string _mapPrefab;

	[FieldOffset(Offset="0xA0")]
	private ClubDungeonDoorSelectController.DoorState _doorState;

	[FieldOffset(Offset="0xA4")]
	private int _numDoorTrys;

	[FieldOffset(Offset="0xA8")]
	private bool _hasSelectedDoor;

	[FieldOffset(Offset="0xB0")]
	private ClubDungeonDoorSelectViewSequencer _activeSequencer;

	[Address(RVA="0x11AD36C", Offset="0x11AD36C", VA="0x11AD36C")]
	public ClubDungeonDoorSelectController()
	{
	}

	[Address(RVA="0x11AD374", Offset="0x11AD374", VA="0x11AD374")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F094", Offset="0x106F094")]
	private void <SelectDungeonDoor>b__9_0(SelectClubDungeonDoorResponse response)
	{
	}

	[Address(RVA="0x11AD3C8", Offset="0x11AD3C8", VA="0x11AD3C8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F0A4", Offset="0x106F0A4")]
	private void <SelectDungeonDoor>b__9_1(long failureCode)
	{
	}

	[Address(RVA="0x11AD290", Offset="0x11AD290", VA="0x11AD290")]
	private void HandleActionPreInitialize(ASequenceAction sequenceAction)
	{
	}

	[Address(RVA="0x11ACFC0", Offset="0x11ACFC0", VA="0x11ACFC0", Slot="9")]
	protected override void HandleBackButton(AView view)
	{
	}

	[Address(RVA="0x11AC8C8", Offset="0x11AC8C8", VA="0x11AC8C8", Slot="13")]
	public void HandleDispatchAction(DClubDungeonDoorSelected action)
	{
	}

	[Address(RVA="0x11ACBEC", Offset="0x11ACBEC", VA="0x11ACBEC", Slot="14")]
	public void HandleDispatchAction(DClubDungeonDoorSelectViewAction action)
	{
	}

	[Address(RVA="0x11ACC8C", Offset="0x11ACC8C", VA="0x11ACC8C", Slot="15")]
	public void HandleDispatchAction(DViewSequencerEndAction action)
	{
	}

	[Address(RVA="0x11AC6A0", Offset="0x11AC6A0", VA="0x11AC6A0", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x11AD028", Offset="0x11AD028", VA="0x11AD028")]
	private void LoadDoorSelectView(Action finished)
	{
	}

	[Address(RVA="0x11ACDCC", Offset="0x11ACDCC", VA="0x11ACDCC")]
	private void PlayDoorVisual(ClubDungeonDoorSelectViewSequencer sequencer)
	{
	}

	[Address(RVA="0x11AD10C", Offset="0x11AD10C", VA="0x11AD10C")]
	private void RequestDungeonDoors(Action finished)
	{
	}

	[Address(RVA="0x11ACA68", Offset="0x11ACA68", VA="0x11ACA68")]
	private void SelectDungeonDoor(ulong door)
	{
	}

	[Address(RVA="0x11AC84C", Offset="0x11AC84C", VA="0x11AC84C", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x11AC88C", Offset="0x11AC88C", VA="0x11AC88C", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B90C", Offset="0x104B90C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonDoorSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[FieldOffset(Offset="0x20")]
		public Action <>9__1;

		[Address(RVA="0x11AC844", Offset="0x11AC844", VA="0x11AC844")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11AD4A0", Offset="0x11AD4A0", VA="0x11AD4A0")]
		internal void <Initialize>b__0()
		{
		}

		[Address(RVA="0x11AD734", Offset="0x11AD734", VA="0x11AD734")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B91C", Offset="0x104B91C")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonDoorSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11AD104", Offset="0x11AD104", VA="0x11AD104")]
		public <>c__DisplayClass7_0()
		{
		}

		[Address(RVA="0x11AD7A4", Offset="0x11AD7A4", VA="0x11AD7A4")]
		internal void <LoadDoorSelectView>b__0(ClubDungeonDoorSelectView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B92C", Offset="0x104B92C")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonDoorSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11AD288", Offset="0x11AD288", VA="0x11AD288")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x11AD7FC", Offset="0x11AD7FC", VA="0x11AD7FC")]
		internal void <RequestDungeonDoors>b__0(ClubDungeonDoorsResponse response)
		{
		}

		[Address(RVA="0x11AD8FC", Offset="0x11AD8FC", VA="0x11AD8FC")]
		internal void <RequestDungeonDoors>b__1(long failureCode)
		{
		}
	}

	private enum DoorState
	{
		[FieldOffset(Offset="0x0")]
		Unknown,
		[FieldOffset(Offset="0x0")]
		Success,
		[FieldOffset(Offset="0x0")]
		Fail
	}
}