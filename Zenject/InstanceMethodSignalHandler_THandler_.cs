using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class InstanceMethodSignalHandler<THandler> : InstanceMethodSignalHandlerBase<THandler>
	{
		[FieldOffset(Offset="0x0")]
		private readonly Func<THandler, Action> _methodGetter;

		[Address(RVA="0x2350D2C", Offset="0x2350D2C", VA="0x2350D2C")]
		[Attribute(Name="InjectAttribute", RVA="0x1073DEC", Offset="0x1073DEC")]
		public InstanceMethodSignalHandler(BindingId signalId, SignalManager manager, InjectContext lookupContext, Func<THandler, Action> methodGetter)
		{
		}

		[Address(RVA="0x2350D9C", Offset="0x2350D9C", VA="0x2350D9C", Slot="10")]
		protected override void InternalExecute(THandler handler, object[] args)
		{
		}
	}
}