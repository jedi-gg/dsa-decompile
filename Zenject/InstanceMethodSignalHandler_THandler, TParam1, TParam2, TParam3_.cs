using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class InstanceMethodSignalHandler<THandler, TParam1, TParam2, TParam3> : InstanceMethodSignalHandlerBase<THandler>
	{
		[FieldOffset(Offset="0x0")]
		private readonly Func<THandler, Action<TParam1, TParam2, TParam3>> _methodGetter;

		[Address(RVA="0x23513B8", Offset="0x23513B8", VA="0x23513B8")]
		[Attribute(Name="InjectAttribute", RVA="0x1073E1C", Offset="0x1073E1C")]
		public InstanceMethodSignalHandler(BindingId signalId, SignalManager manager, InjectContext lookupContext, Func<THandler, Action<TParam1, TParam2, TParam3>> methodGetter)
		{
		}

		[Address(RVA="0x2351428", Offset="0x2351428", VA="0x2351428", Slot="10")]
		protected override void InternalExecute(THandler handler, object[] args)
		{
		}
	}
}