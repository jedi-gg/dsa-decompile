using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class StaticMethodSignalHandler<TParam1, TParam2> : SignalHandlerBase
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<TParam1, TParam2> _method;

		[Address(RVA="0x2BA8E2C", Offset="0x2BA8E2C", VA="0x2BA8E2C")]
		public StaticMethodSignalHandler(BindingId signalId, SignalManager manager, Action<TParam1, TParam2> method)
		{
		}

		[Address(RVA="0x2BA8E7C", Offset="0x2BA8E7C", VA="0x2BA8E7C", Slot="9")]
		public override void Execute(object[] args)
		{
		}
	}
}