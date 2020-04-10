using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class SignalHandlerBase : ISignalHandler, IDisposable, IInitializable, IValidatable
	{
		[FieldOffset(Offset="0x10")]
		private readonly SignalManager _manager;

		[FieldOffset(Offset="0x18")]
		private readonly BindingId _signalId;

		[Address(RVA="0x2331FF8", Offset="0x2331FF8", VA="0x2331FF8")]
		[Attribute(Name="InjectAttribute", RVA="0x1073EFC", Offset="0x1073EFC")]
		public SignalHandlerBase(BindingId signalId, SignalManager manager)
		{
		}

		[Address(RVA="0x23320EC", Offset="0x23320EC", VA="0x23320EC", Slot="5")]
		public void Dispose()
		{
		}

		public abstract void Execute(object[] args);

		[Address(RVA="0x2332030", Offset="0x2332030", VA="0x2332030", Slot="6")]
		public void Initialize()
		{
		}

		[Address(RVA="0x2332198", Offset="0x2332198", VA="0x2332198", Slot="8")]
		public virtual void Validate()
		{
		}

		[Address(RVA="0x16A77CC", Offset="0x16A77CC", VA="0x16A77CC")]
		protected void ValidateParameter<T>(object value)
		{
		}
	}
}