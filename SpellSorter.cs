using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class SpellSorter
{
	[Attribute(Name="InjectAttribute", RVA="0x105C800", Offset="0x105C800")]
	[FieldOffset(Offset="0x10")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C810", Offset="0x105C810")]
	[FieldOffset(Offset="0x18")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C820", Offset="0x105C820")]
	[FieldOffset(Offset="0x20")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105C830", Offset="0x105C830")]
	[FieldOffset(Offset="0x28")]
	private InventoryUtility _inventoryUtility;

	[Address(RVA="0x12448B4", Offset="0x12448B4", VA="0x12448B4")]
	public SpellSorter()
	{
	}

	[Address(RVA="0x12448BC", Offset="0x12448BC", VA="0x12448BC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070994", Offset="0x1070994")]
	private int <Sort>b__0_0(Gamedata.Spell? aSpellDef, Gamedata.Spell? bSpellDef)
	{
		return new int();
	}

	[Address(RVA="0x124429C", Offset="0x124429C", VA="0x124429C")]
	private int Compare(Gamedata.Spell? aDef, Gamedata.Spell? bDef)
	{
		return new int();
	}

	[Address(RVA="0x12445C4", Offset="0x12445C4", VA="0x12445C4")]
	private int Compare(Serverproto.Spell aSpell, Serverproto.Spell bSpell)
	{
		return new int();
	}

	[Address(RVA="0x124415C", Offset="0x124415C", VA="0x124415C")]
	public int CompareLevel(Gamedata.Spell? aDef, Gamedata.Spell? bDef)
	{
		return new int();
	}

	[Address(RVA="0x12444B8", Offset="0x12444B8", VA="0x12444B8")]
	private int CompareName(Gamedata.Spell? aDef, Gamedata.Spell? bDef)
	{
		return new int();
	}

	[Address(RVA="0x1244870", Offset="0x1244870", VA="0x1244870")]
	private int FallbackComparison(Gamedata.Spell? aDef, Gamedata.Spell? bDef)
	{
		return new int();
	}

	[Address(RVA="0x1243F2C", Offset="0x1243F2C", VA="0x1243F2C")]
	public void Sort(List<Gamedata.Spell?> spellDefList)
	{
	}

	[Address(RVA="0x1243FCC", Offset="0x1243FCC", VA="0x1243FCC")]
	public void Sort(List<Serverproto.Spell> spells)
	{
	}

	[Address(RVA="0x124406C", Offset="0x124406C", VA="0x124406C")]
	public void Sort(List<Serverproto.Spell> spells, List<Serverproto.Spell> selectedSpells)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CA8C", Offset="0x104CA8C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public List<Serverproto.Spell> selectedSpells;

		[FieldOffset(Offset="0x18")]
		public SpellSorter <>4__this;

		[Address(RVA="0x1244154", Offset="0x1244154", VA="0x1244154")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1244A0C", Offset="0x1244A0C", VA="0x1244A0C")]
		internal int <Sort>b__0(Serverproto.Spell aSpellProto, Serverproto.Spell bSpellProto)
		{
			return new int();
		}
	}
}