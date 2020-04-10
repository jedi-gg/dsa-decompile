using Glunies;
using Il2CppDummyDll;
using System;

public class InboxGameState : AGameState
{
	[Address(RVA="0x117E614", Offset="0x117E614", VA="0x117E614")]
	public InboxGameState()
	{
	}

	[Address(RVA="0x117E5B4", Offset="0x117E5B4", VA="0x117E5B4", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x1C")]
		public readonly InboxGameState.Context.Tab SelectedTab;

		[Address(RVA="0x117E61C", Offset="0x117E61C", VA="0x117E61C")]
		public Context(InboxGameState.Context.Tab selectedTab)
		{
		}

		public enum Tab
		{
			[FieldOffset(Offset="0x0")]
			DailyLogin
		}
	}
}