using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class BattleAbilityCardWidget : MonoBehaviour, IMonoArchetypePooledItem
{
	[FieldOffset(Offset="0x0")]
	private const float MANA_FILL_DURATION_S = 0.35f;

	[FieldOffset(Offset="0x0")]
	private readonly static Color s_shaderGrayColor;

	[FieldOffset(Offset="0x10")]
	private readonly static Color s_shaderNonGrayColor;

	[Attribute(Name="InjectAttribute", RVA="0x1052B8C", Offset="0x1052B8C")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1052B9C", Offset="0x1052B9C")]
	[FieldOffset(Offset="0x20")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1052BAC", Offset="0x1052BAC")]
	[FieldOffset(Offset="0x28")]
	private DiContainer _diContainer;

	[FieldOffset(Offset="0x30")]
	private BattleAbilityCardData _abilityCardData;

	[FieldOffset(Offset="0x38")]
	private UnityEngine.RectTransform _rectTransform;

	[FieldOffset(Offset="0x40")]
	private SpriteSheetNameLookup _affinitySpriteLookup;

	[FieldOffset(Offset="0x48")]
	private float _lastManaFillAmount;

	[FieldOffset(Offset="0x50")]
	private Tweener _manaFillTween;

	[FieldOffset(Offset="0x58")]
	private Tweener _spellReadyTween;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private AbilityCardWidget _abilityCard;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private GameObject _unitStatusContainer;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private GameObject _stunnedOverlay;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private GameObject _unitBusyOverlay;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private CanvasGroup _manaFillRoot;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Image _manaFill;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private BattleAbilityCardWidgetBuffStatusOverlay _buffStatusOverlay;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private float _notEnoughManaAlpha;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private PressEventHandler _pressEventHandler;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private GameObject _cancelRoot;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private ParticleSystem _spellBecameAvailableParticles;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private ParticleSystem _spellAvailableVfx;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private Color _castAvailableFillColor;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private Color _castUnavailableFillColor;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private float _castAvailableFillAlpha;

	[FieldOffset(Offset="0xEC")]
	[SerializeField]
	private float _castUnavailableFillAlpha;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private float _spellPunchPower;

	[FieldOffset(Offset="0xF4")]
	[SerializeField]
	private float _spellPunchDuration;

	public BattleAbilityCardData AbilityCardData
	{
		[Address(RVA="0x1165D00", Offset="0x1165D00", VA="0x1165D00")]
		get
		{
			return null;
		}
	}

	public AbilityCardWidget AbilityCardWidget
	{
		[Address(RVA="0x1165D10", Offset="0x1165D10", VA="0x1165D10")]
		get
		{
			return null;
		}
	}

	public UnityEngine.RectTransform RectTransform
	{
		[Address(RVA="0x1165D08", Offset="0x1165D08", VA="0x1165D08")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x116738C", Offset="0x116738C", VA="0x116738C")]
	static BattleAbilityCardWidget()
	{
	}

	[Address(RVA="0x1167360", Offset="0x1167360", VA="0x1167360")]
	public BattleAbilityCardWidget()
	{
	}

	[Address(RVA="0x116709C", Offset="0x116709C", VA="0x116709C")]
	public void AnimateNewCharges(int newChargesSinceLast)
	{
	}

	[Address(RVA="0x1166010", Offset="0x1166010", VA="0x1166010")]
	private void ClearAbilityCardData()
	{
	}

	[Address(RVA="0x1167040", Offset="0x1167040", VA="0x1167040")]
	public void ConsumeCharges()
	{
	}

	[Address(RVA="0x1167240", Offset="0x1167240", VA="0x1167240")]
	private void HandleClick()
	{
	}

	[Address(RVA="0x11672D0", Offset="0x11672D0", VA="0x11672D0")]
	private void HandleLongPress()
	{
	}

	[Address(RVA="0x1165D18", Offset="0x1165D18", VA="0x1165D18", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x116710C", Offset="0x116710C", VA="0x116710C")]
	private void ManaFillTweenCompleted()
	{
	}

	[Address(RVA="0x1166B4C", Offset="0x1166B4C", VA="0x1166B4C")]
	public void PlaySpellReadyEffects()
	{
	}

	[Address(RVA="0x116600C", Offset="0x116600C", VA="0x116600C", Slot="6")]
	public void Reinitialize()
	{
	}

	[Address(RVA="0x1166184", Offset="0x1166184", VA="0x1166184")]
	public void SetAbility(BattleAbilityCardData abilityCardData, SpriteSheetNameLookup affinitySpriteLookup)
	{
	}

	[Address(RVA="0x11669B0", Offset="0x11669B0", VA="0x11669B0")]
	private void SetAffinitySprite()
	{
	}

	[Address(RVA="0x1166A8C", Offset="0x1166A8C", VA="0x1166A8C")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x1166C00", Offset="0x1166C00", VA="0x1166C00")]
	public bool SetSpellCharge(float amount)
	{
		return new bool();
	}

	[Address(RVA="0x1166118", Offset="0x1166118", VA="0x1166118")]
	public void ShowScrim(bool show)
	{
	}

	[Address(RVA="0x1166050", Offset="0x1166050", VA="0x1166050", Slot="5")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x11667B4", Offset="0x11667B4", VA="0x11667B4")]
	private void UpdateManaCost()
	{
	}
}