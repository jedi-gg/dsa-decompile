using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClubWarSquadListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	protected LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	protected GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x38")]
	protected DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x40")]
	private SingleAssetRegistry _playerAvatarAssetRegistry;

	[FieldOffset(Offset="0x48")]
	private SingleAssetRegistry _clubXAvatarAssetRegistry;

	[FieldOffset(Offset="0x50")]
	private SingleAssetRegistry _clubYAvatarAssetRegistry;

	[FieldOffset(Offset="0x58")]
	private ClubWarDomainController _clubWarDc;

	[FieldOffset(Offset="0x60")]
	private string _squadId;

	[FieldOffset(Offset="0x68")]
	private object _ownerIdentifier;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private GameObject _squadInfoContainer;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _playerNameLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UiLabel _playerLevelLabel;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private RawImage _playerAvatar;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private UiLabel _squadPowerLabel;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private List<ClubWarUnitListItem> _units;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private List<SpellListItem> _spells;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private LabelButton _editButton;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private LabelButton _newForRebuildButton;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private LabelButton _assignButton;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private LabelButton _battleButton;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private LabelButton _removeButton;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private GameObject _defeatedByContainer;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private GameObject _clubXRoot;

	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	private Image _clubXBackground;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private RawImage _clubXAvatar;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private GameObject _clubYRoot;

	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private Image _clubYBackground;

	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private RawImage _clubYAvatar;

	[FieldOffset(Offset="0x108")]
	[SerializeField]
	private UiColorPalette _colorPalette;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private GameObject _nodeRoot;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private UiLabel _nodeIdLabel;

	[FieldOffset(Offset="0x120")]
	[SerializeField]
	private GameObject _deadRoot;

	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private Image _underAttackIcon;

	public string SquadId
	{
		[Address(RVA="0x14DB614", Offset="0x14DB614", VA="0x14DB614")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14DD208", Offset="0x14DD208", VA="0x14DD208")]
	public ClubWarSquadListItem()
	{
	}

	[Address(RVA="0x14DD210", Offset="0x14DD210", VA="0x14DD210")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F214", Offset="0x106F214")]
	private void <Initialize>b__2_0()
	{
	}

	[Address(RVA="0x14DD218", Offset="0x14DD218", VA="0x14DD218")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F224", Offset="0x106F224")]
	private void <Initialize>b__2_1()
	{
	}

	[Address(RVA="0x14DD220", Offset="0x14DD220", VA="0x14DD220")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F234", Offset="0x106F234")]
	private void <Initialize>b__2_2()
	{
	}

	[Address(RVA="0x14DD228", Offset="0x14DD228", VA="0x14DD228")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F244", Offset="0x106F244")]
	private void <Initialize>b__2_3()
	{
	}

	[Address(RVA="0x14DD230", Offset="0x14DD230", VA="0x14DD230")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F254", Offset="0x106F254")]
	private void <Initialize>b__2_4()
	{
	}

	[Address(RVA="0x14DD148", Offset="0x14DD148", VA="0x14DD148")]
	private static bool ActionMatch(DClubWarSquadListItemAction.ActionType actionType, DClubWarSquadListItemAction.ActionType actionOne, DClubWarSquadListItemAction.ActionType actionTwo)
	{
		return new bool();
	}

	[Address(RVA="0x14D72F4", Offset="0x14D72F4", VA="0x14D72F4")]
	public void ConfigureButtons(DClubWarSquadListItemAction.ActionType actionOne, DClubWarSquadListItemAction.ActionType actionTwo = 0)
	{
	}

	[Address(RVA="0x14DD160", Offset="0x14DD160", VA="0x14DD160")]
	private void Dispatch(DClubWarSquadListItemAction.ActionType actionType)
	{
	}

	[Address(RVA="0x14DB61C", Offset="0x14DB61C", VA="0x14DB61C", Slot="7")]
	public virtual void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x14D7540", Offset="0x14D7540", VA="0x14D7540")]
	public void SetActionDisabled(DClubWarSquadListItemAction.ActionType actionType, bool actionDisabled = true)
	{
	}

	[Address(RVA="0x14DC3F0", Offset="0x14DC3F0", VA="0x14DC3F0")]
	private void SetDefeatedBy(ClubWarDefense defenseData, ClubWarTeam nodeOwner = 0)
	{
	}

	[Address(RVA="0x14D704C", Offset="0x14D704C", VA="0x14D704C")]
	public void SetDefenseData(ClubWarDefense defenseData, ClubWarTeam nodeOwner)
	{
	}

	[Address(RVA="0x14D75D8", Offset="0x14D75D8", VA="0x14D75D8")]
	public void SetEmpty()
	{
	}

	[Address(RVA="0x14DC12C", Offset="0x14DC12C", VA="0x14DC12C")]
	private void SetPlayer(ClubWarPlayerProfileSimple player)
	{
	}

	[Address(RVA="0x14DCE34", Offset="0x14DCE34", VA="0x14DCE34")]
	public void SetSquadData(ClubWarSquad squadData)
	{
	}

	[Address(RVA="0x14DC9E4", Offset="0x14DC9E4", VA="0x14DC9E4")]
	private void SetSquadInternal(ClubWarSquad squad)
	{
	}

	[Address(RVA="0x14DBD94", Offset="0x14DBD94", VA="0x14DBD94", Slot="4")]
	public override void Shutdown()
	{
	}
}