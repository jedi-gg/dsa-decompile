using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class SignalBinderWithId : SignalBinder
	{
		[Address(RVA="0x2331DF4", Offset="0x2331DF4", VA="0x2331DF4")]
		public SignalBinderWithId(Zenject.BindInfo bindInfo, SignalSettings signalSettings)
		{
		}

		[Address(RVA="0x2331E20", Offset="0x2331E20", VA="0x2331E20")]
		public SignalBinder WithId(object identifier)
		{
			return null;
		}
	}
}