using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public abstract class Signal<TParam1, TParam2, TParam3, TParam4, TDerived> : SignalBase, ISignal<TParam1, TParam2, TParam3, TParam4>, ISignalBase
	where TDerived : Signal<TDerived, TParam1, TParam2, TParam3, TParam4>
	{
		[FieldOffset(Offset="0x0")]
		private readonly List<Action<TParam1, TParam2, TParam3, TParam4>> _listeners;

		[FieldOffset(Offset="0x0")]
		private readonly List<Action<TParam1, TParam2, TParam3, TParam4>> _tempListeners;

		public int NumListeners
		{
			[Address(RVA="0x2BA8200", Offset="0x2BA8200", VA="0x2BA8200")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x2BA8B98", Offset="0x2BA8B98", VA="0x2BA8B98")]
		protected Signal()
		{
		}

		[Address(RVA="0x2BA8738", Offset="0x2BA8738", VA="0x2BA8738", Slot="6")]
		public void Fire(TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4)
		{
		}

		[Address(RVA="0x2BA8240", Offset="0x2BA8240", VA="0x2BA8240", Slot="8")]
		public void Listen(Action<TParam1, TParam2, TParam3, TParam4> listener)
		{
		}

		[Address(RVA="0x2BA8508", Offset="0x2BA8508", VA="0x2BA8508")]
		public static TDerived operator +(Signal<TDerived, TParam1, TParam2, TParam3, TParam4> signal, Action<TParam1, TParam2, TParam3, TParam4> listener)
		{
			return null;
		}

		[Address(RVA="0x2BA8620", Offset="0x2BA8620", VA="0x2BA8620")]
		public static TDerived operator -(Signal<TDerived, TParam1, TParam2, TParam3, TParam4> signal, Action<TParam1, TParam2, TParam3, TParam4> listener)
		{
			return null;
		}

		[Address(RVA="0x2BA83B8", Offset="0x2BA83B8", VA="0x2BA83B8", Slot="7")]
		public void Unlisten(Action<TParam1, TParam2, TParam3, TParam4> listener)
		{
		}
	}
}