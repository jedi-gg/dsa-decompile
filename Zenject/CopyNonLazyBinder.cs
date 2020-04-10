using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class CopyNonLazyBinder : NonLazyBinder
	{
		[Address(RVA="0x15AF7C4", Offset="0x15AF7C4", VA="0x15AF7C4")]
		public CopyNonLazyBinder(Zenject.BindInfo bindInfo)
		{
		}

		[Address(RVA="0x15B35E8", Offset="0x15B35E8", VA="0x15B35E8")]
		public NonLazyBinder CopyIntoAllSubContainers()
		{
			return null;
		}
	}
}