using Glunies;
using Il2CppDummyDll;
using System;

public class ItemFindGameState : AGameState
{
	[Address(RVA="0x11C2130", Offset="0x11C2130", VA="0x11C2130")]
	public ItemFindGameState()
	{
	}

	[Address(RVA="0x11C20D0", Offset="0x11C20D0", VA="0x11C20D0", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly ulong ItemId;

		[Address(RVA="0x11C2138", Offset="0x11C2138", VA="0x11C2138")]
		public Context(ulong itemId)
		{
		}
	}
}