using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class InstanceMethodSignalHandler<THandler, TParam1, TParam2, TParam3, TParam4> : InstanceMethodSignalHandlerBase<THandler>
	{
		[FieldOffset(Offset="0x0")]
		private readonly Func<THandler, Action<TParam1, TParam2, TParam3, TParam4>> _methodGetter;

		[Address(RVA="0x23517D8", Offset="0x23517D8", VA="0x23517D8")]
		[Attribute(Name="InjectAttribute", RVA="0x1073E2C", Offset="0x1073E2C")]
		public InstanceMethodSignalHandler(BindingId signalId, SignalManager manager, InjectContext lookupContext, Func<THandler, Action<TParam1, TParam2, TParam3, TParam4>> methodGetter)
		{
		}

		[Address(RVA="0x2351848", Offset="0x2351848", VA="0x2351848", Slot="10")]
		protected override void InternalExecute(THandler handler, object[] args)
		{
		}
	}
}