using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class FactoryProvider<TValue, TFactory, TParam1, TParam2> : FactoryProviderBase<TValue, TFactory>
	where TFactory : IFactory<TParam1, TParam2, TValue>
	{
		[Address(RVA="0x1F4D028", Offset="0x1F4D028", VA="0x1F4D028")]
		public FactoryProvider(DiContainer container, List<TypeValuePair> factoryArgs)
		{
		}

		[Address(RVA="0x1F4D07C", Offset="0x1F4D07C", VA="0x1F4D07C", Slot="6")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072FFC", Offset="0x1072FFC")]
		public override IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DE48", Offset="0x104DE48")]
		private sealed class <GetAllInstancesWithInjectSplit>d__1 : IEnumerator<List<object>>, IEnumerator, IDisposable
		// where TFactory : IFactory<TParam1, TParam2, TValue>
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x0")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x0")]
			public InjectContext context;

			[FieldOffset(Offset="0x0")]
			public FactoryProvider<TParam1, TParam2, TValue, TFactory> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x1F4CFB0", Offset="0x1F4CFB0", VA="0x1F4CFB0", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1F4D020", Offset="0x1F4D020", VA="0x1F4D020", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1F4C80C", Offset="0x1F4C80C", VA="0x1F4C80C")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__1(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1F4C848", Offset="0x1F4C848", VA="0x1F4C848", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1F4CFB8", Offset="0x1F4CFB8", VA="0x1F4CFB8", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1F4C844", Offset="0x1F4C844", VA="0x1F4C844", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}