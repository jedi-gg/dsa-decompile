using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

[Attribute(Name="RequireComponent", RVA="0x104856C", Offset="0x104856C")]
public class BattleBossHealthBar : MonoBehaviour
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052EA8", Offset="0x1052EA8")]
	[FieldOffset(Offset="0x18")]
	private BattleUnit <BattleUnit>k__BackingField;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private BattleHealthBarHealthAndShieldComponent _healthAndShieldComponent;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private BattleHealthBarDamageReactComponent _damageReactComponent;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Image _healthSprite;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private RawImage _bossIcon;

	[FieldOffset(Offset="0x40")]
	private SingleAssetRegistry _bossIconAssetRegistry;

	[FieldOffset(Offset="0x48")]
	private CanvasGroup _canvasGroup;

	[FieldOffset(Offset="0x50")]
	private Color _healthSpriteColor;

	public BattleUnit BattleUnit
	{
		[Address(RVA="0x1135F9C", Offset="0x1135F9C", VA="0x1135F9C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E258", Offset="0x106E258")]
		get
		{
			return null;
		}
		[Address(RVA="0x1135FA4", Offset="0x1135FA4", VA="0x1135FA4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E268", Offset="0x106E268")]
		private set
		{
		}
	}

	public bool IsShowing
	{
		[Address(RVA="0x1135EF8", Offset="0x1135EF8", VA="0x1135EF8")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1136414", Offset="0x1136414", VA="0x1136414")]
	public BattleBossHealthBar()
	{
	}

	[Address(RVA="0x113641C", Offset="0x113641C", VA="0x113641C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E278", Offset="0x106E278")]
	private void <Initialize>b__6_0(AssetHandle assetHandle)
	{
	}

	[Address(RVA="0x1136378", Offset="0x1136378", VA="0x1136378")]
	private void Awake()
	{
	}

	[Address(RVA="0x1135FAC", Offset="0x1135FAC", VA="0x1135FAC")]
	public void Initialize(BattleUnit battleUnit, WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1136340", Offset="0x1136340", VA="0x1136340")]
	public void SetCcImmune(bool immune)
	{
	}

	[Address(RVA="0x11362F4", Offset="0x11362F4", VA="0x11362F4")]
	public void SetHealthAndShieldPercent(float healthPercent, float shieldPercent)
	{
	}

	[Address(RVA="0x11361A8", Offset="0x11361A8", VA="0x11361A8")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x113629C", Offset="0x113629C", VA="0x113629C")]
	public void TickUpdate()
	{
	}
}