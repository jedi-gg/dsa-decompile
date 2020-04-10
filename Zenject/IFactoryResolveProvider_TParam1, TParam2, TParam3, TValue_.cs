using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class IFactoryResolveProvider<TParam1, TParam2, TParam3, TValue> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly object _subIdentifier;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Address(RVA="0x234E8FC", Offset="0x234E8FC", VA="0x234E8FC")]
		public IFactoryResolveProvider(DiContainer container, object subIdentifier)
		{
		}

		[Address(RVA="0x234E9B4", Offset="0x234E9B4", VA="0x234E9B4", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10733E4", Offset="0x10733E4")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x234E940", Offset="0x234E940", VA="0x234E940", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DEE8", Offset="0x104DEE8")]
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
			public IFactoryResolveProvider<TParam1, TParam2, TParam3, TValue> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x234E884", Offset="0x234E884", VA="0x234E884", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x234E8F4", Offset="0x234E8F4", VA="0x234E8F4", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x234E04C", Offset="0x234E04C", VA="0x234E04C")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x234E088", Offset="0x234E088", VA="0x234E088", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x234E88C", Offset="0x234E88C", VA="0x234E88C", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x234E084", Offset="0x234E084", VA="0x234E084", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}