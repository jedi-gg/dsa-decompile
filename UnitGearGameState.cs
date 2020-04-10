using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class UnitGearGameState : AGameState
{
	[Address(RVA="0x11F3678", Offset="0x11F3678", VA="0x11F3678")]
	public UnitGearGameState()
	{
	}

	[Address(RVA="0x11F3618", Offset="0x11F3618", VA="0x11F3618", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public ulong UnitId;

		[FieldOffset(Offset="0x28")]
		public int GearSlotIndex;

		[FieldOffset(Offset="0x30")]
		public List<ulong> SelectedIngredients;

		[Address(RVA="0x11E0AD0", Offset="0x11E0AD0", VA="0x11E0AD0")]
		public Context(ulong unitId, int gearSlotIndex)
		{
		}
	}
}