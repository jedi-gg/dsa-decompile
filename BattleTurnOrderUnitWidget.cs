using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BattleTurnOrderUnitWidget : MonoBehaviour, IMonoArchetypePooledItem
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053DF0", Offset="0x1053DF0")]
	[FieldOffset(Offset="0x18")]
	private uint <UnitId>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053E00", Offset="0x1053E00")]
	[FieldOffset(Offset="0x1C")]
	private uint <TurnOrder>k__BackingField;

	[FieldOffset(Offset="0x0")]
	private readonly static Color s_shaderGrayColor;

	[FieldOffset(Offset="0x10")]
	private readonly static Color s_shaderNonGrayColor;

	[Attribute(Name="InjectAttribute", RVA="0x1053E10", Offset="0x1053E10")]
	[FieldOffset(Offset="0x20")]
	private SingleAssetRegistry _unitIconAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x1053E20", Offset="0x1053E20")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1053E30", Offset="0x1053E30")]
	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1053E40", Offset="0x1053E40")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private RawImage _unitIcon;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Image _border;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private RectTransform _tweenRoot;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private float _tweenDuration;

	[FieldOffset(Offset="0x64")]
	[SerializeField]
	private float _tweenRotation;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private float _tweenScale;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private GameObject _detailsRoot;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _levelLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UiLabel _gearTierLabel;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private UiLabel _starLabel;

	[FieldOffset(Offset="0x90")]
	private string _lastTexturePath;

	[FieldOffset(Offset="0x98")]
	private Sequence _currentTurnSequence;

	public uint TurnOrder
	{
		[Address(RVA="0x1295C54", Offset="0x1295C54", VA="0x1295C54")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E608", Offset="0x106E608")]
		get
		{
			return new uint();
		}
		[Address(RVA="0x1295C5C", Offset="0x1295C5C", VA="0x1295C5C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E618", Offset="0x106E618")]
		private set
		{
		}
	}

	public uint UnitId
	{
		[Address(RVA="0x1295C44", Offset="0x1295C44", VA="0x1295C44")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E5E8", Offset="0x106E5E8")]
		get
		{
			return new uint();
		}
		[Address(RVA="0x1295C4C", Offset="0x1295C4C", VA="0x1295C4C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E5F8", Offset="0x106E5F8")]
		private set
		{
		}
	}

	[Address(RVA="0x1296860", Offset="0x1296860", VA="0x1296860")]
	static BattleTurnOrderUnitWidget()
	{
	}

	[Address(RVA="0x1296834", Offset="0x1296834", VA="0x1296834")]
	public BattleTurnOrderUnitWidget()
	{
	}

	[Address(RVA="0x12967AC", Offset="0x12967AC", VA="0x12967AC")]
	private void HandleClick()
	{
	}

	[Address(RVA="0x1295C64", Offset="0x1295C64", VA="0x1295C64", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1296714", Offset="0x1296714", VA="0x1296714")]
	public void PlayCurrentTurnTween(bool immediate)
	{
	}

	[Address(RVA="0x1295E40", Offset="0x1295E40", VA="0x1295E40", Slot="6")]
	public void Reinitialize()
	{
	}

	[Address(RVA="0x1295FBC", Offset="0x1295FBC", VA="0x1295FBC")]
	public void SetData(uint unitId, uint turnOrder, string icon, Color borderColor)
	{
	}

	[Address(RVA="0x12962A0", Offset="0x12962A0", VA="0x12962A0")]
	private void SetUnitIconGrayscale()
	{
	}

	[Address(RVA="0x1296424", Offset="0x1296424", VA="0x1296424")]
	public void ShowDetail(BattleUnit unit)
	{
	}

	[Address(RVA="0x1295F18", Offset="0x1295F18", VA="0x1295F18", Slot="5")]
	public void Shutdown()
	{
	}
}