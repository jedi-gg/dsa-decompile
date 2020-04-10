using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class TowerGameState : AGameState
{
	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x1435C08", Offset="0x1435C08", VA="0x1435C08", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1435C70", Offset="0x1435C70", VA="0x1435C70")]
	public TowerGameState()
	{
	}

	[Address(RVA="0x1435C10", Offset="0x1435C10", VA="0x1435C10", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly TowerIdentifier TowerId;

		[Address(RVA="0x143028C", Offset="0x143028C", VA="0x143028C")]
		public Context(TowerIdentifier towerId)
		{
		}
	}
}