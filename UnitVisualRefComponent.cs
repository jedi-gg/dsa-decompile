using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitVisualRefComponent : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private UnitVisualSequencer _spawnVisual;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private UnitVisualSequencer _deathVisual;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UnitVisualSequencer _victoryVisual;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitVisualSequencer _storeIdleVisual;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UnitVisualSequencer _storeIdleImmediateVisual;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UnitVisualSequencer _upgradeCelebrationVisual;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UnitVisualSequencer _skinEquippedVisual;

	[Address(RVA="0x1518530", Offset="0x1518530", VA="0x1518530")]
	public UnitVisualRefComponent()
	{
	}

	[Address(RVA="0x1518414", Offset="0x1518414", VA="0x1518414")]
	public UnitVisualSequencer GetUnitVisualSequencer(UnitVisualSequencerType type)
	{
		return null;
	}
}