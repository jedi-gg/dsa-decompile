using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class NullBindingFinalizer : IBindingFinalizer
	{
		public bool CopyIntoAllSubContainers
		{
			[Address(RVA="0x183DE24", Offset="0x183DE24", VA="0x183DE24", Slot="4")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x183DE30", Offset="0x183DE30", VA="0x183DE30")]
		public NullBindingFinalizer()
		{
		}

		[Address(RVA="0x183DE2C", Offset="0x183DE2C", VA="0x183DE2C", Slot="5")]
		public void FinalizeBinding(DiContainer container)
		{
		}
	}
}