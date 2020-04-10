using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class StaticMethodSignalHandler<TParam1, TParam2, TParam3> : SignalHandlerBase
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<TParam1, TParam2, TParam3> _method;

		[Address(RVA="0x2BA9108", Offset="0x2BA9108", VA="0x2BA9108")]
		public StaticMethodSignalHandler(BindingId signalId, SignalManager manager, Action<TParam1, TParam2, TParam3> method)
		{
		}

		[Address(RVA="0x2BA9158", Offset="0x2BA9158", VA="0x2BA9158", Slot="9")]
		public override void Execute(object[] args)
		{
		}
	}
}