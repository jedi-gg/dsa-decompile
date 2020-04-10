using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FixedTickablesTaskUpdater : TaskUpdater<IFixedTickable>
	{
		[Address(RVA="0x183403C", Offset="0x183403C", VA="0x183403C")]
		public FixedTickablesTaskUpdater()
		{
		}

		[Address(RVA="0x1833F8C", Offset="0x1833F8C", VA="0x1833F8C", Slot="4")]
		protected override void UpdateItem(IFixedTickable task)
		{
		}
	}
}