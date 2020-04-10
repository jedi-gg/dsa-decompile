using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class BattleAbilityCardData
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052ADC", Offset="0x1052ADC")]
	[FieldOffset(Offset="0x10")]
	private BattleUnit <Unit>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052AEC", Offset="0x1052AEC")]
	[FieldOffset(Offset="0x18")]
	private DBattleAbilityId <BattleAbilityId>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052AFC", Offset="0x1052AFC")]
	[FieldOffset(Offset="0x28")]
	private BattleLib_Bootstrap.Types.Ability <PrimaryAbility>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052B0C", Offset="0x1052B0C")]
	[FieldOffset(Offset="0x30")]
	private BattleLib_Bootstrap.Types.Ability <SecondaryAbility>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052B1C", Offset="0x1052B1C")]
	[FieldOffset(Offset="0x38")]
	private Texture <PrimaryAbilityIcon>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052B2C", Offset="0x1052B2C")]
	[FieldOffset(Offset="0x40")]
	private bool <IsBusy>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052B3C", Offset="0x1052B3C")]
	[FieldOffset(Offset="0x48")]
	private string <AffinityIconName>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052B4C", Offset="0x1052B4C")]
	[FieldOffset(Offset="0x50")]
	private AbilityImpairmentStatus <ImpairmentStatus>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052B5C", Offset="0x1052B5C")]
	[FieldOffset(Offset="0x54")]
	private AbilityBuffStatus <BuffStatus>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052B6C", Offset="0x1052B6C")]
	[FieldOffset(Offset="0x58")]
	private byte <Charge>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052B7C", Offset="0x1052B7C")]
	[FieldOffset(Offset="0x59")]
	private bool <IsSelected>k__BackingField;

	public BattleLib_Bootstrap.Types.Ability Ability
	{
		[Address(RVA="0x1165B0C", Offset="0x1165B0C", VA="0x1165B0C")]
		get
		{
			return null;
		}
	}

	public string AffinityIconName
	{
		[Address(RVA="0x1165B68", Offset="0x1165B68", VA="0x1165B68")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E1B8", Offset="0x106E1B8")]
		get
		{
			return null;
		}
		[Address(RVA="0x1165B70", Offset="0x1165B70", VA="0x1165B70")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E1C8", Offset="0x106E1C8")]
		set
		{
		}
	}

	public DBattleAbilityId BattleAbilityId
	{
		[Address(RVA="0x1165AF8", Offset="0x1165AF8", VA="0x1165AF8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E118", Offset="0x106E118")]
		get
		{
			return new DBattleAbilityId();
		}
		[Address(RVA="0x1165B04", Offset="0x1165B04", VA="0x1165B04")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E128", Offset="0x106E128")]
		private set
		{
		}
	}

	public AbilityBuffStatus BuffStatus
	{
		[Address(RVA="0x1165B88", Offset="0x1165B88", VA="0x1165B88")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E1F8", Offset="0x106E1F8")]
		get
		{
			return new AbilityBuffStatus();
		}
		[Address(RVA="0x1165B90", Offset="0x1165B90", VA="0x1165B90")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E208", Offset="0x106E208")]
		set
		{
		}
	}

	public byte Charge
	{
		[Address(RVA="0x1165B98", Offset="0x1165B98", VA="0x1165B98")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E218", Offset="0x106E218")]
		get
		{
			return new byte();
		}
		[Address(RVA="0x1165BA0", Offset="0x1165BA0", VA="0x1165BA0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E228", Offset="0x106E228")]
		set
		{
		}
	}

	public AbilityImpairmentStatus ImpairmentStatus
	{
		[Address(RVA="0x1165B78", Offset="0x1165B78", VA="0x1165B78")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E1D8", Offset="0x106E1D8")]
		get
		{
			return new AbilityImpairmentStatus();
		}
		[Address(RVA="0x1165B80", Offset="0x1165B80", VA="0x1165B80")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E1E8", Offset="0x106E1E8")]
		set
		{
		}
	}

	public bool IsBusy
	{
		[Address(RVA="0x1165B54", Offset="0x1165B54", VA="0x1165B54")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E198", Offset="0x106E198")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x1165B5C", Offset="0x1165B5C", VA="0x1165B5C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E1A8", Offset="0x106E1A8")]
		set
		{
		}
	}

	public bool IsSelected
	{
		[Address(RVA="0x1165BA8", Offset="0x1165BA8", VA="0x1165BA8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E238", Offset="0x106E238")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x1165BB0", Offset="0x1165BB0", VA="0x1165BB0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E248", Offset="0x106E248")]
		set
		{
		}
	}

	public BattleLib_Bootstrap.Types.Ability PrimaryAbility
	{
		[Address(RVA="0x1165B2C", Offset="0x1165B2C", VA="0x1165B2C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E138", Offset="0x106E138")]
		get
		{
			return null;
		}
		[Address(RVA="0x1165B34", Offset="0x1165B34", VA="0x1165B34")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E148", Offset="0x106E148")]
		private set
		{
		}
	}

	public Texture PrimaryAbilityIcon
	{
		[Address(RVA="0x1165B44", Offset="0x1165B44", VA="0x1165B44")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E178", Offset="0x106E178")]
		get
		{
			return null;
		}
		[Address(RVA="0x1165B4C", Offset="0x1165B4C", VA="0x1165B4C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E188", Offset="0x106E188")]
		set
		{
		}
	}

	public BattleLib_Bootstrap.Types.Ability SecondaryAbility
	{
		[Address(RVA="0x1165B24", Offset="0x1165B24", VA="0x1165B24")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E158", Offset="0x106E158")]
		get
		{
			return null;
		}
		[Address(RVA="0x1165B3C", Offset="0x1165B3C", VA="0x1165B3C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E168", Offset="0x106E168")]
		private set
		{
		}
	}

	public BattleUnit Unit
	{
		[Address(RVA="0x1165AE8", Offset="0x1165AE8", VA="0x1165AE8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E0F8", Offset="0x106E0F8")]
		get
		{
			return null;
		}
		[Address(RVA="0x1165AF0", Offset="0x1165AF0", VA="0x1165AF0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E108", Offset="0x106E108")]
		private set
		{
		}
	}

	[Address(RVA="0x1165BBC", Offset="0x1165BBC", VA="0x1165BBC")]
	public BattleAbilityCardData()
	{
	}

	[Address(RVA="0x1165BE4", Offset="0x1165BE4", VA="0x1165BE4")]
	public void Reset()
	{
	}

	[Address(RVA="0x1165C70", Offset="0x1165C70", VA="0x1165C70")]
	public void SetData(BattleUnit unit, BattleLib_Bootstrap.Types.Ability ability, BattleLib_Bootstrap.Types.Ability secondaryAbility, DBattleAbilityId battleAbilityId, BattleLib_UpdateResult.Types.AbilityCard abilityCard)
	{
	}
}