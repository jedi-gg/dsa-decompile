using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class StaticMethodWithInstanceSignalHandler<THandler, TParam1, TParam2, TParam3> : InstanceMethodSignalHandlerBase<THandler>
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<THandler, TParam1, TParam2, TParam3> _method;

		[Address(RVA="0x2BA9FC8", Offset="0x2BA9FC8", VA="0x2BA9FC8")]
		[Attribute(Name="InjectAttribute", RVA="0x1073FDC", Offset="0x1073FDC")]
		public StaticMethodWithInstanceSignalHandler(BindingId signalId, SignalManager manager, InjectContext lookupContext, Action<THandler, TParam1, TParam2, TParam3> method)
		{
		}

		[Address(RVA="0x2BAA038", Offset="0x2BAA038", VA="0x2BAA038", Slot="10")]
		protected override void InternalExecute(THandler handler, object[] args)
		{
		}
	}
}