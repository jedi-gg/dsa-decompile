using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class StaticMethodSignalHandler : SignalHandlerBase
	{
		[FieldOffset(Offset="0x20")]
		private readonly Action _method;

		[Address(RVA="0x2334C64", Offset="0x2334C64", VA="0x2334C64")]
		public StaticMethodSignalHandler(BindingId signalId, SignalManager manager, Action method)
		{
		}

		[Address(RVA="0x2334CA4", Offset="0x2334CA4", VA="0x2334CA4", Slot="9")]
		public override void Execute(object[] args)
		{
		}
	}
}