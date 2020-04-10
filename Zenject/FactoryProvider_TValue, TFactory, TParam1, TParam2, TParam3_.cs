using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class FactoryProvider<TValue, TFactory, TParam1, TParam2, TParam3> : FactoryProviderBase<TValue, TFactory>
	where TFactory : IFactory<TParam1, TParam2, TParam3, TValue>
	{
		[Address(RVA="0x1F4DA50", Offset="0x1F4DA50", VA="0x1F4DA50")]
		public FactoryProvider(DiContainer container, List<TypeValuePair> factoryArgs)
		{
		}

		[Address(RVA="0x1F4DAA4", Offset="0x1F4DAA4", VA="0x1F4DAA4", Slot="6")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073060", Offset="0x1073060")]
		public override IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DE58", Offset="0x104DE58")]
		private sealed class <GetAllInstancesWithInjectSplit>d__1 : IEnumerator<List<object>>, IEnumerator, IDisposable
		// where TFactory : IFactory<TParam1, TParam2, TParam3, TValue>
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
			public FactoryProvider<TParam1, TParam2, TParam3, TValue, TFactory> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x1F4D9D8", Offset="0x1F4D9D8", VA="0x1F4D9D8", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1F4DA48", Offset="0x1F4DA48", VA="0x1F4DA48", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1F4D130", Offset="0x1F4D130", VA="0x1F4D130")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__1(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1F4D16C", Offset="0x1F4D16C", VA="0x1F4D16C", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1F4D9E0", Offset="0x1F4D9E0", VA="0x1F4D9E0", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1F4D168", Offset="0x1F4D168", VA="0x1F4D168", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}