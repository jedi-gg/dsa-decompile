using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class InstanceMethodSignalHandler<THandler, TParam1, TParam2> : InstanceMethodSignalHandlerBase<THandler>
	{
		[FieldOffset(Offset="0x0")]
		private readonly Func<THandler, Action<TParam1, TParam2>> _methodGetter;

		[Address(RVA="0x235108C", Offset="0x235108C", VA="0x235108C")]
		[Attribute(Name="InjectAttribute", RVA="0x1073E0C", Offset="0x1073E0C")]
		public InstanceMethodSignalHandler(BindingId signalId, SignalManager manager, InjectContext lookupContext, Func<THandler, Action<TParam1, TParam2>> methodGetter)
		{
		}

		[Address(RVA="0x23510FC", Offset="0x23510FC", VA="0x23510FC", Slot="10")]
		protected override void InternalExecute(THandler handler, object[] args)
		{
		}
	}
}