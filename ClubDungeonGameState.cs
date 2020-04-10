using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubDungeonGameState : AGameState
{
	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x11AF618", Offset="0x11AF618", VA="0x11AF618", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11AF680", Offset="0x11AF680", VA="0x11AF680")]
	public ClubDungeonGameState()
	{
	}

	[Address(RVA="0x11AF620", Offset="0x11AF620", VA="0x11AF620", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly Club Club;

		[Address(RVA="0x11AA76C", Offset="0x11AA76C", VA="0x11AA76C")]
		public Context(Club club)
		{
		}
	}
}