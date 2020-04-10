using Glunies;
using Il2CppDummyDll;
using System;

public class StandaloneIntroCinematicGameState : AGameState
{
	public override bool CanBeNavigatedBackInto
	{
		[Address(RVA="0x12275A0", Offset="0x12275A0", VA="0x12275A0", Slot="8")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x12275A8", Offset="0x12275A8", VA="0x12275A8", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1227610", Offset="0x1227610", VA="0x1227610")]
	public StandaloneIntroCinematicGameState()
	{
	}

	[Address(RVA="0x12275B0", Offset="0x12275B0", VA="0x12275B0", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}
}