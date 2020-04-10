using DG.Tweening;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BattleHealthBarHealthAndShieldComponent : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private Tweener _lowHealthAlertTween;

	[FieldOffset(Offset="0x20")]
	private float _healthPercent;

	[FieldOffset(Offset="0x24")]
	private float _shieldPercent;

	[FieldOffset(Offset="0x28")]
	private float _maxShieldPercent;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleHealthBarDamageReactComponent _damageReactComponent;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Image _healthSprite;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Image _shieldSprite;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Image _ccImmuneBackground;

	[Attribute(Name="HeaderAttribute", RVA="0x1053924", Offset="0x1053924")]
	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Image _background;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Color _safeBGColor;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Color _alertBGColor;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private float _tweenDuration;

	[FieldOffset(Offset="0x7C")]
	[SerializeField]
	private Ease _tweenEase;

	private float EffectMaxHealthPercent
	{
		[Address(RVA="0x10FA25C", Offset="0x10FA25C", VA="0x10FA25C")]
		get
		{
			return new float();
		}
	}

	public float HealthPercent
	{
		[Address(RVA="0x10F9D88", Offset="0x10F9D88", VA="0x10F9D88")]
		get
		{
			return new float();
		}
	}

	public float ShieldPercent
	{
		[Address(RVA="0x10F9D90", Offset="0x10F9D90", VA="0x10F9D90")]
		get
		{
			return new float();
		}
	}

	[Address(RVA="0x10FA3D0", Offset="0x10FA3D0", VA="0x10FA3D0")]
	public BattleHealthBarHealthAndShieldComponent()
	{
	}

	[Address(RVA="0x10FA26C", Offset="0x10FA26C", VA="0x10FA26C")]
	public void DecayHealth(float hpDecayPercent)
	{
	}

	[Address(RVA="0x10F9D98", Offset="0x10F9D98", VA="0x10F9D98")]
	public void Initialize()
	{
	}

	[Address(RVA="0x10F9E78", Offset="0x10F9E78", VA="0x10F9E78")]
	public void ResetState()
	{
	}

	[Address(RVA="0x10FA320", Offset="0x10FA320", VA="0x10FA320")]
	public void SetCcImmune(bool immune)
	{
	}

	[Address(RVA="0x10FA024", Offset="0x10FA024", VA="0x10FA024")]
	public void SetHealthAndShieldPercent(float healthPercent, float shieldPercent, bool silent = false)
	{
	}

	[Address(RVA="0x10F9E44", Offset="0x10F9E44", VA="0x10F9E44")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x10F9F60", Offset="0x10F9F60", VA="0x10F9F60")]
	private void StopLowHealthAlert()
	{
	}
}