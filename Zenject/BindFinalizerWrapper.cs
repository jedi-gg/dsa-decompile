using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class BindFinalizerWrapper : IBindingFinalizer
	{
		[FieldOffset(Offset="0x10")]
		private IBindingFinalizer _subFinalizer;

		public bool CopyIntoAllSubContainers
		{
			[Address(RVA="0x15AB890", Offset="0x15AB890", VA="0x15AB890", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public IBindingFinalizer SubFinalizer
		{
			[Address(RVA="0x15AB888", Offset="0x15AB888", VA="0x15AB888")]
			set
			{
			}
		}

		[Address(RVA="0x15ABA24", Offset="0x15ABA24", VA="0x15ABA24")]
		public BindFinalizerWrapper()
		{
		}

		[Address(RVA="0x15AB944", Offset="0x15AB944", VA="0x15AB944", Slot="5")]
		public void FinalizeBinding(DiContainer container)
		{
		}
	}
}