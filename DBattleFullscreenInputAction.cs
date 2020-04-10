using Il2CppDummyDll;
using System;
using UnityEngine;

public struct DBattleFullscreenInputAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleFullscreenInputAction.Type ActionType;

	[FieldOffset(Offset="0x4")]
	public readonly Vector2 Position;

	[Address(RVA="0xF02C94", Offset="0xF02C94", VA="0xF02C94")]
	public DBattleFullscreenInputAction(DBattleFullscreenInputAction.Type actionType, Vector2 position)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		ShortRelease,
		[FieldOffset(Offset="0x0")]
		LongPress
	}
}