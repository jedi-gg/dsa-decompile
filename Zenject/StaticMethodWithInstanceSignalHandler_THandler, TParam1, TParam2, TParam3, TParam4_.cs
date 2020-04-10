using Il2CppDummyDll;
using ModestTree.Util;
using System;

namespace Zenject
{
	public class StaticMethodWithInstanceSignalHandler<THandler, TParam1, TParam2, TParam3, TParam4> : InstanceMethodSignalHandlerBase<THandler>
	{
		[FieldOffset(Offset="0x0")]
		private readonly ModestTree.Util.Action<THandler, TParam1, TParam2, TParam3, TParam4> _method;

		[Address(RVA="0x2BAA3C0", Offset="0x2BAA3C0", VA="0x2BAA3C0")]
		[Attribute(Name="InjectAttribute", RVA="0x1073FEC", Offset="0x1073FEC")]
		public StaticMethodWithInstanceSignalHandler(BindingId signalId, SignalManager manager, InjectContext lookupContext, ModestTree.Util.Action<THandler, TParam1, TParam2, TParam3, TParam4> method)
		{
		}

		[Address(RVA="0x2BAA430", Offset="0x2BAA430", VA="0x2BAA430", Slot="10")]
		protected override void InternalExecute(THandler handler, object[] args)
		{
		}
	}
}