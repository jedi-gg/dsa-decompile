using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class BattleCinematic : ABattleCinematic
{
	[FieldOffset(Offset="0x0")]
	private const string FOCUS_UNIT_TRACK_NAME = "unit";

	[Attribute(Name="InjectAttribute", RVA="0x105483C", Offset="0x105483C")]
	[FieldOffset(Offset="0x78")]
	private BattleUnitsController _unitsController;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private BattleCinematic.FocusType _focusType;

	[FieldOffset(Offset="0x84")]
	[SerializeField]
	private bool _hideAllExceptFocus;

	[FieldOffset(Offset="0x88")]
	private GameObject _focusUnitObj;

	[FieldOffset(Offset="0x90")]
	private List<DHiddenUnit> _hiddenUnits;

	public BattleCinematic.FocusType FocusOn
	{
		[Address(RVA="0x113CC3C", Offset="0x113CC3C", VA="0x113CC3C")]
		get
		{
			return new BattleCinematic.FocusType();
		}
	}

	[Address(RVA="0x113D368", Offset="0x113D368", VA="0x113D368")]
	public BattleCinematic()
	{
	}

	[Address(RVA="0x113D298", Offset="0x113D298", VA="0x113D298", Slot="9")]
	protected override void BindPlayableGraphOutput(PlayableBinding output)
	{
	}

	[Address(RVA="0x113D140", Offset="0x113D140", VA="0x113D140", Slot="8")]
	protected override void FinishedPlaying()
	{
	}

	[Address(RVA="0x113CC44", Offset="0x113CC44", VA="0x113CC44", Slot="5")]
	public override void Play()
	{
	}

	[Address(RVA="0x113D07C", Offset="0x113D07C", VA="0x113D07C")]
	public void SetFocusUnit(IBattleUnitGameObject focusUnit)
	{
	}

	public enum FocusType
	{
		[FieldOffset(Offset="0x0")]
		Boss,
		[FieldOffset(Offset="0x0")]
		CpuAlly
	}
}