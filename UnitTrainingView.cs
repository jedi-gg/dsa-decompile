using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitTrainingView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x105F8E0", Offset="0x105F8E0")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105F8F0", Offset="0x105F8F0")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105F900", Offset="0x105F900")]
	[FieldOffset(Offset="0x78")]
	private UnitStatCalculator _unitStatCalculator;

	[Attribute(Name="InjectAttribute", RVA="0x105F910", Offset="0x105F910")]
	[FieldOffset(Offset="0x80")]
	private HudController _hudController;

	[FieldOffset(Offset="0x88")]
	private UnitTrainingTable _unitTrainingTable;

	[FieldOffset(Offset="0x98")]
	private Serverproto.Unit _unit;

	[FieldOffset(Offset="0xA0")]
	private List<string> _trainingWarnings;

	[FieldOffset(Offset="0xA8")]
	private UnityEngine.Color _defaultLabelColor;

	[FieldOffset(Offset="0xB8")]
	private long _currencyOwned;

	[FieldOffset(Offset="0xC0")]
	private long _trainingMatsOwned;

	[FieldOffset(Offset="0xC8")]
	private int _currentLevel;

	[FieldOffset(Offset="0xCC")]
	private int _currencyCappedMaxLevel;

	private UnitTrainingView.SerializedFields Fields
	{
		[Address(RVA="0x1517174", Offset="0x1517174", VA="0x1517174")]
		get
		{
			return null;
		}
	}

	private int MinTrainableLevel
	{
		[Address(RVA="0x1517254", Offset="0x1517254", VA="0x1517254")]
		get
		{
			return new int();
		}
	}

	[Address(RVA="0x15183E4", Offset="0x15183E4", VA="0x15183E4")]
	public UnitTrainingView()
	{
	}

	[Address(RVA="0x1518398", Offset="0x1518398", VA="0x1518398")]
	private void CappedByCurrencyClicked()
	{
	}

	[Address(RVA="0x1516CD4", Offset="0x1516CD4", VA="0x1516CD4")]
	public void Celebrate()
	{
	}

	[Address(RVA="0x1517C70", Offset="0x1517C70", VA="0x1517C70")]
	private void ContinueClicked()
	{
	}

	[Address(RVA="0x1517B64", Offset="0x1517B64", VA="0x1517B64")]
	private void GetTrainingCostForLevel(int intSliderValue, out uint trainingMatCost, out uint currencyCost)
	{
		trainingMatCost = 0;
		currencyCost = 0;
	}

	[Address(RVA="0x1517CBC", Offset="0x1517CBC", VA="0x1517CBC")]
	private void LevelSliderChanged(float value)
	{
	}

	[Address(RVA="0x1516360", Offset="0x1516360", VA="0x1516360")]
	public void SetData(ulong unitId)
	{
	}

	[Address(RVA="0x1517948", Offset="0x1517948", VA="0x1517948")]
	private void TrainButtonClicked()
	{
	}

	[Address(RVA="0x1517260", Offset="0x1517260", VA="0x1517260", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1517814", Offset="0x1517814", VA="0x1517814", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106C76C", Offset="0x106C76C")]
		[FieldOffset(Offset="0x30")]
		public LabelButton TrainButton;

		[FieldOffset(Offset="0x38")]
		public Button ContinueButton;

		[FieldOffset(Offset="0x40")]
		public UiSuperSlider LevelSlider;

		[FieldOffset(Offset="0x48")]
		public UiLabel TrainingMatCostLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel CurrencyCostLabel;

		[FieldOffset(Offset="0x58")]
		public RawImage UnitTrainingMatIcon;

		[FieldOffset(Offset="0x60")]
		public RawImage UnitTrainingCurrencyIcon;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.Color InsufficientCurrencyLabelColor;

		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject SliderContainerParent;

		[FieldOffset(Offset="0x80")]
		public UnityEngine.GameObject CelebrationContainerParent;

		[FieldOffset(Offset="0x88")]
		public UiLabel CelebrationLevelLabel;

		[FieldOffset(Offset="0x90")]
		public float PowerTallyDuration;

		[FieldOffset(Offset="0x98")]
		public Animation CelebrationAnimation;

		[FieldOffset(Offset="0xA0")]
		public RectTransform CappedByCurrencyContainer;

		[FieldOffset(Offset="0xA8")]
		public Button CappedByCurrencyButton;

		[FieldOffset(Offset="0xB0")]
		public UiLabel CappedByCurrencyLabel;

		[Attribute(Name="RangeAttribute", RVA="0x106C7A4", Offset="0x106C7A4")]
		[FieldOffset(Offset="0xB8")]
		public float CappedByCurrencyMinAnchor;

		[FieldOffset(Offset="0xC0")]
		public UnityEngine.GameObject CurrentLevelContainer;

		[Attribute(Name="HeaderAttribute", RVA="0x106C7BC", Offset="0x106C7BC")]
		[FieldOffset(Offset="0xC8")]
		public UiLabel OldOffenseLabel;

		[FieldOffset(Offset="0xD0")]
		public TallyLabelUnsigned NewOffenseLabel;

		[FieldOffset(Offset="0xD8")]
		public UnityEngine.GameObject OffenseCarat;

		[FieldOffset(Offset="0xE0")]
		public UiLabel OldDefenseLabel;

		[FieldOffset(Offset="0xE8")]
		public TallyLabelUnsigned NewDefenseLabel;

		[FieldOffset(Offset="0xF0")]
		public UnityEngine.GameObject DefenseCarat;

		[FieldOffset(Offset="0xF8")]
		public UiLabel OldHealthLabel;

		[FieldOffset(Offset="0x100")]
		public TallyLabelUnsigned NewHealthLabel;

		[FieldOffset(Offset="0x108")]
		public UnityEngine.GameObject HealthCarat;

		[FieldOffset(Offset="0x110")]
		public UiLabel OldPowerLabel;

		[FieldOffset(Offset="0x118")]
		public TallyLabelUnsigned NewPowerLabel;

		[FieldOffset(Offset="0x120")]
		public UnityEngine.GameObject PowerCarat;

		[Address(RVA="0x15183F4", Offset="0x15183F4", VA="0x15183F4")]
		public SerializedFields()
		{
		}
	}
}