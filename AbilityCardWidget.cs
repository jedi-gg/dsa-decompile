using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

[Attribute(Name="RequireComponent", RVA="0x1049054", Offset="0x1049054")]
[Attribute(Name="RequireComponent", RVA="0x1049054", Offset="0x1049054")]
public class AbilityCardWidget : MonoBehaviour
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105E7BC", Offset="0x105E7BC")]
	[FieldOffset(Offset="0x18")]
	private UnityEngine.RectTransform <RectTransform>k__BackingField;

	[FieldOffset(Offset="0x20")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x28")]
	private UnitAbility? _abilityDef;

	[FieldOffset(Offset="0x40")]
	private UnityEngine.CanvasGroup _canvasGroup;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private RawImage _abilityImage;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private GameObject _scrim;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Image _frameImage;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Sprite _unitFrameSprite;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Sprite _spellFrameSprite;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Image _affinityIcon;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private AbilityChargeWidget _chargeWidget;

	public UnityEngine.CanvasGroup CanvasGroup
	{
		[Address(RVA="0x10F68FC", Offset="0x10F68FC", VA="0x10F68FC")]
		get
		{
			return null;
		}
	}

	public UnityEngine.RectTransform RectTransform
	{
		[Address(RVA="0x10F68EC", Offset="0x10F68EC", VA="0x10F68EC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070F9C", Offset="0x1070F9C")]
		get
		{
			return null;
		}
		[Address(RVA="0x10F68F4", Offset="0x10F68F4", VA="0x10F68F4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070FAC", Offset="0x1070FAC")]
		private set
		{
		}
	}

	[Address(RVA="0x10F81BC", Offset="0x10F81BC", VA="0x10F81BC")]
	public AbilityCardWidget()
	{
	}

	[Address(RVA="0x10F7EB4", Offset="0x10F7EB4", VA="0x10F7EB4")]
	public void AnimateNewCharges(int newChargesSinceLast)
	{
	}

	[Address(RVA="0x10F7C6C", Offset="0x10F7C6C", VA="0x10F7C6C")]
	public void ConsumeCharges()
	{
	}

	[Address(RVA="0x10F6904", Offset="0x10F6904", VA="0x10F6904")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x10F6B20", Offset="0x10F6B20", VA="0x10F6B20")]
	public void InitializeBattleTweens()
	{
	}

	[Address(RVA="0x10F72AC", Offset="0x10F72AC", VA="0x10F72AC")]
	public void SetAbility(UnitAbility? ability, ulong abilityLevel)
	{
	}

	[Address(RVA="0x10F7694", Offset="0x10F7694", VA="0x10F7694")]
	public void SetAbility(Spell? spellDef)
	{
	}

	[Address(RVA="0x10F744C", Offset="0x10F744C", VA="0x10F744C")]
	public void SetAbilityIcon(string iconPath)
	{
	}

	[Address(RVA="0x10F7724", Offset="0x10F7724", VA="0x10F7724")]
	public void SetAbilityIcon(Texture texture)
	{
	}

	[Address(RVA="0x10F811C", Offset="0x10F811C", VA="0x10F811C")]
	public void SetAbilityImageColor(UnityEngine.Color color)
	{
	}

	[Address(RVA="0x10F74E0", Offset="0x10F74E0", VA="0x10F74E0")]
	public void SetAbilitySourceType(AbilitySourceType sourceType)
	{
	}

	[Address(RVA="0x10F6A04", Offset="0x10F6A04", VA="0x10F6A04")]
	public void SetAffinityIcon(Sprite sprite)
	{
	}

	[Address(RVA="0x10F75C4", Offset="0x10F75C4", VA="0x10F75C4")]
	public void SetCharge(uint numCharged, uint maxCharges)
	{
	}

	[Address(RVA="0x10F69CC", Offset="0x10F69CC", VA="0x10F69CC")]
	public void ShowScrim(bool show)
	{
	}

	[Address(RVA="0x10F6FD8", Offset="0x10F6FD8", VA="0x10F6FD8")]
	public void Shutdown()
	{
	}
}