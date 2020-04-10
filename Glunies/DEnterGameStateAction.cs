using Il2CppDummyDll;
using System;

namespace Glunies
{
	public struct DEnterGameStateAction
	{
		[FieldOffset(Offset="0x0")]
		public Type State;

		[FieldOffset(Offset="0x8")]
		public ITransitionContext Context;

		[FieldOffset(Offset="0x10")]
		public bool ForceReenterIfCurrentStateExists;

		[Address(RVA="0xF00A24", Offset="0xF00A24", VA="0xF00A24")]
		public DEnterGameStateAction(Type state, ITransitionContext context, bool forceReenterIfCurrentStateExists = false)
		{
		}
	}
}