using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public abstract class Signal<TDerived> : SignalBase, ISignal, ISignalBase
	where TDerived : Signal<TDerived>
	{
		[FieldOffset(Offset="0x0")]
		private readonly List<Action> _listeners;

		[FieldOffset(Offset="0x0")]
		private readonly List<Action> _tempListeners;

		public int NumListeners
		{
			[Address(RVA="0x2BA5C34", Offset="0x2BA5C34", VA="0x2BA5C34")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x2BA6430", Offset="0x2BA6430", VA="0x2BA6430")]
		protected Signal()
		{
		}

		[Address(RVA="0x2BA6160", Offset="0x2BA6160", VA="0x2BA6160", Slot="6")]
		public void Fire()
		{
		}

		[Address(RVA="0x2BA5C94", Offset="0x2BA5C94", VA="0x2BA5C94", Slot="7")]
		public void Listen(Action listener)
		{
		}

		[Address(RVA="0x2BA5F30", Offset="0x2BA5F30", VA="0x2BA5F30")]
		public static TDerived operator +(Signal<TDerived> signal, Action listener)
		{
			return null;
		}

		[Address(RVA="0x2BA6048", Offset="0x2BA6048", VA="0x2BA6048")]
		public static TDerived operator -(Signal<TDerived> signal, Action listener)
		{
			return null;
		}

		[Address(RVA="0x2BA5DF4", Offset="0x2BA5DF4", VA="0x2BA5DF4", Slot="8")]
		public void Unlisten(Action listener)
		{
		}
	}
}