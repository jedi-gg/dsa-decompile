using Glunies;
using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public class RebootInfernoState : AInfernoState
	{
		[Address(RVA="0x15255F8", Offset="0x15255F8", VA="0x15255F8")]
		public RebootInfernoState()
		{
		}

		[Address(RVA="0x15255A8", Offset="0x15255A8", VA="0x15255A8", Slot="4")]
		public override void Entering(ITransitionContext context)
		{
		}

		[Address(RVA="0x15255F4", Offset="0x15255F4", VA="0x15255F4", Slot="5")]
		public override void Exiting()
		{
		}
	}
}