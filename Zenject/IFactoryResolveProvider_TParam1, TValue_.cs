using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class IFactoryResolveProvider<TParam1, TValue> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly object _subIdentifier;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Address(RVA="0x234D5C8", Offset="0x234D5C8", VA="0x234D5C8")]
		public IFactoryResolveProvider(DiContainer container, object subIdentifier)
		{
		}

		[Address(RVA="0x234D680", Offset="0x234D680", VA="0x234D680", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x107331C", Offset="0x107331C")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x234D60C", Offset="0x234D60C", VA="0x234D60C", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DEC8", Offset="0x104DEC8")]
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
			public IFactoryResolveProvider<TParam1, TValue> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x234D550", Offset="0x234D550", VA="0x234D550", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x234D5C0", Offset="0x234D5C0", VA="0x234D5C0", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x234CF28", Offset="0x234CF28", VA="0x234CF28")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x234CF64", Offset="0x234CF64", VA="0x234CF64", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x234D558", Offset="0x234D558", VA="0x234D558", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x234CF60", Offset="0x234CF60", VA="0x234CF60", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}