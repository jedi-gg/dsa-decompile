using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleWorldView : AStandardView, IDispatchHandler<DBattleUnitsControllerAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	private const float RETICLE_APPEAR_DELAY_S = 0.25f;

	[FieldOffset(Offset="0x68")]
	private MonoArchetypePool<BattleUnitPingComponent> _unitPingPool;

	[FieldOffset(Offset="0x70")]
	private MonoArchetypePool<BattleSpawnPointComponent> _spawnPointPool;

	[FieldOffset(Offset="0x78")]
	private bool _showReticleIfHaveTarget;

	[FieldOffset(Offset="0x80")]
	private Camera _mainCamera;

	[FieldOffset(Offset="0x88")]
	private BattleUnit _currentTarget;

	[FieldOffset(Offset="0x90")]
	private Tweener _selectTargetTween;

	private BattleWorldView.SerializedFields Fields
	{
		[Address(RVA="0x111EBF0", Offset="0x111EBF0", VA="0x111EBF0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x111ED8C", Offset="0x111ED8C", VA="0x111ED8C")]
	public BattleWorldView()
	{
	}

	[Address(RVA="0x111ED94", Offset="0x111ED94", VA="0x111ED94")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E768", Offset="0x106E768")]
	private void <ViewAssetLoaded>b__9_0()
	{
	}

	[Address(RVA="0x111E0D0", Offset="0x111E0D0", VA="0x111E0D0")]
	public void AddSpawnPoint(Vector3 position, int teamId, int spawnIndex)
	{
	}

	[Address(RVA="0x111D354", Offset="0x111D354", VA="0x111D354")]
	public int GetNearestSpawnPointToScreenPos(Vector2 screenPos)
	{
		return new int();
	}

	[Address(RVA="0x111E46C", Offset="0x111E46C", VA="0x111E46C")]
	private BattleUnitPingComponent GetPingForUnit(byte unitId)
	{
		return null;
	}

	[Address(RVA="0x111E77C", Offset="0x111E77C", VA="0x111E77C", Slot="21")]
	public void HandleDispatchAction(DBattleUnitsControllerAction action)
	{
	}

	[Address(RVA="0x111D890", Offset="0x111D890", VA="0x111D890")]
	public void PingUnit(BattleUnit unit)
	{
	}

	[Address(RVA="0x111DA7C", Offset="0x111DA7C", VA="0x111DA7C")]
	public void SetSpawnPointOccupied(int teamId, int spawnIndex, bool isOccupied)
	{
	}

	[Address(RVA="0x111D814", Offset="0x111D814", VA="0x111D814")]
	public void SetTarget(BattleUnit target)
	{
	}

	[Address(RVA="0x111CD44", Offset="0x111CD44", VA="0x111CD44")]
	public void ShowSpawnPoints(bool show)
	{
	}

	[Address(RVA="0x111D7E8", Offset="0x111D7E8", VA="0x111D7E8")]
	public void ShowTargetReticle(bool show)
	{
	}

	[Address(RVA="0x111CAC4", Offset="0x111CAC4", VA="0x111CAC4")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x111E2D0", Offset="0x111E2D0", VA="0x111E2D0")]
	private void UpdateTargetReticle(bool playSelectTween = false)
	{
	}

	[Address(RVA="0x111E860", Offset="0x111E860", VA="0x111E860", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x111ECD0", Offset="0x111ECD0", VA="0x111ECD0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public UnityEngine.GameObject TargetReticle;

		[FieldOffset(Offset="0x30")]
		public BattleUnitPingComponent UnitPingArchetype;

		[FieldOffset(Offset="0x38")]
		public BattleSpawnPointComponent SpawnPointArchetype;

		[Address(RVA="0x111EDD8", Offset="0x111EDD8", VA="0x111EDD8")]
		public SerializedFields()
		{
		}
	}

	private enum TargetingError
	{
		[FieldOffset(Offset="0x0")]
		UNIT_TAUNTING
	}
}