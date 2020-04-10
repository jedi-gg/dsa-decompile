using Glunies;
using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public abstract class AInfernoState : AState
	{
		[Address(RVA="0x142C234", Offset="0x142C234", VA="0x142C234")]
		protected AInfernoState()
		{
		}

		[Address(RVA="0x142C230", Offset="0x142C230", VA="0x142C230", Slot="6")]
		public virtual void TickUpdate()
		{
		}
	}
}