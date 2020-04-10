using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class IFactoryResolveProvider<TParam1, TParam2, TParam3, TParam4, TParam5, TValue> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly object _subIdentifier;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Address(RVA="0x2350048", Offset="0x2350048", VA="0x2350048")]
		public IFactoryResolveProvider(DiContainer container, object subIdentifier)
		{
		}

		[Address(RVA="0x2350100", Offset="0x2350100", VA="0x2350100", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10734AC", Offset="0x10734AC")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x235008C", Offset="0x235008C", VA="0x235008C", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DF08", Offset="0x104DF08")]
		private sealed class <GetAllInstancesWithInjectSplit>d__4 : IEnumerator<List<object>>, IEnumerator, IDisposable
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
			public IFactoryResolveProvider<TParam1, TParam2, TParam3, TParam4, TParam5, TValue> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x234FFD0", Offset="0x234FFD0", VA="0x234FFD0", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x2350040", Offset="0x2350040", VA="0x2350040", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x234F58C", Offset="0x234F58C", VA="0x234F58C")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x234F5C8", Offset="0x234F5C8", VA="0x234F5C8", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x234FFD8", Offset="0x234FFD8", VA="0x234FFD8", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x234F5C4", Offset="0x234F5C4", VA="0x234F5C4", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}