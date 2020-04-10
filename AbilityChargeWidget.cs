using DG.Tweening;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityChargeWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private const float CONSUME_END_SCALE = 2f;

	[FieldOffset(Offset="0x0")]
	private const float CONSUME_DURATION = 0.3f;

	[FieldOffset(Offset="0x0")]
	private const float CONSUME_PIP_DELAY = 0.1f;

	[FieldOffset(Offset="0x0")]
	private const float FILL_START_SCALE = 1.6f;

	[FieldOffset(Offset="0x0")]
	private const float FILL_DURATION = 0.25f;

	[FieldOffset(Offset="0x0")]
	private const float FILL_DELAY = 0.4f;

	[FieldOffset(Offset="0x18")]
	private List<Sequence> _fillSequences;

	[FieldOffset(Offset="0x20")]
	private List<Sequence> _consumeSequences;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Color _emptyColor;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Color _fullColor;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Color _allFullColor;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _chargeBg;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private List<Image> _charges;

	[Address(RVA="0x10F81C4", Offset="0x10F81C4", VA="0x10F81C4")]
	public AbilityChargeWidget()
	{
	}

	[Address(RVA="0x10F7F60", Offset="0x10F7F60", VA="0x10F7F60")]
	public void AnimateNewCharges(int newChargesSinceLast)
	{
	}

	[Address(RVA="0x10F7D04", Offset="0x10F7D04", VA="0x10F7D04")]
	public void ConsumeCharges()
	{
	}

	[Address(RVA="0x10F6BB8", Offset="0x10F6BB8", VA="0x10F6BB8")]
	public void InitializeBattleTweens()
	{
	}

	[Address(RVA="0x10F78BC", Offset="0x10F78BC", VA="0x10F78BC")]
	public void SetCharge(uint numCharged, uint maxCharges)
	{
	}

	[Address(RVA="0x10F77E0", Offset="0x10F77E0", VA="0x10F77E0")]
	public void Show(bool show)
	{
	}

	[Address(RVA="0x10F7088", Offset="0x10F7088", VA="0x10F7088")]
	public void Shutdown()
	{
	}
}