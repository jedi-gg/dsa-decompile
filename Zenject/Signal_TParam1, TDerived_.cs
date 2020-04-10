using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public abstract class Signal<TParam1, TDerived> : SignalBase, ISignal<TParam1>, ISignalBase
	where TDerived : Signal<TDerived, TParam1>
	{
		[FieldOffset(Offset="0x0")]
		private readonly List<Action<TParam1>> _listeners;

		[FieldOffset(Offset="0x0")]
		private readonly List<Action<TParam1>> _tempListeners;

		public int NumListeners
		{
			[Address(RVA="0x2BA64CC", Offset="0x2BA64CC", VA="0x2BA64CC")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x2BA6D64", Offset="0x2BA6D64", VA="0x2BA6D64")]
		protected Signal()
		{
		}

		[Address(RVA="0x2BA6A04", Offset="0x2BA6A04", VA="0x2BA6A04", Slot="6")]
		public void Fire(TParam1 p1)
		{
		}

		[Address(RVA="0x2BA650C", Offset="0x2BA650C", VA="0x2BA650C", Slot="7")]
		public void Listen(Action<TParam1> listener)
		{
		}

		[Address(RVA="0x2BA67D4", Offset="0x2BA67D4", VA="0x2BA67D4")]
		public static TDerived operator +(Signal<TDerived, TParam1> signal, Action<TParam1> listener)
		{
			return null;
		}

		[Address(RVA="0x2BA68EC", Offset="0x2BA68EC", VA="0x2BA68EC")]
		public static TDerived operator -(Signal<TDerived, TParam1> signal, Action<TParam1> listener)
		{
			return null;
		}

		[Address(RVA="0x2BA6684", Offset="0x2BA6684", VA="0x2BA6684", Slot="8")]
		public void Unlisten(Action<TParam1> listener)
		{
		}
	}
}