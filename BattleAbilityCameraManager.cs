using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleAbilityCameraManager : MonoBehaviour, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.UnitTurnStarted>>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1052ABC", Offset="0x1052ABC")]
	[FieldOffset(Offset="0x18")]
	private BattleUnitsController _unitsController;

	[Attribute(Name="InjectAttribute", RVA="0x1052ACC", Offset="0x1052ACC")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x28")]
	private AbilityCameraAction _currentCamAction;

	[FieldOffset(Offset="0x30")]
	private List<BattleUnit> _neverHideUnits;

	[FieldOffset(Offset="0x38")]
	private List<BattleUnit> _hiddenUnits;

	[FieldOffset(Offset="0x40")]
	private Camera _mainCamera;

	[FieldOffset(Offset="0x48")]
	private bool _cullingIsDirty;

	[FieldOffset(Offset="0x49")]
	private bool _planeSourceIsReferencePoint;

	[FieldOffset(Offset="0x4C")]
	private Vector3 _planeSourcePos;

	[FieldOffset(Offset="0x58")]
	private Vector3 _planeTargetPos;

	[FieldOffset(Offset="0x64")]
	private float _planeCullingOffset;

	[Address(RVA="0x1165A50", Offset="0x1165A50", VA="0x1165A50")]
	public BattleAbilityCameraManager()
	{
	}

	[Address(RVA="0x1165404", Offset="0x1165404", VA="0x1165404")]
	public void CamActionExited(AbilityCameraAction camAction)
	{
	}

	[Address(RVA="0x1165198", Offset="0x1165198", VA="0x1165198")]
	public void EndCurrentCam()
	{
	}

	[Address(RVA="0x1165510", Offset="0x1165510", VA="0x1165510", Slot="4")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.UnitTurnStarted> action)
	{
	}

	[Address(RVA="0x11654D4", Offset="0x11654D4", VA="0x11654D4")]
	public void HideUnitsInFrontOfPlane(Vector3 referencePoint, float cullingOffset)
	{
	}

	[Address(RVA="0x11654F0", Offset="0x11654F0", VA="0x11654F0")]
	public void HideUnitsInFrontOfPlane(Vector3 sourcePos, Vector3 targetPos, float cullingOffset)
	{
	}

	[Address(RVA="0x1165820", Offset="0x1165820", VA="0x1165820")]
	private void HideUnitsInFrontOfPlane(Plane plane)
	{
	}

	[Address(RVA="0x1164E1C", Offset="0x1164E1C", VA="0x1164E1C")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1165514", Offset="0x1165514", VA="0x1165514", Slot="5")]
	protected virtual void LateUpdate()
	{
	}

	[Address(RVA="0x116527C", Offset="0x116527C", VA="0x116527C")]
	private void RestoreAllUnits()
	{
	}

	[Address(RVA="0x1164F4C", Offset="0x1164F4C", VA="0x1164F4C")]
	public void SetCurrentCamAction(AbilityCameraAction camAction)
	{
	}

	[Address(RVA="0x1164E60", Offset="0x1164E60", VA="0x1164E60")]
	public void Shutdown()
	{
	}
}