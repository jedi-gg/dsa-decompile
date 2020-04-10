using Glunies;
using Il2CppDummyDll;
using System;

public class UnitAbilityUpgradeGameState : AGameState
{
	[Address(RVA="0x11DD63C", Offset="0x11DD63C", VA="0x11DD63C")]
	public UnitAbilityUpgradeGameState()
	{
	}

	[Address(RVA="0x11DD5DC", Offset="0x11DD5DC", VA="0x11DD5DC", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly ulong UnitId;

		[FieldOffset(Offset="0x28")]
		public int AbilityId;

		[FieldOffset(Offset="0x2C")]
		public readonly bool AllowUpgrade;

		[FieldOffset(Offset="0x30")]
		public int SelectedAbilityLevelIndex;

		[Address(RVA="0x11DD644", Offset="0x11DD644", VA="0x11DD644")]
		public Context(ulong unitId, int abilityId, bool allowUpgrade = true, int selectedAbilityLevelIndex = -1)
		{
		}
	}
}