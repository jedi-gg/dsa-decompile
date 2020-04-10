using Il2CppDummyDll;
using Serverproto;
using System;
using System.Text;
using UnityEngine.UI;

public class MiniUnitDetailsView : APressedPopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x105A784", Offset="0x105A784")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x78")]
	private StringBuilder _primaryCategoryStringBuilder;

	private MiniUnitDetailsView.SerializedFields Fields
	{
		[Address(RVA="0x12F3E3C", Offset="0x12F3E3C", VA="0x12F3E3C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12F3FF0", Offset="0x12F3FF0", VA="0x12F3FF0")]
	public MiniUnitDetailsView()
	{
	}

	[Address(RVA="0x12F367C", Offset="0x12F367C", VA="0x12F367C")]
	public void SetUnit(EnemyUnitPreview enemyPreview, UnitStatOverride statOverride)
	{
	}

	[Address(RVA="0x12F3F1C", Offset="0x12F3F1C", VA="0x12F3F1C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x12F3F90", Offset="0x12F3F90", VA="0x12F3F90", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PressedPopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public UnitListItem UnitListItem;

		[FieldOffset(Offset="0x38")]
		public Image RoleIcon;

		[FieldOffset(Offset="0x40")]
		public UiLabel RoleLabel;

		[FieldOffset(Offset="0x48")]
		public UiLabel NameLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel CategoriesLabel;

		[FieldOffset(Offset="0x58")]
		public SpriteSheetNameLookup UnitRoleSpriteLookup;

		[Address(RVA="0x12F405C", Offset="0x12F405C", VA="0x12F405C")]
		public SerializedFields()
		{
		}
	}
}