using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class StaticMethodWithInstanceSignalHandler<THandler, TParam1, TParam2> : InstanceMethodSignalHandlerBase<THandler>
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<THandler, TParam1, TParam2> _method;

		[Address(RVA="0x2BA9CBC", Offset="0x2BA9CBC", VA="0x2BA9CBC")]
		[Attribute(Name="InjectAttribute", RVA="0x1073FCC", Offset="0x1073FCC")]
		public StaticMethodWithInstanceSignalHandler(BindingId signalId, SignalManager manager, InjectContext lookupContext, Action<THandler, TParam1, TParam2> method)
		{
		}

		[Address(RVA="0x2BA9D2C", Offset="0x2BA9D2C", VA="0x2BA9D2C", Slot="10")]
		protected override void InternalExecute(THandler handler, object[] args)
		{
		}
	}
}