using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class InstanceMethodSignalHandlerBase<THandler> : SignalHandlerBase
	{
		[FieldOffset(Offset="0x0")]
		private readonly InjectContext _lookupContext;

		[Address(RVA="0x235086C", Offset="0x235086C", VA="0x235086C")]
		[Attribute(Name="InjectAttribute", RVA="0x1073DDC", Offset="0x1073DDC")]
		public InstanceMethodSignalHandlerBase(BindingId signalId, SignalManager manager, InjectContext lookupContext)
		{
		}

		[Address(RVA="0x23509AC", Offset="0x23509AC", VA="0x23509AC", Slot="9")]
		public override void Execute(object[] args)
		{
		}

		protected abstract void InternalExecute(THandler handler, object[] args);

		[Address(RVA="0x2350958", Offset="0x2350958", VA="0x2350958", Slot="8")]
		public override void Validate()
		{
		}
	}
}