using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UnitStatsView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x105F870", Offset="0x105F870")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x70")]
	private UnitStatListItem.DData[] _statData;

	[FieldOffset(Offset="0x78")]
	private ulong _unitDefId;

	private UnitStatsView.SerializedFields Fields
	{
		[Address(RVA="0x1513D28", Offset="0x1513D28", VA="0x1513D28")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1514EE4", Offset="0x1514EE4", VA="0x1514EE4")]
	public UnitStatsView()
	{
	}

	[Address(RVA="0x1514D24", Offset="0x1514D24", VA="0x1514D24")]
	private void BindListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1514C48", Offset="0x1514C48", VA="0x1514C48")]
	private void InitializeListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1514E60", Offset="0x1514E60", VA="0x1514E60")]
	private void RolePressed()
	{
	}

	[Address(RVA="0x1512E1C", Offset="0x1512E1C", VA="0x1512E1C")]
	public void SetUnit(Serverproto.Unit unit)
	{
	}

	[Address(RVA="0x151340C", Offset="0x151340C", VA="0x151340C")]
	public void SetUnit(Gamedata.Unit unitDef)
	{
	}

	[Address(RVA="0x1513E08", Offset="0x1513E08", VA="0x1513E08")]
	private void SetUnitCommonData(Gamedata.Unit unitDef, Serverproto.Unit unit)
	{
	}

	[Address(RVA="0x15142C4", Offset="0x15142C4", VA="0x15142C4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1514BA4", Offset="0x1514BA4", VA="0x1514BA4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106C6FC", Offset="0x106C6FC")]
		[FieldOffset(Offset="0x30")]
		public RawImage UnitImage;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect StatsScrollRect;

		[FieldOffset(Offset="0x40")]
		public UiLabel CategoriesLabel;

		[FieldOffset(Offset="0x48")]
		public UiLabel UnitNameLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel UnitPowerLabel;

		[FieldOffset(Offset="0x58")]
		public UiLabel LevelLabel;

		[FieldOffset(Offset="0x60")]
		public UnitRarityWidget UnitRarityWidget;

		[FieldOffset(Offset="0x68")]
		public Image RoleIcon;

		[FieldOffset(Offset="0x70")]
		public UiLabel RoleLabel;

		[FieldOffset(Offset="0x78")]
		public Graphic GearColorImage;

		[FieldOffset(Offset="0x80")]
		public SpriteSheetNameLookup UnitRoleSpriteLookup;

		[FieldOffset(Offset="0x88")]
		public PressEventHandler RolePressHandler;

		[Attribute(Name="HeaderAttribute", RVA="0x106C734", Offset="0x106C734")]
		[FieldOffset(Offset="0x90")]
		public Sprite OffenseTexture;

		[FieldOffset(Offset="0x98")]
		public Sprite DefenseTexture;

		[FieldOffset(Offset="0xA0")]
		public Sprite HealthTexture;

		[FieldOffset(Offset="0xA8")]
		public Sprite RecoveryTexture;

		[FieldOffset(Offset="0xB0")]
		public Sprite CritChanceTexture;

		[FieldOffset(Offset="0xB8")]
		public Sprite CritPowerTexture;

		[FieldOffset(Offset="0xC0")]
		public Sprite AttackSpeedTexture;

		[FieldOffset(Offset="0xC8")]
		public Sprite SpeedTexture;

		[FieldOffset(Offset="0xD0")]
		public Sprite PotencyTexture;

		[FieldOffset(Offset="0xD8")]
		public Sprite TenacityTexture;

		[FieldOffset(Offset="0xE0")]
		public Sprite AccuracyTexture;

		[FieldOffset(Offset="0xE8")]
		public Sprite EvasionTexture;

		[Address(RVA="0x1514F44", Offset="0x1514F44", VA="0x1514F44")]
		public SerializedFields()
		{
		}
	}
}