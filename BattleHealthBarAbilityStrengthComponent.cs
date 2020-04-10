using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BattleHealthBarAbilityStrengthComponent : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private float? _targetScale;

	[FieldOffset(Offset="0x20")]
	private float _tweenTime;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Image _affinityIcon;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private float _scaleUp;

	[FieldOffset(Offset="0x34")]
	[SerializeField]
	private float _scaleDown;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private float _scaleDurationS;

	[FieldOffset(Offset="0x3C")]
	[SerializeField]
	private float _alphaFade;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private GameObject _strongAgainstContainer;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private GameObject _weakAgainstContainer;

	[Address(RVA="0x1150BB0", Offset="0x1150BB0", VA="0x1150BB0")]
	public BattleHealthBarAbilityStrengthComponent()
	{
	}

	[Address(RVA="0x114F034", Offset="0x114F034", VA="0x114F034")]
	public void ResetState()
	{
	}

	[Address(RVA="0x1150474", Offset="0x1150474", VA="0x1150474")]
	public void SetAbilityStrength(BattleAbilityStrength strength)
	{
	}

	[Address(RVA="0x11502CC", Offset="0x11502CC", VA="0x11502CC")]
	public void SetAffinityIcon(Sprite sprite)
	{
	}

	[Address(RVA="0x114F560", Offset="0x114F560", VA="0x114F560")]
	public void TickUpdate()
	{
	}
}