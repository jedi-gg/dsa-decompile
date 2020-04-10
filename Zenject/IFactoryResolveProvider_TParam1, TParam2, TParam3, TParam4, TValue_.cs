using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class IFactoryResolveProvider<TParam1, TParam2, TParam3, TParam4, TValue> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly object _subIdentifier;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Address(RVA="0x234F420", Offset="0x234F420", VA="0x234F420")]
		public IFactoryResolveProvider(DiContainer container, object subIdentifier)
		{
		}

		[Address(RVA="0x234F4D8", Offset="0x234F4D8", VA="0x234F4D8", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073448", Offset="0x1073448")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x234F464", Offset="0x234F464", VA="0x234F464", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DEF8", Offset="0x104DEF8")]
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
			public IFactoryResolveProvider<TParam1, TParam2, TParam3, TParam4, TValue> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x234F3A8", Offset="0x234F3A8", VA="0x234F3A8", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x234F418", Offset="0x234F418", VA="0x234F418", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x234EA68", Offset="0x234EA68", VA="0x234EA68")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x234EAA4", Offset="0x234EAA4", VA="0x234EAA4", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x234F3B0", Offset="0x234F3B0", VA="0x234F3B0", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x234EAA0", Offset="0x234EAA0", VA="0x234EAA0", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}