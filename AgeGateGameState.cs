using Glunies;
using Il2CppDummyDll;
using System;

public class AgeGateGameState : AGameState
{
	public override bool CanBeDeepLinkedAwayFrom
	{
		[Address(RVA="0x1158584", Offset="0x1158584", VA="0x1158584", Slot="9")]
		get
		{
			return new bool();
		}
	}

	public override bool CanBeNavigatedBackInto
	{
		[Address(RVA="0x115857C", Offset="0x115857C", VA="0x115857C", Slot="8")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11585EC", Offset="0x11585EC", VA="0x11585EC")]
	public AgeGateGameState()
	{
	}

	[Address(RVA="0x115858C", Offset="0x115858C", VA="0x115858C", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}
}