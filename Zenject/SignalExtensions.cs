using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;

namespace Zenject
{
	public static class SignalExtensions
	{
		[Address(RVA="0x2AFEA48", Offset="0x2AFEA48", VA="0x2AFEA48")]
		public static SignalHandlerBinderWithId BindSignal<TSignal>(DiContainer container)
		where TSignal : ISignal
		{
			return null;
		}

		[Address(RVA="0x2AFEB1C", Offset="0x2AFEB1C", VA="0x2AFEB1C")]
		public static SignalHandlerBinderWithId<TParam1> BindSignal<TParam1, TSignal>(DiContainer container)
		where TSignal : ISignal<TParam1>
		{
			return null;
		}

		[Address(RVA="0x2AFEC0C", Offset="0x2AFEC0C", VA="0x2AFEC0C")]
		public static SignalHandlerBinderWithId<TParam1, TParam2> BindSignal<TParam1, TParam2, TSignal>(DiContainer container)
		where TSignal : ISignal<TParam1, TParam2>
		{
			return null;
		}

		[Address(RVA="0x2AFECFC", Offset="0x2AFECFC", VA="0x2AFECFC")]
		public static SignalHandlerBinderWithId<TParam1, TParam2, TParam3> BindSignal<TParam1, TParam2, TParam3, TSignal>(DiContainer container)
		where TSignal : ISignal<TParam1, TParam2, TParam3>
		{
			return null;
		}

		[Address(RVA="0x2AFEDEC", Offset="0x2AFEDEC", VA="0x2AFEDEC")]
		public static SignalHandlerBinderWithId<TParam1, TParam2, TParam3, TParam4> BindSignal<TParam1, TParam2, TParam3, TParam4, TSignal>(DiContainer container)
		where TSignal : ISignal<TParam1, TParam2, TParam3, TParam4>
		{
			return null;
		}

		[Address(RVA="0x2AFBFD0", Offset="0x2AFBFD0", VA="0x2AFBFD0")]
		public static SignalBinderWithId DeclareSignal<T>(DiContainer container)
		where T : ISignalBase
		{
			return null;
		}

		[Address(RVA="0x2331E70", Offset="0x2331E70", VA="0x2331E70")]
		public static SignalBinderWithId DeclareSignal(DiContainer container, Type type)
		{
			return null;
		}
	}
}