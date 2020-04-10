using Glunies;
using Il2CppDummyDll;
using System;

public class InAppBrowserGameState : AGameState
{
	[Address(RVA="0x117DAA8", Offset="0x117DAA8", VA="0x117DAA8")]
	public InAppBrowserGameState()
	{
	}

	[Address(RVA="0x117DA48", Offset="0x117DA48", VA="0x117DA48", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class TransitionContext : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly string Url;

		[Address(RVA="0x117DAB0", Offset="0x117DAB0", VA="0x117DAB0")]
		public TransitionContext(string url)
		{
		}
	}
}