using Il2CppDummyDll;
using System;

namespace Glunies
{
	public abstract class AState
	{
		[Address(RVA="0x14F6974", Offset="0x14F6974", VA="0x14F6974")]
		protected AState()
		{
		}

		public abstract void Entering(ITransitionContext context);

		public abstract void Exiting();
	}
}