using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class FactoryProvider<TValue, TFactory, TParam1> : FactoryProviderBase<TValue, TFactory>
	where TFactory : IFactory<TParam1, TValue>
	{
		[Address(RVA="0x1F4C704", Offset="0x1F4C704", VA="0x1F4C704")]
		public FactoryProvider(DiContainer container, List<TypeValuePair> factoryArgs)
		{
		}

		[Address(RVA="0x1F4C758", Offset="0x1F4C758", VA="0x1F4C758", Slot="6")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072F98", Offset="0x1072F98")]
		public override IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DE38", Offset="0x104DE38")]
		private sealed class <GetAllInstancesWithInjectSplit>d__1 : IEnumerator<List<object>>, IEnumerator, IDisposable
		// where TFactory : IFactory<TParam1, TValue>
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
			public FactoryProvider<TParam1, TValue, TFactory> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x1F4C68C", Offset="0x1F4C68C", VA="0x1F4C68C", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1F4C6FC", Offset="0x1F4C6FC", VA="0x1F4C6FC", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1F4BFF4", Offset="0x1F4BFF4", VA="0x1F4BFF4")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__1(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1F4C030", Offset="0x1F4C030", VA="0x1F4C030", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1F4C694", Offset="0x1F4C694", VA="0x1F4C694", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1F4C02C", Offset="0x1F4C02C", VA="0x1F4C02C", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}