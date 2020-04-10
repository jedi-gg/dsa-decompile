using DG.Tweening;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BattleBadConnectionWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private CanvasGroup _badConnectionCanvas;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Image _badConnectionIcon;

	[Attribute(Name="HeaderAttribute", RVA="0x1052E0C", Offset="0x1052E0C")]
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private float _showDurationS;

	[FieldOffset(Offset="0x2C")]
	[SerializeField]
	private float _blinkDurationS;

	[Attribute(Name="RangeAttribute", RVA="0x1052E68", Offset="0x1052E68")]
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private float _blinkFadeAlpha;

	[FieldOffset(Offset="0x38")]
	private Sequence _showSequence;

	[FieldOffset(Offset="0x40")]
	private Tween _blinkTween;

	[Address(RVA="0x1135ED8", Offset="0x1135ED8", VA="0x1135ED8")]
	public BattleBadConnectionWidget()
	{
	}

	[Address(RVA="0x1135BA4", Offset="0x1135BA4", VA="0x1135BA4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1135E78", Offset="0x1135E78", VA="0x1135E78")]
	public void Show(bool show)
	{
	}

	[Address(RVA="0x1135E2C", Offset="0x1135E2C", VA="0x1135E2C")]
	public void Shutdown()
	{
	}
}