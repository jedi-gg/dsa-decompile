using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class StaticMethodSignalHandler<TParam1, TParam2, TParam3, TParam4> : SignalHandlerBase
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<TParam1, TParam2, TParam3, TParam4> _method;

		[Address(RVA="0x2BA94D8", Offset="0x2BA94D8", VA="0x2BA94D8")]
		public StaticMethodSignalHandler(BindingId signalId, SignalManager manager, Action<TParam1, TParam2, TParam3, TParam4> method)
		{
		}

		[Address(RVA="0x2BA9528", Offset="0x2BA9528", VA="0x2BA9528", Slot="9")]
		public override void Execute(object[] args)
		{
		}
	}
}