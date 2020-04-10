using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class StaticMethodWithInstanceSignalHandler<THandler, TParam1> : InstanceMethodSignalHandlerBase<THandler>
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<THandler, TParam1> _method;

		[Address(RVA="0x2BA9AA8", Offset="0x2BA9AA8", VA="0x2BA9AA8")]
		[Attribute(Name="InjectAttribute", RVA="0x1073FBC", Offset="0x1073FBC")]
		public StaticMethodWithInstanceSignalHandler(BindingId signalId, SignalManager manager, InjectContext lookupContext, Action<THandler, TParam1> method)
		{
		}

		[Address(RVA="0x2BA9B18", Offset="0x2BA9B18", VA="0x2BA9B18", Slot="10")]
		protected override void InternalExecute(THandler handler, object[] args)
		{
		}
	}
}