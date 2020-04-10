using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Attribute(Name="RequireComponent", RVA="0x104869C", Offset="0x104869C")]
public class BattleHealthBar : MonoBehaviour, IMonoArchetypePooledItem
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private BattleHealthBarHealthAndShieldComponent _healthAndShieldComponent;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private BattleHealthBarDamageReactComponent _damageReactComponent;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private BattleHealthBarPipComponent _pipComponent;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleHealthBarBuffIconsComponent _buffIconsComponent;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private BattleHealthBarAbilityStrengthComponent _abilityStrengthComponent;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Vector2 _ownedSize;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Vector2 _unOwnedSize;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UnityEngine.Color _selfColor;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UnityEngine.Color _allyColor;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UnityEngine.Color _enemyColor;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Image _speedFill;

	[FieldOffset(Offset="0x88")]
	private RectTransform _transform;

	[FieldOffset(Offset="0x90")]
	private Camera _camera;

	[FieldOffset(Offset="0x98")]
	private BattleUnit _battleUnit;

	[FieldOffset(Offset="0xA0")]
	private CanvasGroup _canvasGroup;

	[FieldOffset(Offset="0xA8")]
	private UnityEngine.Color _baseColor;

	[FieldOffset(Offset="0xB8")]
	private uint _maxHp;

	[FieldOffset(Offset="0xBC")]
	private uint _hpDecay;

	[FieldOffset(Offset="0xC0")]
	private bool _visible;

	[FieldOffset(Offset="0xC4")]
	private float _canvasGroupDesiredAlpha;

	[FieldOffset(Offset="0xC8")]
	private Bounds _screenClamp;

	public BattleUnit BattleUnit
	{
		[Address(RVA="0x114EC90", Offset="0x114EC90", VA="0x114EC90")]
		get
		{
			return null;
		}
	}

	public RectTransform Transform
	{
		[Address(RVA="0x114EC98", Offset="0x114EC98", VA="0x114EC98")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1150B98", Offset="0x1150B98", VA="0x1150B98")]
	public BattleHealthBar()
	{
	}

	[Address(RVA="0x115001C", Offset="0x115001C", VA="0x115001C")]
	public void GetAllCurrentBuffTypes(ref HashSet<uint> activeBuffTypes)
	{
	}

	[Address(RVA="0x115074C", Offset="0x115074C", VA="0x115074C")]
	public RectTransform GetBuffIconPointAt(uint iconType)
	{
		return null;
	}

	[Address(RVA="0x114ECA0", Offset="0x114ECA0", VA="0x114ECA0", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x114F104", Offset="0x114F104", VA="0x114F104")]
	public void InitWithBattleUnit(BattleUnit battleUnit, uint maxHp)
	{
	}

	[Address(RVA="0x1150960", Offset="0x1150960", VA="0x1150960", Slot="7")]
	protected virtual void LateUpdate()
	{
	}

	[Address(RVA="0x114ED80", Offset="0x114ED80", VA="0x114ED80", Slot="6")]
	public void Reinitialize()
	{
	}

	[Address(RVA="0x11503C8", Offset="0x11503C8", VA="0x11503C8")]
	public void SetAbilityStrength(BattleAbilityStrength strength)
	{
	}

	[Address(RVA="0x1150220", Offset="0x1150220", VA="0x1150220")]
	public void SetAffinityIcon(Sprite sprite)
	{
	}

	[Address(RVA="0x114F060", Offset="0x114F060", VA="0x114F060")]
	public void SetBuffIconPoolDelegates(BattleHealthBarsView.SpawnBattleBuffIcon spawn, BattleHealthBarsView.DespawnBattleBuffIcon despawn)
	{
	}

	[Address(RVA="0x1150B44", Offset="0x1150B44", VA="0x1150B44")]
	private void SetCanvasGroupAlpha(float alpha)
	{
	}

	[Address(RVA="0x114F80C", Offset="0x114F80C", VA="0x114F80C")]
	public void SetCcImmune(bool immune)
	{
	}

	[Address(RVA="0x114F694", Offset="0x114F694", VA="0x114F694")]
	public void SetHealthAndShieldPercent(float healthPercent, float shieldPercent)
	{
	}

	[Address(RVA="0x114F844", Offset="0x114F844", VA="0x114F844")]
	public void SetHpDecay(uint hpDecay)
	{
	}

	[Address(RVA="0x114F7CC", Offset="0x114F7CC", VA="0x114F7CC")]
	public void SetSpeed(float speedBarPercent)
	{
	}

	[Address(RVA="0x114FFB4", Offset="0x114FFB4", VA="0x114FFB4")]
	public void SetVisible(bool visible)
	{
	}

	[Address(RVA="0x114ED50", Offset="0x114ED50", VA="0x114ED50", Slot="5")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x114F3FC", Offset="0x114F3FC", VA="0x114F3FC")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x114F364", Offset="0x114F364", VA="0x114F364")]
	private void UpdateBaseColor()
	{
	}

	[Address(RVA="0x114F84C", Offset="0x114F84C", VA="0x114F84C")]
	public void UpdateBuffIcons(IReadOnlyList<BattleLib_UpdateResult.Types.Effect> effects, BattleBuffIconUiData buffIconUiData, LocalizationManager locManager)
	{
	}
}