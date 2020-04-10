using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class FactoryProvider<TValue, TFactory, TParam1, TParam2, TParam3, TParam4> : FactoryProviderBase<TValue, TFactory>
	where TFactory : IFactory<TParam1, TParam2, TParam3, TParam4, TValue>
	{
		[Address(RVA="0x1F4E584", Offset="0x1F4E584", VA="0x1F4E584")]
		public FactoryProvider(DiContainer container, List<TypeValuePair> factoryArgs)
		{
		}

		[Address(RVA="0x1F4E5D8", Offset="0x1F4E5D8", VA="0x1F4E5D8", Slot="6")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10730C4", Offset="0x10730C4")]
		public override IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DE68", Offset="0x104DE68")]
		private sealed class <GetAllInstancesWithInjectSplit>d__1 : IEnumerator<List<object>>, IEnumerator, IDisposable
		// where TFactory : IFactory<TParam1, TParam2, TParam3, TParam4, TValue>
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
			public FactoryProvider<TParam1, TParam2, TParam3, TParam4, TValue, TFactory> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x1F4E50C", Offset="0x1F4E50C", VA="0x1F4E50C", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1F4E57C", Offset="0x1F4E57C", VA="0x1F4E57C", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1F4DB58", Offset="0x1F4DB58", VA="0x1F4DB58")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__1(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1F4DB94", Offset="0x1F4DB94", VA="0x1F4DB94", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1F4E514", Offset="0x1F4E514", VA="0x1F4E514", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1F4DB90", Offset="0x1F4DB90", VA="0x1F4DB90", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}