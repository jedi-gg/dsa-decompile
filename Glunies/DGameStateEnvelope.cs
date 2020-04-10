using Il2CppDummyDll;
using System;

namespace Glunies
{
	public struct DGameStateEnvelope
	{
		[FieldOffset(Offset="0x0")]
		public readonly Type StateType;

		[FieldOffset(Offset="0x8")]
		public readonly GameStateTransitionContext Context;

		[Address(RVA="0xF00A80", Offset="0xF00A80", VA="0xF00A80")]
		public DGameStateEnvelope(Type stateType, GameStateTransitionContext context)
		{
		}

		[Address(RVA="0x14209F4", Offset="0x14209F4", VA="0x14209F4")]
		public static DGameStateEnvelope FromExisting(AGameState gameState)
		{
			return new DGameStateEnvelope();
		}
	}
}