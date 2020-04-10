using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class TickablesTaskUpdater : TaskUpdater<ITickable>
	{
		[Address(RVA="0x233A404", Offset="0x233A404", VA="0x233A404")]
		public TickablesTaskUpdater()
		{
		}

		[Address(RVA="0x233C0E8", Offset="0x233C0E8", VA="0x233C0E8", Slot="4")]
		protected override void UpdateItem(ITickable task)
		{
		}
	}
}