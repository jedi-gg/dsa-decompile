using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public abstract class Signal<TParam1, TParam2, TDerived> : SignalBase, ISignal<TParam1, TParam2>, ISignalBase
	where TDerived : Signal<TDerived, TParam1, TParam2>
	{
		[FieldOffset(Offset="0x0")]
		private readonly List<Action<TParam1, TParam2>> _listeners;

		[FieldOffset(Offset="0x0")]
		private readonly List<Action<TParam1, TParam2>> _tempListeners;

		public int NumListeners
		{
			[Address(RVA="0x2BA6E14", Offset="0x2BA6E14", VA="0x2BA6E14")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x2BA7760", Offset="0x2BA7760", VA="0x2BA7760")]
		protected Signal()
		{
		}

		[Address(RVA="0x2BA73A8", Offset="0x2BA73A8", VA="0x2BA73A8", Slot="6")]
		public void Fire(TParam1 p1, TParam2 p2)
		{
		}

		[Address(RVA="0x2BA6E54", Offset="0x2BA6E54", VA="0x2BA6E54", Slot="8")]
		public void Listen(Action<TParam1, TParam2> listener)
		{
		}

		[Address(RVA="0x2BA7178", Offset="0x2BA7178", VA="0x2BA7178")]
		public static TDerived operator +(Signal<TDerived, TParam1, TParam2> signal, Action<TParam1, TParam2> listener)
		{
			return null;
		}

		[Address(RVA="0x2BA7290", Offset="0x2BA7290", VA="0x2BA7290")]
		public static TDerived operator -(Signal<TDerived, TParam1, TParam2> signal, Action<TParam1, TParam2> listener)
		{
			return null;
		}

		[Address(RVA="0x2BA6FF8", Offset="0x2BA6FF8", VA="0x2BA6FF8", Slot="7")]
		public void Unlisten(Action<TParam1, TParam2> listener)
		{
		}
	}
}