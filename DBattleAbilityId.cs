using Il2CppDummyDll;
using Serverproto;
using System;

public struct DBattleAbilityId
{
	[FieldOffset(Offset="0x0")]
	public AbilitySourceType SourceType;

	[FieldOffset(Offset="0x4")]
	public byte SourceId;

	[FieldOffset(Offset="0x5")]
	public byte AbilityId;

	[FieldOffset(Offset="0x8")]
	public AbilitySourceType SecondarySourceType;

	[FieldOffset(Offset="0xC")]
	public byte SecondarySourceId;

	[FieldOffset(Offset="0xD")]
	public byte SecondaryAbilityId;

	[Address(RVA="0xF02904", Offset="0xF02904", VA="0xF02904")]
	public DBattleAbilityId(AbilitySourceType sourceType, byte sourceId, byte abilityId, AbilitySourceType secondarySourceType = 0, byte secondarySourceId = 255, byte secondaryAbilityId = 255)
	{
	}

	[Address(RVA="0xF02920", Offset="0xF02920", VA="0xF02920")]
	public DBattleAbilityId(DBattleAbilityId other, AbilitySourceType secondarySourceType = 0, byte secondarySourceId = 255, byte secondaryAbilityId = 255)
	{
	}

	[Address(RVA="0xF02A00", Offset="0xF02A00", VA="0xF02A00")]
	public bool IsAssociatedWith(BattleUnit unit)
	{
		return new bool();
	}

	[Address(RVA="0xF02964", Offset="0xF02964", VA="0xF02964")]
	public bool Matches(DBattleAbilityId other, DBattleAbilityId.MatchMode mode = 2)
	{
		return new bool();
	}

	[Address(RVA="0xF029A8", Offset="0xF029A8", VA="0xF029A8")]
	public bool Matches(BattleLib_UpdateResult.Types.AbilityCard abilityCard, DBattleAbilityId.MatchMode mode = 2)
	{
		return new bool();
	}

	[Address(RVA="0xF029B0", Offset="0xF029B0", VA="0xF029B0")]
	public bool Matches(DCastAttemptAction action, DBattleAbilityId.MatchMode mode = 2)
	{
		return new bool();
	}

	[Address(RVA="0xF029F8", Offset="0xF029F8", VA="0xF029F8")]
	public bool Matches(AbilitySourceType sourceType, byte sourceId, byte abilityId, AbilitySourceType secondarySourceType = 0, byte secondarySourceId = 255, byte secondaryAbilityId = 255, DBattleAbilityId.MatchMode mode = 2)
	{
		return new bool();
	}

	[Address(RVA="0xF0294C", Offset="0xF0294C", VA="0xF0294C")]
	public void Reset()
	{
	}

	[Address(RVA="0xF02944", Offset="0xF02944", VA="0xF02944", Slot="3")]
	public override string ToString()
	{
		return null;
	}

	public enum MatchMode
	{
		[FieldOffset(Offset="0x0")]
		PrimaryOnly,
		[FieldOffset(Offset="0x0")]
		SecondaryOnly,
		[FieldOffset(Offset="0x0")]
		PrimaryAndSecondary,
		[FieldOffset(Offset="0x0")]
		PrimaryOrSecondaryMatchesPrimary
	}
}