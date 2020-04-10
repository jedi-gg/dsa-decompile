using Glunies;
using Il2CppDummyDll;
using System;

public class EventGroupGameStateContext : GameStateTransitionContext
{
	[FieldOffset(Offset="0x20")]
	public readonly ulong EventGroupId;

	[Address(RVA="0x12025D4", Offset="0x12025D4", VA="0x12025D4")]
	public EventGroupGameStateContext(ulong eventGroupId)
	{
	}
}