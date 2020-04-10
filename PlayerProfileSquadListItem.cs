using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProfileSquadListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitListItem[] _unitListItems;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private SpellListItem[] _spellListItems;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UiLabel _deckPowerTextField;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Gamedata.GameMode _mode;

	public Gamedata.GameMode Mode
	{
		[Address(RVA="0x13414B0", Offset="0x13414B0", VA="0x13414B0")]
		get
		{
			return new Gamedata.GameMode();
		}
	}

	[Address(RVA="0x1341A80", Offset="0x1341A80", VA="0x1341A80")]
	public PlayerProfileSquadListItem()
	{
	}

	[Address(RVA="0x13414B8", Offset="0x13414B8", VA="0x13414B8")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x13416DC", Offset="0x13416DC", VA="0x13416DC")]
	public void SetData(List<Serverproto.Unit> units, List<Serverproto.Spell> spells)
	{
	}

	[Address(RVA="0x13415DC", Offset="0x13415DC", VA="0x13415DC", Slot="4")]
	public override void Shutdown()
	{
	}
}