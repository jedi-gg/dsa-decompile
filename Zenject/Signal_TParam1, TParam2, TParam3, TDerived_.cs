using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public abstract class Signal<TParam1, TParam2, TParam3, TDerived> : SignalBase, ISignal<TParam1, TParam2, TParam3>, ISignalBase
	where TDerived : Signal<TDerived, TParam1, TParam2, TParam3>
	{
		[FieldOffset(Offset="0x0")]
		private readonly List<Action<TParam1, TParam2, TParam3>> _listeners;

		[FieldOffset(Offset="0x0")]
		private readonly List<Action<TParam1, TParam2, TParam3>> _tempListeners;

		public int NumListeners
		{
			[Address(RVA="0x2BA7810", Offset="0x2BA7810", VA="0x2BA7810")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x2BA8150", Offset="0x2BA8150", VA="0x2BA8150")]
		protected Signal()
		{
		}

		[Address(RVA="0x2BA7D48", Offset="0x2BA7D48", VA="0x2BA7D48", Slot="6")]
		public void Fire(TParam1 p1, TParam2 p2, TParam3 p3)
		{
		}

		[Address(RVA="0x2BA7850", Offset="0x2BA7850", VA="0x2BA7850", Slot="7")]
		public void Listen(Action<TParam1, TParam2, TParam3> listener)
		{
		}

		[Address(RVA="0x2BA7B18", Offset="0x2BA7B18", VA="0x2BA7B18")]
		public static TDerived operator +(Signal<TDerived, TParam1, TParam2, TParam3> signal, Action<TParam1, TParam2, TParam3> listener)
		{
			return null;
		}

		[Address(RVA="0x2BA7C30", Offset="0x2BA7C30", VA="0x2BA7C30")]
		public static TDerived operator -(Signal<TDerived, TParam1, TParam2, TParam3> signal, Action<TParam1, TParam2, TParam3> listener)
		{
			return null;
		}

		[Address(RVA="0x2BA79C8", Offset="0x2BA79C8", VA="0x2BA79C8", Slot="8")]
		public void Unlisten(Action<TParam1, TParam2, TParam3> listener)
		{
		}
	}
}