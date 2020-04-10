using Glunies;
using Il2CppDummyDll;
using System;

public class PlayerProfileGameState : AGameState
{
	[Attribute(Name="InjectAttribute", RVA="0x105BA80", Offset="0x105BA80")]
	[FieldOffset(Offset="0x30")]
	private PlayerDomainController _playerDc;

	[Address(RVA="0x1340DD4", Offset="0x1340DD4", VA="0x1340DD4")]
	public PlayerProfileGameState()
	{
	}

	[Address(RVA="0x1340CCC", Offset="0x1340CCC", VA="0x1340CCC", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class RemotePlayerTransitionContext : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly string PlayerId;

		[Address(RVA="0x1340DDC", Offset="0x1340DDC", VA="0x1340DDC")]
		public RemotePlayerTransitionContext(string playerId)
		{
		}

		[Address(RVA="0x1340E08", Offset="0x1340E08", VA="0x1340E08")]
		public RemotePlayerTransitionContext(DPlayerListItemClickedAction action)
		{
		}
	}
}