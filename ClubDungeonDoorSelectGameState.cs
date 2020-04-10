using Glunies;
using Il2CppDummyDll;
using System;

public class ClubDungeonDoorSelectGameState : AGameState
{
	public override bool CanBeNavigatedBackInto
	{
		[Address(RVA="0x11AD9D4", Offset="0x11AD9D4", VA="0x11AD9D4", Slot="8")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x11AD9CC", Offset="0x11AD9CC", VA="0x11AD9CC", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11ADA3C", Offset="0x11ADA3C", VA="0x11ADA3C")]
	public ClubDungeonDoorSelectGameState()
	{
	}

	[Address(RVA="0x11AD9DC", Offset="0x11AD9DC", VA="0x11AD9DC", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}
}