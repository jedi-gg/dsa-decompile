using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class StaticMethodSignalHandler<TParam1> : SignalHandlerBase
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<TParam1> _method;

		[Address(RVA="0x2BA8C48", Offset="0x2BA8C48", VA="0x2BA8C48")]
		public StaticMethodSignalHandler(BindingId signalId, SignalManager manager, Action<TParam1> method)
		{
		}

		[Address(RVA="0x2BA8C98", Offset="0x2BA8C98", VA="0x2BA8C98", Slot="9")]
		public override void Execute(object[] args)
		{
		}
	}
}