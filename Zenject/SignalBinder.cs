using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class SignalBinder : ConditionCopyNonLazyBinder
	{
		[FieldOffset(Offset="0x18")]
		private readonly SignalSettings _signalSettings;

		[Address(RVA="0x2331D90", Offset="0x2331D90", VA="0x2331D90")]
		public SignalBinder(Zenject.BindInfo bindInfo, SignalSettings signalSettings)
		{
		}

		[Address(RVA="0x2331DBC", Offset="0x2331DBC", VA="0x2331DBC")]
		public ConditionCopyNonLazyBinder RequireHandler()
		{
			return null;
		}
	}
}