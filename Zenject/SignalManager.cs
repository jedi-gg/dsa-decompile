using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SignalManager : ILateDisposable
	{
		[FieldOffset(Offset="0x10")]
		private readonly Dictionary<BindingId, List<ISignalHandler>> _signalHandlers;

		[Address(RVA="0x2332868", Offset="0x2332868", VA="0x2332868")]
		public SignalManager()
		{
		}

		[Address(RVA="0x2332484", Offset="0x2332484", VA="0x2332484")]
		private List<ISignalHandler> GetList(BindingId signalType)
		{
			return null;
		}

		[Address(RVA="0x2331C74", Offset="0x2331C74", VA="0x2331C74")]
		public int GetNumHandlers(BindingId signalType)
		{
			return new int();
		}

		[Address(RVA="0x2331D08", Offset="0x2331D08", VA="0x2331D08")]
		public bool IsHandlerRegistered(BindingId signalType)
		{
			return new bool();
		}

		[Address(RVA="0x233255C", Offset="0x233255C", VA="0x233255C", Slot="4")]
		public void LateDispose()
		{
		}

		[Address(RVA="0x2332070", Offset="0x2332070", VA="0x2332070")]
		public void Register(BindingId signalType, ISignalHandler handler)
		{
		}

		[Address(RVA="0x23326A0", Offset="0x23326A0", VA="0x23326A0")]
		public bool Trigger(BindingId signalType, object[] args)
		{
			return new bool();
		}

		[Address(RVA="0x233212C", Offset="0x233212C", VA="0x233212C")]
		public void Unregister(BindingId signalType, ISignalHandler handler)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E1B8", Offset="0x104E1B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static SignalManager.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<List<ISignalHandler>, IEnumerable<ISignalHandler>> <>9__6_0;

			[Address(RVA="0x23328D8", Offset="0x23328D8", VA="0x23328D8")]
			static <>c()
			{
			}

			[Address(RVA="0x233293C", Offset="0x233293C", VA="0x233293C")]
			public <>c()
			{
			}

			[Address(RVA="0x2332944", Offset="0x2332944", VA="0x2332944")]
			internal IEnumerable<ISignalHandler> <LateDispose>b__6_0(List<ISignalHandler> x)
			{
				return null;
			}
		}
	}
}