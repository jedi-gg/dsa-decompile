using BattleLib;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using Zenject;

public class BattleWorldController : IDispatchHandler<DBattleSelectTargetAction>, IDispatchHandler, IDispatchHandler<DBattlePingUnitAction>, IDispatchHandler<DBattleEndedAction>, IDispatchHandler<DBattleUnitsControllerAction>, IDispatchHandler<DBattleCinematicAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054120", Offset="0x1054120")]
	[FieldOffset(Offset="0x10")]
	private DiContainer _container;

	[Attribute(Name="InjectAttribute", RVA="0x1054130", Offset="0x1054130")]
	[FieldOffset(Offset="0x18")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1054140", Offset="0x1054140")]
	[FieldOffset(Offset="0x20")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1054150", Offset="0x1054150")]
	[FieldOffset(Offset="0x28")]
	private BattleUnitsController _unitsController;

	[Attribute(Name="InjectAttribute", RVA="0x1054160", Offset="0x1054160")]
	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x38")]
	private BattleWorldView _worldView;

	[FieldOffset(Offset="0x40")]
	private bool _isShutdown;

	[FieldOffset(Offset="0x41")]
	private bool _targetReticleShouldShow;

	[Address(RVA="0x111E220", Offset="0x111E220", VA="0x111E220")]
	public BattleWorldController()
	{
	}

	[Address(RVA="0x111DE04", Offset="0x111DE04", VA="0x111DE04")]
	private void AddAllSpawnPoints()
	{
	}

	[Address(RVA="0x111D340", Offset="0x111D340", VA="0x111D340")]
	public int GetNearestSpawnPointToScreenPos(Vector2 screenPos)
	{
		return new int();
	}

	[Address(RVA="0x111D7F8", Offset="0x111D7F8", VA="0x111D7F8", Slot="4")]
	public void HandleDispatchAction(DBattleSelectTargetAction action)
	{
	}

	[Address(RVA="0x111D824", Offset="0x111D824", VA="0x111D824", Slot="5")]
	public void HandleDispatchAction(DBattlePingUnitAction action)
	{
	}

	[Address(RVA="0x111D974", Offset="0x111D974", VA="0x111D974", Slot="6")]
	public void HandleDispatchAction(DBattleEndedAction action)
	{
	}

	[Address(RVA="0x111D98C", Offset="0x111D98C", VA="0x111D98C", Slot="7")]
	public void HandleDispatchAction(DBattleUnitsControllerAction action)
	{
	}

	[Address(RVA="0x111DDBC", Offset="0x111DDBC", VA="0x111DDBC", Slot="8")]
	public void HandleDispatchAction(DBattleCinematicAction action)
	{
	}

	[Address(RVA="0x111C90C", Offset="0x111C90C", VA="0x111C90C")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x111DDFC", Offset="0x111DDFC", VA="0x111DDFC")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x111CD30", Offset="0x111CD30", VA="0x111CD30")]
	public void ShowSpawnPoints(bool show)
	{
	}

	[Address(RVA="0x111D7C4", Offset="0x111D7C4", VA="0x111D7C4")]
	public void ShowTargetReticle(bool show)
	{
	}

	[Address(RVA="0x111CA40", Offset="0x111CA40", VA="0x111CA40")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x111CAB4", Offset="0x111CAB4", VA="0x111CAB4")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B20C", Offset="0x104B20C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleWorldController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x111CA38", Offset="0x111CA38", VA="0x111CA38")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x111E228", Offset="0x111E228", VA="0x111E228")]
		internal void <Initialize>b__0(BattleWorldView view)
		{
		}
	}
}