using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleHealthBarPipComponent : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private int _healthPerFullPip;

	[FieldOffset(Offset="0x1C")]
	[SerializeField]
	private int _defaultFullPipDivisions;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private float _halfPipHeightOffset;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private List<RectTransform> _pips;

	[Address(RVA="0x10FA7F0", Offset="0x10FA7F0", VA="0x10FA7F0")]
	public BattleHealthBarPipComponent()
	{
	}

	[Address(RVA="0x10FA468", Offset="0x10FA468", VA="0x10FA468")]
	public void SetMaxHealth(uint maxHp)
	{
	}
}