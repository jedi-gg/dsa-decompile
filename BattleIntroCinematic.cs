using Cinemachine;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleIntroCinematic : ABattleCinematic
{
	[FieldOffset(Offset="0x78")]
	private List<Transform> _allTargets;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private CinemachineTargetGroup _friendliesTargetGroup;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private CinemachineTargetGroup _enemiesTargetGroup;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private CinemachineTargetGroup _allTargetGroup;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private string _titleLocKey;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private string _subtitleLocKey;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private List<Transform> _playerCards;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private List<Transform> _enemyCards;

	[Address(RVA="0x10FDB60", Offset="0x10FDB60", VA="0x10FDB60")]
	public BattleIntroCinematic()
	{
	}

	[Address(RVA="0x10FD81C", Offset="0x10FD81C", VA="0x10FD81C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E7C8", Offset="0x106E7C8")]
	internal static void <SetUnits>g__SetTargetWeights|2_0(List<BattleUnit> units, CinemachineTargetGroup targetGroup, ref List<Transform> allTargets)
	{
	}

	[Address(RVA="0x10FD040", Offset="0x10FD040", VA="0x10FD040")]
	public void Initialize(LocalizationManager lm)
	{
	}

	[Address(RVA="0x10FD1A4", Offset="0x10FD1A4", VA="0x10FD1A4", Slot="6")]
	public override void SetUnits(List<BattleUnit> friendlies, List<BattleUnit> enemies)
	{
	}

	[Address(RVA="0x10FD138", Offset="0x10FD138", VA="0x10FD138")]
	public void Shutdown()
	{
	}
}