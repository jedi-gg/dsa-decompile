using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHealthBarDamageReactComponent : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private const float DMG_DRAIN_HOLD_DURATION = 0.35f;

	[FieldOffset(Offset="0x0")]
	private const float DMG_DRAIN_TWEEN_DURATION = 0.2f;

	[FieldOffset(Offset="0x0")]
	private const float DMG_COLOR_FLASH_DURATION = 0.15f;

	[FieldOffset(Offset="0x0")]
	private const float HEAL_FILL_DURATION = 0.25f;

	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Image _healthSprite;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Image _damageDrainSprite;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private DoubleFilledImage _healFillSprite;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Color _damageFlashColor;

	[FieldOffset(Offset="0x40")]
	private float _lastHealthPercent;

	[FieldOffset(Offset="0x44")]
	private float _damageColorFlashTimer;

	[FieldOffset(Offset="0x48")]
	private BattleHealthBarDamageReactComponent.DamageDrainState _damageDrainState;

	[FieldOffset(Offset="0x50")]
	private List<float> _queuedDamageDrainHp;

	[FieldOffset(Offset="0x58")]
	private float _damageDrainStartValue;

	[FieldOffset(Offset="0x5C")]
	private float _damageDrainTimer;

	[FieldOffset(Offset="0x60")]
	private BattleHealthBarDamageReactComponent.HealFillState _healFillState;

	[FieldOffset(Offset="0x68")]
	private List<float> _queuedHealFillHp;

	[FieldOffset(Offset="0x70")]
	private float _healFillTimer;

	[FieldOffset(Offset="0x74")]
	private float _startingHealPercent;

	[Address(RVA="0x10F9CE8", Offset="0x10F9CE8", VA="0x10F9CE8")]
	public BattleHealthBarDamageReactComponent()
	{
	}

	[Address(RVA="0x10F9434", Offset="0x10F9434", VA="0x10F9434")]
	private void ResetDamageDrain()
	{
	}

	[Address(RVA="0x10F9478", Offset="0x10F9478", VA="0x10F9478")]
	private void ResetHealFill()
	{
	}

	[Address(RVA="0x10F9398", Offset="0x10F9398", VA="0x10F9398")]
	public void ResetState()
	{
	}

	[Address(RVA="0x10F99F4", Offset="0x10F99F4", VA="0x10F99F4")]
	public void SetHealthPercent(float healthPercent, bool silent = false)
	{
	}

	[Address(RVA="0x10F9AEC", Offset="0x10F9AEC", VA="0x10F9AEC")]
	private void StartDamageDrain(float startingHealthPercent)
	{
	}

	[Address(RVA="0x10F9BA0", Offset="0x10F9BA0", VA="0x10F9BA0")]
	private void StartHealFill(float startingHealthPercent)
	{
	}

	[Address(RVA="0x10F94C8", Offset="0x10F94C8", VA="0x10F94C8")]
	public void TickUpdate(Color baseColor)
	{
	}

	[Address(RVA="0x10F94F4", Offset="0x10F94F4", VA="0x10F94F4")]
	private void UpdateColor(Color baseColor)
	{
	}

	[Address(RVA="0x10F9604", Offset="0x10F9604", VA="0x10F9604")]
	private void UpdateDamageDrain()
	{
	}

	[Address(RVA="0x10F9814", Offset="0x10F9814", VA="0x10F9814")]
	private void UpdateHealFill()
	{
	}

	private enum DamageDrainState
	{
		[FieldOffset(Offset="0x0")]
		Inactive,
		[FieldOffset(Offset="0x0")]
		Hold,
		[FieldOffset(Offset="0x0")]
		TweenFill
	}

	private enum HealFillState
	{
		[FieldOffset(Offset="0x0")]
		Inactive,
		[FieldOffset(Offset="0x0")]
		TweenFill
	}
}