using Il2CppDummyDll;
using System;

public struct DBattleAutoBattleStateChangedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleAutoBattleStateChangedAction.Type ActionType;

	[FieldOffset(Offset="0x4")]
	public bool Enabled;

	[FieldOffset(Offset="0x8")]
	public int Speed;

	[Address(RVA="0xF02AA4", Offset="0xF02AA4", VA="0xF02AA4")]
	public DBattleAutoBattleStateChangedAction(DBattleAutoBattleStateChangedAction.Type actionType, bool enabled, int speed)
	{
	}

	[Flags]
	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		EnabledChanged = 1,
		[FieldOffset(Offset="0x0")]
		SpeedChanged = 2,
		[FieldOffset(Offset="0x0")]
		Ramp = 4
	}
}