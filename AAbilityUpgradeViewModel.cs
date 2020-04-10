using Gamedata;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public abstract class AAbilityUpgradeViewModel
{
	[FieldOffset(Offset="0x10")]
	public string TitleLocKey;

	[FieldOffset(Offset="0x18")]
	public int CurrentAbilityLevel;

	[FieldOffset(Offset="0x20")]
	public string CurrentAbilityLevelDescriptionLocKey;

	[FieldOffset(Offset="0x28")]
	public List<AAbilityUpgradeViewModel.Level> AbilityLevels;

	public int MaxAbilityLevels
	{
		[Address(RVA="0x10DD22C", Offset="0x10DD22C", VA="0x10DD22C")]
		get
		{
			return new int();
		}
	}

	[Address(RVA="0x10DE700", Offset="0x10DE700", VA="0x10DE700")]
	protected AAbilityUpgradeViewModel()
	{
	}

	public class Ingredient
	{
		[FieldOffset(Offset="0x10")]
		public ulong ItemId;

		[FieldOffset(Offset="0x18")]
		public ulong ItemCount;

		[Address(RVA="0x10DE770", Offset="0x10DE770", VA="0x10DE770")]
		public Ingredient()
		{
		}
	}

	public class Level
	{
		[FieldOffset(Offset="0x10")]
		public string PreviewDescriptionText;

		[FieldOffset(Offset="0x18")]
		public string UpgradeIcon;

		[FieldOffset(Offset="0x20")]
		public UnitRequirements? Requirements;

		[FieldOffset(Offset="0x38")]
		public List<AAbilityUpgradeViewModel.Ingredient> Ingredients;

		[Address(RVA="0x10DE778", Offset="0x10DE778", VA="0x10DE778")]
		public Level()
		{
		}
	}
}