using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class InstanceMethodSignalHandler<THandler, TParam1> : InstanceMethodSignalHandlerBase<THandler>
	{
		[FieldOffset(Offset="0x0")]
		private readonly Func<THandler, Action<TParam1>> _methodGetter;

		[Address(RVA="0x2350E58", Offset="0x2350E58", VA="0x2350E58")]
		[Attribute(Name="InjectAttribute", RVA="0x1073DFC", Offset="0x1073DFC")]
		public InstanceMethodSignalHandler(BindingId signalId, SignalManager manager, InjectContext lookupContext, Func<THandler, Action<TParam1>> methodGetter)
		{
		}

		[Address(RVA="0x2350EC8", Offset="0x2350EC8", VA="0x2350EC8", Slot="10")]
		protected override void InternalExecute(THandler handler, object[] args)
		{
		}
	}
}