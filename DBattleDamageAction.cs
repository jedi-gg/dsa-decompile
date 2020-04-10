using Il2CppDummyDll;
using Serverproto;
using System;

public struct DBattleDamageAction
{
	[FieldOffset(Offset="0x0")]
	public readonly BattleUnit TargetUnit;

	[FieldOffset(Offset="0x8")]
	public readonly int Amount;

	[FieldOffset(Offset="0xC")]
	public readonly bool IsCrit;

	[FieldOffset(Offset="0x10")]
	public readonly BattleLib_UpdateResult.Types.Damage.Types.Strength Strength;

	[Address(RVA="0xF02B88", Offset="0xF02B88", VA="0xF02B88")]
	public DBattleDamageAction(BattleUnit targetUnit, int amount, bool isCrit, BattleLib_UpdateResult.Types.Damage.Types.Strength strength)
	{
	}
}