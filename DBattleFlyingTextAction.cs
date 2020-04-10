using Il2CppDummyDll;
using System;
using UnityEngine;

public struct DBattleFlyingTextAction
{
	[FieldOffset(Offset="0x0")]
	public readonly BattleUnit TargetUnit;

	[FieldOffset(Offset="0x8")]
	public readonly Vector3 TargetPos;

	[FieldOffset(Offset="0x18")]
	public readonly string Text;

	[FieldOffset(Offset="0x20")]
	public readonly FlyingTextType TextType;

	[FieldOffset(Offset="0x24")]
	public readonly BattleFlyingText.AnimType AnimType;

	[Address(RVA="0xF02C74", Offset="0xF02C74", VA="0xF02C74")]
	public DBattleFlyingTextAction(BattleUnit targetUnit, string text, FlyingTextType textType, BattleFlyingText.AnimType animType = 0)
	{
	}

	[Address(RVA="0xF02C7C", Offset="0xF02C7C", VA="0xF02C7C")]
	public DBattleFlyingTextAction(Vector3 targetPos, string text, FlyingTextType textType, BattleFlyingText.AnimType animType = 0)
	{
	}
}