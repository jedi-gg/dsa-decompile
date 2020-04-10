using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class LateTickablesTaskUpdater : TaskUpdater<ILateTickable>
	{
		[Address(RVA="0x183D2AC", Offset="0x183D2AC", VA="0x183D2AC")]
		public LateTickablesTaskUpdater()
		{
		}

		[Address(RVA="0x183D1FC", Offset="0x183D1FC", VA="0x183D1FC", Slot="4")]
		protected override void UpdateItem(ILateTickable task)
		{
		}
	}
}