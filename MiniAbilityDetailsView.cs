using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniAbilityDetailsView : APopupView, IDispatchHandler<DMiniAbilityDetailsListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105A744", Offset="0x105A744")]
	[FieldOffset(Offset="0x68")]
	private AbilityDescriptionFormatUtil _descFormatUtil;

	[Attribute(Name="InjectAttribute", RVA="0x105A754", Offset="0x105A754")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x78")]
	private Serverproto.Unit _unit;

	[FieldOffset(Offset="0x80")]
	private Serverproto.Spell _spell;

	[FieldOffset(Offset="0x88")]
	private Gamedata.GameMode _gameMode;

	[FieldOffset(Offset="0x90")]
	private List<UnitAbility> _abilities;

	[FieldOffset(Offset="0x98")]
	private List<MiniAbilityDetailsListItem> _abilityCardListItems;

	private MiniAbilityDetailsView.SerializedFields Fields
	{
		[Address(RVA="0x12F281C", Offset="0x12F281C", VA="0x12F281C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12F3360", Offset="0x12F3360", VA="0x12F3360")]
	public MiniAbilityDetailsView()
	{
	}

	[Address(RVA="0x12F2A10", Offset="0x12F2A10", VA="0x12F2A10", Slot="22")]
	public void HandleDispatchAction(DMiniAbilityDetailsListItemAction action)
	{
	}

	[Address(RVA="0x12F28FC", Offset="0x12F28FC", VA="0x12F28FC")]
	private void SelectAbilityIndex(int index)
	{
	}

	[Address(RVA="0x12F31B0", Offset="0x12F31B0", VA="0x12F31B0")]
	private void SetAbilityDescriptionInfo(string abilityName, string abilityType, ulong abilityLevel, bool showGameModeExclusion)
	{
	}

	[Address(RVA="0x12F1E90", Offset="0x12F1E90", VA="0x12F1E90")]
	public void SetSpell(Serverproto.Spell spell)
	{
	}

	[Address(RVA="0x12F2F68", Offset="0x12F2F68", VA="0x12F2F68")]
	private void SetSpellAbilityDescription()
	{
	}

	[Address(RVA="0x12F1734", Offset="0x12F1734", VA="0x12F1734")]
	public void SetUnit(Serverproto.Unit unit, Gamedata.GameMode gameMode)
	{
	}

	[Address(RVA="0x12F2C70", Offset="0x12F2C70", VA="0x12F2C70")]
	private void SetUnitAbilityDescription(int index)
	{
	}

	[Address(RVA="0x12F2AA0", Offset="0x12F2AA0", VA="0x12F2AA0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x12F2B2C", Offset="0x12F2B2C", VA="0x12F2B2C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C3EC", Offset="0x104C3EC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static MiniAbilityDetailsView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<MiniAbilityDetailsListItem> <>9__4_0;

		[Address(RVA="0x12F33F8", Offset="0x12F33F8", VA="0x12F33F8")]
		static <>c()
		{
		}

		[Address(RVA="0x12F345C", Offset="0x12F345C", VA="0x12F345C")]
		public <>c()
		{
		}

		[Address(RVA="0x12F3464", Offset="0x12F3464", VA="0x12F3464")]
		internal void <ViewShuttingDown>b__4_0(MiniAbilityDetailsListItem c)
		{
		}
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public MiniAbilityDetailsListItem AbilityCardListItem;

		[FieldOffset(Offset="0x38")]
		public UiLabel AbilityNameLabel;

		[FieldOffset(Offset="0x40")]
		public UiLabel AbilityTypeLabel;

		[FieldOffset(Offset="0x48")]
		public UiLabel CurrentLevelLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel CurrentLevelDescriptionLabel;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject GameModeExclusionAlert;

		[Attribute(Name="HeaderAttribute", RVA="0x106AE94", Offset="0x106AE94")]
		[FieldOffset(Offset="0x60")]
		public UnityEngine.GameObject UnitInfoRoot;

		[FieldOffset(Offset="0x68")]
		public UiLabel UnitNameLabel;

		[FieldOffset(Offset="0x70")]
		public UiLabel UnitLevelLabel;

		[FieldOffset(Offset="0x78")]
		public UiLabel UnitGearTierLabel;

		[FieldOffset(Offset="0x80")]
		public UiLabel UnitRarityLabel;

		[FieldOffset(Offset="0x88")]
		public Image UnitRoleIcon;

		[FieldOffset(Offset="0x90")]
		public SpriteSheetNameLookup UnitRoleSpriteLookup;

		[Address(RVA="0x12F3490", Offset="0x12F3490", VA="0x12F3490")]
		public SerializedFields()
		{
		}
	}
}