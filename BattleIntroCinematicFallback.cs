using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class BattleIntroCinematicFallback : BattleIntroCinematic
{
	[FieldOffset(Offset="0x0")]
	private const float DEFAULT_DURATION_S = 1.5f;

	[FieldOffset(Offset="0xB8")]
	private float _timer;

	[FieldOffset(Offset="0xBC")]
	[SerializeField]
	private float _durationS;

	[Address(RVA="0x10FDCC4", Offset="0x10FDCC4", VA="0x10FDCC4")]
	public BattleIntroCinematicFallback()
	{
	}

	[Address(RVA="0x10FDCC0", Offset="0x10FDCC0", VA="0x10FDCC0", Slot="9")]
	protected override void BindPlayableGraphOutput(PlayableBinding output)
	{
	}

	[Address(RVA="0x10FDC0C", Offset="0x10FDC0C", VA="0x10FDC0C", Slot="5")]
	public override void Play()
	{
	}

	[Address(RVA="0x10FDC08", Offset="0x10FDC08", VA="0x10FDC08", Slot="6")]
	public override void SetUnits(List<BattleUnit> friendlies, List<BattleUnit> enemies)
	{
	}

	[Address(RVA="0x10FDC24", Offset="0x10FDC24", VA="0x10FDC24", Slot="7")]
	protected override void Update()
	{
	}

	[Address(RVA="0x10FDC18", Offset="0x10FDC18", VA="0x10FDC18")]
	public void UseDefaultDuration()
	{
	}
}