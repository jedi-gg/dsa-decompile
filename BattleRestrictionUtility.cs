using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using System.Text;

public class BattleRestrictionUtility
{
	[Attribute(Name="InjectAttribute", RVA="0x105FAB0", Offset="0x105FAB0")]
	[FieldOffset(Offset="0x10")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105FAC0", Offset="0x105FAC0")]
	[FieldOffset(Offset="0x18")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105FAD0", Offset="0x105FAD0")]
	[FieldOffset(Offset="0x20")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x28")]
	private StringBuilder _stringBuilder;

	[FieldOffset(Offset="0x30")]
	private StringBuilder _stringBuilder2;

	[Address(RVA="0x1290AE8", Offset="0x1290AE8", VA="0x1290AE8")]
	public BattleRestrictionUtility()
	{
	}

	[Address(RVA="0x1290A28", Offset="0x1290A28", VA="0x1290A28")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10710BC", Offset="0x10710BC")]
	private void <BuildRequiredUnitFilterLine>g__AddSeparator|3_0(BattleRestrictionUtility.ListSeparatorType type, ref BattleRestrictionUtility.<>c__DisplayClass3_0 _)
	{
	}

	[Address(RVA="0x128F754", Offset="0x128F754", VA="0x128F754")]
	private void BuildRequiredUnitFilterLine(UnitFilter? requiredUnitFilter, StringBuilder stringBuilder, BattleRestrictionUtility.ListSeparatorType listSeparatorType)
	{
	}

	[Address(RVA="0x128FBD0", Offset="0x128FBD0", VA="0x128FBD0")]
	public string GetSquadFailsRestrictionText(BattleRestriction? battleRestriction)
	{
		return null;
	}

	[Address(RVA="0x12900FC", Offset="0x12900FC", VA="0x12900FC")]
	public string GetSquadRequirementStatusText(List<Serverproto.Unit> units, List<Serverproto.Spell> spells, BattleRestriction? battleRestriction)
	{
		return null;
	}

	[Address(RVA="0x128E898", Offset="0x128E898", VA="0x128E898")]
	public void SetLabelText(BattleRestrictionUtility.Labels labels, BattleRestriction? battleRestriction)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D1CC", Offset="0x104D1CC")]
	private struct <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x0")]
		public StringBuilder stringBuilder;

		[FieldOffset(Offset="0x8")]
		public BattleRestrictionUtility <>4__this;
	}

	[Serializable]
	public class Labels
	{
		[FieldOffset(Offset="0x10")]
		public UiLabel RequiredUnitsLabel;

		[FieldOffset(Offset="0x18")]
		public UiLabel RequiredFilterLabel;

		[FieldOffset(Offset="0x20")]
		public UiLabel AllowedCategoriesLabel;

		[FieldOffset(Offset="0x28")]
		public UiLabel FullSquadLabel;

		[FieldOffset(Offset="0x30")]
		public UiLabel RarityLabel;

		[FieldOffset(Offset="0x38")]
		public UiLabel LevelLabel;

		[FieldOffset(Offset="0x40")]
		public UiLabel GearTierLabel;

		[Address(RVA="0x1290B70", Offset="0x1290B70", VA="0x1290B70")]
		public Labels()
		{
		}
	}

	private enum ListSeparatorType
	{
		[FieldOffset(Offset="0x0")]
		LocalizedCharacter,
		[FieldOffset(Offset="0x0")]
		NewLine
	}
}