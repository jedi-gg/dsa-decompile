using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class FactoryProvider<TValue, TFactory> : FactoryProviderBase<TValue, TFactory>
	where TFactory : IFactory<TValue>
	{
		[Address(RVA="0x1F4BEEC", Offset="0x1F4BEEC", VA="0x1F4BEEC")]
		public FactoryProvider(DiContainer container, List<TypeValuePair> factoryArgs)
		{
		}

		[Address(RVA="0x1F4BF40", Offset="0x1F4BF40", VA="0x1F4BF40", Slot="6")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072F34", Offset="0x1072F34")]
		public override IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DE28", Offset="0x104DE28")]
		private sealed class <GetAllInstancesWithInjectSplit>d__1 : IEnumerator<List<object>>, IEnumerator, IDisposable
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
			public FactoryProvider<TValue, TFactory> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x1F4BE74", Offset="0x1F4BE74", VA="0x1F4BE74", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1F4BEE4", Offset="0x1F4BEE4", VA="0x1F4BEE4", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1F4B93C", Offset="0x1F4B93C", VA="0x1F4B93C")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__1(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1F4B978", Offset="0x1F4B978", VA="0x1F4B978", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1F4BE7C", Offset="0x1F4BE7C", VA="0x1F4BE7C", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1F4B974", Offset="0x1F4B974", VA="0x1F4B974", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}