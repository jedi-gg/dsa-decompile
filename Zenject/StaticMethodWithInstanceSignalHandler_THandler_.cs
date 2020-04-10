using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class StaticMethodWithInstanceSignalHandler<THandler> : InstanceMethodSignalHandlerBase<THandler>
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<THandler> _method;

		[Address(RVA="0x2BA9994", Offset="0x2BA9994", VA="0x2BA9994")]
		[Attribute(Name="InjectAttribute", RVA="0x1073FAC", Offset="0x1073FAC")]
		public StaticMethodWithInstanceSignalHandler(BindingId signalId, SignalManager manager, InjectContext lookupContext, Action<THandler> method)
		{
		}

		[Address(RVA="0x2BA9A04", Offset="0x2BA9A04", VA="0x2BA9A04", Slot="10")]
		protected override void InternalExecute(THandler handler, object[] args)
		{
		}
	}
}